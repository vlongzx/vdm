namespace com.vdm.form
{
    partial class frmLandInfo
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
            this.ctvMove_type = new Sunny.UI.UIComboTreeView();
            this.ctvLand_type = new Sunny.UI.UIComboTreeView();
            this.ctvLand_grade = new Sunny.UI.UIComboTreeView();
            this.dpMove_date = new Sunny.UI.UIDatePicker();
            this.tbReal_area = new Sunny.UI.UITextBox();
            this.tbMove_price = new Sunny.UI.UITextBox();
            this.tbMove_area = new Sunny.UI.UITextBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.uiLabel27 = new Sunny.UI.UILabel();
            this.tbLand_use_remark = new Sunny.UI.UITextBox();
            this.tbContractor = new Sunny.UI.UITextBox();
            this.土地使用说明 = new Sunny.UI.UILabel();
            this.uiLabel32 = new Sunny.UI.UILabel();
            this.uiLabel33 = new Sunny.UI.UILabel();
            this.tbContract_time = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.cbIs_basic_farmland = new Sunny.UI.UIComboBox();
            this.tbNorth = new Sunny.UI.UITextBox();
            this.tbWest = new Sunny.UI.UITextBox();
            this.tbSouth = new Sunny.UI.UITextBox();
            this.tbEast = new Sunny.UI.UITextBox();
            this.tbLand_name = new Sunny.UI.UITextBox();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 349);
            this.pnlBtm.Size = new System.Drawing.Size(1386, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1258, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1143, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctvMove_type
            // 
            this.ctvMove_type.CheckBoxes = true;
            this.ctvMove_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvMove_type.FillColor = System.Drawing.Color.White;
            this.ctvMove_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvMove_type.Location = new System.Drawing.Point(495, 202);
            this.ctvMove_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvMove_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvMove_type.Name = "ctvMove_type";
            this.ctvMove_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvMove_type.ShowSelectedAllCheckBox = false;
            this.ctvMove_type.Size = new System.Drawing.Size(160, 29);
            this.ctvMove_type.TabIndex = 359;
            this.ctvMove_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvMove_type.Watermark = "";
            // 
            // ctvLand_type
            // 
            this.ctvLand_type.CheckBoxes = true;
            this.ctvLand_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvLand_type.FillColor = System.Drawing.Color.White;
            this.ctvLand_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvLand_type.Location = new System.Drawing.Point(163, 130);
            this.ctvLand_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvLand_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvLand_type.Name = "ctvLand_type";
            this.ctvLand_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvLand_type.ShowSelectedAllCheckBox = false;
            this.ctvLand_type.Size = new System.Drawing.Size(160, 29);
            this.ctvLand_type.TabIndex = 360;
            this.ctvLand_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvLand_type.Watermark = "";
            // 
            // ctvLand_grade
            // 
            this.ctvLand_grade.CheckBoxes = true;
            this.ctvLand_grade.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvLand_grade.FillColor = System.Drawing.Color.White;
            this.ctvLand_grade.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvLand_grade.Location = new System.Drawing.Point(495, 130);
            this.ctvLand_grade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvLand_grade.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvLand_grade.Name = "ctvLand_grade";
            this.ctvLand_grade.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvLand_grade.ShowSelectedAllCheckBox = false;
            this.ctvLand_grade.Size = new System.Drawing.Size(160, 29);
            this.ctvLand_grade.TabIndex = 361;
            this.ctvLand_grade.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvLand_grade.Watermark = "";
            // 
            // dpMove_date
            // 
            this.dpMove_date.CanEmpty = true;
            this.dpMove_date.FillColor = System.Drawing.Color.White;
            this.dpMove_date.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpMove_date.Location = new System.Drawing.Point(163, 202);
            this.dpMove_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpMove_date.MaxLength = 10;
            this.dpMove_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpMove_date.Name = "dpMove_date";
            this.dpMove_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpMove_date.Size = new System.Drawing.Size(160, 29);
            this.dpMove_date.SymbolDropDown = 61555;
            this.dpMove_date.SymbolNormal = 61555;
            this.dpMove_date.TabIndex = 357;
            this.dpMove_date.Text = "2023-01-01";
            this.dpMove_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpMove_date.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dpMove_date.Watermark = "";
            // 
            // tbReal_area
            // 
            this.tbReal_area.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbReal_area.CanEmpty = true;
            this.tbReal_area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReal_area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbReal_area.Location = new System.Drawing.Point(163, 166);
            this.tbReal_area.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReal_area.Minimum = 0D;
            this.tbReal_area.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbReal_area.Name = "tbReal_area";
            this.tbReal_area.Padding = new System.Windows.Forms.Padding(5);
            this.tbReal_area.ShowText = false;
            this.tbReal_area.Size = new System.Drawing.Size(160, 29);
            this.tbReal_area.TabIndex = 336;
            this.tbReal_area.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbReal_area.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbReal_area.Watermark = "";
            // 
            // tbMove_price
            // 
            this.tbMove_price.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_price.CanEmpty = true;
            this.tbMove_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_price.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_price.Location = new System.Drawing.Point(1144, 166);
            this.tbMove_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_price.Minimum = 0D;
            this.tbMove_price.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_price.Name = "tbMove_price";
            this.tbMove_price.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_price.ShowText = false;
            this.tbMove_price.Size = new System.Drawing.Size(160, 29);
            this.tbMove_price.TabIndex = 348;
            this.tbMove_price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_price.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbMove_price.Watermark = "";
            // 
            // tbMove_area
            // 
            this.tbMove_area.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_area.CanEmpty = true;
            this.tbMove_area.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_area.Location = new System.Drawing.Point(794, 166);
            this.tbMove_area.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_area.Minimum = 0D;
            this.tbMove_area.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_area.Name = "tbMove_area";
            this.tbMove_area.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_area.ShowText = false;
            this.tbMove_area.Size = new System.Drawing.Size(160, 29);
            this.tbMove_area.TabIndex = 345;
            this.tbMove_area.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_area.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.tbMove_area.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(1002, 166);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(219, 31);
            this.uiLabel24.TabIndex = 351;
            this.uiLabel24.Text = "流转价格(元/亩*年)";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel22.Location = new System.Drawing.Point(398, 202);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(110, 31);
            this.uiLabel22.TabIndex = 350;
            this.uiLabel22.Text = "流转形式";
            this.uiLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel27
            // 
            this.uiLabel27.AutoSize = true;
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel27.Location = new System.Drawing.Point(699, 130);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(150, 31);
            this.uiLabel27.TabIndex = 349;
            this.uiLabel27.Text = "承包方(选填)";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLand_use_remark
            // 
            this.tbLand_use_remark.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLand_use_remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLand_use_remark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLand_use_remark.Location = new System.Drawing.Point(1144, 130);
            this.tbLand_use_remark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLand_use_remark.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLand_use_remark.Name = "tbLand_use_remark";
            this.tbLand_use_remark.Padding = new System.Windows.Forms.Padding(5);
            this.tbLand_use_remark.ShowText = false;
            this.tbLand_use_remark.Size = new System.Drawing.Size(160, 29);
            this.tbLand_use_remark.TabIndex = 344;
            this.tbLand_use_remark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLand_use_remark.Watermark = "";
            // 
            // tbContractor
            // 
            this.tbContractor.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContractor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContractor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContractor.Location = new System.Drawing.Point(794, 130);
            this.tbContractor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContractor.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContractor.Name = "tbContractor";
            this.tbContractor.Padding = new System.Windows.Forms.Padding(5);
            this.tbContractor.ShowText = false;
            this.tbContractor.Size = new System.Drawing.Size(160, 29);
            this.tbContractor.TabIndex = 343;
            this.tbContractor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContractor.Watermark = "";
            this.tbContractor.TextChanged += new System.EventHandler(this.tbContractor_TextChanged);
            // 
            // 土地使用说明
            // 
            this.土地使用说明.AutoSize = true;
            this.土地使用说明.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.土地使用说明.Location = new System.Drawing.Point(1002, 130);
            this.土地使用说明.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.土地使用说明.Name = "土地使用说明";
            this.土地使用说明.Size = new System.Drawing.Size(158, 31);
            this.土地使用说明.TabIndex = 342;
            this.土地使用说明.Text = "土地用途说明";
            this.土地使用说明.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel32
            // 
            this.uiLabel32.AutoSize = true;
            this.uiLabel32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel32.Location = new System.Drawing.Point(699, 166);
            this.uiLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel32.Name = "uiLabel32";
            this.uiLabel32.Size = new System.Drawing.Size(150, 31);
            this.uiLabel32.TabIndex = 341;
            this.uiLabel32.Text = "流转面积(亩)";
            this.uiLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel33
            // 
            this.uiLabel33.AutoSize = true;
            this.uiLabel33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel33.Location = new System.Drawing.Point(67, 202);
            this.uiLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel33.Name = "uiLabel33";
            this.uiLabel33.Size = new System.Drawing.Size(110, 31);
            this.uiLabel33.TabIndex = 340;
            this.uiLabel33.Text = "流转日期";
            this.uiLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbContract_time
            // 
            this.tbContract_time.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbContract_time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContract_time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContract_time.Location = new System.Drawing.Point(495, 166);
            this.tbContract_time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContract_time.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbContract_time.Name = "tbContract_time";
            this.tbContract_time.Padding = new System.Windows.Forms.Padding(5);
            this.tbContract_time.ShowText = false;
            this.tbContract_time.Size = new System.Drawing.Size(160, 29);
            this.tbContract_time.TabIndex = 337;
            this.tbContract_time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbContract_time.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(398, 166);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(150, 31);
            this.uiLabel10.TabIndex = 334;
            this.uiLabel10.Text = "承包时间(年)";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbIs_basic_farmland
            // 
            this.cbIs_basic_farmland.DataSource = null;
            this.cbIs_basic_farmland.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbIs_basic_farmland.FillColor = System.Drawing.Color.White;
            this.cbIs_basic_farmland.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_basic_farmland.Location = new System.Drawing.Point(1144, 94);
            this.cbIs_basic_farmland.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_basic_farmland.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_basic_farmland.Name = "cbIs_basic_farmland";
            this.cbIs_basic_farmland.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_basic_farmland.Size = new System.Drawing.Size(160, 29);
            this.cbIs_basic_farmland.TabIndex = 312;
            this.cbIs_basic_farmland.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_basic_farmland.Watermark = "";
            // 
            // tbNorth
            // 
            this.tbNorth.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbNorth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNorth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNorth.Location = new System.Drawing.Point(495, 238);
            this.tbNorth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNorth.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbNorth.Name = "tbNorth";
            this.tbNorth.Padding = new System.Windows.Forms.Padding(5);
            this.tbNorth.ShowText = false;
            this.tbNorth.Size = new System.Drawing.Size(160, 29);
            this.tbNorth.TabIndex = 333;
            this.tbNorth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbNorth.Watermark = "";
            // 
            // tbWest
            // 
            this.tbWest.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbWest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWest.Location = new System.Drawing.Point(163, 238);
            this.tbWest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWest.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbWest.Name = "tbWest";
            this.tbWest.Padding = new System.Windows.Forms.Padding(5);
            this.tbWest.ShowText = false;
            this.tbWest.Size = new System.Drawing.Size(160, 29);
            this.tbWest.TabIndex = 332;
            this.tbWest.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWest.Watermark = "";
            // 
            // tbSouth
            // 
            this.tbSouth.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSouth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSouth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSouth.Location = new System.Drawing.Point(1144, 202);
            this.tbSouth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSouth.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSouth.Name = "tbSouth";
            this.tbSouth.Padding = new System.Windows.Forms.Padding(5);
            this.tbSouth.ShowText = false;
            this.tbSouth.Size = new System.Drawing.Size(160, 29);
            this.tbSouth.TabIndex = 331;
            this.tbSouth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSouth.Watermark = "";
            // 
            // tbEast
            // 
            this.tbEast.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbEast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEast.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEast.Location = new System.Drawing.Point(795, 202);
            this.tbEast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEast.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbEast.Name = "tbEast";
            this.tbEast.Padding = new System.Windows.Forms.Padding(5);
            this.tbEast.ShowText = false;
            this.tbEast.Size = new System.Drawing.Size(160, 29);
            this.tbEast.TabIndex = 330;
            this.tbEast.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEast.Watermark = "";
            // 
            // tbLand_name
            // 
            this.tbLand_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLand_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLand_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLand_name.Location = new System.Drawing.Point(793, 94);
            this.tbLand_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLand_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLand_name.Name = "tbLand_name";
            this.tbLand_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbLand_name.ShowText = false;
            this.tbLand_name.Size = new System.Drawing.Size(160, 29);
            this.tbLand_name.TabIndex = 329;
            this.tbLand_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLand_name.Watermark = "";
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(1002, 238);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(86, 31);
            this.uiLabel25.TabIndex = 327;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(702, 238);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(110, 31);
            this.uiLabel26.TabIndex = 328;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(797, 238);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(160, 29);
            this.cbTown.TabIndex = 325;
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
            this.cbVillage.Location = new System.Drawing.Point(1144, 238);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(160, 29);
            this.cbVillage.TabIndex = 326;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(67, 94);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(62, 31);
            this.uiLabel2.TabIndex = 324;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(495, 94);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(160, 29);
            this.tbIdcard.TabIndex = 323;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // tbName
            // 
            this.tbName.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(163, 94);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(5);
            this.tbName.ShowText = false;
            this.tbName.Size = new System.Drawing.Size(160, 29);
            this.tbName.TabIndex = 322;
            this.tbName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbName.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(398, 238);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(62, 31);
            this.uiLabel9.TabIndex = 320;
            this.uiLabel9.Text = "北至";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(67, 238);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(62, 31);
            this.uiLabel8.TabIndex = 319;
            this.uiLabel8.Text = "西至";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(999, 94);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(158, 31);
            this.uiLabel6.TabIndex = 318;
            this.uiLabel6.Text = "是否基本农田";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(1002, 202);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(62, 31);
            this.uiLabel7.TabIndex = 317;
            this.uiLabel7.Text = "南至";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 321;
            this.label9.Text = "地块等级";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(702, 202);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 31);
            this.label15.TabIndex = 316;
            this.label15.Text = "东至";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(702, 94);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 315;
            this.uiLabel5.Text = "地块名称";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(67, 130);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(110, 31);
            this.uiLabel4.TabIndex = 314;
            this.uiLabel4.Text = "地块类型";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(398, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 31);
            this.label12.TabIndex = 313;
            this.label12.Text = "身份证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(67, 166);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(166, 31);
            this.uiLabel1.TabIndex = 335;
            this.uiLabel1.Text = "实测面积(亩）";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLandInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1388, 407);
            this.Controls.Add(this.ctvMove_type);
            this.Controls.Add(this.ctvLand_type);
            this.Controls.Add(this.tbLand_name);
            this.Controls.Add(this.ctvLand_grade);
            this.Controls.Add(this.dpMove_date);
            this.Controls.Add(this.tbReal_area);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbIdcard);
            this.Controls.Add(this.tbMove_price);
            this.Controls.Add(this.tbMove_area);
            this.Controls.Add(this.cbVillage);
            this.Controls.Add(this.cbTown);
            this.Controls.Add(this.tbLand_use_remark);
            this.Controls.Add(this.tbEast);
            this.Controls.Add(this.tbContractor);
            this.Controls.Add(this.tbSouth);
            this.Controls.Add(this.tbWest);
            this.Controls.Add(this.tbNorth);
            this.Controls.Add(this.cbIs_basic_farmland);
            this.Controls.Add(this.tbContract_time);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel24);
            this.Controls.Add(this.uiLabel22);
            this.Controls.Add(this.uiLabel26);
            this.Controls.Add(this.uiLabel27);
            this.Controls.Add(this.uiLabel25);
            this.Controls.Add(this.土地使用说明);
            this.Controls.Add(this.uiLabel32);
            this.Controls.Add(this.uiLabel33);
            this.Controls.Add(this.uiLabel10);
            this.Name = "frmLandInfo";
            this.Text = "土地信息";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 1021, 595);
            this.Load += new System.EventHandler(this.frmLandInfo_Load);
            this.Controls.SetChildIndex(this.uiLabel10, 0);
            this.Controls.SetChildIndex(this.uiLabel33, 0);
            this.Controls.SetChildIndex(this.uiLabel32, 0);
            this.Controls.SetChildIndex(this.土地使用说明, 0);
            this.Controls.SetChildIndex(this.uiLabel25, 0);
            this.Controls.SetChildIndex(this.uiLabel27, 0);
            this.Controls.SetChildIndex(this.uiLabel26, 0);
            this.Controls.SetChildIndex(this.uiLabel22, 0);
            this.Controls.SetChildIndex(this.uiLabel24, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel9, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.tbContract_time, 0);
            this.Controls.SetChildIndex(this.cbIs_basic_farmland, 0);
            this.Controls.SetChildIndex(this.tbNorth, 0);
            this.Controls.SetChildIndex(this.tbWest, 0);
            this.Controls.SetChildIndex(this.tbSouth, 0);
            this.Controls.SetChildIndex(this.tbContractor, 0);
            this.Controls.SetChildIndex(this.tbEast, 0);
            this.Controls.SetChildIndex(this.tbLand_use_remark, 0);
            this.Controls.SetChildIndex(this.cbTown, 0);
            this.Controls.SetChildIndex(this.cbVillage, 0);
            this.Controls.SetChildIndex(this.tbMove_area, 0);
            this.Controls.SetChildIndex(this.tbMove_price, 0);
            this.Controls.SetChildIndex(this.tbIdcard, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.tbReal_area, 0);
            this.Controls.SetChildIndex(this.dpMove_date, 0);
            this.Controls.SetChildIndex(this.ctvLand_grade, 0);
            this.Controls.SetChildIndex(this.tbLand_name, 0);
            this.Controls.SetChildIndex(this.ctvLand_type, 0);
            this.Controls.SetChildIndex(this.ctvMove_type, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIComboTreeView ctvMove_type;
        private Sunny.UI.UIComboTreeView ctvLand_type;
        private Sunny.UI.UIComboTreeView ctvLand_grade;
        private Sunny.UI.UIDatePicker dpMove_date;
        private Sunny.UI.UITextBox tbReal_area;
        private Sunny.UI.UITextBox tbMove_price;
        private Sunny.UI.UITextBox tbMove_area;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILabel uiLabel27;
        private Sunny.UI.UITextBox tbLand_use_remark;
        private Sunny.UI.UITextBox tbContractor;
        private Sunny.UI.UILabel 土地使用说明;
        private Sunny.UI.UILabel uiLabel32;
        private Sunny.UI.UILabel uiLabel33;
        private Sunny.UI.UITextBox tbContract_time;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox cbIs_basic_farmland;
        private Sunny.UI.UITextBox tbNorth;
        private Sunny.UI.UITextBox tbWest;
        private Sunny.UI.UITextBox tbSouth;
        private Sunny.UI.UITextBox tbEast;
        private Sunny.UI.UITextBox tbLand_name;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbName;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel uiLabel1;
    }
}