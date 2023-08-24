namespace com.vdm.form
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btPeople = new Sunny.UI.UIHeaderButton();
            this.btFamer = new Sunny.UI.UIHeaderButton();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Footer.Location = new System.Drawing.Point(0, 727);
            this.Footer.Size = new System.Drawing.Size(1797, 56);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.Header.Controls.Add(this.btFamer);
            this.Header.Controls.Add(this.btPeople);
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Size = new System.Drawing.Size(1797, 110);
            // 
            // btPeople
            // 
            this.btPeople.CircleColor = System.Drawing.Color.Purple;
            this.btPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPeople.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btPeople.Location = new System.Drawing.Point(53, 12);
            this.btPeople.MinimumSize = new System.Drawing.Size(1, 1);
            this.btPeople.Name = "btPeople";
            this.btPeople.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btPeople.Radius = 0;
            this.btPeople.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btPeople.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btPeople.Size = new System.Drawing.Size(100, 88);
            this.btPeople.Style = Sunny.UI.UIStyle.Custom;
            this.btPeople.Symbol = 61447;
            this.btPeople.SymbolSize = 40;
            this.btPeople.TabIndex = 5;
            this.btPeople.Text = "人员";
            this.btPeople.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPeople.Click += new System.EventHandler(this.tspPeople_Click);
            // 
            // btFamer
            // 
            this.btFamer.CircleColor = System.Drawing.Color.RoyalBlue;
            this.btFamer.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btFamer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFamer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btFamer.Location = new System.Drawing.Point(172, 12);
            this.btFamer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btFamer.Name = "btFamer";
            this.btFamer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btFamer.Radius = 0;
            this.btFamer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btFamer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btFamer.ShowCircleHoverColor = true;
            this.btFamer.ShowTips = true;
            this.btFamer.Size = new System.Drawing.Size(100, 88);
            this.btFamer.Style = Sunny.UI.UIStyle.Custom;
            this.btFamer.Symbol = 61461;
            this.btFamer.TabIndex = 6;
            this.btFamer.Text = "农户";
            this.btFamer.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFamer.TipsText = "12";
            this.btFamer.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1797, 783);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "乡村数据采集系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1797, 783);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIHeaderButton btPeople;
        private Sunny.UI.UIHeaderButton btFamer;
    }
}

