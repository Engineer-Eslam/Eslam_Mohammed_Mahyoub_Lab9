namespace إسلام_محمد_مهيوب_المليكي_lab9
{
    partial class EditForm3Data
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
            this.comboBoxEditOp = new System.Windows.Forms.ComboBox();
            this.txtEditNumber2 = new System.Windows.Forms.TextBox();
            this.txtEditNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEditOp
            // 
            this.comboBoxEditOp.FormattingEnabled = true;
            this.comboBoxEditOp.Location = new System.Drawing.Point(207, 63);
            this.comboBoxEditOp.Name = "comboBoxEditOp";
            this.comboBoxEditOp.Size = new System.Drawing.Size(108, 27);
            this.comboBoxEditOp.TabIndex = 52;
            // 
            // txtEditNumber2
            // 
            this.txtEditNumber2.Location = new System.Drawing.Point(39, 63);
            this.txtEditNumber2.Name = "txtEditNumber2";
            this.txtEditNumber2.Size = new System.Drawing.Size(133, 27);
            this.txtEditNumber2.TabIndex = 50;
            // 
            // txtEditNumber1
            // 
            this.txtEditNumber1.Location = new System.Drawing.Point(352, 63);
            this.txtEditNumber1.Name = "txtEditNumber1";
            this.txtEditNumber1.Size = new System.Drawing.Size(133, 27);
            this.txtEditNumber1.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "العدد الثاني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "العملية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "العدد الأول";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEdit.Location = new System.Drawing.Point(171, 115);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(182, 38);
            this.btnSaveEdit.TabIndex = 53;
            this.btnSaveEdit.Text = "حفظ";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // EditForm3Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 183);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.comboBoxEditOp);
            this.Controls.Add(this.txtEditNumber2);
            this.Controls.Add(this.txtEditNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditForm3Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm3Data";
            this.Load += new System.EventHandler(this.EditForm3Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEditOp;
        private System.Windows.Forms.TextBox txtEditNumber2;
        private System.Windows.Forms.TextBox txtEditNumber1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}