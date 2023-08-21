namespace com.vdm.form
{
    partial class frmExportExcel
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
            this.labFile_password = new System.Windows.Forms.Label();
            this.labFile_name = new System.Windows.Forms.Label();
            this.tbFile_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFile_name = new System.Windows.Forms.TextBox();
            this.btExport_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFile_password
            // 
            this.labFile_password.AutoSize = true;
            this.labFile_password.Location = new System.Drawing.Point(96, 117);
            this.labFile_password.Name = "labFile_password";
            this.labFile_password.Size = new System.Drawing.Size(130, 24);
            this.labFile_password.TabIndex = 27;
            this.labFile_password.Text = "文件密码：";
            // 
            // labFile_name
            // 
            this.labFile_name.AutoSize = true;
            this.labFile_name.Location = new System.Drawing.Point(120, 73);
            this.labFile_name.Name = "labFile_name";
            this.labFile_name.Size = new System.Drawing.Size(106, 24);
            this.labFile_name.TabIndex = 26;
            this.labFile_name.Text = "文件名：";
            // 
            // tbFile_password
            // 
            this.tbFile_password.Location = new System.Drawing.Point(239, 114);
            this.tbFile_password.Name = "tbFile_password";
            this.tbFile_password.Size = new System.Drawing.Size(213, 35);
            this.tbFile_password.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 24;
            // 
            // tbFile_name
            // 
            this.tbFile_name.Location = new System.Drawing.Point(239, 73);
            this.tbFile_name.Name = "tbFile_name";
            this.tbFile_name.Size = new System.Drawing.Size(213, 35);
            this.tbFile_name.TabIndex = 23;
            // 
            // btExport_excel
            // 
            this.btExport_excel.Location = new System.Drawing.Point(193, 175);
            this.btExport_excel.Name = "btExport_excel";
            this.btExport_excel.Size = new System.Drawing.Size(164, 53);
            this.btExport_excel.TabIndex = 22;
            this.btExport_excel.Text = "选择目录导出";
            this.btExport_excel.UseVisualStyleBackColor = true;
            this.btExport_excel.Click += new System.EventHandler(this.btExport_excel_Click);
            // 
            // frmExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.Controls.Add(this.labFile_password);
            this.Controls.Add(this.labFile_name);
            this.Controls.Add(this.tbFile_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFile_name);
            this.Controls.Add(this.btExport_excel);
            this.Name = "frmExportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出Excel";
            this.Load += new System.EventHandler(this.frmExportExcel_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFile_password;
        private System.Windows.Forms.Label labFile_name;
        private System.Windows.Forms.TextBox tbFile_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFile_name;
        private System.Windows.Forms.Button btExport_excel;
    }
}