namespace com.vdm.form
{
    partial class frmManagerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dpBirthday_To = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time_to = new Sunny.UI.UIDatePicker();
            this.dpBirthday_From = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time_from = new Sunny.UI.UIDatePicker();
            this.cbPolitcal_outlook = new Sunny.UI.UIComboBox();
            this.cbEducation = new Sunny.UI.UIComboBox();
            this.cbSex = new Sunny.UI.UIComboBox();
            this.cbNation = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbManager_name = new Sunny.UI.UITextBox();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.label13 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.btImport = new Sunny.UI.UIButton();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.dgManagerList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.dpEmploy_date_To = new Sunny.UI.UIDatePicker();
            this.dpEmploy_date_From = new Sunny.UI.UIDatePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tbPost = new Sunny.UI.UITextBox();
            this.label2 = new Sunny.UI.UILabel();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgManagerList)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(988, 74);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(110, 31);
            this.uiLabel24.TabIndex = 165;
            this.uiLabel24.Text = "最高学历";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(988, 40);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(62, 31);
            this.uiLabel23.TabIndex = 163;
            this.uiLabel23.Text = "性别";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(36, 141);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(86, 31);
            this.uiLabel25.TabIndex = 154;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(988, 108);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(110, 31);
            this.uiLabel26.TabIndex = 155;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(1067, 108);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(147, 29);
            this.cbTown.TabIndex = 152;
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
            this.cbVillage.Location = new System.Drawing.Point(108, 141);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(165, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(323, 42);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(110, 31);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "出生日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(36, 42);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(62, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpBirthday_To
            // 
            this.dpBirthday_To.FillColor = System.Drawing.Color.White;
            this.dpBirthday_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_To.Location = new System.Drawing.Point(539, 42);
            this.dpBirthday_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_To.MaxLength = 10;
            this.dpBirthday_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_To.Name = "dpBirthday_To";
            this.dpBirthday_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_To.Size = new System.Drawing.Size(116, 29);
            this.dpBirthday_To.SymbolDropDown = 61555;
            this.dpBirthday_To.SymbolNormal = 61555;
            this.dpBirthday_To.TabIndex = 144;
            this.dpBirthday_To.Text = "2023-08-25";
            this.dpBirthday_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpBirthday_To.Watermark = "";
            // 
            // dpJoin_party_time_to
            // 
            this.dpJoin_party_time_to.FillColor = System.Drawing.Color.White;
            this.dpJoin_party_time_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpJoin_party_time_to.Location = new System.Drawing.Point(539, 75);
            this.dpJoin_party_time_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_to.MaxLength = 10;
            this.dpJoin_party_time_to.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_to.Name = "dpJoin_party_time_to";
            this.dpJoin_party_time_to.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_to.Size = new System.Drawing.Size(116, 29);
            this.dpJoin_party_time_to.SymbolDropDown = 61555;
            this.dpJoin_party_time_to.SymbolNormal = 61555;
            this.dpJoin_party_time_to.TabIndex = 143;
            this.dpJoin_party_time_to.Text = "2023-08-25";
            this.dpJoin_party_time_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_to.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_to.Watermark = "";
            // 
            // dpBirthday_From
            // 
            this.dpBirthday_From.FillColor = System.Drawing.Color.White;
            this.dpBirthday_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_From.Location = new System.Drawing.Point(398, 42);
            this.dpBirthday_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_From.MaxLength = 10;
            this.dpBirthday_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_From.Name = "dpBirthday_From";
            this.dpBirthday_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_From.Size = new System.Drawing.Size(119, 29);
            this.dpBirthday_From.SymbolDropDown = 61555;
            this.dpBirthday_From.SymbolNormal = 61555;
            this.dpBirthday_From.TabIndex = 142;
            this.dpBirthday_From.Text = "2023-01-01";
            this.dpBirthday_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday_From.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dpBirthday_From.Watermark = "";
            // 
            // dpJoin_party_time_from
            // 
            this.dpJoin_party_time_from.CanEmpty = true;
            this.dpJoin_party_time_from.FillColor = System.Drawing.Color.White;
            this.dpJoin_party_time_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpJoin_party_time_from.Location = new System.Drawing.Point(398, 75);
            this.dpJoin_party_time_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_from.MaxLength = 10;
            this.dpJoin_party_time_from.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_from.Name = "dpJoin_party_time_from";
            this.dpJoin_party_time_from.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_from.Size = new System.Drawing.Size(119, 29);
            this.dpJoin_party_time_from.SymbolDropDown = 61555;
            this.dpJoin_party_time_from.SymbolNormal = 61555;
            this.dpJoin_party_time_from.TabIndex = 141;
            this.dpJoin_party_time_from.Text = "2023-08-25";
            this.dpJoin_party_time_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_from.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_from.Watermark = "";
            // 
            // cbPolitcal_outlook
            // 
            this.cbPolitcal_outlook.DataSource = null;
            this.cbPolitcal_outlook.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPolitcal_outlook.FillColor = System.Drawing.Color.White;
            this.cbPolitcal_outlook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPolitcal_outlook.Location = new System.Drawing.Point(108, 75);
            this.cbPolitcal_outlook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPolitcal_outlook.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPolitcal_outlook.Name = "cbPolitcal_outlook";
            this.cbPolitcal_outlook.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPolitcal_outlook.Size = new System.Drawing.Size(165, 29);
            this.cbPolitcal_outlook.TabIndex = 138;
            this.cbPolitcal_outlook.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPolitcal_outlook.Watermark = "";
            // 
            // cbEducation
            // 
            this.cbEducation.DataSource = null;
            this.cbEducation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbEducation.FillColor = System.Drawing.Color.White;
            this.cbEducation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbEducation.Location = new System.Drawing.Point(1067, 74);
            this.cbEducation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEducation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbEducation.Size = new System.Drawing.Size(147, 29);
            this.cbEducation.TabIndex = 137;
            this.cbEducation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEducation.Watermark = "";
            // 
            // cbSex
            // 
            this.cbSex.DataSource = null;
            this.cbSex.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbSex.FillColor = System.Drawing.Color.White;
            this.cbSex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSex.Location = new System.Drawing.Point(1067, 40);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSex.Size = new System.Drawing.Size(147, 29);
            this.cbSex.TabIndex = 136;
            this.cbSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSex.Watermark = "";
            // 
            // cbNation
            // 
            this.cbNation.DataSource = null;
            this.cbNation.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbNation.FillColor = System.Drawing.Color.White;
            this.cbNation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbNation.Location = new System.Drawing.Point(783, 42);
            this.cbNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNation.Name = "cbNation";
            this.cbNation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNation.Size = new System.Drawing.Size(165, 29);
            this.cbNation.TabIndex = 135;
            this.cbNation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNation.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(108, 108);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 132;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(783, 75);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(165, 29);
            this.tbIdcard.TabIndex = 131;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // tbManager_name
            // 
            this.tbManager_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbManager_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbManager_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbManager_name.Location = new System.Drawing.Point(108, 42);
            this.tbManager_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbManager_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbManager_name.Name = "tbManager_name";
            this.tbManager_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbManager_name.ShowText = false;
            this.tbManager_name.Size = new System.Drawing.Size(165, 29);
            this.tbManager_name.TabIndex = 130;
            this.tbManager_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbManager_name.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 116;
            this.label9.Text = "政治面貌";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 115;
            this.label3.Text = "民族";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 111;
            this.label10.Text = "入党时间";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 31);
            this.label13.TabIndex = 104;
            this.label13.Text = "联系电话";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(710, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 31);
            this.label12.TabIndex = 102;
            this.label12.Text = "身份证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1221, 90);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 38);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1221, 48);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 38);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(314, 230);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(91, 47);
            this.btImport.TabIndex = 82;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgManagerList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(26, 284);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1881, 744);
            this.gbResult.TabIndex = 81;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgManagerList
            // 
            this.dgManagerList.AllowUserToAddRows = false;
            this.dgManagerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgManagerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgManagerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgManagerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManagerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgManagerList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgManagerList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgManagerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgManagerList.EnableHeadersVisualStyles = false;
            this.dgManagerList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgManagerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgManagerList.Location = new System.Drawing.Point(4, 32);
            this.dgManagerList.Name = "dgManagerList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgManagerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgManagerList.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgManagerList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgManagerList.RowTemplate.Height = 23;
            this.dgManagerList.ScrollBarHandleWidth = 40;
            this.dgManagerList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgManagerList.SelectedIndex = -1;
            this.dgManagerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgManagerList.Size = new System.Drawing.Size(1873, 708);
            this.dgManagerList.TabIndex = 7;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(411, 230);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(91, 47);
            this.btExport.TabIndex = 83;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(23, 230);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 47);
            this.btAdd.TabIndex = 84;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(120, 230);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(91, 47);
            this.btEdit.TabIndex = 85;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(217, 230);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(91, 47);
            this.btDelete.TabIndex = 86;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // pagination
            // 
            this.pagination.ActivePage = 20;
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(18, 1028);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 11;
            this.pagination.PageSize = 50;
            this.pagination.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.ShowText = false;
            this.pagination.Size = new System.Drawing.Size(2229, 35);
            this.pagination.TabIndex = 87;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbEducation);
            this.gbSearch.Controls.Add(this.dpBirthday_From);
            this.gbSearch.Controls.Add(this.dpJoin_party_time_from);
            this.gbSearch.Controls.Add(this.dpEmploy_date_To);
            this.gbSearch.Controls.Add(this.dpBirthday_To);
            this.gbSearch.Controls.Add(this.dpJoin_party_time_to);
            this.gbSearch.Controls.Add(this.dpEmploy_date_From);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.tbManager_name);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.uiLabel24);
            this.gbSearch.Controls.Add(this.uiLabel23);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.cbPolitcal_outlook);
            this.gbSearch.Controls.Add(this.cbSex);
            this.gbSearch.Controls.Add(this.cbNation);
            this.gbSearch.Controls.Add(this.tbPhone_number);
            this.gbSearch.Controls.Add(this.tbPost);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.label13);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(21, 37);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1877, 185);
            this.gbSearch.TabIndex = 88;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpEmploy_date_To
            // 
            this.dpEmploy_date_To.FillColor = System.Drawing.Color.White;
            this.dpEmploy_date_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEmploy_date_To.Location = new System.Drawing.Point(539, 108);
            this.dpEmploy_date_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEmploy_date_To.MaxLength = 10;
            this.dpEmploy_date_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEmploy_date_To.Name = "dpEmploy_date_To";
            this.dpEmploy_date_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEmploy_date_To.Size = new System.Drawing.Size(116, 29);
            this.dpEmploy_date_To.SymbolDropDown = 61555;
            this.dpEmploy_date_To.SymbolNormal = 61555;
            this.dpEmploy_date_To.TabIndex = 144;
            this.dpEmploy_date_To.Text = "2023-08-25";
            this.dpEmploy_date_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEmploy_date_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpEmploy_date_To.Watermark = "";
            // 
            // dpEmploy_date_From
            // 
            this.dpEmploy_date_From.FillColor = System.Drawing.Color.White;
            this.dpEmploy_date_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEmploy_date_From.Location = new System.Drawing.Point(398, 108);
            this.dpEmploy_date_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEmploy_date_From.MaxLength = 10;
            this.dpEmploy_date_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEmploy_date_From.Name = "dpEmploy_date_From";
            this.dpEmploy_date_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEmploy_date_From.Size = new System.Drawing.Size(119, 29);
            this.dpEmploy_date_From.SymbolDropDown = 61555;
            this.dpEmploy_date_From.SymbolNormal = 61555;
            this.dpEmploy_date_From.TabIndex = 142;
            this.dpEmploy_date_From.Text = "2023-01-01";
            this.dpEmploy_date_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEmploy_date_From.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dpEmploy_date_From.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(324, 108);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 166;
            this.uiLabel5.Text = "任职时间";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(520, 75);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(24, 31);
            this.uiLabel3.TabIndex = 147;
            this.uiLabel3.Text = "-";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(520, 42);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(24, 31);
            this.uiLabel4.TabIndex = 147;
            this.uiLabel4.Text = "-";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(520, 108);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(24, 31);
            this.uiLabel6.TabIndex = 147;
            this.uiLabel6.Text = "-";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPost
            // 
            this.tbPost.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPost.Location = new System.Drawing.Point(783, 108);
            this.tbPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPost.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPost.Name = "tbPost";
            this.tbPost.Padding = new System.Windows.Forms.Padding(5);
            this.tbPost.ShowText = false;
            this.tbPost.Size = new System.Drawing.Size(165, 29);
            this.tbPost.TabIndex = 131;
            this.tbPost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPost.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 114;
            this.label2.Text = "职务";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmManagerList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmManagerList";
            this.Text = "frmManagerList";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgManagerList)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker dpBirthday_To;
        private Sunny.UI.UIDatePicker dpJoin_party_time_to;
        private Sunny.UI.UIDatePicker dpBirthday_From;
        private Sunny.UI.UIDatePicker dpJoin_party_time_from;
        private Sunny.UI.UIComboBox cbPolitcal_outlook;
        private Sunny.UI.UIComboBox cbEducation;
        private Sunny.UI.UIComboBox cbSex;
        private Sunny.UI.UIComboBox cbNation;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbManager_name;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIDataGridView dgManagerList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UITextBox tbPost;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDatePicker dpEmploy_date_To;
        private Sunny.UI.UIDatePicker dpEmploy_date_From;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
    }
}