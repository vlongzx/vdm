namespace com.vdm.form
{
    partial class frmTourList
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
            this.dgTourList = new Sunny.UI.UIDataGridView();
            this.btExport = new Sunny.UI.UIButton();
            this.btAdd = new Sunny.UI.UIButton();
            this.btEdit = new Sunny.UI.UIButton();
            this.btDelete = new Sunny.UI.UIButton();
            this.gbSearch = new Sunny.UI.UIGroupBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbYear_person_count_to = new Sunny.UI.UITextBox();
            this.tbYear_person_count_from = new Sunny.UI.UITextBox();
            this.tbRegistered_trademark = new Sunny.UI.UITextBox();
            this.tbPrincipal_name = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.tbYear_trade_income_to = new Sunny.UI.UITextBox();
            this.tbYear_trade_income_from = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cbTown = new Sunny.UI.UIComboBox();
            this.cbVillage = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cbTrade_form = new Sunny.UI.UIComboBox();
            this.cbPrincipal_category = new Sunny.UI.UIComboBox();
            this.tbAddress = new Sunny.UI.UITextBox();
            this.tbPhone_number = new Sunny.UI.UITextBox();
            this.tbLegal_name = new Sunny.UI.UITextBox();
            this.tbCompany_id = new Sunny.UI.UITextBox();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label10 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.btReset = new Sunny.UI.UIButton();
            this.btSearch = new Sunny.UI.UIButton();
            this.pagination = new Sunny.UI.UIPagination();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTourList)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(295, 219);
            this.btImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(87, 47);
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
            this.gbResult.Controls.Add(this.dgTourList);
            this.gbResult.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbResult.Location = new System.Drawing.Point(19, 273);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4, 32, 4, 4);
            this.gbResult.Size = new System.Drawing.Size(1883, 750);
            this.gbResult.TabIndex = 89;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "数据列表";
            this.gbResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgTourList
            // 
            this.dgTourList.AllowUserToAddRows = false;
            this.dgTourList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgTourList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTourList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgTourList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTourList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTourList.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTourList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTourList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTourList.EnableHeadersVisualStyles = false;
            this.dgTourList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgTourList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgTourList.Location = new System.Drawing.Point(4, 32);
            this.dgTourList.Name = "dgTourList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTourList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgTourList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgTourList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTourList.RowTemplate.Height = 23;
            this.dgTourList.ScrollBarHandleWidth = 40;
            this.dgTourList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgTourList.SelectedIndex = -1;
            this.dgTourList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTourList.Size = new System.Drawing.Size(1875, 714);
            this.dgTourList.TabIndex = 7;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(388, 219);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(87, 47);
            this.btExport.TabIndex = 91;
            this.btExport.Text = "导出(&E)";
            this.btExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(16, 219);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 47);
            this.btAdd.TabIndex = 92;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(109, 219);
            this.btEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(87, 47);
            this.btEdit.TabIndex = 93;
            this.btEdit.Text = "编辑(&E)";
            this.btEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(202, 219);
            this.btDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(87, 47);
            this.btDelete.TabIndex = 94;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.uiLabel5);
            this.gbSearch.Controls.Add(this.tbYear_person_count_to);
            this.gbSearch.Controls.Add(this.tbYear_person_count_from);
            this.gbSearch.Controls.Add(this.tbRegistered_trademark);
            this.gbSearch.Controls.Add(this.tbPrincipal_name);
            this.gbSearch.Controls.Add(this.uiLabel9);
            this.gbSearch.Controls.Add(this.tbYear_trade_income_to);
            this.gbSearch.Controls.Add(this.tbYear_trade_income_from);
            this.gbSearch.Controls.Add(this.uiLabel6);
            this.gbSearch.Controls.Add(this.cbTown);
            this.gbSearch.Controls.Add(this.cbVillage);
            this.gbSearch.Controls.Add(this.uiLabel7);
            this.gbSearch.Controls.Add(this.uiLabel23);
            this.gbSearch.Controls.Add(this.uiLabel3);
            this.gbSearch.Controls.Add(this.uiLabel1);
            this.gbSearch.Controls.Add(this.uiLabel2);
            this.gbSearch.Controls.Add(this.cbTrade_form);
            this.gbSearch.Controls.Add(this.cbPrincipal_category);
            this.gbSearch.Controls.Add(this.tbAddress);
            this.gbSearch.Controls.Add(this.tbPhone_number);
            this.gbSearch.Controls.Add(this.tbLegal_name);
            this.gbSearch.Controls.Add(this.tbCompany_id);
            this.gbSearch.Controls.Add(this.uiLabel14);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Controls.Add(this.btReset);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearch.Location = new System.Drawing.Point(14, 41);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbSearch.Size = new System.Drawing.Size(1883, 170);
            this.gbSearch.TabIndex = 96;
            this.gbSearch.Text = "查询条件";
            this.gbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(194, 106);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(24, 31);
            this.uiLabel5.TabIndex = 174;
            this.uiLabel5.Text = "-";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbYear_person_count_to
            // 
            this.tbYear_person_count_to.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_person_count_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_person_count_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_person_count_to.Location = new System.Drawing.Point(228, 106);
            this.tbYear_person_count_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_person_count_to.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_person_count_to.Name = "tbYear_person_count_to";
            this.tbYear_person_count_to.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_person_count_to.ShowText = false;
            this.tbYear_person_count_to.Size = new System.Drawing.Size(62, 29);
            this.tbYear_person_count_to.TabIndex = 131;
            this.tbYear_person_count_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_person_count_to.Watermark = "";
            // 
            // tbYear_person_count_from
            // 
            this.tbYear_person_count_from.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_person_count_from.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_person_count_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_person_count_from.Location = new System.Drawing.Point(125, 106);
            this.tbYear_person_count_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_person_count_from.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_person_count_from.Name = "tbYear_person_count_from";
            this.tbYear_person_count_from.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_person_count_from.ShowText = false;
            this.tbYear_person_count_from.Size = new System.Drawing.Size(62, 29);
            this.tbYear_person_count_from.TabIndex = 131;
            this.tbYear_person_count_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_person_count_from.Watermark = "";
            // 
            // tbRegistered_trademark
            // 
            this.tbRegistered_trademark.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbRegistered_trademark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegistered_trademark.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRegistered_trademark.Location = new System.Drawing.Point(125, 74);
            this.tbRegistered_trademark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRegistered_trademark.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbRegistered_trademark.Name = "tbRegistered_trademark";
            this.tbRegistered_trademark.Padding = new System.Windows.Forms.Padding(5);
            this.tbRegistered_trademark.ShowText = false;
            this.tbRegistered_trademark.Size = new System.Drawing.Size(165, 29);
            this.tbRegistered_trademark.TabIndex = 130;
            this.tbRegistered_trademark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRegistered_trademark.Watermark = "";
            // 
            // tbPrincipal_name
            // 
            this.tbPrincipal_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPrincipal_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrincipal_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPrincipal_name.Location = new System.Drawing.Point(125, 42);
            this.tbPrincipal_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrincipal_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPrincipal_name.Name = "tbPrincipal_name";
            this.tbPrincipal_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbPrincipal_name.ShowText = false;
            this.tbPrincipal_name.Size = new System.Drawing.Size(165, 29);
            this.tbPrincipal_name.TabIndex = 130;
            this.tbPrincipal_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPrincipal_name.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(494, 106);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(24, 31);
            this.uiLabel9.TabIndex = 174;
            this.uiLabel9.Text = "-";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbYear_trade_income_to
            // 
            this.tbYear_trade_income_to.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_trade_income_to.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_trade_income_to.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_trade_income_to.Location = new System.Drawing.Point(528, 106);
            this.tbYear_trade_income_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_trade_income_to.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_trade_income_to.Name = "tbYear_trade_income_to";
            this.tbYear_trade_income_to.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_trade_income_to.ShowText = false;
            this.tbYear_trade_income_to.Size = new System.Drawing.Size(62, 29);
            this.tbYear_trade_income_to.TabIndex = 131;
            this.tbYear_trade_income_to.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_trade_income_to.Watermark = "";
            // 
            // tbYear_trade_income_from
            // 
            this.tbYear_trade_income_from.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbYear_trade_income_from.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbYear_trade_income_from.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYear_trade_income_from.Location = new System.Drawing.Point(425, 106);
            this.tbYear_trade_income_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear_trade_income_from.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbYear_trade_income_from.Name = "tbYear_trade_income_from";
            this.tbYear_trade_income_from.Padding = new System.Windows.Forms.Padding(5);
            this.tbYear_trade_income_from.ShowText = false;
            this.tbYear_trade_income_from.Size = new System.Drawing.Size(62, 29);
            this.tbYear_trade_income_from.TabIndex = 131;
            this.tbYear_trade_income_from.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbYear_trade_income_from.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(984, 106);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(86, 31);
            this.uiLabel6.TabIndex = 173;
            this.uiLabel6.Text = "所属村";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTown
            // 
            this.cbTown.DataSource = null;
            this.cbTown.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTown.FillColor = System.Drawing.Color.White;
            this.cbTown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTown.Location = new System.Drawing.Point(760, 106);
            this.cbTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTown.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTown.Name = "cbTown";
            this.cbTown.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTown.Size = new System.Drawing.Size(165, 29);
            this.cbTown.TabIndex = 170;
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
            this.cbVillage.Location = new System.Drawing.Point(1077, 106);
            this.cbVillage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVillage.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbVillage.Size = new System.Drawing.Size(165, 29);
            this.cbVillage.TabIndex = 170;
            this.cbVillage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbVillage.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(646, 106);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(86, 31);
            this.uiLabel7.TabIndex = 167;
            this.uiLabel7.Text = "所属镇";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel23
            // 
            this.uiLabel23.AutoSize = true;
            this.uiLabel23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel23.Location = new System.Drawing.Point(36, 73);
            this.uiLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(110, 31);
            this.uiLabel23.TabIndex = 163;
            this.uiLabel23.Text = "注册商标";
            this.uiLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(646, 74);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(110, 31);
            this.uiLabel3.TabIndex = 147;
            this.uiLabel3.Text = "经营形式";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(331, 74);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(110, 31);
            this.uiLabel1.TabIndex = 146;
            this.uiLabel1.Text = "联系电话";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(36, 42);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(110, 31);
            this.uiLabel2.TabIndex = 145;
            this.uiLabel2.Text = "主体名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTrade_form
            // 
            this.cbTrade_form.DataSource = null;
            this.cbTrade_form.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTrade_form.FillColor = System.Drawing.Color.White;
            this.cbTrade_form.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbTrade_form.Location = new System.Drawing.Point(760, 74);
            this.cbTrade_form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTrade_form.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTrade_form.Name = "cbTrade_form";
            this.cbTrade_form.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTrade_form.Size = new System.Drawing.Size(165, 29);
            this.cbTrade_form.TabIndex = 134;
            this.cbTrade_form.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTrade_form.Watermark = "";
            // 
            // cbPrincipal_category
            // 
            this.cbPrincipal_category.DataSource = null;
            this.cbPrincipal_category.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbPrincipal_category.FillColor = System.Drawing.Color.White;
            this.cbPrincipal_category.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPrincipal_category.Location = new System.Drawing.Point(425, 42);
            this.cbPrincipal_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPrincipal_category.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPrincipal_category.Name = "cbPrincipal_category";
            this.cbPrincipal_category.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPrincipal_category.Size = new System.Drawing.Size(165, 29);
            this.cbPrincipal_category.TabIndex = 134;
            this.cbPrincipal_category.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPrincipal_category.Watermark = "";
            // 
            // tbAddress
            // 
            this.tbAddress.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAddress.Location = new System.Drawing.Point(1077, 74);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Padding = new System.Windows.Forms.Padding(5);
            this.tbAddress.ShowText = false;
            this.tbAddress.Size = new System.Drawing.Size(165, 29);
            this.tbAddress.TabIndex = 130;
            this.tbAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAddress.Watermark = "";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPhone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone_number.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(425, 74);
            this.tbPhone_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone_number.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Padding = new System.Windows.Forms.Padding(5);
            this.tbPhone_number.ShowText = false;
            this.tbPhone_number.Size = new System.Drawing.Size(165, 29);
            this.tbPhone_number.TabIndex = 130;
            this.tbPhone_number.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPhone_number.Watermark = "";
            // 
            // tbLegal_name
            // 
            this.tbLegal_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbLegal_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLegal_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLegal_name.Location = new System.Drawing.Point(1077, 42);
            this.tbLegal_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLegal_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbLegal_name.Name = "tbLegal_name";
            this.tbLegal_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbLegal_name.ShowText = false;
            this.tbLegal_name.Size = new System.Drawing.Size(165, 29);
            this.tbLegal_name.TabIndex = 130;
            this.tbLegal_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbLegal_name.Watermark = "";
            // 
            // tbCompany_id
            // 
            this.tbCompany_id.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbCompany_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCompany_id.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCompany_id.Location = new System.Drawing.Point(760, 42);
            this.tbCompany_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCompany_id.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCompany_id.Name = "tbCompany_id";
            this.tbCompany_id.Padding = new System.Windows.Forms.Padding(5);
            this.tbCompany_id.ShowText = false;
            this.tbCompany_id.Size = new System.Drawing.Size(165, 29);
            this.tbCompany_id.TabIndex = 130;
            this.tbCompany_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCompany_id.Watermark = "";
            // 
            // uiLabel14
            // 
            this.uiLabel14.AutoSize = true;
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel14.Location = new System.Drawing.Point(646, 42);
            this.uiLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(158, 31);
            this.uiLabel14.TabIndex = 116;
            this.uiLabel14.Text = "统一信用代码";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(984, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 116;
            this.label9.Text = "法定代表人";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(984, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 115;
            this.label3.Text = "地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 114;
            this.label2.Text = "主体类别";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 66);
            this.label10.TabIndex = 111;
            this.label10.Text = "年接待旅游\r\n(人次)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 66);
            this.label8.TabIndex = 101;
            this.label8.Text = "年经营收入\r\n(万元)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1249, 89);
            this.btReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 30);
            this.btReset.TabIndex = 62;
            this.btReset.Text = "重置(&R)";
            this.btReset.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1249, 56);
            this.btSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 30);
            this.btSearch.TabIndex = 61;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // pagination
            // 
            this.pagination.ActivePage = 20;
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagination.CausesValidation = false;
            this.pagination.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pagination.Location = new System.Drawing.Point(11, 1032);
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
            // frmTourList
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
            this.Name = "frmTourList";
            this.Text = "frmTourList";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 480);
            this.Load += new System.EventHandler(this.frmTourList_Load);
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTourList)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btImport;
        private Sunny.UI.UIGroupBox gbResult;
        private Sunny.UI.UIDataGridView dgTourList;
        private Sunny.UI.UIButton btExport;
        private Sunny.UI.UIButton btAdd;
        private Sunny.UI.UIButton btEdit;
        private Sunny.UI.UIButton btDelete;
        private Sunny.UI.UIGroupBox gbSearch;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbYear_trade_income_to;
        private Sunny.UI.UITextBox tbYear_person_count_to;
        private Sunny.UI.UITextBox tbYear_trade_income_from;
        private Sunny.UI.UITextBox tbYear_person_count_from;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cbTown;
        private Sunny.UI.UIComboBox cbVillage;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cbPrincipal_category;
        private Sunny.UI.UITextBox tbRegistered_trademark;
        private Sunny.UI.UITextBox tbAddress;
        private Sunny.UI.UITextBox tbPhone_number;
        private Sunny.UI.UITextBox tbPrincipal_name;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UIButton btReset;
        private Sunny.UI.UIButton btSearch;
        private Sunny.UI.UIPagination pagination;
        private Sunny.UI.UITextBox tbLegal_name;
        private Sunny.UI.UITextBox tbCompany_id;
        private Sunny.UI.UIComboBox cbTrade_form;
    }
}