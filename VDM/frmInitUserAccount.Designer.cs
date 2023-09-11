namespace com.vdm.form
{
    partial class frmInitUserAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitUserAccount));
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.tbConfirmPassword = new Sunny.UI.UITextBox();
            this.tbPassword = new Sunny.UI.UITextBox();
            this.tbUsername = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.btInit = new Sunny.UI.UIButton();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(14, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(566, 196);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "温馨提示";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(23, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(518, 131);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "1.设置账号请确定账号所属乡镇还是村级，一旦选择将不能再更改。\r\n2.该账号默认为系统管理员，请妥善设置密码并牢记。";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.ColumnCount = 2;
            this.uiRadioButtonGroup1.ColumnInterval = 10;
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButtonGroup1.Items.AddRange(new object[] {
            "乡镇级",
            "村级"});
            this.uiRadioButtonGroup1.ItemSize = new System.Drawing.Size(150, 60);
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(14, 249);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(566, 95);
            this.uiRadioButtonGroup1.TabIndex = 3;
            this.uiRadioButtonGroup1.Text = "账号级别";
            this.uiRadioButtonGroup1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.uiRadioButtonGroup1.ValueChanged += new Sunny.UI.UIRadioButtonGroup.OnValueChanged(this.uiRadioButtonGroup1_ValueChanged);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.cbVillage);
            this.uiGroupBox2.Controls.Add(this.cbTown);
            this.uiGroupBox2.Controls.Add(this.tbConfirmPassword);
            this.uiGroupBox2.Controls.Add(this.tbPassword);
            this.uiGroupBox2.Controls.Add(this.tbUsername);
            this.uiGroupBox2.Controls.Add(this.uiLabel5);
            this.uiGroupBox2.Controls.Add(this.uiLabel4);
            this.uiGroupBox2.Controls.Add(this.uiLabel3);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.uiLabel6);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(14, 362);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(566, 285);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "初始化账号信息";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(140, 230);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(289, 29);
            this.cbVillage.TabIndex = 24;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(140, 185);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(289, 29);
            this.cbTown.TabIndex = 23;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(140, 141);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirmPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.ShowText = false;
            this.tbConfirmPassword.Size = new System.Drawing.Size(289, 29);
            this.tbConfirmPassword.TabIndex = 22;
            this.tbConfirmPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbConfirmPassword.Watermark = "";
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(140, 98);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(289, 29);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // tbUsername
            // 
            this.tbUsername.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.Enabled = false;
            this.tbUsername.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUsername.Location = new System.Drawing.Point(140, 55);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(5);
            this.tbUsername.ShowText = false;
            this.tbUsername.Size = new System.Drawing.Size(289, 29);
            this.tbUsername.TabIndex = 15;
            this.tbUsername.Text = "admin";
            this.tbUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbUsername.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(23, 228);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(86, 31);
            this.uiLabel5.TabIndex = 16;
            this.uiLabel5.Text = "所属村";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(23, 185);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(110, 31);
            this.uiLabel4.TabIndex = 17;
            this.uiLabel4.Text = "所属乡镇";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(23, 139);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(110, 31);
            this.uiLabel3.TabIndex = 18;
            this.uiLabel3.Text = "确认密码";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(23, 100);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(62, 31);
            this.uiLabel2.TabIndex = 19;
            this.uiLabel2.Text = "密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(23, 55);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 20;
            this.uiLabel6.Text = "用户名";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btInit
            // 
            this.btInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInit.Location = new System.Drawing.Point(412, 665);
            this.btInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btInit.Name = "btInit";
            this.btInit.Size = new System.Drawing.Size(168, 55);
            this.btInit.TabIndex = 5;
            this.btInit.Text = "立即初始化";
            this.btInit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInit.Click += new System.EventHandler(this.btInit_Click);
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            // 
            // frmInitUserAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 741);
            this.Controls.Add(this.btInit);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiRadioButtonGroup1);
            this.Controls.Add(this.uiGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInitUserAccount";
            this.Text = "初始化用户账号";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmInitUserAccount_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UITextBox tbConfirmPassword;
        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UITextBox tbUsername;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btInit;
        private Sunny.UI.UIStyleManager uiStyleManager1;
    }
}