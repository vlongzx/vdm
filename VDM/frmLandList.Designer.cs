namespace com.vdm.form
{
    partial class frmLandList
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
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.tbContractor = new Sunny.UI.UITextBox();
            this.ctvMove_type = new Sunny.UI.UIComboTreeView();
            this.ctvLand_type = new Sunny.UI.UIComboTreeView();
            this.ctvLand_grade = new Sunny.UI.UIComboTreeView();
            this.dpMove_date_To = new Sunny.UI.UIDatePicker();
            this.dpMove_date_From = new Sunny.UI.UIDatePicker();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.tbReal_area_To = new Sunny.UI.UITextBox();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.tbReal_area_From = new Sunny.UI.UITextBox();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.tbMove_price_To = new Sunny.UI.UITextBox();
            this.tbMove_area_To = new Sunny.UI.UITextBox();
            this.tbMove_price_From = new Sunny.UI.UITextBox();
            this.tbMove_area_From = new Sunny.UI.UITextBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.uiLabel27 = new Sunny.UI.UILabel();
            this.tbLand_use_remark = new Sunny.UI.UITextBox();
            this.土地使用说明 = new Sunny.UI.UILabel();
            this.uiLabel32 = new Sunny.UI.UILabel();
            this.uiLabel33 = new Sunny.UI.UILabel();
            this.tbContract_time_To = new Sunny.UI.UITextBox();
            this.tbContract_time_From = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.cbIs_basic_farmland = new Sunny.UI.UIComboBox();
            this.tbNorth = new Sunny.UI.UITextBox();
            this.tbWest = new Sunny.UI.UITextBox();
            this.tbSouth = new Sunny.UI.UITextBox();
            this.tbEast = new Sunny.UI.UITextBox();
            this.tbLand_name = new Sunny.UI.UITextBox();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbName = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btImport = new Sunny.UI.UIButton();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.dgLandList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.gbSearch.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(1022, 188);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(86, 31);
            this.uiLabel25.TabIndex = 154;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(817, 188);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(156, 29);
            this.cbTown.TabIndex = 152;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.tbContractor);
            this.gbSearch.Controls.Add(this.ctvMove_type);
            this.gbSearch.Controls.Add(this.ctvLand_type);
            this.gbSearch.Controls.Add(this.ctvLand_grade);
            this.gbSearch.Controls.Add(this.dpMove_date_To);
            this.gbSearch.Controls.Add(this.dpMove_date_From);
            this.gbSearch.Controls.Add(this.uiLabel12);
            this.gbSearch.Controls.Add(this.tbReal_area_To);
            this.gbSearch.Controls.Add(this.uiLabel13);
            this.gbSearch.Controls.Add(this.tbReal_area_From);
            this.gbSearch.Controls.Add(this.uiLabel15);
            this.gbSearch.Controls.Add(this.uiLabel16);
            this.gbSearch.Controls.Add(this.uiLabel17);
            this.gbSearch.Controls.Add(this.tbMove_price_To);
            this.gbSearch.Controls.Add(this.tbMove_area_To);
            this.gbSearch.Controls.Add(this.tbMove_price_From);
            this.gbSearch.Controls.Add(this.tbMove_area_From);
            this.gbSearch.Controls.Add(this.uiLabel24);
            this.gbSearch.Controls.Add(this.uiLabel22);
            this.gbSearch.Controls.Add(this.uiLabel27);
            this.gbSearch.Controls.Add(this.tbLand_use_remark);
            this.gbSearch.Controls.Add(this.土地使用说明);
            this.gbSearch.Controls.Add(this.uiLabel32);
            this.gbSearch.Controls.Add(this.uiLabel33);
            this.gbSearch.Controls.Add(this.tbContract_time_To);
            this.gbSearch.Controls.Add(this.tbContract_time_From);
            this.gbSearch.Controls.Add(this.uiLabel10);
            this.gbSearch.Controls.Add(this.cbIs_basic_farmland);
            this.gbSearch.Controls.Add(this.tbNorth);
            this.gbSearch.Controls.Add(this.tbWest);
            this.gbSearch.Controls.Add(this.tbSouth);
            this.gbSearch.Controls.Add(this.tbEast);
            this.gbSearch.Controls.Add(this.tbLand_name);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.uiLabel9);
            this.gbSearch.Controls.Add(this.uiLabel8);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.uiLabel7);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label15);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(13, 27);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1889, 231);
            this.gbSearch.TabIndex = 96;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbContractor
            // 
            this.tbContractor.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContractor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContractor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContractor.Location = new System.Drawing.Point(814, 80);
            this.tbContractor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContractor.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContractor.Name = "tbContractor";
            this.tbContractor.Padding = new System.Windows.Forms.Padding(5);
            this.tbContractor.ShowText = false;
            this.tbContractor.Size = new System.Drawing.Size(159, 29);
            this.tbContractor.TabIndex = 213;
            this.tbContractor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContractor.Watermark = "";
            // 
            // ctvMove_type
            // 
            this.ctvMove_type.CheckBoxes = true;
            this.ctvMove_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvMove_type.FillColor = System.Drawing.Color.White;
            this.ctvMove_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvMove_type.Location = new System.Drawing.Point(515, 152);
            this.ctvMove_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvMove_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvMove_type.Name = "ctvMove_type";
            this.ctvMove_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvMove_type.ShowSelectedAllCheckBox = false;
            this.ctvMove_type.Size = new System.Drawing.Size(158, 29);
            this.ctvMove_type.TabIndex = 309;
            this.ctvMove_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvMove_type.Watermark = "";
            // 
            // ctvLand_type
            // 
            this.ctvLand_type.CheckBoxes = true;
            this.ctvLand_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvLand_type.FillColor = System.Drawing.Color.White;
            this.ctvLand_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvLand_type.Location = new System.Drawing.Point(129, 80);
            this.ctvLand_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvLand_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvLand_type.Name = "ctvLand_type";
            this.ctvLand_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvLand_type.ShowSelectedAllCheckBox = false;
            this.ctvLand_type.Size = new System.Drawing.Size(260, 29);
            this.ctvLand_type.TabIndex = 310;
            this.ctvLand_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvLand_type.Watermark = "";
            // 
            // ctvLand_grade
            // 
            this.ctvLand_grade.CheckBoxes = true;
            this.ctvLand_grade.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvLand_grade.FillColor = System.Drawing.Color.White;
            this.ctvLand_grade.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvLand_grade.Location = new System.Drawing.Point(515, 80);
            this.ctvLand_grade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvLand_grade.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvLand_grade.Name = "ctvLand_grade";
            this.ctvLand_grade.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvLand_grade.ShowSelectedAllCheckBox = false;
            this.ctvLand_grade.Size = new System.Drawing.Size(158, 29);
            this.ctvLand_grade.TabIndex = 311;
            this.ctvLand_grade.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvLand_grade.Watermark = "";
            // 
            // dpMove_date_To
            // 
            this.dpMove_date_To.CanEmpty = true;
            this.dpMove_date_To.FillColor = System.Drawing.Color.White;
            this.dpMove_date_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpMove_date_To.Location = new System.Drawing.Point(269, 152);
            this.dpMove_date_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpMove_date_To.MaxLength = 10;
            this.dpMove_date_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpMove_date_To.Name = "dpMove_date_To";
            this.dpMove_date_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpMove_date_To.Size = new System.Drawing.Size(120, 29);
            this.dpMove_date_To.SymbolDropDown = 61555;
            this.dpMove_date_To.SymbolNormal = 61555;
            this.dpMove_date_To.TabIndex = 255;
            this.dpMove_date_To.Text = "2023-08-25";
            this.dpMove_date_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpMove_date_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpMove_date_To.Watermark = "";
            // 
            // dpMove_date_From
            // 
            this.dpMove_date_From.CanEmpty = true;
            this.dpMove_date_From.FillColor = System.Drawing.Color.White;
            this.dpMove_date_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpMove_date_From.Location = new System.Drawing.Point(129, 152);
            this.dpMove_date_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpMove_date_From.MaxLength = 10;
            this.dpMove_date_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpMove_date_From.Name = "dpMove_date_From";
            this.dpMove_date_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpMove_date_From.Size = new System.Drawing.Size(119, 29);
            this.dpMove_date_From.SymbolDropDown = 61555;
            this.dpMove_date_From.SymbolNormal = 61555;
            this.dpMove_date_From.TabIndex = 254;
            this.dpMove_date_From.Text = "1900-01-01";
            this.dpMove_date_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpMove_date_From.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpMove_date_From.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(1233, 116);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(24, 31);
            this.uiLabel12.TabIndex = 253;
            this.uiLabel12.Text = "-";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReal_area_To
            // 
            this.tbReal_area_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbReal_area_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReal_area_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReal_area_To.Location = new System.Drawing.Point(269, 116);
            this.tbReal_area_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReal_area_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbReal_area_To.Name = "tbReal_area_To";
            this.tbReal_area_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbReal_area_To.ShowText = false;
            this.tbReal_area_To.Size = new System.Drawing.Size(120, 29);
            this.tbReal_area_To.TabIndex = 203;
            this.tbReal_area_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbReal_area_To.Watermark = "";
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(881, 116);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(24, 31);
            this.uiLabel13.TabIndex = 252;
            this.uiLabel13.Text = "-";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReal_area_From
            // 
            this.tbReal_area_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbReal_area_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReal_area_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReal_area_From.Location = new System.Drawing.Point(129, 116);
            this.tbReal_area_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReal_area_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbReal_area_From.Name = "tbReal_area_From";
            this.tbReal_area_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbReal_area_From.ShowText = false;
            this.tbReal_area_From.Size = new System.Drawing.Size(119, 29);
            this.tbReal_area_From.TabIndex = 202;
            this.tbReal_area_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbReal_area_From.Watermark = "";
            // 
            // uiLabel15
            // 
            this.uiLabel15.AutoSize = true;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(584, 116);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(24, 31);
            this.uiLabel15.TabIndex = 250;
            this.uiLabel15.Text = "-";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel16
            // 
            this.uiLabel16.AutoSize = true;
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.Location = new System.Drawing.Point(245, 152);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(24, 31);
            this.uiLabel16.TabIndex = 249;
            this.uiLabel16.Text = "-";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel17
            // 
            this.uiLabel17.AutoSize = true;
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel17.Location = new System.Drawing.Point(246, 116);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(24, 31);
            this.uiLabel17.TabIndex = 248;
            this.uiLabel17.Text = "-";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMove_price_To
            // 
            this.tbMove_price_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_price_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_price_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_price_To.Location = new System.Drawing.Point(1253, 116);
            this.tbMove_price_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_price_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_price_To.Name = "tbMove_price_To";
            this.tbMove_price_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_price_To.ShowText = false;
            this.tbMove_price_To.Size = new System.Drawing.Size(62, 29);
            this.tbMove_price_To.TabIndex = 220;
            this.tbMove_price_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_price_To.Watermark = "";
            // 
            // tbMove_area_To
            // 
            this.tbMove_area_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_area_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_area_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_area_To.Location = new System.Drawing.Point(913, 116);
            this.tbMove_area_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_area_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_area_To.Name = "tbMove_area_To";
            this.tbMove_area_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_area_To.ShowText = false;
            this.tbMove_area_To.Size = new System.Drawing.Size(60, 29);
            this.tbMove_area_To.TabIndex = 225;
            this.tbMove_area_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_area_To.Watermark = "";
            // 
            // tbMove_price_From
            // 
            this.tbMove_price_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_price_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_price_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_price_From.Location = new System.Drawing.Point(1164, 116);
            this.tbMove_price_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_price_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_price_From.Name = "tbMove_price_From";
            this.tbMove_price_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_price_From.ShowText = false;
            this.tbMove_price_From.Size = new System.Drawing.Size(62, 29);
            this.tbMove_price_From.TabIndex = 229;
            this.tbMove_price_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_price_From.Watermark = "";
            // 
            // tbMove_area_From
            // 
            this.tbMove_area_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_area_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_area_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_area_From.Location = new System.Drawing.Point(814, 116);
            this.tbMove_area_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_area_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_area_From.Name = "tbMove_area_From";
            this.tbMove_area_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_area_From.ShowText = false;
            this.tbMove_area_From.Size = new System.Drawing.Size(62, 29);
            this.tbMove_area_From.TabIndex = 219;
            this.tbMove_area_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_area_From.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(1022, 116);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(219, 31);
            this.uiLabel24.TabIndex = 241;
            this.uiLabel24.Text = "流转价格(元/亩*年)";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel22.Location = new System.Drawing.Point(418, 152);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(110, 31);
            this.uiLabel22.TabIndex = 239;
            this.uiLabel22.Text = "流转形式";
            this.uiLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel27
            // 
            this.uiLabel27.AutoSize = true;
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel27.Location = new System.Drawing.Point(719, 80);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(86, 31);
            this.uiLabel27.TabIndex = 235;
            this.uiLabel27.Text = "承包方";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLand_use_remark
            // 
            this.tbLand_use_remark.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLand_use_remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLand_use_remark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLand_use_remark.Location = new System.Drawing.Point(1164, 80);
            this.tbLand_use_remark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLand_use_remark.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLand_use_remark.Name = "tbLand_use_remark";
            this.tbLand_use_remark.Padding = new System.Windows.Forms.Padding(5);
            this.tbLand_use_remark.ShowText = false;
            this.tbLand_use_remark.Size = new System.Drawing.Size(151, 29);
            this.tbLand_use_remark.TabIndex = 214;
            this.tbLand_use_remark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLand_use_remark.Watermark = "";
            // 
            // 土地使用说明
            // 
            this.土地使用说明.AutoSize = true;
            this.土地使用说明.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.土地使用说明.Location = new System.Drawing.Point(1022, 80);
            this.土地使用说明.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.土地使用说明.Name = "土地使用说明";
            this.土地使用说明.Size = new System.Drawing.Size(158, 31);
            this.土地使用说明.TabIndex = 210;
            this.土地使用说明.Text = "土地用途说明";
            this.土地使用说明.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel32
            // 
            this.uiLabel32.AutoSize = true;
            this.uiLabel32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel32.Location = new System.Drawing.Point(719, 116);
            this.uiLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel32.Name = "uiLabel32";
            this.uiLabel32.Size = new System.Drawing.Size(150, 31);
            this.uiLabel32.TabIndex = 207;
            this.uiLabel32.Text = "流转面积(亩)";
            this.uiLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel33
            // 
            this.uiLabel33.AutoSize = true;
            this.uiLabel33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel33.Location = new System.Drawing.Point(33, 152);
            this.uiLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel33.Name = "uiLabel33";
            this.uiLabel33.Size = new System.Drawing.Size(110, 31);
            this.uiLabel33.TabIndex = 205;
            this.uiLabel33.Text = "流转日期";
            this.uiLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbContract_time_To
            // 
            this.tbContract_time_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContract_time_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContract_time_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContract_time_To.Location = new System.Drawing.Point(611, 116);
            this.tbContract_time_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContract_time_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContract_time_To.Name = "tbContract_time_To";
            this.tbContract_time_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbContract_time_To.ShowText = false;
            this.tbContract_time_To.Size = new System.Drawing.Size(62, 29);
            this.tbContract_time_To.TabIndex = 203;
            this.tbContract_time_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContract_time_To.Watermark = "";
            // 
            // tbContract_time_From
            // 
            this.tbContract_time_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContract_time_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContract_time_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContract_time_From.Location = new System.Drawing.Point(515, 116);
            this.tbContract_time_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContract_time_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContract_time_From.Name = "tbContract_time_From";
            this.tbContract_time_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbContract_time_From.ShowText = false;
            this.tbContract_time_From.Size = new System.Drawing.Size(62, 29);
            this.tbContract_time_From.TabIndex = 202;
            this.tbContract_time_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContract_time_From.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(418, 116);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(150, 31);
            this.uiLabel10.TabIndex = 200;
            this.uiLabel10.Text = "承包时间(年)";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbIs_basic_farmland
            // 
            this.cbIs_basic_farmland.DataSource = null;
            this.cbIs_basic_farmland.FillColor = System.Drawing.Color.White;
            this.cbIs_basic_farmland.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_basic_farmland.Location = new System.Drawing.Point(1164, 44);
            this.cbIs_basic_farmland.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_basic_farmland.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_basic_farmland.Name = "cbIs_basic_farmland";
            this.cbIs_basic_farmland.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_basic_farmland.Size = new System.Drawing.Size(151, 29);
            this.cbIs_basic_farmland.TabIndex = 88;
            this.cbIs_basic_farmland.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_basic_farmland.Watermark = "";
            // 
            // tbNorth
            // 
            this.tbNorth.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbNorth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNorth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNorth.Location = new System.Drawing.Point(515, 188);
            this.tbNorth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNorth.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbNorth.Name = "tbNorth";
            this.tbNorth.Padding = new System.Windows.Forms.Padding(5);
            this.tbNorth.ShowText = false;
            this.tbNorth.Size = new System.Drawing.Size(158, 29);
            this.tbNorth.TabIndex = 162;
            this.tbNorth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbNorth.Watermark = "";
            // 
            // tbWest
            // 
            this.tbWest.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbWest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWest.Location = new System.Drawing.Point(129, 188);
            this.tbWest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWest.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbWest.Name = "tbWest";
            this.tbWest.Padding = new System.Windows.Forms.Padding(5);
            this.tbWest.ShowText = false;
            this.tbWest.Size = new System.Drawing.Size(260, 29);
            this.tbWest.TabIndex = 162;
            this.tbWest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWest.Watermark = "";
            // 
            // tbSouth
            // 
            this.tbSouth.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSouth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSouth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSouth.Location = new System.Drawing.Point(1164, 152);
            this.tbSouth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSouth.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSouth.Name = "tbSouth";
            this.tbSouth.Padding = new System.Windows.Forms.Padding(5);
            this.tbSouth.ShowText = false;
            this.tbSouth.Size = new System.Drawing.Size(151, 29);
            this.tbSouth.TabIndex = 162;
            this.tbSouth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSouth.Watermark = "";
            // 
            // tbEast
            // 
            this.tbEast.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbEast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEast.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEast.Location = new System.Drawing.Point(815, 152);
            this.tbEast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEast.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbEast.Name = "tbEast";
            this.tbEast.Padding = new System.Windows.Forms.Padding(5);
            this.tbEast.ShowText = false;
            this.tbEast.Size = new System.Drawing.Size(158, 29);
            this.tbEast.TabIndex = 162;
            this.tbEast.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEast.Watermark = "";
            // 
            // tbLand_name
            // 
            this.tbLand_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLand_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLand_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLand_name.Location = new System.Drawing.Point(813, 44);
            this.tbLand_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLand_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLand_name.Name = "tbLand_name";
            this.tbLand_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbLand_name.ShowText = false;
            this.tbLand_name.Size = new System.Drawing.Size(160, 29);
            this.tbLand_name.TabIndex = 162;
            this.tbLand_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLand_name.Watermark = "";
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(722, 188);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(110, 31);
            this.uiLabel26.TabIndex = 155;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(1164, 188);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(151, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(33, 44);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(62, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(515, 44);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(158, 29);
            this.tbIdcard.TabIndex = 131;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // tbName
            // 
            this.tbName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(129, 44);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(5);
            this.tbName.ShowText = false;
            this.tbName.Size = new System.Drawing.Size(260, 29);
            this.tbName.TabIndex = 130;
            this.tbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbName.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(418, 188);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(62, 31);
            this.uiLabel9.TabIndex = 113;
            this.uiLabel9.Text = "北至";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(33, 188);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(62, 31);
            this.uiLabel8.TabIndex = 113;
            this.uiLabel8.Text = "西至";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(1019, 44);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(158, 31);
            this.uiLabel6.TabIndex = 113;
            this.uiLabel6.Text = "是否基本农田";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(1022, 152);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(62, 31);
            this.uiLabel7.TabIndex = 113;
            this.uiLabel7.Text = "南至";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 116;
            this.label9.Text = "地块等级";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(722, 152);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 31);
            this.label15.TabIndex = 113;
            this.label15.Text = "东至";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(722, 44);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 108;
            this.uiLabel5.Text = "地块名称";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(33, 80);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(110, 31);
            this.uiLabel4.TabIndex = 108;
            this.uiLabel4.Text = "地块类型";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 44);
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
            this.btReset.Location = new System.Drawing.Point(1322, 124);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(73, 40);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1322, 79);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(73, 40);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(33, 116);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(166, 31);
            this.uiLabel1.TabIndex = 200;
            this.uiLabel1.Text = "实测面积(亩）";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(306, 266);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(91, 51);
            this.btImport.TabIndex = 90;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgLandList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(18, 324);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1889, 706);
            this.gbResult.TabIndex = 89;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgLandList
            // 
            this.dgLandList.AllowUserToAddRows = false;
            this.dgLandList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgLandList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLandList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgLandList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLandList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLandList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLandList.EnableHeadersVisualStyles = false;
            this.dgLandList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgLandList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgLandList.Location = new System.Drawing.Point(4, 32);
            this.dgLandList.Name = "dgLandList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLandList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLandList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgLandList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgLandList.RowTemplate.Height = 23;
            this.dgLandList.ScrollBarHandleWidth = 40;
            this.dgLandList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgLandList.SelectedIndex = -1;
            this.dgLandList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLandList.Size = new System.Drawing.Size(1881, 670);
            this.dgLandList.TabIndex = 8;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(403, 266);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(91, 51);
            this.btExport.TabIndex = 91;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(15, 266);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(91, 51);
            this.btAdd.TabIndex = 92;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(112, 266);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(91, 51);
            this.btEdit.TabIndex = 93;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(209, 266);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(91, 51);
            this.btDelete.TabIndex = 94;
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
            this.pagination.Location = new System.Drawing.Point(10, 1031);
            this.pagination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagination.MinimumSize = new System.Drawing.Size(1, 1);
            this.pagination.Name = "pagination";
            this.pagination.PagerCount = 11;
            this.pagination.PageSize = 50;
            this.pagination.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.pagination.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.pagination.ShowText = false;
            this.pagination.Size = new System.Drawing.Size(2229, 35);
            this.pagination.TabIndex = 95;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            // 
            // frmLandList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pagination);
            this.Name = "frmLandList";
            this.Text = "frmLandList";
            this.Load += new System.EventHandler(this.frmLandList_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLandList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UIComboBox cbIs_basic_farmland;
        private Sunny.UI.UITextBox tbLand_name;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbName;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIDataGridView dgLandList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UITextBox tbNorth;
        private Sunny.UI.UITextBox tbWest;
        private Sunny.UI.UITextBox tbSouth;
        private Sunny.UI.UITextBox tbEast;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox tbContract_time_To;
        private Sunny.UI.UITextBox tbContract_time_From;
        private Sunny.UI.UITextBox tbReal_area_To;
        private Sunny.UI.UITextBox tbReal_area_From;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UITextBox tbMove_price_To;
        private Sunny.UI.UITextBox tbMove_area_To;
        private Sunny.UI.UITextBox tbMove_price_From;
        private Sunny.UI.UITextBox tbMove_area_From;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILabel uiLabel27;
        private Sunny.UI.UITextBox tbLand_use_remark;
        private Sunny.UI.UITextBox tbContractor;
        private Sunny.UI.UILabel 土地使用说明;
        private Sunny.UI.UILabel uiLabel32;
        private Sunny.UI.UILabel uiLabel33;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDatePicker dpMove_date_To;
        private Sunny.UI.UIDatePicker dpMove_date_From;
        private Sunny.UI.UIComboTreeView ctvMove_type;
        private Sunny.UI.UIComboTreeView ctvLand_type;
        private Sunny.UI.UIComboTreeView ctvLand_grade;
    }
}