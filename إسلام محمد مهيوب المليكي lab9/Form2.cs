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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnAdd.Enabled = false;
            btnAdd.BackColor = Color.Transparent;

            txtId.KeyPress += new KeyPressEventHandler(txtIdAndAge_KeyPress);
            txtAge.KeyPress += new KeyPressEventHandler(txtIdAndAge_KeyPress);

            txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);

            txtId.TextChanged += new EventHandler(ValidateInputs);
            txtName.TextChanged += new EventHandler(ValidateInputs);
            txtAge.TextChanged += new EventHandler(ValidateInputs);
            radioBtnMale.CheckedChanged += new EventHandler(ValidateInputs);
            radioBtnFeminine.CheckedChanged += new EventHandler(ValidateInputs);

            listBoxIds.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxNames.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxAges.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            listBoxGenders.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
        }

        private void txtIdAndAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بإدخال الأرقام ومفاتيح التحكم فقط ولايقبل الرموز الحروف
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بإدخال الحروف، المسافات، ومفاتيح التحكم فقط ولايقبل الرموز والأرقام
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            //btnAdd.Enabled = (txtId.Text.Trim() != "") && (txtName.Text.Trim() != "") && (txtAge.Text.Trim() != "") && (radioBtnMale.Checked || radioBtnFeminine.Checked);
            if (txtId.Text.Trim() != "" && txtName.Text.Trim() != "" && txtAge.Text.Trim() != "" && (radioBtnMale.Checked || radioBtnFeminine.Checked))
            {
                btnAdd.Enabled = true;
                btnAdd.BackColor = Color.LightCyan;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.Transparent;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox = sender as ListBox;
            int index = listbox.SelectedIndex;
            if (index != -1)
            {
                listBoxIds.SelectedIndex = listBoxNames.SelectedIndex = listBoxAges.SelectedIndex = listBoxGenders.SelectedIndex = index;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listBoxIds.Items.Contains(txtId.Text))
            {
                MessageBox.Show("هذا الرقم موجود مسبقا قم بتغييره", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtId.Text = "";
                txtId.Focus();
                return;
            }
            listBoxIds.Items.Add(txtId.Text);
            listBoxNames.Items.Add(txtName.Text);
            listBoxAges.Items.Add(txtAge.Text);
            if (radioBtnMale.Checked)
            {
                listBoxGenders.Items.Add("ذكر");
                radioBtnMale.Checked = false;
            }
            else if (radioBtnFeminine.Checked)
            {
                listBoxGenders.Items.Add("أنثى");
                radioBtnFeminine.Checked = false;
            }
            txtId.Text = txtName.Text = txtAge.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxIds.SelectedIndex;
            if (index != -1)
            {
                listBoxIds.Items.RemoveAt(index);
                listBoxNames.Items.RemoveAt(index);
                listBoxAges.Items.RemoveAt(index);
                listBoxGenders.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("قم بتحديد العنصر المراد حذف صفه من جميع القاوئم", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnDeletesAll_Click(object sender, EventArgs e)
        {
            listBoxIds.Items.Clear();
            listBoxNames.Items.Clear();
            listBoxAges.Items.Clear();
            listBoxGenders.Items.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // التحقق من العنصر المحدد
            int selectedIndex = listBoxIds.SelectedIndex;
            if (selectedIndex >= 0)
            {
                // فتح الفورم الثاني ونقل البيانات
                EditForm2Data editForm = new EditForm2Data
                {
                    OriginalNumber = listBoxIds.Items[selectedIndex].ToString(),
                    OriginalName = listBoxNames.Items[selectedIndex].ToString(),
                    OriginalAge = listBoxAges.Items[selectedIndex].ToString(),
                    OriginalGender = listBoxGenders.Items[selectedIndex].ToString(),
                    SelectedIndex = selectedIndex,
                    IsNumberUnique = number => !listBoxIds.Items.Contains(number) // تحقق من تفرد الرقم
                };
                editForm.DataUpdated += EditForm_DataUpdated;
                editForm.ShowDialog();
                //editForm.OriginalNumber = listBoxIds.Items[selectedIndex].ToString();
                //editForm.OriginalName = listBoxNames.Items[selectedIndex].ToString();
                //editForm.OriginalAge = listBoxAges.Items[selectedIndex].ToString();
                //editForm.OriginalGender = listBoxGenders.Items[selectedIndex].ToString();
                //editForm.SelectedIndex = selectedIndex;
                //editForm.DataUpdated += EditForm_DataUpdated;
                //editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("قم بتحديد العنصر المراد تعديل بيانات صفه لجميع القاوئم", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
        private void EditForm_DataUpdated(object sender, DataUpdatedEventArgs e)
        {
            // تحديث القوائم بالبيانات المعدلة
            listBoxIds.Items[e.SelectedIndex] = e.UpdatedNumber;
            listBoxNames.Items[e.SelectedIndex] = e.UpdatedName;
            listBoxAges.Items[e.SelectedIndex] = e.UpdatedAge;
            listBoxGenders.Items[e.SelectedIndex] = e.UpdatedGender;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
