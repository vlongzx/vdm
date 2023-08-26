﻿namespace com.vdm.form
{
    partial class frmPeopleList
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
            this.groupBox2 = new Sunny.UI.UIGroupBox();
            this.dgPeopleList = new Sunny.UI.UIDataGridView();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.btImport = new Sunny.UI.UIButton();
            this.btExport = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.dpJoin_party_time_to = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time_from = new Sunny.UI.UIDatePicker();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.cbReligious_belief = new Sunny.UI.UIComboBox();
            this.cbPolitcal_outlook = new Sunny.UI.UIComboBox();
            this.cbEducation = new Sunny.UI.UIComboBox();
            this.cbSex = new Sunny.UI.UIComboBox();
            this.cbNation = new Sunny.UI.UIComboBox();
            this.cbRelationship = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbPeople_name = new Sunny.UI.UITextBox();
            this.label4 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.label14 = new Sunny.UI.UILabel();
            this.label13 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.dpBirthday_From = new Sunny.UI.UIDatePicker();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.label12 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.dpBirthday_To = new Sunny.UI.UIDatePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgPeopleList);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(16, 345);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1891, 683);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据列表";
            this.groupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPeopleList
            // 
            this.dgPeopleList.AllowUserToAddRows = false;
            this.dgPeopleList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPeopleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPeopleList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeopleList.EnableHeadersVisualStyles = false;
            this.dgPeopleList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgPeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgPeopleList.Location = new System.Drawing.Point(4, 32);
            this.dgPeopleList.Name = "dgPeopleList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgPeopleList.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgPeopleList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPeopleList.RowTemplate.Height = 23;
            this.dgPeopleList.ScrollBarHandleWidth = 40;
            this.dgPeopleList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgPeopleList.SelectedIndex = -1;
            this.dgPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeopleList.Size = new System.Drawing.Size(1883, 647);
            this.dgPeopleList.TabIndex = 7;
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(16, 266);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 62);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(176, 266);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(154, 62);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(336, 266);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(154, 62);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(496, 266);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(154, 62);
            this.btImport.TabIndex = 6;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(656, 266);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 62);
            this.btExport.TabIndex = 6;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
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
            this.pagination.TabIndex = 9;
            this.pagination.Text = "uiDataGridPage1";
            this.pagination.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pagination.TotalCount = 40000;
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
            // 
            // dpJoin_party_time_to
            // 
            this.dpJoin_party_time_to.FillColor = System.Drawing.Color.White;
            this.dpJoin_party_time_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpJoin_party_time_to.Location = new System.Drawing.Point(590, 140);
            this.dpJoin_party_time_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_to.MaxLength = 10;
            this.dpJoin_party_time_to.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_to.Name = "dpJoin_party_time_to";
            this.dpJoin_party_time_to.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_to.Size = new System.Drawing.Size(165, 29);
            this.dpJoin_party_time_to.SymbolDropDown = 61555;
            this.dpJoin_party_time_to.SymbolNormal = 61555;
            this.dpJoin_party_time_to.TabIndex = 37;
            this.dpJoin_party_time_to.Text = "2023-08-25";
            this.dpJoin_party_time_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_to.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_to.Watermark = "";
            // 
            // dpJoin_party_time_from
            // 
            this.dpJoin_party_time_from.FillColor = System.Drawing.Color.White;
            this.dpJoin_party_time_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpJoin_party_time_from.Location = new System.Drawing.Point(590, 101);
            this.dpJoin_party_time_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_from.MaxLength = 10;
            this.dpJoin_party_time_from.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_from.Name = "dpJoin_party_time_from";
            this.dpJoin_party_time_from.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_from.Size = new System.Drawing.Size(165, 29);
            this.dpJoin_party_time_from.SymbolDropDown = 61555;
            this.dpJoin_party_time_from.SymbolNormal = 61555;
            this.dpJoin_party_time_from.TabIndex = 35;
            this.dpJoin_party_time_from.Text = "2023-08-25";
            this.dpJoin_party_time_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_from.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_from.Watermark = "";
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1705, 93);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(154, 62);
            this.btReset.TabIndex = 33;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1534, 93);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(154, 62);
            this.btSearch.TabIndex = 32;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // cbReligious_belief
            // 
            this.cbReligious_belief.DataSource = null;
            this.cbReligious_belief.FillColor = System.Drawing.Color.White;
            this.cbReligious_belief.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbReligious_belief.Location = new System.Drawing.Point(922, 189);
            this.cbReligious_belief.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbReligious_belief.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbReligious_belief.Name = "cbReligious_belief";
            this.cbReligious_belief.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbReligious_belief.Size = new System.Drawing.Size(165, 29);
            this.cbReligious_belief.TabIndex = 31;
            this.cbReligious_belief.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbReligious_belief.Watermark = "";
            // 
            // cbPolitcal_outlook
            // 
            this.cbPolitcal_outlook.DataSource = null;
            this.cbPolitcal_outlook.FillColor = System.Drawing.Color.White;
            this.cbPolitcal_outlook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPolitcal_outlook.Location = new System.Drawing.Point(922, 101);
            this.cbPolitcal_outlook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPolitcal_outlook.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPolitcal_outlook.Name = "cbPolitcal_outlook";
            this.cbPolitcal_outlook.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPolitcal_outlook.Size = new System.Drawing.Size(165, 29);
            this.cbPolitcal_outlook.TabIndex = 30;
            this.cbPolitcal_outlook.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPolitcal_outlook.Watermark = "";
            // 
            // cbEducation
            // 
            this.cbEducation.DataSource = null;
            this.cbEducation.FillColor = System.Drawing.Color.White;
            this.cbEducation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbEducation.Location = new System.Drawing.Point(1243, 184);
            this.cbEducation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEducation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbEducation.Size = new System.Drawing.Size(165, 29);
            this.cbEducation.TabIndex = 29;
            this.cbEducation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEducation.Watermark = "";
            // 
            // cbSex
            // 
            this.cbSex.DataSource = null;
            this.cbSex.FillColor = System.Drawing.Color.White;
            this.cbSex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSex.Location = new System.Drawing.Point(1243, 44);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSex.Size = new System.Drawing.Size(165, 29);
            this.cbSex.TabIndex = 28;
            this.cbSex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSex.Watermark = "";
            // 
            // cbNation
            // 
            this.cbNation.DataSource = null;
            this.cbNation.FillColor = System.Drawing.Color.White;
            this.cbNation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbNation.Location = new System.Drawing.Point(887, 43);
            this.cbNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNation.Name = "cbNation";
            this.cbNation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNation.Size = new System.Drawing.Size(165, 30);
            this.cbNation.TabIndex = 27;
            this.cbNation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNation.Watermark = "";
            // 
            // cbRelationship
            // 
            this.cbRelationship.DataSource = null;
            this.cbRelationship.FillColor = System.Drawing.Color.White;
            this.cbRelationship.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRelationship.Location = new System.Drawing.Point(590, 50);
            this.cbRelationship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRelationship.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbRelationship.Size = new System.Drawing.Size(165, 29);
            this.cbRelationship.TabIndex = 26;
            this.cbRelationship.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRelationship.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(582, 196);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 25;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbPeople_name
            // 
            this.tbPeople_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPeople_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPeople_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPeople_name.Location = new System.Drawing.Point(137, 59);
            this.tbPeople_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPeople_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPeople_name.Name = "tbPeople_name";
            this.tbPeople_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbPeople_name.ShowText = false;
            this.tbPeople_name.Size = new System.Drawing.Size(165, 29);
            this.tbPeople_name.TabIndex = 23;
            this.tbPeople_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPeople_name.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1121, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 41);
            this.label4.TabIndex = 21;
            this.label4.Text = "性别：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(770, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 41);
            this.label9.TabIndex = 20;
            this.label9.Text = "政治面貌：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "民族：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "与户主关系：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1121, 170);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 41);
            this.label15.TabIndex = 17;
            this.label15.Text = "学历：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(770, 184);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 41);
            this.label14.TabIndex = 15;
            this.label14.Text = "宗教信仰：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(428, 184);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 41);
            this.label13.TabIndex = 14;
            this.label13.Text = "联系电话：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(48, 50);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 41);
            this.uiLabel2.TabIndex = 39;
            this.uiLabel2.Text = "姓名:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(24, 96);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 41);
            this.uiLabel1.TabIndex = 40;
            this.uiLabel1.Text = "出生日期(从)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(152, 140);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(72, 41);
            this.uiLabel3.TabIndex = 41;
            this.uiLabel3.Text = "(到)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpBirthday_From
            // 
            this.dpBirthday_From.AutoSize = true;
            this.dpBirthday_From.FillColor = System.Drawing.Color.White;
            this.dpBirthday_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_From.Location = new System.Drawing.Point(222, 96);
            this.dpBirthday_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_From.MaxLength = 10;
            this.dpBirthday_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_From.Name = "dpBirthday_From";
            this.dpBirthday_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_From.Size = new System.Drawing.Size(171, 52);
            this.dpBirthday_From.SymbolDropDown = 61555;
            this.dpBirthday_From.SymbolNormal = 61555;
            this.dpBirthday_From.TabIndex = 43;
            this.dpBirthday_From.Text = "2023-08-26";
            this.dpBirthday_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday_From.Value = new System.DateTime(2023, 8, 26, 12, 2, 48, 667);
            this.dpBirthday_From.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(209, 201);
            this.tbIdcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdcard.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Padding = new System.Windows.Forms.Padding(5);
            this.tbIdcard.ShowText = false;
            this.tbIdcard.Size = new System.Drawing.Size(165, 29);
            this.tbIdcard.TabIndex = 24;
            this.tbIdcard.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbIdcard.Watermark = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 189);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 41);
            this.label12.TabIndex = 13;
            this.label12.Text = "身份证号：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 41);
            this.label8.TabIndex = 12;
            this.label8.Text = "(到)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 41);
            this.label10.TabIndex = 16;
            this.label10.Text = "入党时间(从)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpBirthday_To
            // 
            this.dpBirthday_To.AutoSize = true;
            this.dpBirthday_To.FillColor = System.Drawing.Color.White;
            this.dpBirthday_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_To.Location = new System.Drawing.Point(222, 147);
            this.dpBirthday_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_To.MaxLength = 10;
            this.dpBirthday_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_To.Name = "dpBirthday_To";
            this.dpBirthday_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_To.Size = new System.Drawing.Size(171, 52);
            this.dpBirthday_To.SymbolDropDown = 61555;
            this.dpBirthday_To.SymbolNormal = 61555;
            this.dpBirthday_To.TabIndex = 44;
            this.dpBirthday_To.Text = "2023-08-26";
            this.dpBirthday_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday_To.Value = new System.DateTime(2023, 8, 26, 12, 2, 48, 667);
            this.dpBirthday_To.Watermark = "";
            // 
            // frmPeopleList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.dpBirthday_To);
            this.Controls.Add(this.dpBirthday_From);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.dpJoin_party_time_to);
            this.Controls.Add(this.dpJoin_party_time_from);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.cbReligious_belief);
            this.Controls.Add(this.cbPolitcal_outlook);
            this.Controls.Add(this.cbEducation);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbNation);
            this.Controls.Add(this.cbRelationship);
            this.Controls.Add(this.tbPhone_number);
            this.Controls.Add(this.tbIdcard);
            this.Controls.Add(this.tbPeople_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPeopleList";
            this.Text = "人员信息管理";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeopleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIGroupBox groupBox2;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIDataGridView dgPeopleList;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIDatePicker dpJoin_party_time_to;
        private Sunny.UI.UIDatePicker dpJoin_party_time_from;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIComboBox cbReligious_belief;
        private Sunny.UI.UIComboBox cbPolitcal_outlook;
        private Sunny.UI.UIComboBox cbEducation;
        private Sunny.UI.UIComboBox cbSex;
        private Sunny.UI.UIComboBox cbNation;
        private Sunny.UI.UIComboBox cbRelationship;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbPeople_name;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel label14;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDatePicker dpBirthday_From;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UIDatePicker dpBirthday_To;
    }
}