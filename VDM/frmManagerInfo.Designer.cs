namespace com.vdm.form
{
    partial class frmManagerInfo
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
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dpEmploy_date = new Sunny.UI.UIDatePicker();
            this.dpBirthday = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time = new Sunny.UI.UIDatePicker();
            this.cbPolitcal_outlook = new Sunny.UI.UIComboBox();
            this.cbEducation = new Sunny.UI.UIComboBox();
            this.cbSex = new Sunny.UI.UIComboBox();
            this.cbNation = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbPost = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbManager_name = new Sunny.UI.UITextBox();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.label13 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 397);
            this.pnlBtm.Size = new System.Drawing.Size(1536, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1408, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1293, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(85, 214);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(146, 41);
            this.uiLabel5.TabIndex = 198;
            this.uiLabel5.Text = "任职时间";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(798, 216);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(146, 41);
            this.uiLabel24.TabIndex = 197;
            this.uiLabel24.Text = "最高学历";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(1153, 129);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(82, 41);
            this.uiLabel23.TabIndex = 196;
            this.uiLabel23.Text = "性别";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(85, 263);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(114, 41);
            this.uiLabel25.TabIndex = 194;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(1153, 214);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(146, 41);
            this.uiLabel26.TabIndex = 195;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(1297, 226);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(163, 29);
            this.cbTown.TabIndex = 192;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(246, 275);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(165, 29);
            this.cbVillage.TabIndex = 193;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(449, 175);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(146, 41);
            this.uiLabel1.TabIndex = 189;
            this.uiLabel1.Text = "出生日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(85, 129);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(82, 41);
            this.uiLabel2.TabIndex = 188;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpEmploy_date
            // 
            this.dpEmploy_date.FillColor = System.Drawing.Color.White;
            this.dpEmploy_date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEmploy_date.Location = new System.Drawing.Point(246, 222);
            this.dpEmploy_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEmploy_date.MaxLength = 10;
            this.dpEmploy_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEmploy_date.Name = "dpEmploy_date";
            this.dpEmploy_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEmploy_date.Size = new System.Drawing.Size(165, 29);
            this.dpEmploy_date.SymbolDropDown = 61555;
            this.dpEmploy_date.SymbolNormal = 61555;
            this.dpEmploy_date.TabIndex = 187;
            this.dpEmploy_date.Text = "2023-08-25";
            this.dpEmploy_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEmploy_date.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpEmploy_date.Watermark = "";
            // 
            // dpBirthday
            // 
            this.dpBirthday.FillColor = System.Drawing.Color.White;
            this.dpBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday.Location = new System.Drawing.Point(591, 183);
            this.dpBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday.MaxLength = 10;
            this.dpBirthday.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday.Size = new System.Drawing.Size(165, 29);
            this.dpBirthday.SymbolDropDown = 61555;
            this.dpBirthday.SymbolNormal = 61555;
            this.dpBirthday.TabIndex = 186;
            this.dpBirthday.Text = "2023-08-25";
            this.dpBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpBirthday.Watermark = "";
            // 
            // dpJoin_party_time
            // 
            this.dpJoin_party_time.FillColor = System.Drawing.Color.White;
            this.dpJoin_party_time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpJoin_party_time.Location = new System.Drawing.Point(1297, 175);
            this.dpJoin_party_time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time.MaxLength = 10;
            this.dpJoin_party_time.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time.Name = "dpJoin_party_time";
            this.dpJoin_party_time.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time.Size = new System.Drawing.Size(163, 29);
            this.dpJoin_party_time.SymbolDropDown = 61555;
            this.dpJoin_party_time.SymbolNormal = 61555;
            this.dpJoin_party_time.TabIndex = 185;
            this.dpJoin_party_time.Text = "2023-08-25";
            this.dpJoin_party_time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time.Watermark = "";
            // 
            // cbPolitcal_outlook
            // 
            this.cbPolitcal_outlook.DataSource = null;
            this.cbPolitcal_outlook.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPolitcal_outlook.FillColor = System.Drawing.Color.White;
            this.cbPolitcal_outlook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPolitcal_outlook.Location = new System.Drawing.Point(950, 176);
            this.cbPolitcal_outlook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPolitcal_outlook.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPolitcal_outlook.Name = "cbPolitcal_outlook";
            this.cbPolitcal_outlook.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPolitcal_outlook.Size = new System.Drawing.Size(152, 29);
            this.cbPolitcal_outlook.TabIndex = 181;
            this.cbPolitcal_outlook.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPolitcal_outlook.Watermark = "";
            // 
            // cbEducation
            // 
            this.cbEducation.DataSource = null;
            this.cbEducation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbEducation.FillColor = System.Drawing.Color.White;
            this.cbEducation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbEducation.Location = new System.Drawing.Point(950, 226);
            this.cbEducation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEducation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbEducation.Size = new System.Drawing.Size(152, 29);
            this.cbEducation.TabIndex = 180;
            this.cbEducation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEducation.Watermark = "";
            // 
            // cbSex
            // 
            this.cbSex.DataSource = null;
            this.cbSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbSex.FillColor = System.Drawing.Color.White;
            this.cbSex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSex.Location = new System.Drawing.Point(1297, 130);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSex.Size = new System.Drawing.Size(163, 29);
            this.cbSex.TabIndex = 179;
            this.cbSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSex.Watermark = "";
            // 
            // cbNation
            // 
            this.cbNation.DataSource = null;
            this.cbNation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbNation.FillColor = System.Drawing.Color.White;
            this.cbNation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbNation.Location = new System.Drawing.Point(950, 130);
            this.cbNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNation.Name = "cbNation";
            this.cbNation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNation.Size = new System.Drawing.Size(152, 29);
            this.cbNation.TabIndex = 178;
            this.cbNation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNation.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(591, 234);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 177;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbPost
            // 
            this.tbPost.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPost.Location = new System.Drawing.Point(591, 130);
            this.tbPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPost.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPost.Name = "tbPost";
            this.tbPost.Padding = new System.Windows.Forms.Padding(5);
            this.tbPost.ShowText = false;
            this.tbPost.Size = new System.Drawing.Size(165, 29);
            this.tbPost.TabIndex = 176;
            this.tbPost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPost.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(246, 176);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(165, 29);
            this.tbIdcard.TabIndex = 175;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            this.tbIdcard.TextChanged += new System.EventHandler(this.tbIdcard_TextChanged);
            // 
            // tbManager_name
            // 
            this.tbManager_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbManager_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbManager_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbManager_name.Location = new System.Drawing.Point(246, 130);
            this.tbManager_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbManager_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbManager_name.Name = "tbManager_name";
            this.tbManager_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbManager_name.ShowText = false;
            this.tbManager_name.Size = new System.Drawing.Size(165, 29);
            this.tbManager_name.TabIndex = 174;
            this.tbManager_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbManager_name.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(798, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 41);
            this.label9.TabIndex = 173;
            this.label9.Text = "政治面貌";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(798, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 172;
            this.label3.Text = "民族";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 41);
            this.label2.TabIndex = 171;
            this.label2.Text = "职务";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1152, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 41);
            this.label10.TabIndex = 170;
            this.label10.Text = "入党时间";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 41);
            this.label13.TabIndex = 169;
            this.label13.Text = "联系电话";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 41);
            this.label12.TabIndex = 168;
            this.label12.Text = "身份证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmManagerInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1538, 455);
            this.Controls.Add(this.dpBirthday);
            this.Controls.Add(this.tbPhone_number);
            this.Controls.Add(this.tbPost);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel24);
            this.Controls.Add(this.uiLabel23);
            this.Controls.Add(this.uiLabel25);
            this.Controls.Add(this.uiLabel26);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.cbVillage);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.dpEmploy_date);
            this.Controls.Add(this.dpJoin_party_time);
            this.Controls.Add(this.cbPolitcal_outlook);
            this.Controls.Add(this.cbEducation);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbNation);
            this.Controls.Add(this.tbIdcard);
            this.Controls.Add(this.tbManager_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "frmManagerInfo";
            this.Text = "村干部信息";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 730, 512);
            this.Load += new System.EventHandler(this.frmManagerInfo_Load);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbManager_name, 0);
            this.Controls.SetChildIndex(this.tbIdcard, 0);
            this.Controls.SetChildIndex(this.cbNation, 0);
            this.Controls.SetChildIndex(this.cbSex, 0);
            this.Controls.SetChildIndex(this.cbEducation, 0);
            this.Controls.SetChildIndex(this.cbPolitcal_outlook, 0);
            this.Controls.SetChildIndex(this.dpJoin_party_time, 0);
            this.Controls.SetChildIndex(this.dpEmploy_date, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.cbVillage, 0);
            this.Controls.SetChildIndex(this.cbTown, 0);
            this.Controls.SetChildIndex(this.uiLabel26, 0);
            this.Controls.SetChildIndex(this.uiLabel25, 0);
            this.Controls.SetChildIndex(this.uiLabel23, 0);
            this.Controls.SetChildIndex(this.uiLabel24, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.tbPost, 0);
            this.Controls.SetChildIndex(this.tbPhone_number, 0);
            this.Controls.SetChildIndex(this.dpBirthday, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker dpEmploy_date;
        private Sunny.UI.UIDatePicker dpBirthday;
        private Sunny.UI.UIDatePicker dpJoin_party_time;
        private Sunny.UI.UIComboBox cbPolitcal_outlook;
        private Sunny.UI.UIComboBox cbEducation;
        private Sunny.UI.UIComboBox cbSex;
        private Sunny.UI.UIComboBox cbNation;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbPost;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbManager_name;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel label12;
    }
}