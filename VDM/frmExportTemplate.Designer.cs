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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tbSavePath = new Sunny.UI.UITextBox();
            this.btSelect = new Sunny.UI.UIButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 222);
            this.pnlBtm.Size = new System.Drawing.Size(661, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(418, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(258, 73);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(304, 35);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(24, 73);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(206, 31);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "设置模板访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(24, 139);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(206, 31);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "设置模板保存路径";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSavePath
            // 
            this.tbSavePath.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSavePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSavePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSavePath.Location = new System.Drawing.Point(258, 139);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSavePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Padding = new System.Windows.Forms.Padding(5);
            this.tbSavePath.ShowText = false;
            this.tbSavePath.Size = new System.Drawing.Size(304, 35);
            this.tbSavePath.TabIndex = 1;
            this.tbSavePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSavePath.Watermark = "";
            // 
            // btSelect
            // 
            this.btSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btSelect.Location = new System.Drawing.Point(569, 139);
            this.btSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(68, 35);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "选择";
            this.btSelect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // frmExportTemplate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(663, 280);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Name = "frmExportTemplate";
            this.Text = "导出模板";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 559, 229);
            this.Load += new System.EventHandler(this.frmExportTemplate_Load);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.tbSavePath, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.btSelect, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tbSavePath;
        private Sunny.UI.UIButton btSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}