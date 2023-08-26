﻿namespace com.vdm.form
{
    partial class UserInfo
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
            this.tbUsername = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbPassword = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tbConfirmPassword = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.tbRemark = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 407);
            this.pnlBtm.Size = new System.Drawing.Size(598, 66);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cbVillage);
            this.uiGroupBox1.Controls.Add(this.cbTown);
            this.uiGroupBox1.Controls.Add(this.tbRemark);
            this.uiGroupBox1.Controls.Add(this.tbConfirmPassword);
            this.uiGroupBox1.Controls.Add(this.tbPassword);
            this.uiGroupBox1.Controls.Add(this.tbUsername);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(17, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(568, 356);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "用户信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(50, 61);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(110, 31);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "用户名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsername
            // 
            this.tbUsername.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUsername.Location = new System.Drawing.Point(167, 61);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(5);
            this.tbUsername.ShowText = false;
            this.tbUsername.Size = new System.Drawing.Size(289, 29);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbUsername.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(50, 106);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(86, 31);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(167, 104);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(289, 29);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(50, 145);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(134, 31);
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "确认密码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(167, 147);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirmPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.ShowText = false;
            this.tbConfirmPassword.Size = new System.Drawing.Size(289, 29);
            this.tbConfirmPassword.TabIndex = 1;
            this.tbConfirmPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbConfirmPassword.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(50, 191);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(134, 31);
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "所属乡镇：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(50, 234);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "所属村：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(50, 276);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 0;
            this.uiLabel6.Text = "备注：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(167, 191);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(289, 29);
            this.cbTown.TabIndex = 2;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(167, 236);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(289, 29);
            this.cbVillage.TabIndex = 2;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // tbRemark
            // 
            this.tbRemark.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRemark.Location = new System.Drawing.Point(167, 276);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRemark.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Padding = new System.Windows.Forms.Padding(5);
            this.tbRemark.ShowScrollBar = true;
            this.tbRemark.ShowText = false;
            this.tbRemark.Size = new System.Drawing.Size(289, 60);
            this.tbRemark.TabIndex = 1;
            this.tbRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRemark.Watermark = "";
            // 
            // UserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 476);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
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
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UITextBox tbRemark;
        private Sunny.UI.UITextBox tbConfirmPassword;
        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UITextBox tbUsername;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
    }
}