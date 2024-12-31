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
    public partial class EditForm2Data : Form
    {
        public string OriginalName { get; set; }
        public string OriginalAge { get; set; }
        public string OriginalNumber { get; set; }
        public string OriginalGender { get; set; }
        public int SelectedIndex { get; set; }

        public event EventHandler<DataUpdatedEventArgs> DataUpdated;
        public Func<string, bool> IsNumberUnique { get; set; } // دالة للتحقق من تفرد الرقم
        public EditForm2Data()
        {
            InitializeComponent();
            // ربط الأحداث بالمربعات النصية
            txtEditId.KeyPress += new KeyPressEventHandler(txtIdAndAge_KeyPress);
            txtEditAge.KeyPress += new KeyPressEventHandler(txtIdAndAge_KeyPress);
            txtEditName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
        }

        private void EditForm2Data_Load(object sender, EventArgs e)
        {
            // تعبئة الحقول بالبيانات الأصلية
            txtEditId.Text = OriginalNumber;
            txtEditName.Text = OriginalName;
            txtEditAge.Text = OriginalAge;
            // تحديد الجنس بناءً على القيمة الأصلية
            if (OriginalGender == "ذكر")
            {
                radioBtnEditMale.Checked = true;
            }
            else if (OriginalGender == "أنثى")
            {
                radioBtnEditFeminine.Checked = true;
            }
        }

        private void txtIdAndAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بإدخال الأرقام ومفاتيح التحكم فقط ولا يقبل الرموز أو الحروف
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) // 8 هو Backspace
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بإدخال الحروف، المسافات، ومفاتيح التحكم فقط ولا يقبل الرموز أو الأرقام
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            // تحديد الجنس المعدل
            string updatedGender;
            if (radioBtnEditMale.Checked)
            {
                updatedGender = "ذكر";
            }
            else if (radioBtnEditFeminine.Checked)
            {
                updatedGender = "أنثى";
            }
            else
            {
                updatedGender = string.Empty;
            }

            // التحقق من صحة الإدخالات
            if (string.IsNullOrWhiteSpace(txtEditName.Text) || string.IsNullOrWhiteSpace(txtEditAge.Text) || string.IsNullOrWhiteSpace(txtEditId.Text) || string.IsNullOrWhiteSpace(updatedGender))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول واختيار الجنس.", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                return;
            }

            // التحقق من تفرد الرقم
            if (txtEditId.Text != OriginalNumber && IsNumberUnique != null && !IsNumberUnique(txtEditId.Text))
            {
                MessageBox.Show("هذا الرقم موجود مسبقا، قم بتغييره", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtEditId.Text = "";
                txtEditId.Focus();
                return;
            }

            // تمرير البيانات المعدلة إلى الفورم الرئيسي
            if (DataUpdated != null)
            {
                DataUpdated(this, new DataUpdatedEventArgs
                {
                    UpdatedNumber = txtEditId.Text,
                    SelectedIndex = SelectedIndex,
                    UpdatedName = txtEditName.Text,
                    UpdatedAge = txtEditAge.Text,
                    UpdatedGender = updatedGender
                });
            }
            // إغلاق الفورم الثاني
            this.Close();
            }
    }

    public class DataUpdatedEventArgs : EventArgs
    {
        public int SelectedIndex { get; set; }
        public string UpdatedName { get; set; }
        public string UpdatedAge { get; set; }
        public string UpdatedNumber { get; set; }
        public string UpdatedGender { get; set; }
    }
}
