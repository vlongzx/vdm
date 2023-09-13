namespace com.vdm.form
{
    partial class frmHouseList
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
            this.btDelete = new Sunny.UI.UIButton();
            this.dpOh_checktime_To = new Sunny.UI.UIDatePicker();
            this.dpOh_checktime_From = new Sunny.UI.UIDatePicker();
            this.dpHouse_build_date_To = new Sunny.UI.UIDatePicker();
            this.dpHouse_build_date_From = new Sunny.UI.UIDatePicker();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.pagination = new Sunny.UI.UIPagination();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.cbHouse_is_rent = new Sunny.UI.UIComboBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.tbArea_To = new Sunny.UI.UITextBox();
            this.tbArea_From = new Sunny.UI.UITextBox();
            this.cbIs_old_house = new Sunny.UI.UIComboBox();
            this.cbHouse_safe_grade = new Sunny.UI.UIComboBox();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.tbHouse_location = new Sunny.UI.UITextBox();
            this.tbHouse_owner = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.uiLabel27 = new Sunny.UI.UILabel();
            this.土地使用说明 = new Sunny.UI.UILabel();
            this.uiLabel32 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbHouse_type = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.cbIs_my_struct = new Sunny.UI.UIComboBox();
            this.cbHouse_struction = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btImport = new Sunny.UI.UIButton();
            this.dgHouseList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseList)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(351, 322);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(154, 62);
            this.btDelete.TabIndex = 110;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dpOh_checktime_To
            // 
            this.dpOh_checktime_To.CanEmpty = true;
            this.dpOh_checktime_To.FillColor = System.Drawing.Color.White;
            this.dpOh_checktime_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpOh_checktime_To.Location = new System.Drawing.Point(1215, 136);
            this.dpOh_checktime_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpOh_checktime_To.MaxLength = 10;
            this.dpOh_checktime_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpOh_checktime_To.Name = "dpOh_checktime_To";
            this.dpOh_checktime_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpOh_checktime_To.Size = new System.Drawing.Size(126, 29);
            this.dpOh_checktime_To.SymbolDropDown = 61555;
            this.dpOh_checktime_To.SymbolNormal = 61555;
            this.dpOh_checktime_To.TabIndex = 255;
            this.dpOh_checktime_To.Text = "2023-08-25";
            this.dpOh_checktime_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpOh_checktime_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpOh_checktime_To.Watermark = "";
            // 
            // dpOh_checktime_From
            // 
            this.dpOh_checktime_From.CanEmpty = true;
            this.dpOh_checktime_From.FillColor = System.Drawing.Color.White;
            this.dpOh_checktime_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpOh_checktime_From.Location = new System.Drawing.Point(1078, 140);
            this.dpOh_checktime_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpOh_checktime_From.MaxLength = 10;
            this.dpOh_checktime_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpOh_checktime_From.Name = "dpOh_checktime_From";
            this.dpOh_checktime_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpOh_checktime_From.Size = new System.Drawing.Size(118, 29);
            this.dpOh_checktime_From.SymbolDropDown = 61555;
            this.dpOh_checktime_From.SymbolNormal = 61555;
            this.dpOh_checktime_From.TabIndex = 254;
            this.dpOh_checktime_From.Text = "1900-01-01";
            this.dpOh_checktime_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpOh_checktime_From.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpOh_checktime_From.Watermark = "";
            // 
            // dpHouse_build_date_To
            // 
            this.dpHouse_build_date_To.CanEmpty = true;
            this.dpHouse_build_date_To.FillColor = System.Drawing.Color.White;
            this.dpHouse_build_date_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpHouse_build_date_To.Location = new System.Drawing.Point(1215, 95);
            this.dpHouse_build_date_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpHouse_build_date_To.MaxLength = 10;
            this.dpHouse_build_date_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpHouse_build_date_To.Name = "dpHouse_build_date_To";
            this.dpHouse_build_date_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpHouse_build_date_To.Size = new System.Drawing.Size(126, 29);
            this.dpHouse_build_date_To.SymbolDropDown = 61555;
            this.dpHouse_build_date_To.SymbolNormal = 61555;
            this.dpHouse_build_date_To.TabIndex = 255;
            this.dpHouse_build_date_To.Text = "2023-08-25";
            this.dpHouse_build_date_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpHouse_build_date_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpHouse_build_date_To.Watermark = "";
            // 
            // dpHouse_build_date_From
            // 
            this.dpHouse_build_date_From.CanEmpty = true;
            this.dpHouse_build_date_From.FillColor = System.Drawing.Color.White;
            this.dpHouse_build_date_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpHouse_build_date_From.Location = new System.Drawing.Point(1077, 95);
            this.dpHouse_build_date_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpHouse_build_date_From.MaxLength = 10;
            this.dpHouse_build_date_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpHouse_build_date_From.Name = "dpHouse_build_date_From";
            this.dpHouse_build_date_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpHouse_build_date_From.Size = new System.Drawing.Size(119, 29);
            this.dpHouse_build_date_From.SymbolDropDown = 61555;
            this.dpHouse_build_date_From.SymbolNormal = 61555;
            this.dpHouse_build_date_From.TabIndex = 254;
            this.dpHouse_build_date_From.Text = "1900-01-01";
            this.dpHouse_build_date_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpHouse_build_date_From.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpHouse_build_date_From.Watermark = "";
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(1196, 134);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(24, 31);
            this.uiLabel13.TabIndex = 252;
            this.uiLabel13.Text = "-";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel17
            // 
            this.uiLabel17.AutoSize = true;
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel17.Location = new System.Drawing.Point(1196, 87);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(24, 31);
            this.uiLabel17.TabIndex = 248;
            this.uiLabel17.Text = "-";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagination
            // 
            this.pagination.ActivePage = 20;
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(26, 1036);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 11;
            this.pagination.PageSize = 50;
            this.pagination.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.ShowText = false;
            this.pagination.Size = new System.Drawing.Size(2229, 35);
            this.pagination.TabIndex = 111;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.cbHouse_is_rent);
            this.gbSearch.Controls.Add(this.uiLabel15);
            this.gbSearch.Controls.Add(this.tbArea_To);
            this.gbSearch.Controls.Add(this.tbArea_From);
            this.gbSearch.Controls.Add(this.cbIs_old_house);
            this.gbSearch.Controls.Add(this.cbHouse_safe_grade);
            this.gbSearch.Controls.Add(this.dpHouse_build_date_To);
            this.gbSearch.Controls.Add(this.dpHouse_build_date_From);
            this.gbSearch.Controls.Add(this.uiLabel17);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.tbHouse_location);
            this.gbSearch.Controls.Add(this.tbHouse_owner);
            this.gbSearch.Controls.Add(this.dpOh_checktime_To);
            this.gbSearch.Controls.Add(this.dpOh_checktime_From);
            this.gbSearch.Controls.Add(this.uiLabel13);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.uiLabel27);
            this.gbSearch.Controls.Add(this.土地使用说明);
            this.gbSearch.Controls.Add(this.uiLabel32);
            this.gbSearch.Controls.Add(this.uiLabel11);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.cbHouse_type);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.cbIs_my_struct);
            this.gbSearch.Controls.Add(this.cbHouse_struction);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel24);
            this.gbSearch.Controls.Add(this.uiLabel10);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(29, 45);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1814, 247);
            this.gbSearch.TabIndex = 112;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHouse_is_rent
            // 
            this.cbHouse_is_rent.DataSource = null;
            this.cbHouse_is_rent.FillColor = System.Drawing.Color.White;
            this.cbHouse_is_rent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHouse_is_rent.Location = new System.Drawing.Point(174, 140);
            this.cbHouse_is_rent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHouse_is_rent.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbHouse_is_rent.Name = "cbHouse_is_rent";
            this.cbHouse_is_rent.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbHouse_is_rent.Size = new System.Drawing.Size(174, 29);
            this.cbHouse_is_rent.TabIndex = 153;
            this.cbHouse_is_rent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbHouse_is_rent.Watermark = "";
            // 
            // uiLabel15
            // 
            this.uiLabel15.AutoSize = true;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(860, 45);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(24, 31);
            this.uiLabel15.TabIndex = 252;
            this.uiLabel15.Text = "-";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbArea_To
            // 
            this.tbArea_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbArea_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArea_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbArea_To.Location = new System.Drawing.Point(892, 47);
            this.tbArea_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbArea_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbArea_To.Name = "tbArea_To";
            this.tbArea_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbArea_To.ShowText = false;
            this.tbArea_To.Size = new System.Drawing.Size(62, 29);
            this.tbArea_To.TabIndex = 225;
            this.tbArea_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbArea_To.Watermark = "";
            // 
            // tbArea_From
            // 
            this.tbArea_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbArea_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbArea_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbArea_From.Location = new System.Drawing.Point(793, 47);
            this.tbArea_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbArea_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbArea_From.Name = "tbArea_From";
            this.tbArea_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbArea_From.ShowText = false;
            this.tbArea_From.Size = new System.Drawing.Size(62, 29);
            this.tbArea_From.TabIndex = 219;
            this.tbArea_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbArea_From.Watermark = "";
            // 
            // cbIs_old_house
            // 
            this.cbIs_old_house.DataSource = null;
            this.cbIs_old_house.FillColor = System.Drawing.Color.White;
            this.cbIs_old_house.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_old_house.Location = new System.Drawing.Point(793, 146);
            this.cbIs_old_house.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_old_house.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_old_house.Name = "cbIs_old_house";
            this.cbIs_old_house.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_old_house.Size = new System.Drawing.Size(161, 29);
            this.cbIs_old_house.TabIndex = 153;
            this.cbIs_old_house.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_old_house.Watermark = "";
            // 
            // cbHouse_safe_grade
            // 
            this.cbHouse_safe_grade.DataSource = null;
            this.cbHouse_safe_grade.FillColor = System.Drawing.Color.White;
            this.cbHouse_safe_grade.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHouse_safe_grade.Location = new System.Drawing.Point(793, 93);
            this.cbHouse_safe_grade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHouse_safe_grade.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbHouse_safe_grade.Name = "cbHouse_safe_grade";
            this.cbHouse_safe_grade.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbHouse_safe_grade.Size = new System.Drawing.Size(161, 29);
            this.cbHouse_safe_grade.TabIndex = 153;
            this.cbHouse_safe_grade.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbHouse_safe_grade.Watermark = "";
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(174, 191);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(174, 29);
            this.cbTown.TabIndex = 152;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // tbHouse_location
            // 
            this.tbHouse_location.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbHouse_location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHouse_location.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHouse_location.Location = new System.Drawing.Point(174, 95);
            this.tbHouse_location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHouse_location.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbHouse_location.Name = "tbHouse_location";
            this.tbHouse_location.Padding = new System.Windows.Forms.Padding(5);
            this.tbHouse_location.ShowText = false;
            this.tbHouse_location.Size = new System.Drawing.Size(178, 29);
            this.tbHouse_location.TabIndex = 131;
            this.tbHouse_location.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbHouse_location.Watermark = "";
            // 
            // tbHouse_owner
            // 
            this.tbHouse_owner.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbHouse_owner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHouse_owner.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHouse_owner.Location = new System.Drawing.Point(174, 53);
            this.tbHouse_owner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHouse_owner.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbHouse_owner.Name = "tbHouse_owner";
            this.tbHouse_owner.Padding = new System.Windows.Forms.Padding(5);
            this.tbHouse_owner.ShowText = false;
            this.tbHouse_owner.Size = new System.Drawing.Size(178, 29);
            this.tbHouse_owner.TabIndex = 130;
            this.tbHouse_owner.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbHouse_owner.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(482, 47);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(167, 29);
            this.tbIdcard.TabIndex = 229;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // uiLabel27
            // 
            this.uiLabel27.AutoSize = true;
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel27.Location = new System.Drawing.Point(961, 40);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(110, 31);
            this.uiLabel27.TabIndex = 235;
            this.uiLabel27.Text = "房屋类别";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 土地使用说明
            // 
            this.土地使用说明.AutoSize = true;
            this.土地使用说明.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.土地使用说明.Location = new System.Drawing.Point(657, 86);
            this.土地使用说明.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.土地使用说明.Name = "土地使用说明";
            this.土地使用说明.Size = new System.Drawing.Size(158, 31);
            this.土地使用说明.TabIndex = 210;
            this.土地使用说明.Text = "房屋安全等级";
            this.土地使用说明.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel32
            // 
            this.uiLabel32.AutoSize = true;
            this.uiLabel32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel32.Location = new System.Drawing.Point(961, 135);
            this.uiLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel32.Name = "uiLabel32";
            this.uiLabel32.Size = new System.Drawing.Size(158, 31);
            this.uiLabel32.TabIndex = 207;
            this.uiLabel32.Text = "古宅审批时间";
            this.uiLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(657, 138);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(110, 31);
            this.uiLabel11.TabIndex = 154;
            this.uiLabel11.Text = "是否古宅";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(33, 131);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(158, 31);
            this.uiLabel3.TabIndex = 154;
            this.uiLabel3.Text = "房屋是否租赁";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(33, 179);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(110, 31);
            this.uiLabel26.TabIndex = 155;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHouse_type
            // 
            this.cbHouse_type.DataSource = null;
            this.cbHouse_type.FillColor = System.Drawing.Color.White;
            this.cbHouse_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHouse_type.Location = new System.Drawing.Point(1078, 40);
            this.cbHouse_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHouse_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbHouse_type.Name = "cbHouse_type";
            this.cbHouse_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbHouse_type.Size = new System.Drawing.Size(263, 29);
            this.cbHouse_type.TabIndex = 153;
            this.cbHouse_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbHouse_type.Watermark = "";
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(482, 188);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(167, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // cbIs_my_struct
            // 
            this.cbIs_my_struct.DataSource = null;
            this.cbIs_my_struct.FillColor = System.Drawing.Color.White;
            this.cbIs_my_struct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_my_struct.Location = new System.Drawing.Point(482, 145);
            this.cbIs_my_struct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_my_struct.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_my_struct.Name = "cbIs_my_struct";
            this.cbIs_my_struct.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_my_struct.Size = new System.Drawing.Size(167, 29);
            this.cbIs_my_struct.TabIndex = 153;
            this.cbIs_my_struct.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_my_struct.Watermark = "";
            // 
            // cbHouse_struction
            // 
            this.cbHouse_struction.DataSource = null;
            this.cbHouse_struction.FillColor = System.Drawing.Color.White;
            this.cbHouse_struction.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbHouse_struction.Location = new System.Drawing.Point(482, 94);
            this.cbHouse_struction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHouse_struction.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbHouse_struction.Name = "cbHouse_struction";
            this.cbHouse_struction.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbHouse_struction.Size = new System.Drawing.Size(167, 29);
            this.cbHouse_struction.TabIndex = 153;
            this.cbHouse_struction.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbHouse_struction.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(33, 44);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(134, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "房屋所有人";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(657, 40);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(198, 31);
            this.uiLabel6.TabIndex = 113;
            this.uiLabel6.Text = "房屋面积(平方米)";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 31);
            this.label12.TabIndex = 102;
            this.label12.Text = "房屋具体位置";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1467, 81);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(104, 62);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1348, 81);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(113, 62);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(961, 88);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 200;
            this.uiLabel1.Text = "房屋建设时间";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(360, 86);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(110, 31);
            this.uiLabel24.TabIndex = 241;
            this.uiLabel24.Text = "房屋结构";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(360, 136);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(158, 31);
            this.uiLabel10.TabIndex = 200;
            this.uiLabel10.Text = "房屋是否自建";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(360, 187);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(86, 31);
            this.uiLabel25.TabIndex = 154;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(360, 40);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 108;
            this.uiLabel5.Text = "身份证号";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(511, 322);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(154, 62);
            this.btImport.TabIndex = 106;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgHouseList
            // 
            this.dgHouseList.AllowUserToAddRows = false;
            this.dgHouseList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgHouseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHouseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgHouseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgHouseList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgHouseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgHouseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHouseList.EnableHeadersVisualStyles = false;
            this.dgHouseList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgHouseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgHouseList.Location = new System.Drawing.Point(4, 32);
            this.dgHouseList.Name = "dgHouseList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHouseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgHouseList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgHouseList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgHouseList.RowTemplate.Height = 23;
            this.dgHouseList.ScrollBarHandleWidth = 40;
            this.dgHouseList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgHouseList.SelectedIndex = -1;
            this.dgHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHouseList.Size = new System.Drawing.Size(1801, 600);
            this.dgHouseList.TabIndex = 8;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(671, 322);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 62);
            this.btExport.TabIndex = 107;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgHouseList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(34, 391);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1809, 636);
            this.gbResult.TabIndex = 105;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(31, 322);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 62);
            this.btAdd.TabIndex = 108;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(191, 322);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(154, 62);
            this.btEdit.TabIndex = 109;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // frmHouseList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Name = "frmHouseList";
            this.Text = "frmHouseList";
            this.Load += new System.EventHandler(this.frmHouseList_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHouseList)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIDatePicker dpOh_checktime_To;
        private Sunny.UI.UIDatePicker dpOh_checktime_From;
        private Sunny.UI.UIDatePicker dpHouse_build_date_To;
        private Sunny.UI.UIDatePicker dpHouse_build_date_From;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel27;
        private Sunny.UI.UILabel 土地使用说明;
        private Sunny.UI.UILabel uiLabel32;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbIs_old_house;
        private Sunny.UI.UIComboBox cbHouse_is_rent;
        private Sunny.UI.UIComboBox cbHouse_struction;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbHouse_location;
        private Sunny.UI.UITextBox tbHouse_owner;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIDataGridView dgHouseList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UITextBox tbArea_To;
        private Sunny.UI.UITextBox tbArea_From;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UIComboBox cbHouse_safe_grade;
        private Sunny.UI.UIComboBox cbHouse_type;
        private Sunny.UI.UIComboBox cbIs_my_struct;
        private Sunny.UI.UIComboBox cbVillage;
    }
}