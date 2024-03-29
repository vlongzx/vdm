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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pagination = new Sunny.UI.UIPagination();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiComboBox3 = new Sunny.UI.UIComboBox();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.btDelete = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btExport = new Sunny.UI.UIButton();
            this.btImport = new Sunny.UI.UIButton();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.btSearch = new Sunny.UI.UIButton();
            this.dpBirthday_From = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time_from = new Sunny.UI.UIDatePicker();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.tbPeople_name = new Sunny.UI.UITextBox();
            this.btAdanceSearch = new Sunny.UI.UIButton();
            this.cbMarital_status = new Sunny.UI.UIComboBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.tbSkill_type = new Sunny.UI.UITextBox();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dpBirthday_To = new Sunny.UI.UIDatePicker();
            this.dpJoin_party_time_to = new Sunny.UI.UIDatePicker();
            this.cbPolitcal_outlook = new Sunny.UI.UIComboBox();
            this.cbEducation = new Sunny.UI.UIComboBox();
            this.cbSex = new Sunny.UI.UIComboBox();
            this.cbNation = new Sunny.UI.UIComboBox();
            this.cbRelationship = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.label13 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.dgPeopleList = new Sunny.UI.UIDataGridView();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeopleList)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagination
            // 
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
            // uiTextBox1
            // 
            this.uiTextBox1.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(276, 44);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(165, 29);
            this.uiTextBox1.TabIndex = 75;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // uiComboBox3
            // 
            this.uiComboBox3.DataSource = null;
            this.uiComboBox3.FillColor = System.Drawing.Color.White;
            this.uiComboBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox3.Location = new System.Drawing.Point(657, 44);
            this.uiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox3.Name = "uiComboBox3";
            this.uiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox3.Size = new System.Drawing.Size(165, 29);
            this.uiComboBox3.TabIndex = 76;
            this.uiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox3.Watermark = "";
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.DataSource = null;
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox2.Location = new System.Drawing.Point(1010, 44);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(165, 30);
            this.uiComboBox2.TabIndex = 77;
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox2.Watermark = "";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.Location = new System.Drawing.Point(1010, 90);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(165, 29);
            this.uiComboBox1.TabIndex = 78;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiDatePicker2
            // 
            this.uiDatePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatePicker2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatePicker2.Location = new System.Drawing.Point(276, 90);
            this.uiDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker2.MaxLength = 10;
            this.uiDatePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker2.Name = "uiDatePicker2";
            this.uiDatePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker2.Size = new System.Drawing.Size(165, 29);
            this.uiDatePicker2.SymbolDropDown = 61555;
            this.uiDatePicker2.SymbolNormal = 61555;
            this.uiDatePicker2.TabIndex = 79;
            this.uiDatePicker2.Text = "1900-01-01";
            this.uiDatePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker2.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.uiDatePicker2.Watermark = "";
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatePicker1.Location = new System.Drawing.Point(657, 89);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(165, 29);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 80;
            this.uiDatePicker1.Text = "2023-08-25";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.uiDatePicker1.Watermark = "";
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(239, 225);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 48);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(130, 225);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(96, 48);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(21, 225);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 48);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(457, 225);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(96, 48);
            this.btExport.TabIndex = 6;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(348, 225);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(96, 48);
            this.btImport.TabIndex = 6;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.dpBirthday_From);
            this.gbSearch.Controls.Add(this.dpJoin_party_time_from);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.tbPeople_name);
            this.gbSearch.Controls.Add(this.btAdanceSearch);
            this.gbSearch.Controls.Add(this.cbMarital_status);
            this.gbSearch.Controls.Add(this.uiLabel24);
            this.gbSearch.Controls.Add(this.uiLabel23);
            this.gbSearch.Controls.Add(this.tbSkill_type);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.dpBirthday_To);
            this.gbSearch.Controls.Add(this.dpJoin_party_time_to);
            this.gbSearch.Controls.Add(this.cbPolitcal_outlook);
            this.gbSearch.Controls.Add(this.cbEducation);
            this.gbSearch.Controls.Add(this.cbSex);
            this.gbSearch.Controls.Add(this.cbNation);
            this.gbSearch.Controls.Add(this.cbRelationship);
            this.gbSearch.Controls.Add(this.tbPhone_number);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label15);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.label13);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(19, 29);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1888, 188);
            this.gbSearch.TabIndex = 10;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gbSearch.Click += new System.EventHandler(this.uiGroupBox1_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1247, 43);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(96, 40);
            this.btSearch.TabIndex = 62;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dpBirthday_From
            // 
            this.dpBirthday_From.FillColor = System.Drawing.Color.White;
            this.dpBirthday_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_From.Location = new System.Drawing.Point(139, 78);
            this.dpBirthday_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_From.MaxLength = 10;
            this.dpBirthday_From.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_From.Name = "dpBirthday_From";
            this.dpBirthday_From.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_From.Size = new System.Drawing.Size(165, 29);
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
            this.dpJoin_party_time_from.Location = new System.Drawing.Point(139, 114);
            this.dpJoin_party_time_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_from.MaxLength = 10;
            this.dpJoin_party_time_from.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_from.Name = "dpJoin_party_time_from";
            this.dpJoin_party_time_from.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_from.Size = new System.Drawing.Size(165, 29);
            this.dpJoin_party_time_from.SymbolDropDown = 61555;
            this.dpJoin_party_time_from.SymbolNormal = 61555;
            this.dpJoin_party_time_from.TabIndex = 141;
            this.dpJoin_party_time_from.Text = "2023-08-25";
            this.dpJoin_party_time_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_from.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_from.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(139, 149);
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
            // tbPeople_name
            // 
            this.tbPeople_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPeople_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPeople_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPeople_name.Location = new System.Drawing.Point(139, 43);
            this.tbPeople_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPeople_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPeople_name.Name = "tbPeople_name";
            this.tbPeople_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbPeople_name.ShowText = false;
            this.tbPeople_name.Size = new System.Drawing.Size(165, 29);
            this.tbPeople_name.TabIndex = 130;
            this.tbPeople_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPeople_name.Watermark = "";
            // 
            // btAdanceSearch
            // 
            this.btAdanceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdanceSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdanceSearch.Location = new System.Drawing.Point(1247, 137);
            this.btAdanceSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdanceSearch.Name = "btAdanceSearch";
            this.btAdanceSearch.Size = new System.Drawing.Size(96, 40);
            this.btAdanceSearch.TabIndex = 62;
            this.btAdanceSearch.Text = "高级查询(&Q)";
            this.btAdanceSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdanceSearch.Click += new System.EventHandler(this.btAdanceSearch_Click);
            // 
            // cbMarital_status
            // 
            this.cbMarital_status.DataSource = null;
            this.cbMarital_status.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbMarital_status.FillColor = System.Drawing.Color.White;
            this.cbMarital_status.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbMarital_status.Location = new System.Drawing.Point(1040, 78);
            this.cbMarital_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMarital_status.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbMarital_status.Name = "cbMarital_status";
            this.cbMarital_status.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbMarital_status.Size = new System.Drawing.Size(200, 29);
            this.cbMarital_status.TabIndex = 88;
            this.cbMarital_status.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbMarital_status.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.AutoSize = true;
            this.uiLabel24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel24.Location = new System.Drawing.Point(963, 113);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(146, 41);
            this.uiLabel24.TabIndex = 165;
            this.uiLabel24.Text = "最高学历";
            this.uiLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(963, 42);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(82, 41);
            this.uiLabel23.TabIndex = 163;
            this.uiLabel23.Text = "性别";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSkill_type
            // 
            this.tbSkill_type.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSkill_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSkill_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSkill_type.Location = new System.Drawing.Point(729, 114);
            this.tbSkill_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSkill_type.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSkill_type.Name = "tbSkill_type";
            this.tbSkill_type.Padding = new System.Windows.Forms.Padding(5);
            this.tbSkill_type.ShowText = false;
            this.tbSkill_type.Size = new System.Drawing.Size(200, 29);
            this.tbSkill_type.TabIndex = 162;
            this.tbSkill_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSkill_type.Watermark = "";
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(963, 148);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(114, 41);
            this.uiLabel25.TabIndex = 154;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(652, 148);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(146, 41);
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
            this.cbTown.Location = new System.Drawing.Point(729, 149);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(200, 29);
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
            this.cbVillage.Location = new System.Drawing.Point(1040, 149);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(200, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(346, 77);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(72, 41);
            this.uiLabel3.TabIndex = 147;
            this.uiLabel3.Text = "(到)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(36, 77);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 41);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "出生日期(从)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(36, 42);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(82, 41);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpBirthday_To
            // 
            this.dpBirthday_To.FillColor = System.Drawing.Color.White;
            this.dpBirthday_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday_To.Location = new System.Drawing.Point(443, 78);
            this.dpBirthday_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday_To.MaxLength = 10;
            this.dpBirthday_To.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday_To.Name = "dpBirthday_To";
            this.dpBirthday_To.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday_To.Size = new System.Drawing.Size(165, 29);
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
            this.dpJoin_party_time_to.Location = new System.Drawing.Point(443, 114);
            this.dpJoin_party_time_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpJoin_party_time_to.MaxLength = 10;
            this.dpJoin_party_time_to.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpJoin_party_time_to.Name = "dpJoin_party_time_to";
            this.dpJoin_party_time_to.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpJoin_party_time_to.Size = new System.Drawing.Size(165, 29);
            this.dpJoin_party_time_to.SymbolDropDown = 61555;
            this.dpJoin_party_time_to.SymbolNormal = 61555;
            this.dpJoin_party_time_to.TabIndex = 143;
            this.dpJoin_party_time_to.Text = "2023-08-25";
            this.dpJoin_party_time_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpJoin_party_time_to.Value = new System.DateTime(2023, 8, 25, 20, 18, 35, 482);
            this.dpJoin_party_time_to.Watermark = "";
            // 
            // cbPolitcal_outlook
            // 
            this.cbPolitcal_outlook.DataSource = null;
            this.cbPolitcal_outlook.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPolitcal_outlook.FillColor = System.Drawing.Color.White;
            this.cbPolitcal_outlook.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPolitcal_outlook.Location = new System.Drawing.Point(729, 78);
            this.cbPolitcal_outlook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPolitcal_outlook.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPolitcal_outlook.Name = "cbPolitcal_outlook";
            this.cbPolitcal_outlook.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPolitcal_outlook.Size = new System.Drawing.Size(200, 29);
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
            this.cbEducation.Location = new System.Drawing.Point(1040, 114);
            this.cbEducation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEducation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbEducation.Size = new System.Drawing.Size(200, 29);
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
            this.cbSex.Location = new System.Drawing.Point(1040, 43);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSex.Size = new System.Drawing.Size(200, 29);
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
            this.cbNation.Location = new System.Drawing.Point(729, 43);
            this.cbNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbNation.Name = "cbNation";
            this.cbNation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbNation.Size = new System.Drawing.Size(200, 29);
            this.cbNation.TabIndex = 135;
            this.cbNation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNation.Watermark = "";
            // 
            // cbRelationship
            // 
            this.cbRelationship.DataSource = null;
            this.cbRelationship.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbRelationship.FillColor = System.Drawing.Color.White;
            this.cbRelationship.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRelationship.Location = new System.Drawing.Point(443, 43);
            this.cbRelationship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRelationship.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbRelationship.Size = new System.Drawing.Size(165, 29);
            this.cbRelationship.TabIndex = 134;
            this.cbRelationship.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRelationship.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(443, 149);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(652, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 41);
            this.label9.TabIndex = 116;
            this.label9.Text = "政治面貌";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 115;
            this.label3.Text = "民族";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 41);
            this.label2.TabIndex = 114;
            this.label2.Text = "与户主关系";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(963, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 41);
            this.label15.TabIndex = 113;
            this.label15.Text = "婚姻状况";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 41);
            this.label10.TabIndex = 111;
            this.label10.Text = "入党时间(从)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(652, 113);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(146, 41);
            this.uiLabel4.TabIndex = 108;
            this.uiLabel4.Text = "技能类型";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 41);
            this.label13.TabIndex = 104;
            this.label13.Text = "联系电话";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 41);
            this.label12.TabIndex = 102;
            this.label12.Text = "身份证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 41);
            this.label8.TabIndex = 101;
            this.label8.Text = "(到)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1247, 89);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(96, 40);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // dgPeopleList
            // 
            this.dgPeopleList.AllowUserToAddRows = false;
            this.dgPeopleList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPeopleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgPeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPeopleList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPeopleList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPeopleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeopleList.EnableHeadersVisualStyles = false;
            this.dgPeopleList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgPeopleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgPeopleList.Location = new System.Drawing.Point(4, 32);
            this.dgPeopleList.MultiSelect = false;
            this.dgPeopleList.Name = "dgPeopleList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPeopleList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgPeopleList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgPeopleList.RowTemplate.Height = 23;
            this.dgPeopleList.ScrollBarHandleWidth = 40;
            this.dgPeopleList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgPeopleList.SelectedIndex = -1;
            this.dgPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeopleList.Size = new System.Drawing.Size(1875, 706);
            this.dgPeopleList.TabIndex = 7;
            this.dgPeopleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeopleList_CellContentClick);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgPeopleList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(24, 280);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1883, 742);
            this.gbResult.TabIndex = 5;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPeopleList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pagination);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPeopleList";
            this.Text = "人员信息管理";
            this.Initialize += new System.EventHandler(this.frmPeopleList_Initialize);
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeopleList)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIComboBox uiComboBox3;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UIButton btAdanceSearch;
        private Sunny.UI.UIComboBox cbMarital_status;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UITextBox tbSkill_type;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel3;
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
        private Sunny.UI.UIComboBox cbRelationship;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UITextBox tbPeople_name;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIDataGridView dgPeopleList;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIButton btSearch;
    }
}