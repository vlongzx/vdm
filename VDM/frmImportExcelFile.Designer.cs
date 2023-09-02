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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbFileName = new Sunny.UI.UITextBox();
            this.btSelect = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbPassword = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 297);
            this.pnlBtm.Size = new System.Drawing.Size(740, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(612, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(497, 12);
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
            this.uiGroupBox1.Location = new System.Drawing.Point(18, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(707, 232);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "选择文件";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(35, 71);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(206, 31);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "选择要导入的文件";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbFileName.TabIndex = 1;
            this.tbFileName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFileName.Watermark = "";
            // 
            // btSelect
            // 
            this.btSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Location = new System.Drawing.Point(595, 69);
            this.btSelect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(100, 35);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = "选择";
            this.btSelect.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(35, 136);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(158, 31);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "文档访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // frmImportExcelFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(742, 355);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "frmImportExcelFile";
            this.Text = "文件批量导入";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiGroupBox1, 0);
            this.pnlBtm.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
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
    }
}