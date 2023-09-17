namespace com.vdm.form
{
    partial class frmPesonInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labRealName = new System.Windows.Forms.Label();
            this.labTown = new System.Windows.Forms.Label();
            this.labVillage = new System.Windows.Forms.Label();
            this.labRoleName = new System.Windows.Forms.Label();
            this.labLevelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "所属乡/镇：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "所属村/社区：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "角色：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "账号级别：";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(249, 99);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(82, 31);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = "label7";
            // 
            // labRealName
            // 
            this.labRealName.AutoSize = true;
            this.labRealName.Location = new System.Drawing.Point(249, 153);
            this.labRealName.Name = "labRealName";
            this.labRealName.Size = new System.Drawing.Size(82, 31);
            this.labRealName.TabIndex = 1;
            this.labRealName.Text = "label7";
            // 
            // labTown
            // 
            this.labTown.AutoSize = true;
            this.labTown.Location = new System.Drawing.Point(249, 207);
            this.labTown.Name = "labTown";
            this.labTown.Size = new System.Drawing.Size(82, 31);
            this.labTown.TabIndex = 1;
            this.labTown.Text = "label7";
            // 
            // labVillage
            // 
            this.labVillage.AutoSize = true;
            this.labVillage.Location = new System.Drawing.Point(249, 261);
            this.labVillage.Name = "labVillage";
            this.labVillage.Size = new System.Drawing.Size(82, 31);
            this.labVillage.TabIndex = 1;
            this.labVillage.Text = "label7";
            // 
            // labRoleName
            // 
            this.labRoleName.AutoSize = true;
            this.labRoleName.Location = new System.Drawing.Point(249, 315);
            this.labRoleName.Name = "labRoleName";
            this.labRoleName.Size = new System.Drawing.Size(82, 31);
            this.labRoleName.TabIndex = 1;
            this.labRoleName.Text = "label7";
            // 
            // labLevelName
            // 
            this.labLevelName.AutoSize = true;
            this.labLevelName.Location = new System.Drawing.Point(249, 369);
            this.labLevelName.Name = "labLevelName";
            this.labLevelName.Size = new System.Drawing.Size(82, 31);
            this.labLevelName.TabIndex = 1;
            this.labLevelName.Text = "label7";
            // 
            // frmPesonInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.labLevelName);
            this.Controls.Add(this.labRoleName);
            this.Controls.Add(this.labVillage);
            this.Controls.Add(this.labTown);
            this.Controls.Add(this.labRealName);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPesonInfo";
            this.Text = "个人信息";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 480);
            this.Load += new System.EventHandler(this.frmPesonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labRealName;
        private System.Windows.Forms.Label labTown;
        private System.Windows.Forms.Label labVillage;
        private System.Windows.Forms.Label labRoleName;
        private System.Windows.Forms.Label labLevelName;
    }
}