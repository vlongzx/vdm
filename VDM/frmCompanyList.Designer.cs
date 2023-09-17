namespace com.vdm.form
{
    partial class frmCompanyList
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
            this.btImport = new Sunny.UI.UIButton();
            this.dgCompanyList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.tbLegal_idcard = new Sunny.UI.UITextBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
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
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.tbCompany_phone = new Sunny.UI.UITextBox();
            this.tbLegal_name = new Sunny.UI.UITextBox();
            this.tbCompany_name = new Sunny.UI.UITextBox();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.ctvCompany_type = new Sunny.UI.UIComboTreeView();
            this.tbInsure_person_count_From = new Sunny.UI.UITextBox();
            this.cbCompany_status = new Sunny.UI.UIComboBox();
            this.cbIs_top_company = new Sunny.UI.UIComboBox();
            this.dpEstablish_date_To = new Sunny.UI.UIDatePicker();
            this.dpEstablish_date_From = new Sunny.UI.UIDatePicker();
            this.dpLicense_date_To = new Sunny.UI.UIDatePicker();
            this.dpLicense_date_From = new Sunny.UI.UIDatePicker();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tbOutput_To = new Sunny.UI.UITextBox();
            this.tbOutput_From = new Sunny.UI.UITextBox();
            this.tbInsure_person_count_To = new Sunny.UI.UITextBox();
            this.tbStaff_size_To = new Sunny.UI.UITextBox();
            this.tbStaff_size_From = new Sunny.UI.UITextBox();
            this.tbCompany_address = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTaxpayer_qualification = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btDelete = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyList)).BeginInit();
            this.gbResult.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(315, 268);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(94, 50);
            this.btImport.TabIndex = 98;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgCompanyList
            // 
            this.dgCompanyList.AllowUserToAddRows = false;
            this.dgCompanyList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgCompanyList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCompanyList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgCompanyList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompanyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCompanyList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCompanyList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgCompanyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCompanyList.EnableHeadersVisualStyles = false;
            this.dgCompanyList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgCompanyList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgCompanyList.Location = new System.Drawing.Point(4, 32);
            this.dgCompanyList.Name = "dgCompanyList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompanyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCompanyList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgCompanyList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCompanyList.RowTemplate.Height = 23;
            this.dgCompanyList.ScrollBarHandleWidth = 40;
            this.dgCompanyList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgCompanyList.SelectedIndex = -1;
            this.dgCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCompanyList.Size = new System.Drawing.Size(1881, 669);
            this.dgCompanyList.TabIndex = 8;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(415, 268);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(94, 50);
            this.btExport.TabIndex = 99;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(835, 114);
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
            this.uiLabel17.Location = new System.Drawing.Point(835, 79);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(24, 31);
            this.uiLabel17.TabIndex = 248;
            this.uiLabel17.Text = "-";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLegal_idcard
            // 
            this.tbLegal_idcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLegal_idcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLegal_idcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLegal_idcard.Location = new System.Drawing.Point(422, 79);
            this.tbLegal_idcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLegal_idcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLegal_idcard.Name = "tbLegal_idcard";
            this.tbLegal_idcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbLegal_idcard.ShowText = false;
            this.tbLegal_idcard.Size = new System.Drawing.Size(158, 29);
            this.tbLegal_idcard.TabIndex = 229;
            this.tbLegal_idcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLegal_idcard.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(304, 79);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(182, 31);
            this.uiLabel24.TabIndex = 241;
            this.uiLabel24.Text = "企业法人身份证";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgCompanyList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(18, 325);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1889, 705);
            this.gbResult.TabIndex = 97;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(15, 268);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 50);
            this.btAdd.TabIndex = 100;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(115, 268);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(94, 50);
            this.btEdit.TabIndex = 101;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            this.pagination.TabIndex = 103;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            // 
            // uiLabel22
            // 
            this.uiLabel22.AutoSize = true;
            this.uiLabel22.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel22.Location = new System.Drawing.Point(303, 149);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(110, 31);
            this.uiLabel22.TabIndex = 239;
            this.uiLabel22.Text = "人员规模";
            this.uiLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel27
            // 
            this.uiLabel27.AutoSize = true;
            this.uiLabel27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel27.Location = new System.Drawing.Point(1015, 42);
            this.uiLabel27.Name = "uiLabel27";
            this.uiLabel27.Size = new System.Drawing.Size(206, 31);
            this.uiLabel27.TabIndex = 235;
            this.uiLabel27.Text = "统一社会信用编码";
            this.uiLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBusiness_code
            // 
            this.tbBusiness_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbBusiness_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBusiness_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBusiness_code.Location = new System.Drawing.Point(139, 114);
            this.tbBusiness_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBusiness_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbBusiness_code.Name = "tbBusiness_code";
            this.tbBusiness_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbBusiness_code.ShowText = false;
            this.tbBusiness_code.Size = new System.Drawing.Size(129, 29);
            this.tbBusiness_code.TabIndex = 214;
            this.tbBusiness_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbBusiness_code.Watermark = "";
            // 
            // tbCredit_code
            // 
            this.tbCredit_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCredit_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCredit_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCredit_code.Location = new System.Drawing.Point(1156, 44);
            this.tbCredit_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCredit_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCredit_code.Name = "tbCredit_code";
            this.tbCredit_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbCredit_code.ShowText = false;
            this.tbCredit_code.Size = new System.Drawing.Size(159, 29);
            this.tbCredit_code.TabIndex = 213;
            this.tbCredit_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCredit_code.Watermark = "";
            // 
            // 土地使用说明
            // 
            this.土地使用说明.AutoSize = true;
            this.土地使用说明.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.土地使用说明.Location = new System.Drawing.Point(33, 114);
            this.土地使用说明.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.土地使用说明.Name = "土地使用说明";
            this.土地使用说明.Size = new System.Drawing.Size(134, 31);
            this.土地使用说明.TabIndex = 210;
            this.土地使用说明.Text = "工商注册号";
            this.土地使用说明.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel32
            // 
            this.uiLabel32.AutoSize = true;
            this.uiLabel32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel32.Location = new System.Drawing.Point(618, 114);
            this.uiLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel32.Name = "uiLabel32";
            this.uiLabel32.Size = new System.Drawing.Size(110, 31);
            this.uiLabel32.TabIndex = 207;
            this.uiLabel32.Text = "成立时间";
            this.uiLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel33
            // 
            this.uiLabel33.AutoSize = true;
            this.uiLabel33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel33.Location = new System.Drawing.Point(33, 149);
            this.uiLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel33.Name = "uiLabel33";
            this.uiLabel33.Size = new System.Drawing.Size(158, 31);
            this.uiLabel33.TabIndex = 205;
            this.uiLabel33.Text = "企业联系电话";
            this.uiLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrganization_code
            // 
            this.tbOrganization_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOrganization_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOrganization_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOrganization_code.Location = new System.Drawing.Point(422, 114);
            this.tbOrganization_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOrganization_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOrganization_code.Name = "tbOrganization_code";
            this.tbOrganization_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbOrganization_code.ShowText = false;
            this.tbOrganization_code.Size = new System.Drawing.Size(158, 29);
            this.tbOrganization_code.TabIndex = 203;
            this.tbOrganization_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOrganization_code.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(304, 114);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(158, 31);
            this.uiLabel10.TabIndex = 200;
            this.uiLabel10.Text = "组织机构代码";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTaxpayer_code
            // 
            this.tbTaxpayer_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbTaxpayer_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTaxpayer_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTaxpayer_code.Location = new System.Drawing.Point(139, 184);
            this.tbTaxpayer_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTaxpayer_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbTaxpayer_code.Name = "tbTaxpayer_code";
            this.tbTaxpayer_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbTaxpayer_code.ShowText = false;
            this.tbTaxpayer_code.Size = new System.Drawing.Size(129, 29);
            this.tbTaxpayer_code.TabIndex = 162;
            this.tbTaxpayer_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTaxpayer_code.Watermark = "";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.tbCompany_phone);
            this.gbSearch.Controls.Add(this.tbBusiness_code);
            this.gbSearch.Controls.Add(this.tbTaxpayer_code);
            this.gbSearch.Controls.Add(this.tbLegal_name);
            this.gbSearch.Controls.Add(this.tbCompany_name);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.ctvCompany_type);
            this.gbSearch.Controls.Add(this.tbInsure_person_count_From);
            this.gbSearch.Controls.Add(this.cbCompany_status);
            this.gbSearch.Controls.Add(this.cbIs_top_company);
            this.gbSearch.Controls.Add(this.tbCredit_code);
            this.gbSearch.Controls.Add(this.dpEstablish_date_To);
            this.gbSearch.Controls.Add(this.dpEstablish_date_From);
            this.gbSearch.Controls.Add(this.dpLicense_date_To);
            this.gbSearch.Controls.Add(this.dpLicense_date_From);
            this.gbSearch.Controls.Add(this.uiLabel14);
            this.gbSearch.Controls.Add(this.uiLabel12);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.uiLabel13);
            this.gbSearch.Controls.Add(this.uiLabel17);
            this.gbSearch.Controls.Add(this.tbOutput_To);
            this.gbSearch.Controls.Add(this.tbOutput_From);
            this.gbSearch.Controls.Add(this.tbInsure_person_count_To);
            this.gbSearch.Controls.Add(this.tbStaff_size_To);
            this.gbSearch.Controls.Add(this.tbStaff_size_From);
            this.gbSearch.Controls.Add(this.tbLegal_idcard);
            this.gbSearch.Controls.Add(this.uiLabel24);
            this.gbSearch.Controls.Add(this.uiLabel22);
            this.gbSearch.Controls.Add(this.uiLabel27);
            this.gbSearch.Controls.Add(this.土地使用说明);
            this.gbSearch.Controls.Add(this.uiLabel32);
            this.gbSearch.Controls.Add(this.uiLabel33);
            this.gbSearch.Controls.Add(this.tbOrganization_code);
            this.gbSearch.Controls.Add(this.uiLabel10);
            this.gbSearch.Controls.Add(this.tbCompany_address);
            this.gbSearch.Controls.Add(this.uiLabel11);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.cbTaxpayer_qualification);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.uiLabel9);
            this.gbSearch.Controls.Add(this.uiLabel8);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.uiLabel7);
            this.gbSearch.Controls.Add(this.label15);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(13, 36);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1894, 224);
            this.gbSearch.TabIndex = 104;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCompany_phone
            // 
            this.tbCompany_phone.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_phone.Location = new System.Drawing.Point(139, 149);
            this.tbCompany_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_phone.Name = "tbCompany_phone";
            this.tbCompany_phone.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_phone.ShowText = false;
            this.tbCompany_phone.Size = new System.Drawing.Size(129, 29);
            this.tbCompany_phone.TabIndex = 131;
            this.tbCompany_phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_phone.Watermark = "";
            // 
            // tbLegal_name
            // 
            this.tbLegal_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLegal_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLegal_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLegal_name.Location = new System.Drawing.Point(139, 79);
            this.tbLegal_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLegal_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLegal_name.Name = "tbLegal_name";
            this.tbLegal_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbLegal_name.ShowText = false;
            this.tbLegal_name.Size = new System.Drawing.Size(129, 29);
            this.tbLegal_name.TabIndex = 131;
            this.tbLegal_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLegal_name.Watermark = "";
            // 
            // tbCompany_name
            // 
            this.tbCompany_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_name.Location = new System.Drawing.Point(139, 44);
            this.tbCompany_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_name.Name = "tbCompany_name";
            this.tbCompany_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_name.ShowText = false;
            this.tbCompany_name.Size = new System.Drawing.Size(129, 29);
            this.tbCompany_name.TabIndex = 130;
            this.tbCompany_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_name.Watermark = "";
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(720, 184);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(261, 29);
            this.cbTown.TabIndex = 152;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // ctvCompany_type
            // 
            this.ctvCompany_type.CheckBoxes = true;
            this.ctvCompany_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvCompany_type.FillColor = System.Drawing.Color.White;
            this.ctvCompany_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvCompany_type.Location = new System.Drawing.Point(422, 44);
            this.ctvCompany_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvCompany_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvCompany_type.Name = "ctvCompany_type";
            this.ctvCompany_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvCompany_type.ShowSelectedAllCheckBox = false;
            this.ctvCompany_type.Size = new System.Drawing.Size(158, 29);
            this.ctvCompany_type.TabIndex = 307;
            this.ctvCompany_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvCompany_type.Watermark = "";
            // 
            // tbInsure_person_count_From
            // 
            this.tbInsure_person_count_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbInsure_person_count_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInsure_person_count_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInsure_person_count_From.Location = new System.Drawing.Point(720, 149);
            this.tbInsure_person_count_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInsure_person_count_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbInsure_person_count_From.Name = "tbInsure_person_count_From";
            this.tbInsure_person_count_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbInsure_person_count_From.ShowText = false;
            this.tbInsure_person_count_From.Size = new System.Drawing.Size(119, 29);
            this.tbInsure_person_count_From.TabIndex = 219;
            this.tbInsure_person_count_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbInsure_person_count_From.Watermark = "";
            // 
            // cbCompany_status
            // 
            this.cbCompany_status.DataSource = null;
            this.cbCompany_status.FillColor = System.Drawing.Color.White;
            this.cbCompany_status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCompany_status.Location = new System.Drawing.Point(1155, 114);
            this.cbCompany_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCompany_status.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCompany_status.Name = "cbCompany_status";
            this.cbCompany_status.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCompany_status.Size = new System.Drawing.Size(160, 29);
            this.cbCompany_status.TabIndex = 153;
            this.cbCompany_status.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCompany_status.Watermark = "";
            // 
            // cbIs_top_company
            // 
            this.cbIs_top_company.DataSource = null;
            this.cbIs_top_company.FillColor = System.Drawing.Color.White;
            this.cbIs_top_company.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_top_company.Location = new System.Drawing.Point(1155, 79);
            this.cbIs_top_company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_top_company.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_top_company.Name = "cbIs_top_company";
            this.cbIs_top_company.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_top_company.Size = new System.Drawing.Size(160, 29);
            this.cbIs_top_company.TabIndex = 153;
            this.cbIs_top_company.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_top_company.Watermark = "";
            // 
            // dpEstablish_date_To
            // 
            this.dpEstablish_date_To.CanEmpty = true;
            this.dpEstablish_date_To.FillColor = System.Drawing.Color.White;
            this.dpEstablish_date_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEstablish_date_To.Location = new System.Drawing.Point(861, 114);
            this.dpEstablish_date_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEstablish_date_To.MaxLength = 10;
            this.dpEstablish_date_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEstablish_date_To.Name = "dpEstablish_date_To";
            this.dpEstablish_date_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEstablish_date_To.Size = new System.Drawing.Size(120, 29);
            this.dpEstablish_date_To.SymbolDropDown = 61555;
            this.dpEstablish_date_To.SymbolNormal = 61555;
            this.dpEstablish_date_To.TabIndex = 255;
            this.dpEstablish_date_To.Text = "2023-08-25";
            this.dpEstablish_date_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEstablish_date_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpEstablish_date_To.Watermark = "";
            // 
            // dpEstablish_date_From
            // 
            this.dpEstablish_date_From.CanEmpty = true;
            this.dpEstablish_date_From.FillColor = System.Drawing.Color.White;
            this.dpEstablish_date_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpEstablish_date_From.Location = new System.Drawing.Point(720, 114);
            this.dpEstablish_date_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEstablish_date_From.MaxLength = 10;
            this.dpEstablish_date_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEstablish_date_From.Name = "dpEstablish_date_From";
            this.dpEstablish_date_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEstablish_date_From.Size = new System.Drawing.Size(119, 29);
            this.dpEstablish_date_From.SymbolDropDown = 61555;
            this.dpEstablish_date_From.SymbolNormal = 61555;
            this.dpEstablish_date_From.TabIndex = 254;
            this.dpEstablish_date_From.Text = "1900-01-01";
            this.dpEstablish_date_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEstablish_date_From.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpEstablish_date_From.Watermark = "";
            // 
            // dpLicense_date_To
            // 
            this.dpLicense_date_To.CanEmpty = true;
            this.dpLicense_date_To.FillColor = System.Drawing.Color.White;
            this.dpLicense_date_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpLicense_date_To.Location = new System.Drawing.Point(861, 79);
            this.dpLicense_date_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpLicense_date_To.MaxLength = 10;
            this.dpLicense_date_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpLicense_date_To.Name = "dpLicense_date_To";
            this.dpLicense_date_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpLicense_date_To.Size = new System.Drawing.Size(120, 29);
            this.dpLicense_date_To.SymbolDropDown = 61555;
            this.dpLicense_date_To.SymbolNormal = 61555;
            this.dpLicense_date_To.TabIndex = 255;
            this.dpLicense_date_To.Text = "2023-08-25";
            this.dpLicense_date_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpLicense_date_To.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpLicense_date_To.Watermark = "";
            // 
            // dpLicense_date_From
            // 
            this.dpLicense_date_From.CanEmpty = true;
            this.dpLicense_date_From.FillColor = System.Drawing.Color.White;
            this.dpLicense_date_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpLicense_date_From.Location = new System.Drawing.Point(720, 79);
            this.dpLicense_date_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpLicense_date_From.MaxLength = 10;
            this.dpLicense_date_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpLicense_date_From.Name = "dpLicense_date_From";
            this.dpLicense_date_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpLicense_date_From.Size = new System.Drawing.Size(119, 29);
            this.dpLicense_date_From.SymbolDropDown = 61555;
            this.dpLicense_date_From.SymbolNormal = 61555;
            this.dpLicense_date_From.TabIndex = 254;
            this.dpLicense_date_From.Text = "1900-01-01";
            this.dpLicense_date_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpLicense_date_From.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dpLicense_date_From.Watermark = "";
            // 
            // uiLabel14
            // 
            this.uiLabel14.AutoSize = true;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel14.Location = new System.Drawing.Point(1222, 149);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(24, 31);
            this.uiLabel14.TabIndex = 252;
            this.uiLabel14.Text = "-";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(835, 149);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(24, 31);
            this.uiLabel12.TabIndex = 252;
            this.uiLabel12.Text = "-";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(484, 149);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(24, 31);
            this.uiLabel4.TabIndex = 252;
            this.uiLabel4.Text = "-";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOutput_To
            // 
            this.tbOutput_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput_To.Location = new System.Drawing.Point(1254, 149);
            this.tbOutput_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput_To.Name = "tbOutput_To";
            this.tbOutput_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput_To.ShowText = false;
            this.tbOutput_To.Size = new System.Drawing.Size(62, 29);
            this.tbOutput_To.TabIndex = 225;
            this.tbOutput_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput_To.Watermark = "";
            // 
            // tbOutput_From
            // 
            this.tbOutput_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOutput_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOutput_From.Location = new System.Drawing.Point(1155, 149);
            this.tbOutput_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOutput_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOutput_From.Name = "tbOutput_From";
            this.tbOutput_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbOutput_From.ShowText = false;
            this.tbOutput_From.Size = new System.Drawing.Size(62, 29);
            this.tbOutput_From.TabIndex = 219;
            this.tbOutput_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOutput_From.Watermark = "";
            // 
            // tbInsure_person_count_To
            // 
            this.tbInsure_person_count_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbInsure_person_count_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInsure_person_count_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbInsure_person_count_To.Location = new System.Drawing.Point(861, 149);
            this.tbInsure_person_count_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInsure_person_count_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbInsure_person_count_To.Name = "tbInsure_person_count_To";
            this.tbInsure_person_count_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbInsure_person_count_To.ShowText = false;
            this.tbInsure_person_count_To.Size = new System.Drawing.Size(120, 29);
            this.tbInsure_person_count_To.TabIndex = 225;
            this.tbInsure_person_count_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbInsure_person_count_To.Watermark = "";
            // 
            // tbStaff_size_To
            // 
            this.tbStaff_size_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbStaff_size_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaff_size_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStaff_size_To.Location = new System.Drawing.Point(518, 149);
            this.tbStaff_size_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStaff_size_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbStaff_size_To.Name = "tbStaff_size_To";
            this.tbStaff_size_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbStaff_size_To.ShowText = false;
            this.tbStaff_size_To.Size = new System.Drawing.Size(62, 29);
            this.tbStaff_size_To.TabIndex = 225;
            this.tbStaff_size_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbStaff_size_To.Watermark = "";
            // 
            // tbStaff_size_From
            // 
            this.tbStaff_size_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbStaff_size_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaff_size_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStaff_size_From.Location = new System.Drawing.Point(421, 149);
            this.tbStaff_size_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStaff_size_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbStaff_size_From.Name = "tbStaff_size_From";
            this.tbStaff_size_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbStaff_size_From.ShowText = false;
            this.tbStaff_size_From.Size = new System.Drawing.Size(62, 29);
            this.tbStaff_size_From.TabIndex = 219;
            this.tbStaff_size_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbStaff_size_From.Watermark = "";
            // 
            // tbCompany_address
            // 
            this.tbCompany_address.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_address.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_address.Location = new System.Drawing.Point(720, 44);
            this.tbCompany_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_address.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_address.Name = "tbCompany_address";
            this.tbCompany_address.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_address.ShowText = false;
            this.tbCompany_address.Size = new System.Drawing.Size(261, 29);
            this.tbCompany_address.TabIndex = 162;
            this.tbCompany_address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_address.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(1015, 114);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(158, 31);
            this.uiLabel11.TabIndex = 154;
            this.uiLabel11.Text = "企业经营状态";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(1015, 79);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(158, 31);
            this.uiLabel3.TabIndex = 154;
            this.uiLabel3.Text = "是否龙头企业";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(1015, 184);
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
            this.uiLabel26.Location = new System.Drawing.Point(618, 184);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(110, 31);
            this.uiLabel26.TabIndex = 155;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTaxpayer_qualification
            // 
            this.cbTaxpayer_qualification.DataSource = null;
            this.cbTaxpayer_qualification.FillColor = System.Drawing.Color.White;
            this.cbTaxpayer_qualification.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTaxpayer_qualification.Location = new System.Drawing.Point(422, 184);
            this.cbTaxpayer_qualification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTaxpayer_qualification.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTaxpayer_qualification.Name = "cbTaxpayer_qualification";
            this.cbTaxpayer_qualification.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTaxpayer_qualification.Size = new System.Drawing.Size(158, 29);
            this.cbTaxpayer_qualification.TabIndex = 153;
            this.cbTaxpayer_qualification.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTaxpayer_qualification.Watermark = "";
            // 
            // cbVillage
            // 
            this.cbVillage.DataSource = null;
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(1156, 184);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(159, 29);
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
            this.uiLabel2.Size = new System.Drawing.Size(110, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "企业名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(304, 184);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(134, 31);
            this.uiLabel9.TabIndex = 113;
            this.uiLabel9.Text = "纳税人资质";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(33, 184);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(158, 31);
            this.uiLabel8.TabIndex = 113;
            this.uiLabel8.Text = "纳税人识别号";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(618, 44);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(110, 31);
            this.uiLabel6.TabIndex = 113;
            this.uiLabel6.Text = "企业地址";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(1015, 149);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(126, 31);
            this.uiLabel7.TabIndex = 113;
            this.uiLabel7.Text = "产值(万元)";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(618, 149);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 31);
            this.label15.TabIndex = 113;
            this.label15.Text = "参保人数";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(304, 44);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(110, 31);
            this.uiLabel5.TabIndex = 108;
            this.uiLabel5.Text = "企业类型";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 31);
            this.label12.TabIndex = 102;
            this.label12.Text = "法人姓名";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1322, 130);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(79, 37);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1322, 87);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(79, 37);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(618, 79);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 200;
            this.uiLabel1.Text = "营业执照日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(215, 268);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 50);
            this.btDelete.TabIndex = 102;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // frmCompanyList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btDelete);
            this.Name = "frmCompanyList";
            this.Text = "frmCompanyList";
            this.Load += new System.EventHandler(this.frmCompanyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyList)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIDataGridView dgCompanyList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UITextBox tbLegal_idcard;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIPagination pagination;
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
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbLegal_name;
        private Sunny.UI.UITextBox tbCompany_name;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboBox cbCompany_status;
        private Sunny.UI.UIComboBox cbIs_top_company;
        private Sunny.UI.UIDatePicker dpEstablish_date_To;
        private Sunny.UI.UIDatePicker dpEstablish_date_From;
        private Sunny.UI.UIDatePicker dpLicense_date_To;
        private Sunny.UI.UIDatePicker dpLicense_date_From;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox tbOutput_To;
        private Sunny.UI.UITextBox tbOutput_From;
        private Sunny.UI.UITextBox tbInsure_person_count_To;
        private Sunny.UI.UITextBox tbInsure_person_count_From;
        private Sunny.UI.UITextBox tbStaff_size_To;
        private Sunny.UI.UITextBox tbStaff_size_From;
        private Sunny.UI.UITextBox tbCompany_address;
        private Sunny.UI.UITextBox tbCompany_phone;
        private Sunny.UI.UIComboBox cbTaxpayer_qualification;
        private Sunny.UI.UIComboTreeView ctvCompany_type;
    }
}