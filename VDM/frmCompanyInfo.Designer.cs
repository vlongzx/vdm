﻿namespace com.vdm.form
{
    partial class frmCompanyInfo
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
            this.dpEstablish_date = new Sunny.UI.UIDatePicker();
            this.dpLicense_date = new Sunny.UI.UIDatePicker();
            this.tbOutput = new Sunny.UI.UITextBox();
            this.tbInsure_person_count = new Sunny.UI.UITextBox();
            this.tbStaff_size = new Sunny.UI.UITextBox();
            this.tbLegal_idcard = new Sunny.UI.UITextBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.uiLabel27 = new Sunny.UI.UILabel();
            this.tbBusiness_code = new Sunny.UI.UITextBox();
            this.tbCredit_code = new Sunny.UI.UITextBox();
            this.土地使用说明 = new Sunny.UI.UILabel();
            this.uiLabel32 = new Sunny.UI.UILabel();
            this.uiLabel33 = new Sunny.UI.UILabel();
            this.tbOrganization_code = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.tbTaxpayer_code = new Sunny.UI.UITextBox();
            this.tbCompany_address = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbCompany_type = new Sunny.UI.UIComboBox();
            this.cbCompany_status = new Sunny.UI.UIComboBox();
            this.cbIs_top_company = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbCompany_phone = new Sunny.UI.UITextBox();
            this.tbLegal_name = new Sunny.UI.UITextBox();
            this.tbCompany_name = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cbTaxpayer_qualification = new Sunny.UI.UIComboBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 484);
            this.pnlBtm.Size = new System.Drawing.Size(1610, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1482, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1367, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dpEstablish_date
            // 
            this.dpEstablish_date.FillColor = System.Drawing.Color.White;
            this.dpEstablish_date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEstablish_date.Location = new System.Drawing.Point(979, 210);
            this.dpEstablish_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEstablish_date.MaxLength = 10;
            this.dpEstablish_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEstablish_date.Name = "dpEstablish_date";
            this.dpEstablish_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEstablish_date.Size = new System.Drawing.Size(138, 29);
            this.dpEstablish_date.SymbolDropDown = 61555;
            this.dpEstablish_date.SymbolNormal = 61555;
            this.dpEstablish_date.TabIndex = 305;
            this.dpEstablish_date.Text = "2023-08-25";
            this.dpEstablish_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEstablish_date.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpEstablish_date.Watermark = "";
            // 
            // dpLicense_date
            // 
            this.dpLicense_date.FillColor = System.Drawing.Color.White;
            this.dpLicense_date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpLicense_date.Location = new System.Drawing.Point(281, 210);
            this.dpLicense_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpLicense_date.MaxLength = 10;
            this.dpLicense_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpLicense_date.Name = "dpLicense_date";
            this.dpLicense_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpLicense_date.Size = new System.Drawing.Size(120, 29);
            this.dpLicense_date.SymbolDropDown = 61555;
            this.dpLicense_date.SymbolNormal = 61555;
            this.dpLicense_date.TabIndex = 304;
            this.dpLicense_date.Text = "2023-08-25";
            this.dpLicense_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpLicense_date.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpLicense_date.Watermark = "";
            // 
            // tbOutput
            // 
            this.tbOutput.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput.Location = new System.Drawing.Point(1302, 263);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput.ShowText = false;
            this.tbOutput.Size = new System.Drawing.Size(164, 29);
            this.tbOutput.TabIndex = 287;
            this.tbOutput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput.Watermark = "";
            // 
            // tbInsure_person_count
            // 
            this.tbInsure_person_count.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbInsure_person_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInsure_person_count.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInsure_person_count.Location = new System.Drawing.Point(982, 265);
            this.tbInsure_person_count.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInsure_person_count.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbInsure_person_count.Name = "tbInsure_person_count";
            this.tbInsure_person_count.Padding = new System.Windows.Forms.Padding(5);
            this.tbInsure_person_count.ShowText = false;
            this.tbInsure_person_count.Size = new System.Drawing.Size(146, 29);
            this.tbInsure_person_count.TabIndex = 291;
            this.tbInsure_person_count.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbInsure_person_count.Watermark = "";
            // 
            // tbStaff_size
            // 
            this.tbStaff_size.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbStaff_size.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaff_size.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStaff_size.Location = new System.Drawing.Point(606, 265);
            this.tbStaff_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStaff_size.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbStaff_size.Name = "tbStaff_size";
            this.tbStaff_size.Padding = new System.Windows.Forms.Padding(5);
            this.tbStaff_size.ShowText = false;
            this.tbStaff_size.Size = new System.Drawing.Size(140, 29);
            this.tbStaff_size.TabIndex = 292;
            this.tbStaff_size.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbStaff_size.Watermark = "";
            // 
            // tbLegal_idcard
            // 
            this.tbLegal_idcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLegal_idcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLegal_idcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLegal_idcard.Location = new System.Drawing.Point(606, 166);
            this.tbLegal_idcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLegal_idcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLegal_idcard.Name = "tbLegal_idcard";
            this.tbLegal_idcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbLegal_idcard.ShowText = false;
            this.tbLegal_idcard.Size = new System.Drawing.Size(140, 29);
            this.tbLegal_idcard.TabIndex = 293;
            this.tbLegal_idcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLegal_idcard.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(466, 161);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(242, 41);
            this.uiLabel24.TabIndex = 296;
            this.uiLabel24.Text = "企业法人身份证";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel22.Location = new System.Drawing.Point(457, 256);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(146, 41);
            this.uiLabel22.TabIndex = 295;
            this.uiLabel22.Text = "人员规模";
            this.uiLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel27
            // 
            this.uiLabel27.AutoSize = true;
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel27.Location = new System.Drawing.Point(1128, 115);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(274, 41);
            this.uiLabel27.TabIndex = 294;
            this.uiLabel27.Text = "统一社会信用编码";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBusiness_code
            // 
            this.tbBusiness_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbBusiness_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBusiness_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBusiness_code.Location = new System.Drawing.Point(977, 166);
            this.tbBusiness_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusiness_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbBusiness_code.Name = "tbBusiness_code";
            this.tbBusiness_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbBusiness_code.ShowText = false;
            this.tbBusiness_code.Size = new System.Drawing.Size(140, 29);
            this.tbBusiness_code.TabIndex = 286;
            this.tbBusiness_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbBusiness_code.Watermark = "";
            // 
            // tbCredit_code
            // 
            this.tbCredit_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCredit_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCredit_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCredit_code.Location = new System.Drawing.Point(1327, 122);
            this.tbCredit_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCredit_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCredit_code.Name = "tbCredit_code";
            this.tbCredit_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbCredit_code.ShowText = false;
            this.tbCredit_code.Size = new System.Drawing.Size(139, 29);
            this.tbCredit_code.TabIndex = 285;
            this.tbCredit_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCredit_code.Watermark = "";
            // 
            // 土地使用说明
            // 
            this.土地使用说明.AutoSize = true;
            this.土地使用说明.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.土地使用说明.Location = new System.Drawing.Point(828, 161);
            this.土地使用说明.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.土地使用说明.Name = "土地使用说明";
            this.土地使用说明.Size = new System.Drawing.Size(178, 41);
            this.土地使用说明.TabIndex = 284;
            this.土地使用说明.Text = "工商注册号";
            this.土地使用说明.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel32
            // 
            this.uiLabel32.AutoSize = true;
            this.uiLabel32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel32.Location = new System.Drawing.Point(825, 212);
            this.uiLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel32.Name = "uiLabel32";
            this.uiLabel32.Size = new System.Drawing.Size(146, 41);
            this.uiLabel32.TabIndex = 283;
            this.uiLabel32.Text = "成立时间";
            this.uiLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel33
            // 
            this.uiLabel33.AutoSize = true;
            this.uiLabel33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel33.Location = new System.Drawing.Point(82, 258);
            this.uiLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel33.Name = "uiLabel33";
            this.uiLabel33.Size = new System.Drawing.Size(210, 41);
            this.uiLabel33.TabIndex = 282;
            this.uiLabel33.Text = "企业联系电话";
            this.uiLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrganization_code
            // 
            this.tbOrganization_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOrganization_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOrganization_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOrganization_code.Location = new System.Drawing.Point(606, 223);
            this.tbOrganization_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOrganization_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOrganization_code.Name = "tbOrganization_code";
            this.tbOrganization_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbOrganization_code.ShowText = false;
            this.tbOrganization_code.Size = new System.Drawing.Size(140, 29);
            this.tbOrganization_code.TabIndex = 281;
            this.tbOrganization_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOrganization_code.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(446, 211);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(210, 41);
            this.uiLabel10.TabIndex = 279;
            this.uiLabel10.Text = "组织机构代码";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTaxpayer_code
            // 
            this.tbTaxpayer_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbTaxpayer_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTaxpayer_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTaxpayer_code.Location = new System.Drawing.Point(243, 303);
            this.tbTaxpayer_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTaxpayer_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbTaxpayer_code.Name = "tbTaxpayer_code";
            this.tbTaxpayer_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbTaxpayer_code.ShowText = false;
            this.tbTaxpayer_code.Size = new System.Drawing.Size(140, 29);
            this.tbTaxpayer_code.TabIndex = 277;
            this.tbTaxpayer_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTaxpayer_code.Watermark = "";
            // 
            // tbCompany_address
            // 
            this.tbCompany_address.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_address.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_address.Location = new System.Drawing.Point(978, 119);
            this.tbCompany_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_address.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_address.Name = "tbCompany_address";
            this.tbCompany_address.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_address.ShowText = false;
            this.tbCompany_address.Size = new System.Drawing.Size(140, 29);
            this.tbCompany_address.TabIndex = 276;
            this.tbCompany_address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_address.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(1136, 203);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(210, 41);
            this.uiLabel11.TabIndex = 274;
            this.uiLabel11.Text = "企业经营状态";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(1128, 156);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(210, 41);
            this.uiLabel3.TabIndex = 273;
            this.uiLabel3.Text = "是否龙头企业";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(1136, 303);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(114, 41);
            this.uiLabel25.TabIndex = 272;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(828, 303);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(146, 41);
            this.uiLabel26.TabIndex = 275;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(981, 311);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(148, 29);
            this.cbTown.TabIndex = 267;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // cbCompany_type
            // 
            this.cbCompany_type.DataSource = null;
            this.cbCompany_type.FillColor = System.Drawing.Color.White;
            this.cbCompany_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCompany_type.Location = new System.Drawing.Point(606, 122);
            this.cbCompany_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCompany_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCompany_type.Name = "cbCompany_type";
            this.cbCompany_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCompany_type.Size = new System.Drawing.Size(140, 29);
            this.cbCompany_type.TabIndex = 268;
            this.cbCompany_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCompany_type.Watermark = "";
            // 
            // cbCompany_status
            // 
            this.cbCompany_status.DataSource = null;
            this.cbCompany_status.FillColor = System.Drawing.Color.White;
            this.cbCompany_status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCompany_status.Location = new System.Drawing.Point(1326, 211);
            this.cbCompany_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCompany_status.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCompany_status.Name = "cbCompany_status";
            this.cbCompany_status.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCompany_status.Size = new System.Drawing.Size(140, 29);
            this.cbCompany_status.TabIndex = 271;
            this.cbCompany_status.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCompany_status.Watermark = "";
            // 
            // cbIs_top_company
            // 
            this.cbIs_top_company.DataSource = null;
            this.cbIs_top_company.FillColor = System.Drawing.Color.White;
            this.cbIs_top_company.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_top_company.Location = new System.Drawing.Point(1326, 166);
            this.cbIs_top_company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_top_company.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_top_company.Name = "cbIs_top_company";
            this.cbIs_top_company.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_top_company.Size = new System.Drawing.Size(140, 29);
            this.cbIs_top_company.TabIndex = 269;
            this.cbIs_top_company.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_top_company.Watermark = "";
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(1327, 307);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(140, 29);
            this.cbVillage.TabIndex = 270;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(82, 119);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(146, 41);
            this.uiLabel2.TabIndex = 266;
            this.uiLabel2.Text = "企业名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCompany_phone
            // 
            this.tbCompany_phone.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_phone.Location = new System.Drawing.Point(243, 256);
            this.tbCompany_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_phone.Name = "tbCompany_phone";
            this.tbCompany_phone.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_phone.ShowText = false;
            this.tbCompany_phone.Size = new System.Drawing.Size(158, 29);
            this.tbCompany_phone.TabIndex = 265;
            this.tbCompany_phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_phone.Watermark = "";
            // 
            // tbLegal_name
            // 
            this.tbLegal_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLegal_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLegal_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLegal_name.Location = new System.Drawing.Point(243, 166);
            this.tbLegal_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLegal_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLegal_name.Name = "tbLegal_name";
            this.tbLegal_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbLegal_name.ShowText = false;
            this.tbLegal_name.Size = new System.Drawing.Size(158, 29);
            this.tbLegal_name.TabIndex = 264;
            this.tbLegal_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLegal_name.Watermark = "";
            // 
            // tbCompany_name
            // 
            this.tbCompany_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_name.Location = new System.Drawing.Point(243, 122);
            this.tbCompany_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_name.Name = "tbCompany_name";
            this.tbCompany_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_name.ShowText = false;
            this.tbCompany_name.Size = new System.Drawing.Size(165, 29);
            this.tbCompany_name.TabIndex = 263;
            this.tbCompany_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_name.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(457, 303);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(178, 41);
            this.uiLabel9.TabIndex = 262;
            this.uiLabel9.Text = "纳税人资质";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(82, 299);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(210, 41);
            this.uiLabel8.TabIndex = 261;
            this.uiLabel8.Text = "纳税人识别号";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(828, 110);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(146, 41);
            this.uiLabel6.TabIndex = 260;
            this.uiLabel6.Text = "企业地址";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(1136, 253);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(82, 41);
            this.uiLabel7.TabIndex = 259;
            this.uiLabel7.Text = "产值";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(828, 256);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 41);
            this.label15.TabIndex = 258;
            this.label15.Text = "参保人数";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(466, 115);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(146, 41);
            this.uiLabel5.TabIndex = 257;
            this.uiLabel5.Text = "企业类型";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(82, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 41);
            this.label12.TabIndex = 256;
            this.label12.Text = "法人姓名";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(82, 203);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(210, 41);
            this.uiLabel1.TabIndex = 280;
            this.uiLabel1.Text = "营业执照日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTaxpayer_qualification
            // 
            this.cbTaxpayer_qualification.DataSource = null;
            this.cbTaxpayer_qualification.FillColor = System.Drawing.Color.White;
            this.cbTaxpayer_qualification.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTaxpayer_qualification.Location = new System.Drawing.Point(606, 315);
            this.cbTaxpayer_qualification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTaxpayer_qualification.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTaxpayer_qualification.Name = "cbTaxpayer_qualification";
            this.cbTaxpayer_qualification.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTaxpayer_qualification.Size = new System.Drawing.Size(140, 29);
            this.cbTaxpayer_qualification.TabIndex = 268;
            this.cbTaxpayer_qualification.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTaxpayer_qualification.Watermark = "";
            // 
            // frmCompanyInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1612, 542);
            this.Controls.Add(this.dpEstablish_date);
            this.Controls.Add(this.dpLicense_date);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInsure_person_count);
            this.Controls.Add(this.tbStaff_size);
            this.Controls.Add(this.tbLegal_idcard);
            this.Controls.Add(this.uiLabel24);
            this.Controls.Add(this.uiLabel22);
            this.Controls.Add(this.uiLabel27);
            this.Controls.Add(this.tbBusiness_code);
            this.Controls.Add(this.tbCredit_code);
            this.Controls.Add(this.土地使用说明);
            this.Controls.Add(this.uiLabel32);
            this.Controls.Add(this.uiLabel33);
            this.Controls.Add(this.tbOrganization_code);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.tbTaxpayer_code);
            this.Controls.Add(this.tbCompany_address);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel25);
            this.Controls.Add(this.uiLabel26);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.cbTaxpayer_qualification);
            this.Controls.Add(this.cbCompany_type);
            this.Controls.Add(this.cbCompany_status);
            this.Controls.Add(this.cbIs_top_company);
            this.Controls.Add(this.cbVillage);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.tbCompany_phone);
            this.Controls.Add(this.tbLegal_name);
            this.Controls.Add(this.tbCompany_name);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uiLabel1);
            this.Name = "frmCompanyInfo";
            this.Text = "企业信息";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 600, 450);
            this.Load += new System.EventHandler(this.frmCompanyInfo_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.uiLabel9, 0);
            this.Controls.SetChildIndex(this.tbCompany_name, 0);
            this.Controls.SetChildIndex(this.tbLegal_name, 0);
            this.Controls.SetChildIndex(this.tbCompany_phone, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.cbVillage, 0);
            this.Controls.SetChildIndex(this.cbIs_top_company, 0);
            this.Controls.SetChildIndex(this.cbCompany_status, 0);
            this.Controls.SetChildIndex(this.cbCompany_type, 0);
            this.Controls.SetChildIndex(this.cbTaxpayer_qualification, 0);
            this.Controls.SetChildIndex(this.cbTown, 0);
            this.Controls.SetChildIndex(this.uiLabel26, 0);
            this.Controls.SetChildIndex(this.uiLabel25, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.uiLabel11, 0);
            this.Controls.SetChildIndex(this.tbCompany_address, 0);
            this.Controls.SetChildIndex(this.tbTaxpayer_code, 0);
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.tbOrganization_code, 0);
            this.Controls.SetChildIndex(this.uiLabel33, 0);
            this.Controls.SetChildIndex(this.uiLabel32, 0);
            this.Controls.SetChildIndex(this.土地使用说明, 0);
            this.Controls.SetChildIndex(this.tbCredit_code, 0);
            this.Controls.SetChildIndex(this.tbBusiness_code, 0);
            this.Controls.SetChildIndex(this.uiLabel27, 0);
            this.Controls.SetChildIndex(this.uiLabel22, 0);
            this.Controls.SetChildIndex(this.uiLabel24, 0);
            this.Controls.SetChildIndex(this.tbLegal_idcard, 0);
            this.Controls.SetChildIndex(this.tbStaff_size, 0);
            this.Controls.SetChildIndex(this.tbInsure_person_count, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.dpLicense_date, 0);
            this.Controls.SetChildIndex(this.dpEstablish_date, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDatePicker dpEstablish_date;
        private Sunny.UI.UIDatePicker dpLicense_date;
        private Sunny.UI.UITextBox tbOutput;
        private Sunny.UI.UITextBox tbInsure_person_count;
        private Sunny.UI.UITextBox tbStaff_size;
        private Sunny.UI.UITextBox tbLegal_idcard;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILabel uiLabel27;
        private Sunny.UI.UITextBox tbBusiness_code;
        private Sunny.UI.UITextBox tbCredit_code;
        private Sunny.UI.UILabel 土地使用说明;
        private Sunny.UI.UILabel uiLabel32;
        private Sunny.UI.UILabel uiLabel33;
        private Sunny.UI.UITextBox tbOrganization_code;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox tbTaxpayer_code;
        private Sunny.UI.UITextBox tbCompany_address;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbCompany_type;
        private Sunny.UI.UIComboBox cbCompany_status;
        private Sunny.UI.UIComboBox cbIs_top_company;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbCompany_phone;
        private Sunny.UI.UITextBox tbLegal_name;
        private Sunny.UI.UITextBox tbCompany_name;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbTaxpayer_qualification;
    }
}