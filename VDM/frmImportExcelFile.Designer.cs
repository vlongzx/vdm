namespace com.vdm.form
{
    partial class frmImportExcelFile
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btSelect = new Sunny.UI.UIButton();
            this.tbPassword = new Sunny.UI.UITextBox();
            this.tbFileName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btExportTemplate = new Sunny.UI.UIButton();
            this.lbInformation = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.pnlBtm.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 532);
            this.pnlBtm.Size = new System.Drawing.Size(895, 55);
            this.pnlBtm.Style = Sunny.UI.UIStyle.Custom;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(767, 12);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(652, 12);
            this.btnOK.Style = Sunny.UI.UIStyle.Custom;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btSelect);
            this.uiGroupBox1.Controls.Add(this.tbPassword);
            this.uiGroupBox1.Controls.Add(this.tbFileName);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(31, 270);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(837, 232);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "导入文件";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSelect
            // 
            this.btSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Location = new System.Drawing.Point(595, 69);
            this.btSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(100, 35);
            this.btSelect.Style = Sunny.UI.UIStyle.Custom;
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "选择";
            this.btSelect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(248, 132);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(341, 35);
            this.tbPassword.Style = Sunny.UI.UIStyle.Custom;
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // tbFileName
            // 
            this.tbFileName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFileName.Location = new System.Drawing.Point(248, 69);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFileName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Padding = new System.Windows.Forms.Padding(5);
            this.tbFileName.ReadOnly = true;
            this.tbFileName.ShowText = false;
            this.tbFileName.Size = new System.Drawing.Size(341, 35);
            this.tbFileName.Style = Sunny.UI.UIStyle.Custom;
            this.tbFileName.TabIndex = 1;
            this.tbFileName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFileName.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(35, 136);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(158, 31);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "文档访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(35, 71);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(206, 31);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "选择要导入的文件";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btExportTemplate
            // 
            this.btExportTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportTemplate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExportTemplate.Location = new System.Drawing.Point(622, 41);
            this.btExportTemplate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExportTemplate.Name = "btExportTemplate";
            this.btExportTemplate.Size = new System.Drawing.Size(145, 35);
            this.btExportTemplate.Style = Sunny.UI.UIStyle.Custom;
            this.btExportTemplate.TabIndex = 2;
            this.btExportTemplate.Text = "导出模板";
            this.btExportTemplate.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExportTemplate.Click += new System.EventHandler(this.btExportTemplate_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInformation.ForeColor = System.Drawing.Color.DimGray;
            this.lbInformation.Location = new System.Drawing.Point(27, 32);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(562, 174);
            this.lbInformation.Style = Sunny.UI.UIStyle.Custom;
            this.lbInformation.TabIndex = 3;
            this.lbInformation.Text = "1.如需要EXCEL模板，请单击右侧导出模板按钮。\r\n2.模板文件的标题列不允许修改，不允许删除。\r\n3.模板列数据需要符合列数据格式要求。\r\n4.导入前需要输入" +
    "文档访问密码。\r\n5.如导入发生错误，请根据错误提示进行修改。";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.lbInformation);
            this.uiGroupBox2.Controls.Add(this.btExportTemplate);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(31, 40);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(837, 220);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "温馨提示";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmImportExcelFileFamer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(897, 590);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "frmImportExcelFileFamer";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "文件批量导入";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmImportExcelFileFamer_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiGroupBox1, 0);
            this.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.pnlBtm.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btSelect;
        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UITextBox tbFileName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Sunny.UI.UIButton btExportTemplate;
        private Sunny.UI.UILabel lbInformation;
        private Sunny.UI.UIGroupBox uiGroupBox2;
    }
}