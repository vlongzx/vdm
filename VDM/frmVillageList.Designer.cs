namespace com.vdm.form
{
    partial class frmVillageList
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
            this.gbResult = new Sunny.UI.UIGroupBox();
            this.dgVillageList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel18 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbFactory_To = new Sunny.UI.UITextBox();
            this.tbMove_area_To = new Sunny.UI.UITextBox();
            this.tbConfirm_area_To = new Sunny.UI.UITextBox();
            this.tbForeast_area_To = new Sunny.UI.UITextBox();
            this.tbOffice_To = new Sunny.UI.UITextBox();
            this.tbMoney_To = new Sunny.UI.UITextBox();
            this.tbFactory_From = new Sunny.UI.UITextBox();
            this.tbMove_area_From = new Sunny.UI.UITextBox();
            this.tbShop_To = new Sunny.UI.UITextBox();
            this.tbWater_resource_To = new Sunny.UI.UITextBox();
            this.tbMineral_resource_To = new Sunny.UI.UITextBox();
            this.tbSchool_To = new Sunny.UI.UITextBox();
            this.tbConfirm_area_From = new Sunny.UI.UITextBox();
            this.tbForeast_area_From = new Sunny.UI.UITextBox();
            this.tbMechine = new Sunny.UI.UITextBox();
            this.tbShop_From = new Sunny.UI.UITextBox();
            this.tbWater_resource_From = new Sunny.UI.UITextBox();
            this.tbOffice_From = new Sunny.UI.UITextBox();
            this.tbMineral_resource_From = new Sunny.UI.UITextBox();
            this.tbMoney_From = new Sunny.UI.UITextBox();
            this.tbSchool_From = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVilliage = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVillageList)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(297, 223);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(86, 49);
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
            this.gbResult.Controls.Add(this.dgVillageList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(21, 279);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1912, 769);
            this.gbResult.TabIndex = 89;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgVillageList
            // 
            this.dgVillageList.AllowUserToAddRows = false;
            this.dgVillageList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgVillageList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVillageList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgVillageList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVillageList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVillageList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVillageList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgVillageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVillageList.EnableHeadersVisualStyles = false;
            this.dgVillageList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgVillageList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgVillageList.Location = new System.Drawing.Point(4, 32);
            this.dgVillageList.Name = "dgVillageList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVillageList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVillageList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgVillageList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVillageList.RowTemplate.Height = 23;
            this.dgVillageList.ScrollBarHandleWidth = 40;
            this.dgVillageList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgVillageList.SelectedIndex = -1;
            this.dgVillageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVillageList.Size = new System.Drawing.Size(1904, 733);
            this.dgVillageList.TabIndex = 7;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(389, 223);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(86, 49);
            this.btExport.TabIndex = 91;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(18, 223);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 49);
            this.btAdd.TabIndex = 92;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(110, 223);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(86, 49);
            this.btEdit.TabIndex = 93;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(202, 223);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 49);
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
            this.pagination.Location = new System.Drawing.Point(13, 1050);
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
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.uiLabel17);
            this.gbSearch.Controls.Add(this.uiLabel16);
            this.gbSearch.Controls.Add(this.uiLabel15);
            this.gbSearch.Controls.Add(this.uiLabel8);
            this.gbSearch.Controls.Add(this.uiLabel9);
            this.gbSearch.Controls.Add(this.uiLabel12);
            this.gbSearch.Controls.Add(this.uiLabel18);
            this.gbSearch.Controls.Add(this.uiLabel13);
            this.gbSearch.Controls.Add(this.uiLabel11);
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.tbFactory_To);
            this.gbSearch.Controls.Add(this.tbMove_area_To);
            this.gbSearch.Controls.Add(this.tbConfirm_area_To);
            this.gbSearch.Controls.Add(this.tbForeast_area_To);
            this.gbSearch.Controls.Add(this.tbOffice_To);
            this.gbSearch.Controls.Add(this.tbMoney_To);
            this.gbSearch.Controls.Add(this.tbFactory_From);
            this.gbSearch.Controls.Add(this.tbMove_area_From);
            this.gbSearch.Controls.Add(this.tbShop_To);
            this.gbSearch.Controls.Add(this.tbWater_resource_To);
            this.gbSearch.Controls.Add(this.tbMineral_resource_To);
            this.gbSearch.Controls.Add(this.tbSchool_To);
            this.gbSearch.Controls.Add(this.tbConfirm_area_From);
            this.gbSearch.Controls.Add(this.tbForeast_area_From);
            this.gbSearch.Controls.Add(this.tbMechine);
            this.gbSearch.Controls.Add(this.tbShop_From);
            this.gbSearch.Controls.Add(this.tbWater_resource_From);
            this.gbSearch.Controls.Add(this.tbOffice_From);
            this.gbSearch.Controls.Add(this.tbMineral_resource_From);
            this.gbSearch.Controls.Add(this.tbMoney_From);
            this.gbSearch.Controls.Add(this.tbSchool_From);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVilliage);
            this.gbSearch.Controls.Add(this.uiLabel7);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.uiLabel14);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.uiLabel4);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel23);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(16, 31);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1917, 184);
            this.gbSearch.TabIndex = 96;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel17
            // 
            this.uiLabel17.AutoSize = true;
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel17.Location = new System.Drawing.Point(1408, 79);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(24, 31);
            this.uiLabel17.TabIndex = 174;
            this.uiLabel17.Text = "-";
            this.uiLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel16
            // 
            this.uiLabel16.AutoSize = true;
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.Location = new System.Drawing.Point(1408, 48);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(24, 31);
            this.uiLabel16.TabIndex = 174;
            this.uiLabel16.Text = "-";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel15
            // 
            this.uiLabel15.AutoSize = true;
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(1049, 48);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(24, 31);
            this.uiLabel15.TabIndex = 174;
            this.uiLabel15.Text = "-";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(676, 48);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(24, 31);
            this.uiLabel8.TabIndex = 174;
            this.uiLabel8.Text = "-";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(676, 110);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(24, 31);
            this.uiLabel9.TabIndex = 174;
            this.uiLabel9.Text = "-";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(275, 48);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(24, 31);
            this.uiLabel12.TabIndex = 174;
            this.uiLabel12.Text = "-";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel18
            // 
            this.uiLabel18.AutoSize = true;
            this.uiLabel18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel18.Location = new System.Drawing.Point(1049, 79);
            this.uiLabel18.Name = "uiLabel18";
            this.uiLabel18.Size = new System.Drawing.Size(24, 31);
            this.uiLabel18.TabIndex = 174;
            this.uiLabel18.Text = "-";
            this.uiLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel13
            // 
            this.uiLabel13.AutoSize = true;
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(676, 79);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(24, 31);
            this.uiLabel13.TabIndex = 174;
            this.uiLabel13.Text = "-";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(275, 79);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(24, 31);
            this.uiLabel11.TabIndex = 174;
            this.uiLabel11.Text = "-";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(275, 110);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(24, 31);
            this.uiLabel5.TabIndex = 174;
            this.uiLabel5.Text = "-";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFactory_To
            // 
            this.tbFactory_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbFactory_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFactory_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFactory_To.Location = new System.Drawing.Point(1442, 79);
            this.tbFactory_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFactory_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbFactory_To.Name = "tbFactory_To";
            this.tbFactory_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbFactory_To.ShowText = false;
            this.tbFactory_To.Size = new System.Drawing.Size(78, 29);
            this.tbFactory_To.TabIndex = 131;
            this.tbFactory_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFactory_To.Watermark = "";
            // 
            // tbMove_area_To
            // 
            this.tbMove_area_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_area_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_area_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_area_To.Location = new System.Drawing.Point(1442, 48);
            this.tbMove_area_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_area_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_area_To.Name = "tbMove_area_To";
            this.tbMove_area_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_area_To.ShowText = false;
            this.tbMove_area_To.Size = new System.Drawing.Size(78, 29);
            this.tbMove_area_To.TabIndex = 131;
            this.tbMove_area_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_area_To.Watermark = "";
            // 
            // tbConfirm_area_To
            // 
            this.tbConfirm_area_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbConfirm_area_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm_area_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConfirm_area_To.Location = new System.Drawing.Point(1083, 48);
            this.tbConfirm_area_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirm_area_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbConfirm_area_To.Name = "tbConfirm_area_To";
            this.tbConfirm_area_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbConfirm_area_To.ShowText = false;
            this.tbConfirm_area_To.Size = new System.Drawing.Size(82, 29);
            this.tbConfirm_area_To.TabIndex = 131;
            this.tbConfirm_area_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbConfirm_area_To.Watermark = "";
            // 
            // tbForeast_area_To
            // 
            this.tbForeast_area_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbForeast_area_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbForeast_area_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbForeast_area_To.Location = new System.Drawing.Point(698, 48);
            this.tbForeast_area_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbForeast_area_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbForeast_area_To.Name = "tbForeast_area_To";
            this.tbForeast_area_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbForeast_area_To.ShowText = false;
            this.tbForeast_area_To.Size = new System.Drawing.Size(79, 29);
            this.tbForeast_area_To.TabIndex = 131;
            this.tbForeast_area_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbForeast_area_To.Watermark = "";
            // 
            // tbOffice_To
            // 
            this.tbOffice_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOffice_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOffice_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOffice_To.Location = new System.Drawing.Point(698, 110);
            this.tbOffice_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOffice_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOffice_To.Name = "tbOffice_To";
            this.tbOffice_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbOffice_To.ShowText = false;
            this.tbOffice_To.Size = new System.Drawing.Size(79, 29);
            this.tbOffice_To.TabIndex = 131;
            this.tbOffice_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOffice_To.Watermark = "";
            // 
            // tbMoney_To
            // 
            this.tbMoney_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMoney_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMoney_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMoney_To.Location = new System.Drawing.Point(299, 48);
            this.tbMoney_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMoney_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMoney_To.Name = "tbMoney_To";
            this.tbMoney_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbMoney_To.ShowText = false;
            this.tbMoney_To.Size = new System.Drawing.Size(85, 29);
            this.tbMoney_To.TabIndex = 131;
            this.tbMoney_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoney_To.Watermark = "";
            // 
            // tbFactory_From
            // 
            this.tbFactory_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbFactory_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFactory_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFactory_From.Location = new System.Drawing.Point(1326, 79);
            this.tbFactory_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFactory_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbFactory_From.Name = "tbFactory_From";
            this.tbFactory_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbFactory_From.ShowText = false;
            this.tbFactory_From.Size = new System.Drawing.Size(75, 29);
            this.tbFactory_From.TabIndex = 131;
            this.tbFactory_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbFactory_From.Watermark = "";
            // 
            // tbMove_area_From
            // 
            this.tbMove_area_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMove_area_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMove_area_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMove_area_From.Location = new System.Drawing.Point(1327, 48);
            this.tbMove_area_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMove_area_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMove_area_From.Name = "tbMove_area_From";
            this.tbMove_area_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbMove_area_From.ShowText = false;
            this.tbMove_area_From.Size = new System.Drawing.Size(75, 29);
            this.tbMove_area_From.TabIndex = 131;
            this.tbMove_area_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMove_area_From.Watermark = "";
            // 
            // tbShop_To
            // 
            this.tbShop_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbShop_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbShop_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbShop_To.Location = new System.Drawing.Point(1083, 79);
            this.tbShop_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbShop_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbShop_To.Name = "tbShop_To";
            this.tbShop_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbShop_To.ShowText = false;
            this.tbShop_To.Size = new System.Drawing.Size(82, 29);
            this.tbShop_To.TabIndex = 131;
            this.tbShop_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbShop_To.Watermark = "";
            // 
            // tbWater_resource_To
            // 
            this.tbWater_resource_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbWater_resource_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWater_resource_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWater_resource_To.Location = new System.Drawing.Point(698, 79);
            this.tbWater_resource_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWater_resource_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbWater_resource_To.Name = "tbWater_resource_To";
            this.tbWater_resource_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbWater_resource_To.ShowText = false;
            this.tbWater_resource_To.Size = new System.Drawing.Size(79, 29);
            this.tbWater_resource_To.TabIndex = 131;
            this.tbWater_resource_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWater_resource_To.Watermark = "";
            // 
            // tbMineral_resource_To
            // 
            this.tbMineral_resource_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMineral_resource_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMineral_resource_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMineral_resource_To.Location = new System.Drawing.Point(299, 79);
            this.tbMineral_resource_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMineral_resource_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMineral_resource_To.Name = "tbMineral_resource_To";
            this.tbMineral_resource_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbMineral_resource_To.ShowText = false;
            this.tbMineral_resource_To.Size = new System.Drawing.Size(85, 29);
            this.tbMineral_resource_To.TabIndex = 131;
            this.tbMineral_resource_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMineral_resource_To.Watermark = "";
            // 
            // tbSchool_To
            // 
            this.tbSchool_To.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSchool_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSchool_To.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSchool_To.Location = new System.Drawing.Point(299, 110);
            this.tbSchool_To.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSchool_To.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSchool_To.Name = "tbSchool_To";
            this.tbSchool_To.Padding = new System.Windows.Forms.Padding(5);
            this.tbSchool_To.ShowText = false;
            this.tbSchool_To.Size = new System.Drawing.Size(85, 29);
            this.tbSchool_To.TabIndex = 131;
            this.tbSchool_To.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSchool_To.Watermark = "";
            // 
            // tbConfirm_area_From
            // 
            this.tbConfirm_area_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbConfirm_area_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm_area_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbConfirm_area_From.Location = new System.Drawing.Point(959, 48);
            this.tbConfirm_area_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbConfirm_area_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbConfirm_area_From.Name = "tbConfirm_area_From";
            this.tbConfirm_area_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbConfirm_area_From.ShowText = false;
            this.tbConfirm_area_From.Size = new System.Drawing.Size(83, 29);
            this.tbConfirm_area_From.TabIndex = 131;
            this.tbConfirm_area_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbConfirm_area_From.Watermark = "";
            // 
            // tbForeast_area_From
            // 
            this.tbForeast_area_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbForeast_area_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbForeast_area_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbForeast_area_From.Location = new System.Drawing.Point(589, 48);
            this.tbForeast_area_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbForeast_area_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbForeast_area_From.Name = "tbForeast_area_From";
            this.tbForeast_area_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbForeast_area_From.ShowText = false;
            this.tbForeast_area_From.Size = new System.Drawing.Size(84, 29);
            this.tbForeast_area_From.TabIndex = 131;
            this.tbForeast_area_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbForeast_area_From.Watermark = "";
            // 
            // tbMechine
            // 
            this.tbMechine.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMechine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMechine.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMechine.Location = new System.Drawing.Point(959, 110);
            this.tbMechine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMechine.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMechine.Name = "tbMechine";
            this.tbMechine.Padding = new System.Windows.Forms.Padding(5);
            this.tbMechine.ShowText = false;
            this.tbMechine.Size = new System.Drawing.Size(206, 29);
            this.tbMechine.TabIndex = 131;
            this.tbMechine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMechine.Watermark = "";
            // 
            // tbShop_From
            // 
            this.tbShop_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbShop_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbShop_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbShop_From.Location = new System.Drawing.Point(959, 79);
            this.tbShop_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbShop_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbShop_From.Name = "tbShop_From";
            this.tbShop_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbShop_From.ShowText = false;
            this.tbShop_From.Size = new System.Drawing.Size(83, 29);
            this.tbShop_From.TabIndex = 131;
            this.tbShop_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbShop_From.Watermark = "";
            // 
            // tbWater_resource_From
            // 
            this.tbWater_resource_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbWater_resource_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWater_resource_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWater_resource_From.Location = new System.Drawing.Point(589, 79);
            this.tbWater_resource_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWater_resource_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbWater_resource_From.Name = "tbWater_resource_From";
            this.tbWater_resource_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbWater_resource_From.ShowText = false;
            this.tbWater_resource_From.Size = new System.Drawing.Size(84, 29);
            this.tbWater_resource_From.TabIndex = 131;
            this.tbWater_resource_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWater_resource_From.Watermark = "";
            // 
            // tbOffice_From
            // 
            this.tbOffice_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbOffice_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOffice_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbOffice_From.Location = new System.Drawing.Point(589, 110);
            this.tbOffice_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOffice_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbOffice_From.Name = "tbOffice_From";
            this.tbOffice_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbOffice_From.ShowText = false;
            this.tbOffice_From.Size = new System.Drawing.Size(84, 29);
            this.tbOffice_From.TabIndex = 131;
            this.tbOffice_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbOffice_From.Watermark = "";
            // 
            // tbMineral_resource_From
            // 
            this.tbMineral_resource_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMineral_resource_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMineral_resource_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMineral_resource_From.Location = new System.Drawing.Point(186, 79);
            this.tbMineral_resource_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMineral_resource_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMineral_resource_From.Name = "tbMineral_resource_From";
            this.tbMineral_resource_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbMineral_resource_From.ShowText = false;
            this.tbMineral_resource_From.Size = new System.Drawing.Size(82, 29);
            this.tbMineral_resource_From.TabIndex = 131;
            this.tbMineral_resource_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMineral_resource_From.Watermark = "";
            // 
            // tbMoney_From
            // 
            this.tbMoney_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbMoney_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMoney_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMoney_From.Location = new System.Drawing.Point(186, 48);
            this.tbMoney_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMoney_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbMoney_From.Name = "tbMoney_From";
            this.tbMoney_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbMoney_From.ShowText = false;
            this.tbMoney_From.Size = new System.Drawing.Size(82, 29);
            this.tbMoney_From.TabIndex = 131;
            this.tbMoney_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbMoney_From.Watermark = "";
            // 
            // tbSchool_From
            // 
            this.tbSchool_From.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbSchool_From.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSchool_From.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSchool_From.Location = new System.Drawing.Point(186, 110);
            this.tbSchool_From.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSchool_From.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSchool_From.Name = "tbSchool_From";
            this.tbSchool_From.Padding = new System.Windows.Forms.Padding(5);
            this.tbSchool_From.ShowText = false;
            this.tbSchool_From.Size = new System.Drawing.Size(82, 29);
            this.tbSchool_From.TabIndex = 131;
            this.tbSchool_From.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSchool_From.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(12, 141);
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
            this.cbTown.Location = new System.Drawing.Point(1326, 110);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(194, 29);
            this.cbTown.TabIndex = 170;
            this.cbTown.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTown.Watermark = "";
            this.cbTown.SelectedValueChanged += new System.EventHandler(this.cbTown_SelectedValueChanged);
            // 
            // cbVilliage
            // 
            this.cbVilliage.DataSource = null;
            this.cbVilliage.FillColor = System.Drawing.Color.White;
            this.cbVilliage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbVilliage.Location = new System.Drawing.Point(186, 141);
            this.cbVilliage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVilliage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVilliage.Name = "cbVilliage";
            this.cbVilliage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVilliage.Size = new System.Drawing.Size(198, 29);
            this.cbVilliage.TabIndex = 170;
            this.cbVilliage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVilliage.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(1188, 110);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(86, 31);
            this.uiLabel7.TabIndex = 167;
            this.uiLabel7.Text = "所属镇";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(12, 48);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(198, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "村集体资金(万元)";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel14
            // 
            this.uiLabel14.AutoSize = true;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel14.Location = new System.Drawing.Point(802, 48);
            this.uiLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(230, 31);
            this.uiLabel14.TabIndex = 116;
            this.uiLabel14.Text = "确权耕地面积（亩）";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1182, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 31);
            this.label9.TabIndex = 116;
            this.label9.Text = "机动耕地面积(亩)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1182, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 115;
            this.label3.Text = "村集体厂房(平方米)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 114;
            this.label2.Text = "林地面积（亩）";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 31);
            this.label10.TabIndex = 111;
            this.label10.Text = "学校(平方米)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(802, 110);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(206, 31);
            this.uiLabel4.TabIndex = 108;
            this.uiLabel4.Text = "村集体设施、设备";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 31);
            this.label8.TabIndex = 101;
            this.label8.Text = "村组织办公场所(平方米)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1527, 93);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(70, 36);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1527, 53);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(70, 36);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(802, 79);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(254, 31);
            this.uiLabel3.TabIndex = 147;
            this.uiLabel3.Text = "村集体门店（平方米）";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(415, 79);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(208, 31);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "水资源量(立方/亩)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(12, 79);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(266, 31);
            this.uiLabel23.TabIndex = 163;
            this.uiLabel23.Text = "矿产资源量(亩/吨/立方)";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmVillageList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1946, 1099);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmVillageList";
            this.Text = "frmVillageList";
            this.Load += new System.EventHandler(this.frmVillageList_Load);
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVillageList)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIDataGridView dgVillageList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbFactory_To;
        private Sunny.UI.UITextBox tbMove_area_To;
        private Sunny.UI.UITextBox tbConfirm_area_To;
        private Sunny.UI.UITextBox tbForeast_area_To;
        private Sunny.UI.UITextBox tbOffice_To;
        private Sunny.UI.UITextBox tbMoney_To;
        private Sunny.UI.UITextBox tbFactory_From;
        private Sunny.UI.UITextBox tbMove_area_From;
        private Sunny.UI.UITextBox tbSchool_To;
        private Sunny.UI.UITextBox tbConfirm_area_From;
        private Sunny.UI.UITextBox tbForeast_area_From;
        private Sunny.UI.UITextBox tbOffice_From;
        private Sunny.UI.UITextBox tbMoney_From;
        private Sunny.UI.UITextBox tbSchool_From;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVilliage;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UILabel uiLabel18;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox tbShop_To;
        private Sunny.UI.UITextBox tbWater_resource_To;
        private Sunny.UI.UITextBox tbMineral_resource_To;
        private Sunny.UI.UITextBox tbShop_From;
        private Sunny.UI.UITextBox tbWater_resource_From;
        private Sunny.UI.UITextBox tbMineral_resource_From;
        private Sunny.UI.UITextBox tbMechine;
    }
}