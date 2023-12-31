﻿namespace com.vdm.form
{
    partial class frmPlantInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbQuestion = new Sunny.UI.UIComboBox();
            this.tbRemark = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel20 = new Sunny.UI.UILabel();
            this.ctvManage_skill_method = new Sunny.UI.UIComboTreeView();
            this.ctvSale_way = new Sunny.UI.UIComboTreeView();
            this.ctvPlant_type = new Sunny.UI.UIComboTreeView();
            this.tbYear_yield = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbInsect_ill = new Sunny.UI.UIComboBox();
            this.cbDevelop_willing = new Sunny.UI.UIComboBox();
            this.cbIs_plan = new Sunny.UI.UIComboBox();
            this.tbAddress = new Sunny.UI.UITextBox();
            this.tbPlant_brand = new Sunny.UI.UITextBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbOutput = new Sunny.UI.UITextBox();
            this.tbPlant_area = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbContact_person = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 461);
            this.pnlBtm.Size = new System.Drawing.Size(1391, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1263, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1148, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPlant_area);
            this.groupBox1.Controls.Add(this.cbIs_plan);
            this.groupBox1.Controls.Add(this.ctvManage_skill_method);
            this.groupBox1.Controls.Add(this.ctvSale_way);
            this.groupBox1.Controls.Add(this.ctvPlant_type);
            this.groupBox1.Controls.Add(this.tbYear_yield);
            this.groupBox1.Controls.Add(this.uiLabel6);
            this.groupBox1.Controls.Add(this.cbTown);
            this.groupBox1.Controls.Add(this.cbVillage);
            this.groupBox1.Controls.Add(this.uiLabel7);
            this.groupBox1.Controls.Add(this.uiLabel23);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.uiLabel9);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Controls.Add(this.cbInsect_ill);
            this.groupBox1.Controls.Add(this.cbDevelop_willing);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbPlant_brand);
            this.groupBox1.Controls.Add(this.tbPhone_number);
            this.groupBox1.Controls.Add(this.tbOutput);
            this.groupBox1.Controls.Add(this.tbIdcard);
            this.groupBox1.Controls.Add(this.tbContact_person);
            this.groupBox1.Controls.Add(this.uiLabel14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.uiLabel8);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.uiLabel10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbQuestion);
            this.groupBox1.Controls.Add(this.tbRemark);
            this.groupBox1.Controls.Add(this.uiLabel11);
            this.groupBox1.Controls.Add(this.uiLabel20);
            this.groupBox1.Location = new System.Drawing.Point(19, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1328, 389);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "种植信息";
            // 
            // cbQuestion
            // 
            this.cbQuestion.DataSource = null;
            this.cbQuestion.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbQuestion.FillColor = System.Drawing.Color.White;
            this.cbQuestion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbQuestion.Location = new System.Drawing.Point(186, 193);
            this.cbQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbQuestion.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbQuestion.Size = new System.Drawing.Size(165, 29);
            this.cbQuestion.TabIndex = 14;
            this.cbQuestion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbQuestion.Watermark = "";
            // 
            // tbRemark
            // 
            this.tbRemark.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRemark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRemark.Location = new System.Drawing.Point(186, 233);
            this.tbRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRemark.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Padding = new System.Windows.Forms.Padding(5);
            this.tbRemark.ShowScrollBar = true;
            this.tbRemark.ShowText = false;
            this.tbRemark.Size = new System.Drawing.Size(1100, 127);
            this.tbRemark.Style = Sunny.UI.UIStyle.Custom;
            this.tbRemark.TabIndex = 18;
            this.tbRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRemark.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(65, 228);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(62, 31);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 13;
            this.uiLabel11.Text = "备注";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel20
            // 
            this.uiLabel20.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel20.Location = new System.Drawing.Point(65, 182);
            this.uiLabel20.Name = "uiLabel20";
            this.uiLabel20.Size = new System.Drawing.Size(306, 46);
            this.uiLabel20.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel20.TabIndex = 13;
            this.uiLabel20.Text = "需要政府\r\n解决的问题";
            this.uiLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctvManage_skill_method
            // 
            this.ctvManage_skill_method.CheckBoxes = true;
            this.ctvManage_skill_method.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvManage_skill_method.FillColor = System.Drawing.Color.White;
            this.ctvManage_skill_method.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvManage_skill_method.Location = new System.Drawing.Point(186, 159);
            this.ctvManage_skill_method.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvManage_skill_method.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvManage_skill_method.Name = "ctvManage_skill_method";
            this.ctvManage_skill_method.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvManage_skill_method.ShowSelectedAllCheckBox = false;
            this.ctvManage_skill_method.Size = new System.Drawing.Size(165, 29);
            this.ctvManage_skill_method.TabIndex = 343;
            this.ctvManage_skill_method.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvManage_skill_method.Watermark = "";
            // 
            // ctvSale_way
            // 
            this.ctvSale_way.CheckBoxes = true;
            this.ctvSale_way.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvSale_way.FillColor = System.Drawing.Color.White;
            this.ctvSale_way.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvSale_way.Location = new System.Drawing.Point(499, 128);
            this.ctvSale_way.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvSale_way.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvSale_way.Name = "ctvSale_way";
            this.ctvSale_way.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvSale_way.ShowSelectedAllCheckBox = false;
            this.ctvSale_way.Size = new System.Drawing.Size(165, 29);
            this.ctvSale_way.TabIndex = 344;
            this.ctvSale_way.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvSale_way.Watermark = "";
            // 
            // ctvPlant_type
            // 
            this.ctvPlant_type.CheckBoxes = true;
            this.ctvPlant_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvPlant_type.FillColor = System.Drawing.Color.White;
            this.ctvPlant_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvPlant_type.Location = new System.Drawing.Point(186, 66);
            this.ctvPlant_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvPlant_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvPlant_type.Name = "ctvPlant_type";
            this.ctvPlant_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvPlant_type.ShowSelectedAllCheckBox = false;
            this.ctvPlant_type.Size = new System.Drawing.Size(165, 29);
            this.ctvPlant_type.TabIndex = 345;
            this.ctvPlant_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvPlant_type.Watermark = "";
            // 
            // tbYear_yield
            // 
            this.tbYear_yield.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_yield.CanEmpty = true;
            this.tbYear_yield.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_yield.DecimalPlaces = 1;
            this.tbYear_yield.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_yield.Location = new System.Drawing.Point(186, 128);
            this.tbYear_yield.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_yield.Minimum = 0D;
            this.tbYear_yield.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_yield.Name = "tbYear_yield";
            this.tbYear_yield.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_yield.ShowText = false;
            this.tbYear_yield.Size = new System.Drawing.Size(165, 29);
            this.tbYear_yield.TabIndex = 329;
            this.tbYear_yield.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_yield.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbYear_yield.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(1027, 159);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 341;
            this.uiLabel6.Text = "所属村";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(827, 159);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(165, 29);
            this.cbTown.TabIndex = 340;
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
            this.cbVillage.Location = new System.Drawing.Point(1121, 159);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(165, 29);
            this.cbVillage.TabIndex = 339;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(700, 159);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(86, 31);
            this.uiLabel7.TabIndex = 338;
            this.uiLabel7.Text = "所属镇";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(65, 97);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(110, 31);
            this.uiLabel23.TabIndex = 337;
            this.uiLabel23.Text = "详细地址";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(700, 97);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(150, 31);
            this.uiLabel3.TabIndex = 336;
            this.uiLabel3.Text = "种植面积(亩)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(393, 97);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 335;
            this.uiLabel1.Text = "是否符合规划";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(65, 159);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(182, 31);
            this.uiLabel9.TabIndex = 334;
            this.uiLabel9.Text = "主要管理和技术";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(65, 66);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(110, 31);
            this.uiLabel2.TabIndex = 333;
            this.uiLabel2.Text = "种植类别";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInsect_ill
            // 
            this.cbInsect_ill.DataSource = null;
            this.cbInsect_ill.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbInsect_ill.FillColor = System.Drawing.Color.White;
            this.cbInsect_ill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbInsect_ill.Location = new System.Drawing.Point(1121, 128);
            this.cbInsect_ill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInsect_ill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbInsect_ill.Name = "cbInsect_ill";
            this.cbInsect_ill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbInsect_ill.Size = new System.Drawing.Size(165, 29);
            this.cbInsect_ill.TabIndex = 331;
            this.cbInsect_ill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbInsect_ill.Watermark = "";
            // 
            // cbDevelop_willing
            // 
            this.cbDevelop_willing.DataSource = null;
            this.cbDevelop_willing.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbDevelop_willing.FillColor = System.Drawing.Color.White;
            this.cbDevelop_willing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDevelop_willing.Location = new System.Drawing.Point(499, 159);
            this.cbDevelop_willing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDevelop_willing.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDevelop_willing.Name = "cbDevelop_willing";
            this.cbDevelop_willing.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDevelop_willing.Size = new System.Drawing.Size(165, 29);
            this.cbDevelop_willing.TabIndex = 330;
            this.cbDevelop_willing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDevelop_willing.Watermark = "";
            // 
            // cbIs_plan
            // 
            this.cbIs_plan.DataSource = null;
            this.cbIs_plan.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbIs_plan.FillColor = System.Drawing.Color.White;
            this.cbIs_plan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_plan.Location = new System.Drawing.Point(499, 97);
            this.cbIs_plan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_plan.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_plan.Name = "cbIs_plan";
            this.cbIs_plan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_plan.Size = new System.Drawing.Size(165, 29);
            this.cbIs_plan.TabIndex = 332;
            this.cbIs_plan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_plan.Watermark = "";
            // 
            // tbAddress
            // 
            this.tbAddress.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(186, 97);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tbAddress.ShowText = false;
            this.tbAddress.Size = new System.Drawing.Size(165, 29);
            this.tbAddress.TabIndex = 327;
            this.tbAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAddress.Watermark = "";
            // 
            // tbPlant_brand
            // 
            this.tbPlant_brand.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_brand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_brand.Location = new System.Drawing.Point(1121, 97);
            this.tbPlant_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_brand.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_brand.Name = "tbPlant_brand";
            this.tbPlant_brand.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_brand.ShowText = false;
            this.tbPlant_brand.Size = new System.Drawing.Size(165, 29);
            this.tbPlant_brand.TabIndex = 326;
            this.tbPlant_brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_brand.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(1121, 64);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 325;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbOutput
            // 
            this.tbOutput.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput.CanEmpty = true;
            this.tbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput.Location = new System.Drawing.Point(827, 128);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput.Minimum = 0D;
            this.tbOutput.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput.ShowText = false;
            this.tbOutput.Size = new System.Drawing.Size(165, 29);
            this.tbOutput.TabIndex = 324;
            this.tbOutput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbOutput.Watermark = "";
            // 
            // tbPlant_area
            // 
            this.tbPlant_area.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_area.CanEmpty = true;
            this.tbPlant_area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_area.Location = new System.Drawing.Point(827, 97);
            this.tbPlant_area.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_area.Minimum = 0D;
            this.tbPlant_area.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_area.Name = "tbPlant_area";
            this.tbPlant_area.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_area.ShowText = false;
            this.tbPlant_area.Size = new System.Drawing.Size(165, 29);
            this.tbPlant_area.TabIndex = 323;
            this.tbPlant_area.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_area.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbPlant_area.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(827, 66);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(165, 29);
            this.tbIdcard.TabIndex = 322;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // tbContact_person
            // 
            this.tbContact_person.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContact_person.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContact_person.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContact_person.Location = new System.Drawing.Point(499, 66);
            this.tbContact_person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContact_person.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContact_person.Name = "tbContact_person";
            this.tbContact_person.Padding = new System.Windows.Forms.Padding(5);
            this.tbContact_person.ShowText = false;
            this.tbContact_person.Size = new System.Drawing.Size(165, 29);
            this.tbContact_person.TabIndex = 321;
            this.tbContact_person.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContact_person.Watermark = "";
            // 
            // uiLabel14
            // 
            this.uiLabel14.AutoSize = true;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel14.Location = new System.Drawing.Point(700, 66);
            this.uiLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(182, 31);
            this.uiLabel14.TabIndex = 319;
            this.uiLabel14.Text = "联系人身份证号";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1027, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 320;
            this.label9.Text = "联系电话";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1027, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 318;
            this.label3.Text = "种植品种";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 317;
            this.label2.Text = "联系人";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 31);
            this.label10.TabIndex = 316;
            this.label10.Text = "年产量(斤)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(1027, 128);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(134, 31);
            this.uiLabel8.TabIndex = 314;
            this.uiLabel8.Text = "主要虫病害";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(700, 128);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(126, 31);
            this.uiLabel4.TabIndex = 313;
            this.uiLabel4.Text = "产值(万元)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(393, 159);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(110, 31);
            this.uiLabel10.TabIndex = 315;
            this.uiLabel10.Text = "发展意愿";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 312;
            this.label8.Text = "销售途径";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPlantInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1393, 519);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPlantInfo";
            this.Text = "frmPlantInfo";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmPlantInfo_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlBtm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UILabel uiLabel20;
        private Sunny.UI.UITextBox tbRemark;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIComboBox cbQuestion;
        private Sunny.UI.UITextBox tbPlant_area;
        private Sunny.UI.UIComboBox cbIs_plan;
        private Sunny.UI.UIComboTreeView ctvManage_skill_method;
        private Sunny.UI.UIComboTreeView ctvSale_way;
        private Sunny.UI.UIComboTreeView ctvPlant_type;
        private Sunny.UI.UITextBox tbYear_yield;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cbInsect_ill;
        private Sunny.UI.UIComboBox cbDevelop_willing;
        private Sunny.UI.UITextBox tbAddress;
        private Sunny.UI.UITextBox tbPlant_brand;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbOutput;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbContact_person;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel label8;
    }
}