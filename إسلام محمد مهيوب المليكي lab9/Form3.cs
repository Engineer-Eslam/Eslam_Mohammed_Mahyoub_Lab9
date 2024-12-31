using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            txtResult.ReadOnly = true;

            btnCalculate.Enabled = false;
            btnCalculate.BackColor = Color.Transparent;

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //لجعل الأداه قابله للإختيار فقط
            //comboBox1.SelectedIndex = 0;

            comboBox1.KeyPress += new KeyPressEventHandler(comboBox1_KeyPress);


            txtNumber1.TextChanged += new EventHandler(TxtAndCombo_Changed);
            txtNumber2.TextChanged += new EventHandler(TxtAndCombo_Changed);
            comboBox1.TextChanged += new EventHandler(TxtAndCombo_Changed);
            
            // ربط معالج واحد للحدث KeyPress لكل من txtNumber1 و txtNumber2
            txtNumber1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtNumber2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            // ربط معالج واحد للحدث KeyUp لكل من txtNumber1 و txtNumber2
            txtNumber1.KeyUp += new KeyEventHandler(textBox_KeyUp);
            txtNumber2.KeyUp += new KeyEventHandler(textBox_KeyUp);

            // ربط معالج واحد للحدث MouseClick لكل من txtNumber1 و txtNumber2
            txtNumber1.MouseClick += new MouseEventHandler(textBox_MouseClick);
            txtNumber2.MouseClick += new MouseEventHandler(textBox_MouseClick);

            listBoxNumber1.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxNumber2.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxOperation.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxResult.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالحروف المسموح بها: +, -, *, / أو مفاتيح التحكم مثل Backspace
            if (e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // منع كتابة أي حرف غير مسموح
            }
            else if (!char.IsControl(e.KeyChar)) // إذا كان الحرف مسموحًا
            {
                // البحث عن العنصر المطابق للحرف وتحديده
                string inputChar = e.KeyChar.ToString(); // الحرف المكتوب
                int index = comboBox1.Items.IndexOf(inputChar); // البحث عن العنصر في القائمة

                if (index != -1)
                {
                    comboBox1.SelectedIndex = index; // تحديد العنصر إذا وُجد
                }

                e.Handled = true; // منع كتابة الحرف فعليًا في مربع النص
            }
        }
        

        private void TxtAndCombo_Changed(object sender, EventArgs e)
        {
            //btnCalculate.Enabled = (txtNumber1.Text.Trim() != "") && (txtNumber2.Text.Trim() != "") && (comboBox1.SelectedIndex != -1);
            if (txtNumber1.Text.Trim() != "" && txtNumber2.Text.Trim() != "" && comboBox1.SelectedIndex != -1)
            {
                btnCalculate.Enabled = true;
                btnCalculate.BackColor = Color.PaleTurquoise;
            }
            else
            {
                btnCalculate.Enabled = false;
                btnCalculate.BackColor = Color.Transparent;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox; // الحصول على مربع النص الذي أثار الحدث
            txtResult.Text = "";
            txtResult.BackColor = Color.White;

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 45))
            {
                e.Handled = true; // منع إدخال أي حرف غير رقمي
            }

            if (e.KeyChar == 45) // السماح بإدخال السالب فقط إذا لم يكن موجودًا وفي البداية
            {
                if (textBox.Text.Contains("-") || textBox.SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 46) // السماح بإدخال النقطة العشرية فقط لمرة واحدة
            {
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.StartsWith("-") && textBox.SelectionStart == 0)
            {
                textBox.SelectionStart = 1;
            }
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.StartsWith("-") && textBox.SelectionStart == 0)
            {
                textBox.SelectionStart = 1;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            int index = list.SelectedIndex;
            if (index != -1)
            {
                listBoxNumber1.SelectedIndex = listBoxNumber2.SelectedIndex = listBoxOperation.SelectedIndex = listBoxResult.SelectedIndex = index;
            }
        }

        private double ArithmeticOperation(double n1, int op, double n2)
        {
            double r = 0;
            switch (op)
            {
                default: break;
                case 0:
                    r = n1 + n2;
                    break;
                case 1:
                    r = n1 - n2;
                    break;
                case 2:
                    r = n1 * n2;
                    break;
                case 3:
                    r = n1 / n2;
                    break;
            }
            return r;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtResult.BackColor = Color.MediumSpringGreen;
            if ((comboBox1.SelectedIndex == 3) && (txtNumber2.Text.Trim() == "0" || txtNumber2.Text.Trim() == "-0"))
            {
                MessageBox.Show("لا يمكن القسمه على الصفر ، قم بتعديل العملية", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtNumber2.Text = "";
                txtNumber2.Focus();
                return;
            }
            double Result = ArithmeticOperation(Convert.ToDouble(txtNumber1.Text), comboBox1.SelectedIndex, Convert.ToDouble(txtNumber2.Text));
            txtResult.Text = Result.ToString();
            listBoxNumber1.Items.Add(txtNumber1.Text);
            listBoxNumber2.Items.Add(txtNumber2.Text);
            listBoxOperation.Items.Add(comboBox1.SelectedItem.ToString());
            listBoxResult.Items.Add(txtResult.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = txtNumber2.Text = txtResult.Text =  "";
            txtResult.BackColor = Color.White;
            comboBox1.SelectedItem = null;
            int index=listBoxResult.SelectedIndex;
            if (index != -1)
            {
                listBoxNumber1.Items.RemoveAt(index);
                listBoxNumber2.Items.RemoveAt(index);
                listBoxOperation.Items.RemoveAt(index);
                listBoxResult.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("قم بتحديد العملية المراد حذفها من جميع القاوئم", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnDeletesAll_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = txtNumber2.Text = txtResult.Text = "";
            txtResult.BackColor = Color.White;
            comboBox1.SelectedItem = null;
            listBoxNumber1.Items.Clear();
            listBoxNumber2.Items.Clear();
            listBoxOperation.Items.Clear();
            listBoxResult.Items.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = txtNumber2.Text = txtResult.Text = "";
            txtResult.BackColor = Color.White;
            comboBox1.SelectedItem = null;
            //التحقق من العنصر المحدد
            int index = listBoxResult.SelectedIndex;
            if (index != -1)
            {
                EditForm3Data editForm = new EditForm3Data();
                editForm.EditlNamber1 = listBoxNumber1.Items[index].ToString();
                editForm.EditlNamber2 = listBoxNumber2.Items[index].ToString();
                editForm.EditOperationElement = listBoxOperation.Items[index].ToString();
                editForm.ShowDialog();
                double Result = ArithmeticOperation(Convert.ToDouble(editForm.EditlNamber1), editForm.EditOperationIndex, Convert.ToDouble(editForm.EditlNamber2));
                listBoxNumber1.Items[index] = editForm.EditlNamber1;
                listBoxNumber2.Items[index] = editForm.EditlNamber2;
                listBoxOperation.Items[index] = comboBox1.Items[editForm.EditOperationIndex];
                listBoxResult.Items[index] = Result.ToString();
            }
            else
            {
                MessageBox.Show("قم بتحديد العملية المراد تعديلها ", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
