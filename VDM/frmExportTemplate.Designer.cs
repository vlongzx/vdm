namespace com.vdm.form
{
    partial class frmExportTemplate
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
            this.tbPassword = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btTempleExport = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPassword.Location = new System.Drawing.Point(288, 87);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(5);
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ShowText = false;
            this.tbPassword.Size = new System.Drawing.Size(267, 35);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbPassword.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(7, 81);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(274, 41);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "设置模板访问密码";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btTempleExport
            // 
            this.btTempleExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTempleExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTempleExport.Location = new System.Drawing.Point(142, 145);
            this.btTempleExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btTempleExport.Name = "btTempleExport";
            this.btTempleExport.Size = new System.Drawing.Size(293, 35);
            this.btTempleExport.TabIndex = 5;
            this.btTempleExport.Text = "选择目录导出模板";
            this.btTempleExport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTempleExport.Click += new System.EventHandler(this.btTempleExport_Click);
            // 
            // frmExportTemplate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 241);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btTempleExport);
            this.Name = "frmExportTemplate";
            this.Text = "导出模板";
            this.ZoomScaleRect = new System.Drawing.Rectangle(30, 30, 559, 229);
            this.Load += new System.EventHandler(this.frmExportTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox tbPassword;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btTempleExport;
    }
}