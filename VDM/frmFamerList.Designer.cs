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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btImport = new Sunny.UI.UIButton();
            this.groupBox2 = new Sunny.UI.UIGroupBox();
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cbIs_handle_process = new Sunny.UI.UIComboBox();
            this.cbPlant_area_type = new Sunny.UI.UIComboBox();
            this.tbCar_brand = new Sunny.UI.UITextBox();
            this.tbMechine_type = new Sunny.UI.UITextBox();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.cbAnimal_area_type = new Sunny.UI.UIComboBox();
            this.cbAnimal_type = new Sunny.UI.UIComboBox();
            this.cbPlant_type = new Sunny.UI.UIComboBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbIdcard = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.tbHolder_name = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamerList)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(490, 303);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(154, 62);
            this.btImport.TabIndex = 82;
            this.btImport.Text = "导入(&I)";
            this.btImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgFamerList);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(2063, 647);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据列表";
            this.groupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgFamerList
            // 
            this.dgFamerList.AllowUserToAddRows = false;
            this.dgFamerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgFamerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFamerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgFamerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFamerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFamerList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFamerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgFamerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFamerList.EnableHeadersVisualStyles = false;
            this.dgFamerList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgFamerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgFamerList.Location = new System.Drawing.Point(4, 32);
            this.dgFamerList.Name = "dgFamerList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFamerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFamerList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgFamerList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgFamerList.RowTemplate.Height = 23;
            this.dgFamerList.ScrollBarHandleWidth = 40;
            this.dgFamerList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgFamerList.SelectedIndex = -1;
            this.dgFamerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFamerList.Size = new System.Drawing.Size(2055, 611);
            this.dgFamerList.TabIndex = 8;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(650, 303);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(154, 62);
            this.btExport.TabIndex = 83;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(10, 303);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(154, 62);
            this.btAdd.TabIndex = 84;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(170, 303);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(154, 62);
            this.btEdit.TabIndex = 85;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(330, 303);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(154, 62);
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
            this.pagination.Location = new System.Drawing.Point(5, 1028);
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
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1610, 81);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(154, 62);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1770, 81);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(154, 62);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(412, 36);
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
            this.label13.Location = new System.Drawing.Point(808, 33);
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
            this.uiLabel4.Location = new System.Drawing.Point(21, 104);
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
            this.uiLabel5.Location = new System.Drawing.Point(1169, 33);
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
            this.label15.Location = new System.Drawing.Point(808, 97);
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
            this.label9.Location = new System.Drawing.Point(412, 105);
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
            this.uiLabel6.Location = new System.Drawing.Point(1169, 101);
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
            this.uiLabel26.Location = new System.Drawing.Point(808, 161);
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
            this.uiLabel25.Location = new System.Drawing.Point(1169, 169);
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
            this.btAdanceSearch.Location = new System.Drawing.Point(1930, 81);
            this.btAdanceSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdanceSearch.Name = "btAdanceSearch";
            this.btAdanceSearch.Size = new System.Drawing.Size(154, 62);
            this.btAdanceSearch.TabIndex = 62;
            this.btAdanceSearch.Text = "高级查询(&Q)";
            this.btAdanceSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdanceSearch.Click += new System.EventHandler(this.btAdanceSearch_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.btAdanceSearch);
            this.uiGroupBox1.Controls.Add(this.cbIs_handle_process);
            this.uiGroupBox1.Controls.Add(this.cbPlant_area_type);
            this.uiGroupBox1.Controls.Add(this.tbCar_brand);
            this.uiGroupBox1.Controls.Add(this.tbMechine_type);
            this.uiGroupBox1.Controls.Add(this.uiLabel25);
            this.uiGroupBox1.Controls.Add(this.uiLabel26);
            this.uiGroupBox1.Controls.Add(this.cbTown);
            this.uiGroupBox1.Controls.Add(this.cbVillage);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.cbAnimal_area_type);
            this.uiGroupBox1.Controls.Add(this.cbAnimal_type);
            this.uiGroupBox1.Controls.Add(this.cbPlant_type);
            this.uiGroupBox1.Controls.Add(this.tbPhone_number);
            this.uiGroupBox1.Controls.Add(this.tbIdcard);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.tbHolder_name);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.label9);
            this.uiGroupBox1.Controls.Add(this.label15);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.label13);
            this.uiGroupBox1.Controls.Add(this.label12);
            this.uiGroupBox1.Controls.Add(this.btReset);
            this.uiGroupBox1.Controls.Add(this.btSearch);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(8, 26);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(2063, 255);
            this.uiGroupBox1.TabIndex = 88;
            this.uiGroupBox1.Text = "查询条件";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbIs_handle_process
            // 
            this.cbIs_handle_process.DataSource = null;
            this.cbIs_handle_process.FillColor = System.Drawing.Color.White;
            this.cbIs_handle_process.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIs_handle_process.Location = new System.Drawing.Point(1442, 107);
            this.cbIs_handle_process.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIs_handle_process.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIs_handle_process.Name = "cbIs_handle_process";
            this.cbIs_handle_process.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIs_handle_process.Size = new System.Drawing.Size(140, 29);
            this.cbIs_handle_process.TabIndex = 88;
            this.cbIs_handle_process.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIs_handle_process.Watermark = "";
            // 
            // cbPlant_area_type
            // 
            this.cbPlant_area_type.DataSource = null;
            this.cbPlant_area_type.FillColor = System.Drawing.Color.White;
            this.cbPlant_area_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPlant_area_type.Location = new System.Drawing.Point(1013, 107);
            this.cbPlant_area_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPlant_area_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPlant_area_type.Name = "cbPlant_area_type";
            this.cbPlant_area_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPlant_area_type.Size = new System.Drawing.Size(148, 29);
            this.cbPlant_area_type.TabIndex = 88;
            this.cbPlant_area_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPlant_area_type.Watermark = "";
            // 
            // tbCar_brand
            // 
            this.tbCar_brand.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCar_brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCar_brand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCar_brand.Location = new System.Drawing.Point(1442, 36);
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
            // tbMechine_type
            // 
            this.tbMechine_type.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMechine_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMechine_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMechine_type.Location = new System.Drawing.Point(239, 110);
            this.tbMechine_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMechine_type.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMechine_type.Name = "tbMechine_type";
            this.tbMechine_type.Padding = new System.Windows.Forms.Padding(5);
            this.tbMechine_type.ShowText = false;
            this.tbMechine_type.Size = new System.Drawing.Size(165, 29);
            this.tbMechine_type.TabIndex = 162;
            this.tbMechine_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMechine_type.Watermark = "";
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(1013, 174);
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
            this.cbVillage.FillColor = System.Drawing.Color.White;
            this.cbVillage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVillage.Location = new System.Drawing.Point(1442, 171);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(140, 29);
            this.cbVillage.TabIndex = 153;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // cbAnimal_area_type
            // 
            this.cbAnimal_area_type.DataSource = null;
            this.cbAnimal_area_type.FillColor = System.Drawing.Color.White;
            this.cbAnimal_area_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAnimal_area_type.Location = new System.Drawing.Point(630, 173);
            this.cbAnimal_area_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAnimal_area_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAnimal_area_type.Name = "cbAnimal_area_type";
            this.cbAnimal_area_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAnimal_area_type.Size = new System.Drawing.Size(158, 29);
            this.cbAnimal_area_type.TabIndex = 138;
            this.cbAnimal_area_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAnimal_area_type.Watermark = "";
            // 
            // cbAnimal_type
            // 
            this.cbAnimal_type.DataSource = null;
            this.cbAnimal_type.FillColor = System.Drawing.Color.White;
            this.cbAnimal_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAnimal_type.Location = new System.Drawing.Point(239, 183);
            this.cbAnimal_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAnimal_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAnimal_type.Name = "cbAnimal_type";
            this.cbAnimal_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAnimal_type.Size = new System.Drawing.Size(165, 29);
            this.cbAnimal_type.TabIndex = 138;
            this.cbAnimal_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAnimal_type.Watermark = "";
            // 
            // cbPlant_type
            // 
            this.cbPlant_type.DataSource = null;
            this.cbPlant_type.FillColor = System.Drawing.Color.White;
            this.cbPlant_type.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPlant_type.Location = new System.Drawing.Point(630, 105);
            this.cbPlant_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPlant_type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPlant_type.Name = "cbPlant_type";
            this.cbPlant_type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPlant_type.Size = new System.Drawing.Size(158, 29);
            this.cbPlant_type.TabIndex = 138;
            this.cbPlant_type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPlant_type.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(1013, 40);
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
            this.tbIdcard.Location = new System.Drawing.Point(630, 37);
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
            this.uiLabel3.Location = new System.Drawing.Point(412, 174);
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
            this.tbHolder_name.Location = new System.Drawing.Point(239, 37);
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
            this.uiLabel1.Location = new System.Drawing.Point(21, 171);
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
            this.ClientSize = new System.Drawing.Size(2095, 1125);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.pagination);
            this.Name = "frmFamerList";
            this.Text = "frmFamerList";
            this.Load += new System.EventHandler(this.frmFamerList_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamerList)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox groupBox2;
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
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cbIs_handle_process;
        private Sunny.UI.UIComboBox cbPlant_area_type;
        private Sunny.UI.UITextBox tbCar_brand;
        private Sunny.UI.UITextBox tbMechine_type;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UIComboBox cbAnimal_area_type;
        private Sunny.UI.UIComboBox cbAnimal_type;
        private Sunny.UI.UIComboBox cbPlant_type;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbIdcard;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox tbHolder_name;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgFamerList;
    }
}