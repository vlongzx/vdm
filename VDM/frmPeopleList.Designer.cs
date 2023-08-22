namespace com.vdm.form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.cbReligious_belief = new System.Windows.Forms.ComboBox();
            this.cbPolitcal_outlook = new System.Windows.Forms.ComboBox();
            this.cbNation = new System.Windows.Forms.ComboBox();
            this.cbRelationship = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone_number = new System.Windows.Forms.TextBox();
            this.tbIdcard = new System.Windows.Forms.TextBox();
            this.tbPeople_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPeople = new System.Windows.Forms.ListView();
            this.btRefresh = new System.Windows.Forms.Button();
            this.pagination = new PageControl.Pagination();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.cbSex);
            this.groupBox1.Controls.Add(this.cbEducation);
            this.groupBox1.Controls.Add(this.cbReligious_belief);
            this.groupBox1.Controls.Add(this.cbPolitcal_outlook);
            this.groupBox1.Controls.Add(this.cbNation);
            this.groupBox1.Controls.Add(this.cbRelationship);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPhone_number);
            this.groupBox1.Controls.Add(this.tbIdcard);
            this.groupBox1.Controls.Add(this.tbPeople_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1874, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(1696, 71);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(140, 60);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "重置(&R)";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearch.Location = new System.Drawing.Point(1539, 71);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(140, 60);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "查询(&S)";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(657, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 35);
            this.textBox5.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(1397, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 35);
            this.textBox7.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(282, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 35);
            this.textBox3.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(1279, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 35);
            this.textBox6.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(539, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 35);
            this.textBox4.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(162, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 35);
            this.textBox2.TabIndex = 3;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(1279, 36);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(200, 32);
            this.cbSex.TabIndex = 2;
            // 
            // cbEducation
            // 
            this.cbEducation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Location = new System.Drawing.Point(1279, 146);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(200, 32);
            this.cbEducation.TabIndex = 2;
            // 
            // cbReligious_belief
            // 
            this.cbReligious_belief.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbReligious_belief.FormattingEnabled = true;
            this.cbReligious_belief.Location = new System.Drawing.Point(895, 146);
            this.cbReligious_belief.Name = "cbReligious_belief";
            this.cbReligious_belief.Size = new System.Drawing.Size(200, 32);
            this.cbReligious_belief.TabIndex = 2;
            // 
            // cbPolitcal_outlook
            // 
            this.cbPolitcal_outlook.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPolitcal_outlook.FormattingEnabled = true;
            this.cbPolitcal_outlook.Location = new System.Drawing.Point(895, 88);
            this.cbPolitcal_outlook.Name = "cbPolitcal_outlook";
            this.cbPolitcal_outlook.Size = new System.Drawing.Size(200, 32);
            this.cbPolitcal_outlook.TabIndex = 2;
            // 
            // cbNation
            // 
            this.cbNation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbNation.FormattingEnabled = true;
            this.cbNation.Location = new System.Drawing.Point(895, 36);
            this.cbNation.Name = "cbNation";
            this.cbNation.Size = new System.Drawing.Size(200, 32);
            this.cbNation.TabIndex = 2;
            // 
            // cbRelationship
            // 
            this.cbRelationship.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.Location = new System.Drawing.Point(537, 36);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(200, 32);
            this.cbRelationship.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1161, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "性别：";
            // 
            // tbPhone_number
            // 
            this.tbPhone_number.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhone_number.Location = new System.Drawing.Point(537, 145);
            this.tbPhone_number.Name = "tbPhone_number";
            this.tbPhone_number.Size = new System.Drawing.Size(200, 35);
            this.tbPhone_number.TabIndex = 1;
            // 
            // tbIdcard
            // 
            this.tbIdcard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbIdcard.Location = new System.Drawing.Point(162, 145);
            this.tbIdcard.Name = "tbIdcard";
            this.tbIdcard.Size = new System.Drawing.Size(200, 35);
            this.tbIdcard.TabIndex = 1;
            // 
            // tbPeople_name
            // 
            this.tbPeople_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPeople_name.Location = new System.Drawing.Point(162, 35);
            this.tbPeople_name.Name = "tbPeople_name";
            this.tbPeople_name.Size = new System.Drawing.Size(200, 35);
            this.tbPeople_name.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(781, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "政治面貌：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(781, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "民族：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(386, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "与户主关系：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1367, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(627, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(248, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(1165, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "学历：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(1157, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "入党时间：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(781, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "宗教信仰：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(415, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(417, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "年龄：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(40, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "身份证号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(40, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "出生日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAdd.Location = new System.Drawing.Point(11, 213);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(140, 60);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "新增(&A)";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEdit.Location = new System.Drawing.Point(157, 213);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(140, 60);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "编辑(&M)";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelete.Location = new System.Drawing.Point(303, 213);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(140, 60);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "删除(&D)";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btImport
            // 
            this.btImport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btImport.Location = new System.Drawing.Point(449, 213);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(140, 60);
            this.btImport.TabIndex = 4;
            this.btImport.Text = "导入(&I)";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btExport
            // 
            this.btExport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(595, 213);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(140, 60);
            this.btExport.TabIndex = 4;
            this.btExport.Text = "导出(&E)";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pagination);
            this.groupBox2.Controls.Add(this.lvPeople);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1874, 733);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据列表";
            // 
            // lvPeople
            // 
            this.lvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPeople.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvPeople.FullRowSelect = true;
            this.lvPeople.GridLines = true;
            this.lvPeople.Location = new System.Drawing.Point(18, 27);
            this.lvPeople.Name = "lvPeople";
            this.lvPeople.Size = new System.Drawing.Size(1839, 625);
            this.lvPeople.SmallImageList = this.imageList1;
            this.lvPeople.TabIndex = 0;
            this.lvPeople.UseCompatibleStateImageBehavior = false;
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefresh.Location = new System.Drawing.Point(752, 213);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(140, 60);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "刷新(&R)";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // pagination
            // 
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pagination.CurrentPage = 1;
            this.pagination.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pagination.Location = new System.Drawing.Point(578, 659);
            this.pagination.Margin = new System.Windows.Forms.Padding(4);
            this.pagination.Name = "pagination";
            this.pagination.PageSize = 10;
            this.pagination.Size = new System.Drawing.Size(1279, 65);
            this.pagination.TabIndex = 1;
            this.pagination.TotalPage = 1;
            this.pagination.LoadListView += new PageControl.Pagination.LoadListViewEventHandler(this.pagination_LoadListView);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(10, 45);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Name = "frmPeopleList";
            this.Text = "人员信息管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbNation;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPeople_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.ComboBox cbReligious_belief;
        private System.Windows.Forms.ComboBox cbPolitcal_outlook;
        private System.Windows.Forms.TextBox tbPhone_number;
        private System.Windows.Forms.TextBox tbIdcard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvPeople;
        private System.Windows.Forms.Button btRefresh;
        private PageControl.Pagination pagination;
        private System.Windows.Forms.ImageList imageList1;
    }
}