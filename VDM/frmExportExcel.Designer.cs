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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.lbInformation = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tbSavePath = new Sunny.UI.UITextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btSelect = new Sunny.UI.UIButton();
            this.pnlBtm.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 370);
            this.pnlBtm.Size = new System.Drawing.Size(814, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(686, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(571, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.tbFile_password.Size = new System.Drawing.Size(359, 35);
            this.tbFile_password.TabIndex = 30;
            this.tbFile_password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFile_password.Watermark = "";
            this.tbFile_password.TextChanged += new System.EventHandler(this.tbFile_password_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(28, 219);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(206, 31);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "设置文件访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
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
            this.uiGroupBox2.Size = new System.Drawing.Size(753, 145);
            this.uiGroupBox2.TabIndex = 31;
            this.uiGroupBox2.Text = "温馨提示";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInformation.Location = new System.Drawing.Point(18, 32);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(547, 99);
            this.lbInformation.TabIndex = 3;
            this.lbInformation.Text = "1、选择目录导出前请输入文件密码。\r\n2、选择目录保存时需要输入文件名。";
            this.lbInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(28, 287);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(206, 31);
            this.uiLabel1.TabIndex = 29;
            this.uiLabel1.Text = "设置文件保存位置";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // tbSavePath
            // 
            this.tbSavePath.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSavePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSavePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSavePath.Location = new System.Drawing.Point(266, 283);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSavePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Padding = new System.Windows.Forms.Padding(5);
            this.tbSavePath.ShowText = false;
            this.tbSavePath.Size = new System.Drawing.Size(359, 35);
            this.tbSavePath.TabIndex = 30;
            this.tbSavePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSavePath.Watermark = "";
            this.tbSavePath.TextChanged += new System.EventHandler(this.tbFile_password_TextChanged);
            // 
            // btSelect
            // 
            this.btSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Location = new System.Drawing.Point(632, 283);
            this.btSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(100, 35);
            this.btSelect.TabIndex = 32;
            this.btSelect.Text = "选择";
            this.btSelect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // frmExportExcel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 428);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbFile_password);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Name = "frmExportExcel";
            this.Text = "导出Excel";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 540, 300);
            this.Load += new System.EventHandler(this.frmExportExcel_Load_1);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.tbFile_password, 0);
            this.Controls.SetChildIndex(this.tbSavePath, 0);
            this.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.Controls.SetChildIndex(this.btSelect, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.pnlBtm.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox tbFile_password;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel lbInformation;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tbSavePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private Sunny.UI.UIButton btSelect;
    }
}