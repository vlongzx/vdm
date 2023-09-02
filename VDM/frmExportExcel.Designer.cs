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
            this.tbFile_password = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btExcelExport = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.lbInformation = new Sunny.UI.UILabel();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFile_password
            // 
            this.tbFile_password.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbFile_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFile_password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFile_password.Location = new System.Drawing.Point(266, 219);
            this.tbFile_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFile_password.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbFile_password.Name = "tbFile_password";
            this.tbFile_password.Padding = new System.Windows.Forms.Padding(5);
            this.tbFile_password.PasswordChar = '*';
            this.tbFile_password.ShowText = false;
            this.tbFile_password.Size = new System.Drawing.Size(267, 35);
            this.tbFile_password.TabIndex = 30;
            this.tbFile_password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFile_password.Watermark = "";
            this.tbFile_password.TextChanged += new System.EventHandler(this.tbFile_password_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(61, 213);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(274, 41);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "设置文件访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // btExcelExport
            // 
            this.btExcelExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcelExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExcelExport.Location = new System.Drawing.Point(143, 277);
            this.btExcelExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExcelExport.Name = "btExcelExport";
            this.btExcelExport.Size = new System.Drawing.Size(293, 35);
            this.btExcelExport.TabIndex = 28;
            this.btExcelExport.Text = "选择目录导出保存";
            this.btExcelExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExcelExport.Click += new System.EventHandler(this.btExcelExport_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.lbInformation);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(34, 52);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(591, 145);
            this.uiGroupBox2.TabIndex = 31;
            this.uiGroupBox2.Text = "温馨提示";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInformation.Location = new System.Drawing.Point(27, 32);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(561, 99);
            this.lbInformation.TabIndex = 3;
            this.lbInformation.Text = "1、选择目录导出前请输入文件密码。\r\n2、选择目录保存时需要输入文件名。";
            this.lbInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmExportExcel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 342);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.tbFile_password);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btExcelExport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportExcel";
            this.Text = "导出Excel";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 540, 300);
            this.Load += new System.EventHandler(this.frmExportExcel_Load_1);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox tbFile_password;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btExcelExport;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel lbInformation;
    }
}