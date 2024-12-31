namespace إسلام_محمد_مهيوب_المليكي_lab9
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeletesAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.listBoxNumber1 = new System.Windows.Forms.ListBox();
            this.listBoxOperation = new System.Windows.Forms.ListBox();
            this.listBoxNumber2 = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "العملية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "العدد الثاني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "الناتج";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(27, 338);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightCyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(700, 288);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 32);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeletesAll
            // 
            this.btnDeletesAll.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeletesAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletesAll.Location = new System.Drawing.Point(700, 216);
            this.btnDeletesAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeletesAll.Name = "btnDeletesAll";
            this.btnDeletesAll.Size = new System.Drawing.Size(94, 32);
            this.btnDeletesAll.TabIndex = 33;
            this.btnDeletesAll.Text = "حذف الكل";
            this.btnDeletesAll.UseVisualStyleBackColor = false;
            this.btnDeletesAll.Click += new System.EventHandler(this.btnDeletesAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(700, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(550, 52);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(133, 27);
            this.txtNumber1.TabIndex = 36;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(255, 52);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(133, 27);
            this.txtNumber2.TabIndex = 37;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(70, 52);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(133, 27);
            this.txtResult.TabIndex = 38;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxNumber1
            // 
            this.listBoxNumber1.FormattingEnabled = true;
            this.listBoxNumber1.ItemHeight = 19;
            this.listBoxNumber1.Location = new System.Drawing.Point(550, 145);
            this.listBoxNumber1.Name = "listBoxNumber1";
            this.listBoxNumber1.Size = new System.Drawing.Size(133, 175);
            this.listBoxNumber1.TabIndex = 39;
            // 
            // listBoxOperation
            // 
            this.listBoxOperation.FormattingEnabled = true;
            this.listBoxOperation.ItemHeight = 19;
            this.listBoxOperation.Location = new System.Drawing.Point(415, 145);
            this.listBoxOperation.Name = "listBoxOperation";
            this.listBoxOperation.Size = new System.Drawing.Size(108, 175);
            this.listBoxOperation.TabIndex = 40;
            // 
            // listBoxNumber2
            // 
            this.listBoxNumber2.FormattingEnabled = true;
            this.listBoxNumber2.ItemHeight = 19;
            this.listBoxNumber2.Location = new System.Drawing.Point(255, 145);
            this.listBoxNumber2.Name = "listBoxNumber2";
            this.listBoxNumber2.Size = new System.Drawing.Size(133, 175);
            this.listBoxNumber2.TabIndex = 41;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 19;
            this.listBoxResult.Location = new System.Drawing.Point(70, 145);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(133, 175);
            this.listBoxResult.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 27);
            this.comboBox1.TabIndex = 43;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(466, 94);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(217, 32);
            this.btnCalculate.TabIndex = 44;
            this.btnCalculate.Text = "حساب";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 382);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxNumber2);
            this.Controls.Add(this.listBoxOperation);
            this.Controls.Add(this.listBoxNumber1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeletesAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeletesAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListBox listBoxNumber1;
        private System.Windows.Forms.ListBox listBoxOperation;
        private System.Windows.Forms.ListBox listBoxNumber2;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCalculate;
    }
}