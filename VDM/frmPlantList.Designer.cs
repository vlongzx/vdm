namespace com.vdm.form
{
    partial class frmPlantList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pagination = new Sunny.UI.UIPagination();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbYear_yield_to = new Sunny.UI.UITextBox();
            this.tbYear_yield_from = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btImport = new Sunny.UI.UIButton();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.ctvManage_skill_method = new Sunny.UI.UIComboTreeView();
            this.ctvSale_way = new Sunny.UI.UIComboTreeView();
            this.ctvPlant_type = new Sunny.UI.UIComboTreeView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbInsect_ill = new Sunny.UI.UIComboBox();
            this.cbDevelop_willing = new Sunny.UI.UIComboBox();
            this.cbIs_plan = new Sunny.UI.UIComboBox();
            this.tbAddress = new Sunny.UI.UITextBox();
            this.tbPlant_brand = new Sunny.UI.UITextBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
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
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.dgPlantList = new Sunny.UI.UIDataGridView();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.btEdit = new Sunny.UI.UIButton();
            this.tbPlant_area_from = new Sunny.UI.UITextBox();
            this.tbPlant_area_to = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.tbOutput_from = new Sunny.UI.UITextBox();
            this.tbOutput_to = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlantList)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagination
            // 
            this.pagination.ActivePage = 20;
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(16, 1031);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 11;
            this.pagination.PageSize = 50;
            this.pagination.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.ShowText = false;
            this.pagination.Size = new System.Drawing.Size(2229, 35);
            this.pagination.TabIndex = 103;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(226, 104);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(24, 31);
            this.uiLabel5.TabIndex = 174;
            this.uiLabel5.Text = "-";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbYear_yield_to
            // 
            this.tbYear_yield_to.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_yield_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_yield_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_yield_to.Location = new System.Drawing.Point(260, 104);
            this.tbYear_yield_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_yield_to.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_yield_to.Name = "tbYear_yield_to";
            this.tbYear_yield_to.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_yield_to.ShowText = false;
            this.tbYear_yield_to.Size = new System.Drawing.Size(62, 29);
            this.tbYear_yield_to.TabIndex = 131;
            this.tbYear_yield_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_yield_to.Watermark = "";
            // 
            // tbYear_yield_from
            // 
            this.tbYear_yield_from.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_yield_from.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_yield_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_yield_from.Location = new System.Drawing.Point(157, 104);
            this.tbYear_yield_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_yield_from.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_yield_from.Name = "tbYear_yield_from";
            this.tbYear_yield_from.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_yield_from.ShowText = false;
            this.tbYear_yield_from.Size = new System.Drawing.Size(62, 29);
            this.tbYear_yield_from.TabIndex = 131;
            this.tbYear_yield_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_yield_from.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(998, 135);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 173;
            this.uiLabel6.Text = "所属村";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(798, 135);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(165, 29);
            this.cbTown.TabIndex = 170;
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
            this.cbVillage.Location = new System.Drawing.Point(1092, 135);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(165, 29);
            this.cbVillage.TabIndex = 170;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(671, 135);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(86, 31);
            this.uiLabel7.TabIndex = 167;
            this.uiLabel7.Text = "所属镇";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(36, 73);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(110, 31);
            this.uiLabel23.TabIndex = 163;
            this.uiLabel23.Text = "详细地址";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(671, 73);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(150, 31);
            this.uiLabel3.TabIndex = 147;
            this.uiLabel3.Text = "种植面积(亩)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(300, 194);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(87, 48);
            this.btImport.TabIndex = 98;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.ctvManage_skill_method);
            this.gbSearch.Controls.Add(this.ctvSale_way);
            this.gbSearch.Controls.Add(this.ctvPlant_type);
            this.gbSearch.Controls.Add(this.uiLabel12);
            this.gbSearch.Controls.Add(this.uiLabel11);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.tbOutput_to);
            this.gbSearch.Controls.Add(this.tbPlant_area_to);
            this.gbSearch.Controls.Add(this.tbOutput_from);
            this.gbSearch.Controls.Add(this.tbPlant_area_from);
            this.gbSearch.Controls.Add(this.tbYear_yield_to);
            this.gbSearch.Controls.Add(this.tbYear_yield_from);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel7);
            this.gbSearch.Controls.Add(this.uiLabel23);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel9);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.cbInsect_ill);
            this.gbSearch.Controls.Add(this.cbDevelop_willing);
            this.gbSearch.Controls.Add(this.cbIs_plan);
            this.gbSearch.Controls.Add(this.tbAddress);
            this.gbSearch.Controls.Add(this.tbPlant_brand);
            this.gbSearch.Controls.Add(this.tbPhone_number);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.tbContact_person);
            this.gbSearch.Controls.Add(this.uiLabel14);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.uiLabel8);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.uiLabel10);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(19, 7);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1883, 179);
            this.gbSearch.TabIndex = 104;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctvManage_skill_method
            // 
            this.ctvManage_skill_method.CheckBoxes = true;
            this.ctvManage_skill_method.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvManage_skill_method.FillColor = System.Drawing.Color.White;
            this.ctvManage_skill_method.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvManage_skill_method.Location = new System.Drawing.Point(157, 135);
            this.ctvManage_skill_method.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvManage_skill_method.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvManage_skill_method.Name = "ctvManage_skill_method";
            this.ctvManage_skill_method.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvManage_skill_method.ShowSelectedAllCheckBox = false;
            this.ctvManage_skill_method.Size = new System.Drawing.Size(165, 29);
            this.ctvManage_skill_method.TabIndex = 309;
            this.ctvManage_skill_method.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvManage_skill_method.Watermark = "";
            // 
            // ctvSale_way
            // 
            this.ctvSale_way.CheckBoxes = true;
            this.ctvSale_way.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvSale_way.FillColor = System.Drawing.Color.White;
            this.ctvSale_way.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvSale_way.Location = new System.Drawing.Point(470, 104);
            this.ctvSale_way.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvSale_way.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvSale_way.Name = "ctvSale_way";
            this.ctvSale_way.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvSale_way.ShowSelectedAllCheckBox = false;
            this.ctvSale_way.Size = new System.Drawing.Size(165, 29);
            this.ctvSale_way.TabIndex = 310;
            this.ctvSale_way.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvSale_way.Watermark = "";
            // 
            // ctvPlant_type
            // 
            this.ctvPlant_type.CheckBoxes = true;
            this.ctvPlant_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvPlant_type.FillColor = System.Drawing.Color.White;
            this.ctvPlant_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvPlant_type.Location = new System.Drawing.Point(157, 42);
            this.ctvPlant_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvPlant_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvPlant_type.Name = "ctvPlant_type";
            this.ctvPlant_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvPlant_type.ShowSelectedAllCheckBox = false;
            this.ctvPlant_type.Size = new System.Drawing.Size(165, 29);
            this.ctvPlant_type.TabIndex = 311;
            this.ctvPlant_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvPlant_type.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(364, 73);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "是否符合规划";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(36, 135);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(182, 31);
            this.uiLabel9.TabIndex = 145;
            this.uiLabel9.Text = "主要管理和技术";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(36, 42);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(110, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "种植类别";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInsect_ill
            // 
            this.cbInsect_ill.DataSource = null;
            this.cbInsect_ill.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbInsect_ill.FillColor = System.Drawing.Color.White;
            this.cbInsect_ill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbInsect_ill.Location = new System.Drawing.Point(1092, 104);
            this.cbInsect_ill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInsect_ill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbInsect_ill.Name = "cbInsect_ill";
            this.cbInsect_ill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbInsect_ill.Size = new System.Drawing.Size(165, 29);
            this.cbInsect_ill.TabIndex = 134;
            this.cbInsect_ill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbInsect_ill.Watermark = "";
            // 
            // cbDevelop_willing
            // 
            this.cbDevelop_willing.DataSource = null;
            this.cbDevelop_willing.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbDevelop_willing.FillColor = System.Drawing.Color.White;
            this.cbDevelop_willing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDevelop_willing.Location = new System.Drawing.Point(470, 135);
            this.cbDevelop_willing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDevelop_willing.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDevelop_willing.Name = "cbDevelop_willing";
            this.cbDevelop_willing.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDevelop_willing.Size = new System.Drawing.Size(165, 29);
            this.cbDevelop_willing.TabIndex = 134;
            this.cbDevelop_willing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDevelop_willing.Watermark = "";
            // 
            // cbIs_plan
            // 
            this.cbIs_plan.DataSource = null;
            this.cbIs_plan.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbIs_plan.FillColor = System.Drawing.Color.White;
            this.cbIs_plan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_plan.Location = new System.Drawing.Point(470, 73);
            this.cbIs_plan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_plan.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_plan.Name = "cbIs_plan";
            this.cbIs_plan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_plan.Size = new System.Drawing.Size(165, 29);
            this.cbIs_plan.TabIndex = 134;
            this.cbIs_plan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_plan.Watermark = "";
            // 
            // tbAddress
            // 
            this.tbAddress.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(157, 73);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tbAddress.ShowText = false;
            this.tbAddress.Size = new System.Drawing.Size(165, 29);
            this.tbAddress.TabIndex = 130;
            this.tbAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAddress.Watermark = "";
            // 
            // tbPlant_brand
            // 
            this.tbPlant_brand.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_brand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_brand.Location = new System.Drawing.Point(1092, 73);
            this.tbPlant_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_brand.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_brand.Name = "tbPlant_brand";
            this.tbPlant_brand.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_brand.ShowText = false;
            this.tbPlant_brand.Size = new System.Drawing.Size(165, 29);
            this.tbPlant_brand.TabIndex = 130;
            this.tbPlant_brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_brand.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(1092, 40);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 130;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(798, 42);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(165, 29);
            this.tbIdcard.TabIndex = 130;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // tbContact_person
            // 
            this.tbContact_person.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContact_person.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContact_person.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContact_person.Location = new System.Drawing.Point(470, 42);
            this.tbContact_person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContact_person.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContact_person.Name = "tbContact_person";
            this.tbContact_person.Padding = new System.Windows.Forms.Padding(5);
            this.tbContact_person.ShowText = false;
            this.tbContact_person.Size = new System.Drawing.Size(165, 29);
            this.tbContact_person.TabIndex = 130;
            this.tbContact_person.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContact_person.Watermark = "";
            // 
            // uiLabel14
            // 
            this.uiLabel14.AutoSize = true;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel14.Location = new System.Drawing.Point(671, 42);
            this.uiLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(182, 31);
            this.uiLabel14.TabIndex = 116;
            this.uiLabel14.Text = "联系人身份证号";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(998, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 116;
            this.label9.Text = "联系电话";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(998, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 115;
            this.label3.Text = "种植品种";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 114;
            this.label2.Text = "联系人";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 31);
            this.label10.TabIndex = 111;
            this.label10.Text = "年产量(斤)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(998, 104);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(134, 31);
            this.uiLabel8.TabIndex = 101;
            this.uiLabel8.Text = "主要虫病害";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(671, 104);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(126, 31);
            this.uiLabel4.TabIndex = 101;
            this.uiLabel4.Text = "产值(万元)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(364, 135);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(110, 31);
            this.uiLabel10.TabIndex = 101;
            this.uiLabel10.Text = "发展意愿";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 101;
            this.label8.Text = "销售途径";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1264, 100);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(77, 31);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1264, 67);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(77, 31);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(207, 194);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(87, 48);
            this.btDelete.TabIndex = 102;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(393, 194);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(87, 48);
            this.btExport.TabIndex = 99;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(21, 194);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 48);
            this.btAdd.TabIndex = 100;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgPlantList
            // 
            this.dgPlantList.AllowUserToAddRows = false;
            this.dgPlantList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPlantList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPlantList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPlantList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlantList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPlantList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPlantList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPlantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPlantList.EnableHeadersVisualStyles = false;
            this.dgPlantList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgPlantList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgPlantList.Location = new System.Drawing.Point(4, 32);
            this.dgPlantList.Name = "dgPlantList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlantList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPlantList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgPlantList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPlantList.RowTemplate.Height = 23;
            this.dgPlantList.ScrollBarHandleWidth = 40;
            this.dgPlantList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgPlantList.SelectedIndex = -1;
            this.dgPlantList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlantList.Size = new System.Drawing.Size(1875, 737);
            this.dgPlantList.TabIndex = 7;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgPlantList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(24, 249);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1883, 773);
            this.gbResult.TabIndex = 97;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(114, 194);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(87, 48);
            this.btEdit.TabIndex = 101;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbPlant_area_from
            // 
            this.tbPlant_area_from.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_area_from.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_area_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_area_from.Location = new System.Drawing.Point(798, 73);
            this.tbPlant_area_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_area_from.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_area_from.Name = "tbPlant_area_from";
            this.tbPlant_area_from.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_area_from.ShowText = false;
            this.tbPlant_area_from.Size = new System.Drawing.Size(62, 29);
            this.tbPlant_area_from.TabIndex = 131;
            this.tbPlant_area_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_area_from.Watermark = "";
            // 
            // tbPlant_area_to
            // 
            this.tbPlant_area_to.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_area_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_area_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_area_to.Location = new System.Drawing.Point(901, 73);
            this.tbPlant_area_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_area_to.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_area_to.Name = "tbPlant_area_to";
            this.tbPlant_area_to.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_area_to.ShowText = false;
            this.tbPlant_area_to.Size = new System.Drawing.Size(62, 29);
            this.tbPlant_area_to.TabIndex = 131;
            this.tbPlant_area_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_area_to.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(867, 73);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(24, 31);
            this.uiLabel11.TabIndex = 174;
            this.uiLabel11.Text = "-";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOutput_from
            // 
            this.tbOutput_from.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput_from.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput_from.Location = new System.Drawing.Point(798, 104);
            this.tbOutput_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput_from.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput_from.Name = "tbOutput_from";
            this.tbOutput_from.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput_from.ShowText = false;
            this.tbOutput_from.Size = new System.Drawing.Size(62, 29);
            this.tbOutput_from.TabIndex = 131;
            this.tbOutput_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput_from.Watermark = "";
            // 
            // tbOutput_to
            // 
            this.tbOutput_to.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput_to.Location = new System.Drawing.Point(901, 104);
            this.tbOutput_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput_to.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput_to.Name = "tbOutput_to";
            this.tbOutput_to.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput_to.ShowText = false;
            this.tbOutput_to.Size = new System.Drawing.Size(62, 29);
            this.tbOutput_to.TabIndex = 131;
            this.tbOutput_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput_to.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(867, 104);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(24, 31);
            this.uiLabel12.TabIndex = 174;
            this.uiLabel12.Text = "-";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPlantList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btEdit);
            this.Name = "frmPlantList";
            this.Text = "frmPlantList";
            this.Load += new System.EventHandler(this.frmPlantList_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlantList)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbYear_yield_to;
        private Sunny.UI.UITextBox tbYear_yield_from;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbAddress;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbContact_person;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIDataGridView dgPlantList;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIComboBox cbInsect_ill;
        private Sunny.UI.UIComboBox cbDevelop_willing;
        private Sunny.UI.UIComboBox cbIs_plan;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboTreeView ctvManage_skill_method;
        private Sunny.UI.UIComboTreeView ctvSale_way;
        private Sunny.UI.UIComboTreeView ctvPlant_type;
        private Sunny.UI.UITextBox tbPlant_brand;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox tbOutput_to;
        private Sunny.UI.UITextBox tbPlant_area_to;
        private Sunny.UI.UITextBox tbOutput_from;
        private Sunny.UI.UITextBox tbPlant_area_from;
    }
}