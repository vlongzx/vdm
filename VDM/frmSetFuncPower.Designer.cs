namespace com.vdm.form
{
    partial class frmSetFuncPower
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
            this.tvFunc = new Sunny.UI.UITreeView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tbRole_Name = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 804);
            this.pnlBtm.Size = new System.Drawing.Size(502, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tvFunc
            // 
            this.tvFunc.CheckBoxes = true;
            this.tvFunc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvFunc.FillColor = System.Drawing.Color.White;
            this.tvFunc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvFunc.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tvFunc.Location = new System.Drawing.Point(1, 120);
            this.tvFunc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvFunc.MinimumSize = new System.Drawing.Size(1, 1);
            this.tvFunc.Name = "tvFunc";
            this.tvFunc.ShowText = false;
            this.tvFunc.Size = new System.Drawing.Size(502, 684);
            this.tvFunc.TabIndex = 2;
            this.tvFunc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(18, 65);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 32);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "角色名称：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRole_Name
            // 
            this.tbRole_Name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbRole_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRole_Name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRole_Name.Location = new System.Drawing.Point(113, 68);
            this.tbRole_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRole_Name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbRole_Name.Name = "tbRole_Name";
            this.tbRole_Name.Padding = new System.Windows.Forms.Padding(5);
            this.tbRole_Name.ShowText = false;
            this.tbRole_Name.Size = new System.Drawing.Size(362, 29);
            this.tbRole_Name.TabIndex = 4;
            this.tbRole_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbRole_Name.Watermark = "";
            // 
            // frmSetFuncPower
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 862);
            this.Controls.Add(this.tbRole_Name);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.tvFunc);
            this.Name = "frmSetFuncPower";
            this.Text = "设置功能权限";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmSetFuncPower_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.tvFunc, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.tbRole_Name, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITreeView tvFunc;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox tbRole_Name;
    }
}