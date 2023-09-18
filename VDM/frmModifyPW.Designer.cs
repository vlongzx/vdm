namespace com.vdm.form
{
    partial class frmModifyPW
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
            this.tbConfirmNewPassword = new Sunny.UI.UITextBox();
            this.tbNewPassword = new Sunny.UI.UITextBox();
            this.tbOldPassword = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 422);
            this.pnlBtm.Size = new System.Drawing.Size(798, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 12);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(555, 12);
            this.btnOK.TabIndex = 3;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.tbConfirmNewPassword);
            this.uiGroupBox1.Controls.Add(this.tbNewPassword);
            this.uiGroupBox1.Controls.Add(this.tbOldPassword);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(26, 54);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(745, 339);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "重新设置新密码";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbConfirmNewPassword
            // 
            this.tbConfirmNewPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmNewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(233, 219);
            this.tbConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirmNewPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbConfirmNewPassword.PasswordChar = '*';
            this.tbConfirmNewPassword.ShowText = false;
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(391, 29);
            this.tbConfirmNewPassword.TabIndex = 2;
            this.tbConfirmNewPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbConfirmNewPassword.Watermark = "";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNewPassword.Location = new System.Drawing.Point(233, 162);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.ShowText = false;
            this.tbNewPassword.Size = new System.Drawing.Size(391, 29);
            this.tbNewPassword.TabIndex = 1;
            this.tbNewPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbNewPassword.Watermark = "";
            this.tbNewPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOldPassword.Location = new System.Drawing.Point(233, 103);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOldPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.ShowText = false;
            this.tbOldPassword.Size = new System.Drawing.Size(391, 29);
            this.tbOldPassword.TabIndex = 0;
            this.tbOldPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOldPassword.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(106, 214);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(120, 39);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "确认新密码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(106, 157);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 39);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "新密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(106, 98);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(120, 39);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "原密码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmModifyPW
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "frmModifyPW";
            this.Text = "修改密码";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 480);
            this.Load += new System.EventHandler(this.frmModifyPW_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiGroupBox1, 0);
            this.pnlBtm.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox tbConfirmNewPassword;
        private Sunny.UI.UITextBox tbNewPassword;
        private Sunny.UI.UITextBox tbOldPassword;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
    }
}