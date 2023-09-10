namespace com.vdm.form
{
    partial class frmSetDataPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetDataPower));
            this.cbgOrgDataAuthor = new Sunny.UI.UICheckBoxGroup();
            this.cbgObjDataAuthor = new Sunny.UI.UICheckBoxGroup();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 624);
            this.pnlBtm.Size = new System.Drawing.Size(1156, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1028, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(913, 12);
            // 
            // cbgOrgDataAuthor
            // 
            this.cbgOrgDataAuthor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbgOrgDataAuthor.Location = new System.Drawing.Point(20, 40);
            this.cbgOrgDataAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbgOrgDataAuthor.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbgOrgDataAuthor.Name = "cbgOrgDataAuthor";
            this.cbgOrgDataAuthor.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.cbgOrgDataAuthor.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("cbgOrgDataAuthor.SelectedIndexes")));
            this.cbgOrgDataAuthor.Size = new System.Drawing.Size(1118, 180);
            this.cbgOrgDataAuthor.TabIndex = 0;
            this.cbgOrgDataAuthor.Text = "组织类数据权限";
            this.cbgOrgDataAuthor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbgObjDataAuthor
            // 
            this.cbgObjDataAuthor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbgObjDataAuthor.Location = new System.Drawing.Point(20, 239);
            this.cbgObjDataAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbgObjDataAuthor.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbgObjDataAuthor.Name = "cbgObjDataAuthor";
            this.cbgObjDataAuthor.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.cbgObjDataAuthor.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("cbgObjDataAuthor.SelectedIndexes")));
            this.cbgObjDataAuthor.Size = new System.Drawing.Size(1118, 355);
            this.cbgObjDataAuthor.TabIndex = 0;
            this.cbgObjDataAuthor.Text = "对象类数据权限";
            this.cbgObjDataAuthor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSetDataPower
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1158, 682);
            this.Controls.Add(this.cbgObjDataAuthor);
            this.Controls.Add(this.cbgOrgDataAuthor);
            this.Name = "frmSetDataPower";
            this.Text = "frmSetDataPower";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmSetDataPower_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.cbgOrgDataAuthor, 0);
            this.Controls.SetChildIndex(this.cbgObjDataAuthor, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UICheckBoxGroup cbgOrgDataAuthor;
        private Sunny.UI.UICheckBoxGroup cbgObjDataAuthor;
    }
}