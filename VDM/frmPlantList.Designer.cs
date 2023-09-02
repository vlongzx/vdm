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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbPlant_type = new Sunny.UI.UIComboBox();
            this.tbAddress = new Sunny.UI.UITextBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbContact_person = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.dgPlantList = new Sunny.UI.UIDataGridView();
            this.groupBox2 = new Sunny.UI.UIGroupBox();
            this.btEdit = new Sunny.UI.UIButton();
            this.cbIs_plan = new Sunny.UI.UIComboBox();
            this.tbPlant_area = new Sunny.UI.UITextBox();
            this.cbPlant_brand = new Sunny.UI.UIComboBox();
            this.cbSale_way = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.cbOutput = new Sunny.UI.UIComboBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.cbInsect_ill = new Sunny.UI.UIComboBox();
            this.cbManage_skill_method = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.cbDevelop_willing = new Sunny.UI.UIComboBox();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlantList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagination
            // 
            this.pagination.ActivePage = 20;
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(16, 998);
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
            this.uiLabel5.Location = new System.Drawing.Point(266, 133);
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
            this.tbYear_yield_to.Location = new System.Drawing.Point(300, 135);
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
            this.tbYear_yield_from.Location = new System.Drawing.Point(197, 135);
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
            this.uiLabel6.Location = new System.Drawing.Point(1137, 188);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 173;
            this.uiLabel6.Text = "所属村";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(932, 190);
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
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(1281, 190);
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
            this.uiLabel7.Location = new System.Drawing.Point(779, 190);
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
            this.uiLabel23.Location = new System.Drawing.Point(36, 88);
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
            this.uiLabel3.Location = new System.Drawing.Point(779, 88);
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
            this.btImport.Location = new System.Drawing.Point(501, 269);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(154, 62);
            this.btImport.TabIndex = 98;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.tbYear_yield_to);
            this.uiGroupBox1.Controls.Add(this.tbYear_yield_from);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.cbTown);
            this.uiGroupBox1.Controls.Add(this.cbPlant_brand);
            this.uiGroupBox1.Controls.Add(this.cbVillage);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.uiLabel23);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.cbInsect_ill);
            this.uiGroupBox1.Controls.Add(this.cbOutput);
            this.uiGroupBox1.Controls.Add(this.cbDevelop_willing);
            this.uiGroupBox1.Controls.Add(this.cbSale_way);
            this.uiGroupBox1.Controls.Add(this.cbManage_skill_method);
            this.uiGroupBox1.Controls.Add(this.cbIs_plan);
            this.uiGroupBox1.Controls.Add(this.cbPlant_type);
            this.uiGroupBox1.Controls.Add(this.tbAddress);
            this.uiGroupBox1.Controls.Add(this.tbPhone_number);
            this.uiGroupBox1.Controls.Add(this.tbPlant_area);
            this.uiGroupBox1.Controls.Add(this.tbIdcard);
            this.uiGroupBox1.Controls.Add(this.tbContact_person);
            this.uiGroupBox1.Controls.Add(this.uiLabel14);
            this.uiGroupBox1.Controls.Add(this.label9);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label10);
            this.uiGroupBox1.Controls.Add(this.uiLabel8);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.label8);
            this.uiGroupBox1.Controls.Add(this.btReset);
            this.uiGroupBox1.Controls.Add(this.btSearch);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(19, 7);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(2063, 236);
            this.uiGroupBox1.TabIndex = 104;
            this.uiGroupBox1.Text = "查询条件";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(400, 88);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "是否符合规划";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cbPlant_type
            // 
            this.cbPlant_type.DataSource = null;
            this.cbPlant_type.FillColor = System.Drawing.Color.White;
            this.cbPlant_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPlant_type.Location = new System.Drawing.Point(197, 44);
            this.cbPlant_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPlant_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPlant_type.Name = "cbPlant_type";
            this.cbPlant_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPlant_type.Size = new System.Drawing.Size(165, 29);
            this.cbPlant_type.TabIndex = 134;
            this.cbPlant_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPlant_type.Watermark = "";
            // 
            // tbAddress
            // 
            this.tbAddress.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(197, 88);
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
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(1281, 44);
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
            this.tbIdcard.Location = new System.Drawing.Point(932, 44);
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
            this.tbContact_person.Location = new System.Drawing.Point(578, 41);
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
            this.uiLabel14.Location = new System.Drawing.Point(779, 41);
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
            this.label9.Location = new System.Drawing.Point(1137, 41);
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
            this.label3.Location = new System.Drawing.Point(1137, 88);
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
            this.label2.Location = new System.Drawing.Point(400, 42);
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
            this.label10.Location = new System.Drawing.Point(36, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 31);
            this.label10.TabIndex = 111;
            this.label10.Text = "年产量(斤)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 134);
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
            this.btReset.Location = new System.Drawing.Point(1714, 88);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(154, 62);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1554, 88);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(154, 62);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(341, 269);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(154, 62);
            this.btDelete.TabIndex = 102;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(661, 269);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 62);
            this.btExport.TabIndex = 99;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(21, 269);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 62);
            this.btAdd.TabIndex = 100;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgPlantList
            // 
            this.dgPlantList.AllowUserToAddRows = false;
            this.dgPlantList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPlantList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dgPlantList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPlantList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlantList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgPlantList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPlantList.DefaultCellStyle = dataGridViewCellStyle43;
            this.dgPlantList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPlantList.EnableHeadersVisualStyles = false;
            this.dgPlantList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgPlantList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgPlantList.Location = new System.Drawing.Point(4, 32);
            this.dgPlantList.Name = "dgPlantList";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPlantList.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgPlantList.RowHeadersVisible = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgPlantList.RowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dgPlantList.RowTemplate.Height = 23;
            this.dgPlantList.ScrollBarHandleWidth = 40;
            this.dgPlantList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgPlantList.SelectedIndex = -1;
            this.dgPlantList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlantList.Size = new System.Drawing.Size(2055, 611);
            this.dgPlantList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgPlantList);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 342);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(2063, 647);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据列表";
            this.groupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(181, 269);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(154, 62);
            this.btEdit.TabIndex = 101;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // cbIs_plan
            // 
            this.cbIs_plan.DataSource = null;
            this.cbIs_plan.FillColor = System.Drawing.Color.White;
            this.cbIs_plan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_plan.Location = new System.Drawing.Point(578, 88);
            this.cbIs_plan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_plan.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_plan.Name = "cbIs_plan";
            this.cbIs_plan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_plan.Size = new System.Drawing.Size(165, 29);
            this.cbIs_plan.TabIndex = 134;
            this.cbIs_plan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_plan.Watermark = "";
            // 
            // tbPlant_area
            // 
            this.tbPlant_area.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPlant_area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlant_area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPlant_area.Location = new System.Drawing.Point(932, 88);
            this.tbPlant_area.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPlant_area.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPlant_area.Name = "tbPlant_area";
            this.tbPlant_area.Padding = new System.Windows.Forms.Padding(5);
            this.tbPlant_area.ShowText = false;
            this.tbPlant_area.Size = new System.Drawing.Size(165, 29);
            this.tbPlant_area.TabIndex = 130;
            this.tbPlant_area.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPlant_area.Watermark = "";
            // 
            // cbPlant_brand
            // 
            this.cbPlant_brand.DataSource = null;
            this.cbPlant_brand.FillColor = System.Drawing.Color.White;
            this.cbPlant_brand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPlant_brand.Location = new System.Drawing.Point(1281, 88);
            this.cbPlant_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPlant_brand.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPlant_brand.Name = "cbPlant_brand";
            this.cbPlant_brand.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPlant_brand.Size = new System.Drawing.Size(165, 29);
            this.cbPlant_brand.TabIndex = 170;
            this.cbPlant_brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPlant_brand.Watermark = "";
            // 
            // cbSale_way
            // 
            this.cbSale_way.DataSource = null;
            this.cbSale_way.FillColor = System.Drawing.Color.White;
            this.cbSale_way.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSale_way.Location = new System.Drawing.Point(578, 135);
            this.cbSale_way.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSale_way.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSale_way.Name = "cbSale_way";
            this.cbSale_way.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSale_way.Size = new System.Drawing.Size(165, 29);
            this.cbSale_way.TabIndex = 134;
            this.cbSale_way.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSale_way.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(779, 133);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(126, 31);
            this.uiLabel4.TabIndex = 101;
            this.uiLabel4.Text = "产值(万元)";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbOutput
            // 
            this.cbOutput.DataSource = null;
            this.cbOutput.FillColor = System.Drawing.Color.White;
            this.cbOutput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbOutput.Location = new System.Drawing.Point(932, 133);
            this.cbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOutput.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbOutput.Size = new System.Drawing.Size(165, 29);
            this.cbOutput.TabIndex = 134;
            this.cbOutput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbOutput.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(1137, 135);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(134, 31);
            this.uiLabel8.TabIndex = 101;
            this.uiLabel8.Text = "主要虫病害";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInsect_ill
            // 
            this.cbInsect_ill.DataSource = null;
            this.cbInsect_ill.FillColor = System.Drawing.Color.White;
            this.cbInsect_ill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbInsect_ill.Location = new System.Drawing.Point(1281, 135);
            this.cbInsect_ill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInsect_ill.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbInsect_ill.Name = "cbInsect_ill";
            this.cbInsect_ill.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbInsect_ill.Size = new System.Drawing.Size(165, 29);
            this.cbInsect_ill.TabIndex = 134;
            this.cbInsect_ill.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbInsect_ill.Watermark = "";
            // 
            // cbManage_skill_method
            // 
            this.cbManage_skill_method.DataSource = null;
            this.cbManage_skill_method.FillColor = System.Drawing.Color.White;
            this.cbManage_skill_method.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbManage_skill_method.Location = new System.Drawing.Point(197, 190);
            this.cbManage_skill_method.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbManage_skill_method.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbManage_skill_method.Name = "cbManage_skill_method";
            this.cbManage_skill_method.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbManage_skill_method.Size = new System.Drawing.Size(165, 29);
            this.cbManage_skill_method.TabIndex = 134;
            this.cbManage_skill_method.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbManage_skill_method.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(36, 188);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(182, 31);
            this.uiLabel9.TabIndex = 145;
            this.uiLabel9.Text = "主要管理和技术";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(400, 188);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(110, 31);
            this.uiLabel10.TabIndex = 101;
            this.uiLabel10.Text = "发展意愿";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDevelop_willing
            // 
            this.cbDevelop_willing.DataSource = null;
            this.cbDevelop_willing.FillColor = System.Drawing.Color.White;
            this.cbDevelop_willing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDevelop_willing.Location = new System.Drawing.Point(578, 189);
            this.cbDevelop_willing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDevelop_willing.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDevelop_willing.Name = "cbDevelop_willing";
            this.cbDevelop_willing.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDevelop_willing.Size = new System.Drawing.Size(165, 29);
            this.cbDevelop_willing.TabIndex = 134;
            this.cbDevelop_willing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDevelop_willing.Watermark = "";
            // 
            // frmPlantList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2100, 1080);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btEdit);
            this.Name = "frmPlantList";
            this.Text = "frmPlantList";
            this.Load += new System.EventHandler(this.frmPlantList_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlantList)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cbPlant_type;
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
        private Sunny.UI.UIGroupBox groupBox2;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIComboBox cbPlant_brand;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIComboBox cbInsect_ill;
        private Sunny.UI.UIComboBox cbOutput;
        private Sunny.UI.UIComboBox cbDevelop_willing;
        private Sunny.UI.UIComboBox cbSale_way;
        private Sunny.UI.UIComboBox cbManage_skill_method;
        private Sunny.UI.UIComboBox cbIs_plan;
        private Sunny.UI.UITextBox tbPlant_area;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel10;
    }
}