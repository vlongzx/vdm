namespace com.vdm.form
{
    partial class frmFamerList
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
            this.btImport = new Sunny.UI.UIButton();
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.dgFamerList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.btSearch = new Sunny.UI.UIButton();
            this.btReset = new Sunny.UI.UIButton();
            this.label12 = new Sunny.UI.UILabel();
            this.label13 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.btAdanceSearch = new Sunny.UI.UIButton();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.ctvMechine_type = new Sunny.UI.UIComboTreeView();
            this.ctvAnimal_area_type = new Sunny.UI.UIComboTreeView();
            this.ctvAnimal_type = new Sunny.UI.UIComboTreeView();
            this.ctvPlant_area_type = new Sunny.UI.UIComboTreeView();
            this.ctvPlant_type = new Sunny.UI.UIComboTreeView();
            this.cbIs_handle_process = new Sunny.UI.UIComboBox();
            this.tbCar_brand = new Sunny.UI.UITextBox();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tbHolder_name = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamerList)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(316, 183);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(96, 48);
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
            this.gbResult.Controls.Add(this.dgFamerList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(13, 238);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1888, 793);
            this.gbResult.TabIndex = 81;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgFamerList
            // 
            this.dgFamerList.AllowUserToAddRows = false;
            this.dgFamerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgFamerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgFamerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgFamerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFamerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgFamerList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFamerList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgFamerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFamerList.EnableHeadersVisualStyles = false;
            this.dgFamerList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgFamerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgFamerList.Location = new System.Drawing.Point(4, 32);
            this.dgFamerList.Name = "dgFamerList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFamerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgFamerList.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgFamerList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgFamerList.RowTemplate.Height = 23;
            this.dgFamerList.ScrollBarHandleWidth = 40;
            this.dgFamerList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgFamerList.SelectedIndex = -1;
            this.dgFamerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFamerList.Size = new System.Drawing.Size(1880, 757);
            this.dgFamerList.TabIndex = 8;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(422, 183);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(96, 48);
            this.btExport.TabIndex = 83;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(10, 183);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(96, 48);
            this.btAdd.TabIndex = 84;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(112, 183);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(96, 48);
            this.btEdit.TabIndex = 85;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(214, 183);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 48);
            this.btDelete.TabIndex = 86;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // pagination
            // 
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(5, 1031);
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
            this.pagination.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.pagination_PageChanged);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1287, 32);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 34);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1287, 68);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(94, 34);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 41);
            this.label12.TabIndex = 102;
            this.label12.Text = "身份证号";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(677, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 41);
            this.label13.TabIndex = 104;
            this.label13.Text = "联系电话";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(21, 71);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(210, 41);
            this.uiLabel4.TabIndex = 108;
            this.uiLabel4.Text = "农用机械类型";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(992, 32);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(210, 41);
            this.uiLabel5.TabIndex = 108;
            this.uiLabel5.Text = "家用车辆品牌";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(678, 71);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 41);
            this.label15.TabIndex = 113;
            this.label15.Text = "种植占地地类";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 41);
            this.label9.TabIndex = 116;
            this.label9.Text = "种植作物种类";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(992, 67);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(274, 41);
            this.uiLabel6.TabIndex = 113;
            this.uiLabel6.Text = "办理设施农用手续";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(21, 37);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(146, 41);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "户主姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel26
            // 
            this.uiLabel26.AutoSize = true;
            this.uiLabel26.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel26.Location = new System.Drawing.Point(678, 111);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(146, 41);
            this.uiLabel26.TabIndex = 155;
            this.uiLabel26.Text = "所在乡镇";
            this.uiLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel25
            // 
            this.uiLabel25.AutoSize = true;
            this.uiLabel25.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel25.Location = new System.Drawing.Point(992, 109);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(114, 41);
            this.uiLabel25.TabIndex = 154;
            this.uiLabel25.Text = "所在村";
            this.uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAdanceSearch
            // 
            this.btAdanceSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdanceSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdanceSearch.Location = new System.Drawing.Point(1287, 104);
            this.btAdanceSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdanceSearch.Name = "btAdanceSearch";
            this.btAdanceSearch.Size = new System.Drawing.Size(94, 34);
            this.btAdanceSearch.TabIndex = 62;
            this.btAdanceSearch.Text = "高级查询(&Q)";
            this.btAdanceSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdanceSearch.Click += new System.EventHandler(this.btAdanceSearch_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.ctvMechine_type);
            this.gbSearch.Controls.Add(this.ctvAnimal_area_type);
            this.gbSearch.Controls.Add(this.ctvAnimal_type);
            this.gbSearch.Controls.Add(this.ctvPlant_area_type);
            this.gbSearch.Controls.Add(this.ctvPlant_type);
            this.gbSearch.Controls.Add(this.btAdanceSearch);
            this.gbSearch.Controls.Add(this.cbIs_handle_process);
            this.gbSearch.Controls.Add(this.tbCar_brand);
            this.gbSearch.Controls.Add(this.uiLabel25);
            this.gbSearch.Controls.Add(this.uiLabel26);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.tbPhone_number);
            this.gbSearch.Controls.Add(this.tbIdcard);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.tbHolder_name);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label15);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.label13);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(8, 26);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1888, 149);
            this.gbSearch.TabIndex = 88;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctvMechine_type
            // 
            this.ctvMechine_type.CheckBoxes = true;
            this.ctvMechine_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvMechine_type.FillColor = System.Drawing.Color.White;
            this.ctvMechine_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvMechine_type.Location = new System.Drawing.Point(128, 73);
            this.ctvMechine_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvMechine_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvMechine_type.Name = "ctvMechine_type";
            this.ctvMechine_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvMechine_type.ShowSelectedAllCheckBox = false;
            this.ctvMechine_type.Size = new System.Drawing.Size(165, 29);
            this.ctvMechine_type.TabIndex = 309;
            this.ctvMechine_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvMechine_type.Watermark = "";
            // 
            // ctvAnimal_area_type
            // 
            this.ctvAnimal_area_type.CheckBoxes = true;
            this.ctvAnimal_area_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvAnimal_area_type.FillColor = System.Drawing.Color.White;
            this.ctvAnimal_area_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvAnimal_area_type.Location = new System.Drawing.Point(458, 113);
            this.ctvAnimal_area_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvAnimal_area_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvAnimal_area_type.Name = "ctvAnimal_area_type";
            this.ctvAnimal_area_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvAnimal_area_type.ShowSelectedAllCheckBox = false;
            this.ctvAnimal_area_type.Size = new System.Drawing.Size(158, 29);
            this.ctvAnimal_area_type.TabIndex = 308;
            this.ctvAnimal_area_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvAnimal_area_type.Watermark = "";
            // 
            // ctvAnimal_type
            // 
            this.ctvAnimal_type.CheckBoxes = true;
            this.ctvAnimal_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvAnimal_type.FillColor = System.Drawing.Color.White;
            this.ctvAnimal_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvAnimal_type.Location = new System.Drawing.Point(128, 113);
            this.ctvAnimal_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvAnimal_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvAnimal_type.Name = "ctvAnimal_type";
            this.ctvAnimal_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvAnimal_type.ShowSelectedAllCheckBox = false;
            this.ctvAnimal_type.Size = new System.Drawing.Size(165, 29);
            this.ctvAnimal_type.TabIndex = 309;
            this.ctvAnimal_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvAnimal_type.Watermark = "";
            // 
            // ctvPlant_area_type
            // 
            this.ctvPlant_area_type.CheckBoxes = true;
            this.ctvPlant_area_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvPlant_area_type.FillColor = System.Drawing.Color.White;
            this.ctvPlant_area_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvPlant_area_type.Location = new System.Drawing.Point(784, 70);
            this.ctvPlant_area_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvPlant_area_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvPlant_area_type.Name = "ctvPlant_area_type";
            this.ctvPlant_area_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvPlant_area_type.ShowSelectedAllCheckBox = false;
            this.ctvPlant_area_type.Size = new System.Drawing.Size(148, 29);
            this.ctvPlant_area_type.TabIndex = 310;
            this.ctvPlant_area_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvPlant_area_type.Watermark = "";
            // 
            // ctvPlant_type
            // 
            this.ctvPlant_type.CheckBoxes = true;
            this.ctvPlant_type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ctvPlant_type.FillColor = System.Drawing.Color.White;
            this.ctvPlant_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctvPlant_type.Location = new System.Drawing.Point(458, 71);
            this.ctvPlant_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctvPlant_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.ctvPlant_type.Name = "ctvPlant_type";
            this.ctvPlant_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ctvPlant_type.ShowSelectedAllCheckBox = false;
            this.ctvPlant_type.Size = new System.Drawing.Size(158, 29);
            this.ctvPlant_type.TabIndex = 311;
            this.ctvPlant_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctvPlant_type.Watermark = "";
            // 
            // cbIs_handle_process
            // 
            this.cbIs_handle_process.DataSource = null;
            this.cbIs_handle_process.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbIs_handle_process.FillColor = System.Drawing.Color.White;
            this.cbIs_handle_process.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_handle_process.Location = new System.Drawing.Point(1134, 68);
            this.cbIs_handle_process.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_handle_process.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_handle_process.Name = "cbIs_handle_process";
            this.cbIs_handle_process.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_handle_process.Size = new System.Drawing.Size(140, 29);
            this.cbIs_handle_process.TabIndex = 88;
            this.cbIs_handle_process.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_handle_process.Watermark = "";
            // 
            // tbCar_brand
            // 
            this.tbCar_brand.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCar_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCar_brand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCar_brand.Location = new System.Drawing.Point(1134, 31);
            this.tbCar_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCar_brand.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCar_brand.Name = "tbCar_brand";
            this.tbCar_brand.Padding = new System.Windows.Forms.Padding(5);
            this.tbCar_brand.ShowText = false;
            this.tbCar_brand.Size = new System.Drawing.Size(140, 29);
            this.tbCar_brand.TabIndex = 162;
            this.tbCar_brand.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCar_brand.Watermark = "";
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(784, 110);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(148, 29);
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
            this.cbVillage.Location = new System.Drawing.Point(1134, 107);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(140, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(784, 35);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(148, 29);
            this.tbPhone_number.TabIndex = 132;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbIdcard
            // 
            this.tbIdcard.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbIdcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdcard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(458, 36);
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
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(352, 114);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(210, 41);
            this.uiLabel3.TabIndex = 116;
            this.uiLabel3.Text = "养殖占地地类";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbHolder_name
            // 
            this.tbHolder_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbHolder_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHolder_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHolder_name.Location = new System.Drawing.Point(128, 37);
            this.tbHolder_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHolder_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbHolder_name.Name = "tbHolder_name";
            this.tbHolder_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbHolder_name.ShowText = false;
            this.tbHolder_name.Size = new System.Drawing.Size(165, 29);
            this.tbHolder_name.TabIndex = 130;
            this.tbHolder_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbHolder_name.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(21, 112);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(210, 41);
            this.uiLabel1.TabIndex = 116;
            this.uiLabel1.Text = "养殖动物类型";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFamerList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.pagination);
            this.Name = "frmFamerList";
            this.Text = "frmFamerList";
            this.Load += new System.EventHandler(this.frmFamerList_Load);
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamerList)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UIButton btAdanceSearch;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UIComboBox cbIs_handle_process;
        private Sunny.UI.UITextBox tbCar_brand;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox tbHolder_name;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgFamerList;
        private Sunny.UI.UIComboTreeView ctvAnimal_area_type;
        private Sunny.UI.UIComboTreeView ctvAnimal_type;
        private Sunny.UI.UIComboTreeView ctvPlant_area_type;
        private Sunny.UI.UIComboTreeView ctvPlant_type;
        private Sunny.UI.UIComboTreeView ctvMechine_type;
    }
}