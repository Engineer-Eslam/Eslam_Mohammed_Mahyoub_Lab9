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
    public partial class EditForm3Data : Form
    {
        public string EditlNamber1 { get; set; }
        public string EditlNamber2 { get; set; }
        public string EditOperationElement { get; set; }
        public int EditOperationIndex { get; set; }

        public EditForm3Data()
        {
            InitializeComponent();
            comboBoxEditOp.Items.Add("+");
            comboBoxEditOp.Items.Add("-");
            comboBoxEditOp.Items.Add("*");
            comboBoxEditOp.Items.Add("/");


            comboBoxEditOp.KeyPress += new KeyPressEventHandler(comboBoxEditOp_KeyPress);

            // ربط معالج واحد للحدث KeyPress لكل من txtEditNumber1 و txtEditNumber2
            txtEditNumber1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtEditNumber2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            // ربط معالج واحد للحدث KeyUp لكل من txtEditNumber1 و txtEditNumber2
            txtEditNumber1.KeyUp += new KeyEventHandler(textBox_KeyUp);
            txtEditNumber2.KeyUp += new KeyEventHandler(textBox_KeyUp);

            // ربط معالج واحد للحدث MouseClick لكل من txtEditNumber1 و txtEditNumber2
            txtEditNumber1.MouseClick += new MouseEventHandler(textBox_MouseClick);
            txtEditNumber2.MouseClick += new MouseEventHandler(textBox_MouseClick);
        }

        private void EditForm3Data_Load(object sender, EventArgs e)
        {
            txtEditNumber1.Text = EditlNamber1;
            txtEditNumber2.Text = EditlNamber2;
            comboBoxEditOp.SelectedItem = EditOperationElement;
        }

        private void comboBoxEditOp_KeyPress(object sender, KeyPressEventArgs e)
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
                int index = comboBoxEditOp.Items.IndexOf(inputChar); // البحث عن العنصر في القائمة

                if (index != -1)
                {
                    comboBoxEditOp.SelectedIndex = index; // تحديد العنصر إذا وُجد
                }

                e.Handled = true; // منع كتابة الحرف فعليًا في مربع النص
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox; // الحصول على مربع النص الذي أثار الحدث
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

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            // التحقق من صحة الإدخالات
            if (txtEditNumber1.Text.Trim() == "" || txtEditNumber2.Text.Trim() == "" || comboBoxEditOp.SelectedIndex == -1)
            {
                MessageBox.Show("يرجى تعبئة حقول العددين مع إختيار العملية .", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return;
            }
            if ((comboBoxEditOp.SelectedIndex == 3) && (txtEditNumber2.Text.Trim() == "0" || txtEditNumber2.Text.Trim() == "-0"))
            {
                MessageBox.Show("لا يمكن القسمه على الصفر ، قم بتعديل العملية", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtEditNumber2.Text = "";
                txtEditNumber2.Focus();
                return;
            }
            EditlNamber1 = txtEditNumber1.Text;
            EditlNamber2 = txtEditNumber2.Text;
            EditOperationIndex = comboBoxEditOp.SelectedIndex;
            this.Close();
        }

        
    }
}
