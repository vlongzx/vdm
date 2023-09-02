namespace com.vdm.form
{
    partial class frmExportTemplate
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
            this.tbPassword = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btTempleExport = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.lbInformation = new Sunny.UI.UILabel();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(460, 334);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(267, 35);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(179, 328);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(274, 41);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "设置模板访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btTempleExport
            // 
            this.btTempleExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTempleExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTempleExport.Location = new System.Drawing.Point(314, 392);
            this.btTempleExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btTempleExport.Name = "btTempleExport";
            this.btTempleExport.Size = new System.Drawing.Size(293, 35);
            this.btTempleExport.TabIndex = 5;
            this.btTempleExport.Text = "选择目录导出模板";
            this.btTempleExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTempleExport.Click += new System.EventHandler(this.btTempleExport_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.lbInformation);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(66, 67);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(601, 220);
            this.uiGroupBox2.TabIndex = 8;
            this.uiGroupBox2.Text = "温馨提示";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInformation.Location = new System.Drawing.Point(27, 32);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(562, 174);
            this.lbInformation.TabIndex = 3;
            this.lbInformation.Text = "1.如需要EXCEL模板，请单击右侧导出模板按钮。\r\n2.模板文件的标题列不允许修改，不允许删除。\r\n3.模板列数据需要符合列数据格式要求。\r\n4.导入前需要输入" +
    "文档访问密码。\r\n5.如导入发生错误，请根据错误提示进行修改。";
            this.lbInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbInformation.Click += new System.EventHandler(this.lbInformation_Click);
            // 
            // frmExportTemplate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1020, 584);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btTempleExport);
            this.Name = "frmExportTemplate";
            this.Text = "导出模板";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 559, 229);
            this.Load += new System.EventHandler(this.frmExportTemplate_Load);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btTempleExport;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel lbInformation;
    }
}