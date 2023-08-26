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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btPeople = new Sunny.UI.UIHeaderButton();
            this.btFamer = new Sunny.UI.UIHeaderButton();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.btLand = new Sunny.UI.UIHeaderButton();
            this.btCompany = new Sunny.UI.UIHeaderButton();
            this.btHouse = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            this.btAnimal = new Sunny.UI.UIHeaderButton();
            this.btTour = new Sunny.UI.UIHeaderButton();
            this.btPlant = new Sunny.UI.UIHeaderButton();
            this.uiHeaderButton8 = new Sunny.UI.UIHeaderButton();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Footer.Location = new System.Drawing.Point(0, 727);
            this.Footer.Size = new System.Drawing.Size(1797, 56);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.Header.Controls.Add(this.uiHeaderButton8);
            this.Header.Controls.Add(this.btPlant);
            this.Header.Controls.Add(this.btTour);
            this.Header.Controls.Add(this.btAnimal);
            this.Header.Controls.Add(this.uiHeaderButton4);
            this.Header.Controls.Add(this.btHouse);
            this.Header.Controls.Add(this.btCompany);
            this.Header.Controls.Add(this.btLand);
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
            this.btFamer.Location = new System.Drawing.Point(167, 12);
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
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            // 
            // btLand
            // 
            this.btLand.CircleColor = System.Drawing.Color.Chocolate;
            this.btLand.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btLand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLand.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btLand.Location = new System.Drawing.Point(281, 12);
            this.btLand.MinimumSize = new System.Drawing.Size(1, 1);
            this.btLand.Name = "btLand";
            this.btLand.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btLand.Radius = 0;
            this.btLand.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btLand.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btLand.ShowCircleHoverColor = true;
            this.btLand.ShowTips = true;
            this.btLand.Size = new System.Drawing.Size(100, 88);
            this.btLand.Style = Sunny.UI.UIStyle.Custom;
            this.btLand.Symbol = 361646;
            this.btLand.SymbolOffset = new System.Drawing.Point(-4, 0);
            this.btLand.SymbolSize = 40;
            this.btLand.TabIndex = 6;
            this.btLand.Text = "土地";
            this.btLand.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLand.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // btCompany
            // 
            this.btCompany.CircleColor = System.Drawing.Color.DarkTurquoise;
            this.btCompany.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCompany.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btCompany.Location = new System.Drawing.Point(395, 12);
            this.btCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCompany.Name = "btCompany";
            this.btCompany.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btCompany.Radius = 0;
            this.btCompany.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btCompany.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btCompany.ShowCircleHoverColor = true;
            this.btCompany.ShowTips = true;
            this.btCompany.Size = new System.Drawing.Size(100, 88);
            this.btCompany.Style = Sunny.UI.UIStyle.Custom;
            this.btCompany.Symbol = 361869;
            this.btCompany.SymbolSize = 30;
            this.btCompany.TabIndex = 6;
            this.btCompany.Text = "企业";
            this.btCompany.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCompany.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // btHouse
            // 
            this.btHouse.CircleColor = System.Drawing.Color.Orange;
            this.btHouse.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHouse.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btHouse.Location = new System.Drawing.Point(509, 12);
            this.btHouse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btHouse.Name = "btHouse";
            this.btHouse.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btHouse.Radius = 0;
            this.btHouse.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btHouse.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btHouse.ShowCircleHoverColor = true;
            this.btHouse.ShowTips = true;
            this.btHouse.Size = new System.Drawing.Size(100, 88);
            this.btHouse.Style = Sunny.UI.UIStyle.Custom;
            this.btHouse.Symbol = 358703;
            this.btHouse.SymbolOffset = new System.Drawing.Point(-2, 0);
            this.btHouse.SymbolSize = 30;
            this.btHouse.TabIndex = 6;
            this.btHouse.Text = "房屋";
            this.btHouse.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHouse.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // uiHeaderButton4
            // 
            this.uiHeaderButton4.CircleColor = System.Drawing.Color.OrangeRed;
            this.uiHeaderButton4.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiHeaderButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiHeaderButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiHeaderButton4.Location = new System.Drawing.Point(623, 12);
            this.uiHeaderButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton4.Name = "uiHeaderButton4";
            this.uiHeaderButton4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton4.Radius = 0;
            this.uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton4.ShowCircleHoverColor = true;
            this.uiHeaderButton4.ShowTips = true;
            this.uiHeaderButton4.Size = new System.Drawing.Size(100, 88);
            this.uiHeaderButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton4.Symbol = 363137;
            this.uiHeaderButton4.SymbolOffset = new System.Drawing.Point(-2, 0);
            this.uiHeaderButton4.SymbolSize = 30;
            this.uiHeaderButton4.TabIndex = 6;
            this.uiHeaderButton4.Text = "村情";
            this.uiHeaderButton4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton4.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // btAnimal
            // 
            this.btAnimal.CircleColor = System.Drawing.Color.Gold;
            this.btAnimal.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnimal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btAnimal.Location = new System.Drawing.Point(737, 12);
            this.btAnimal.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAnimal.Name = "btAnimal";
            this.btAnimal.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btAnimal.Radius = 0;
            this.btAnimal.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btAnimal.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btAnimal.ShowCircleHoverColor = true;
            this.btAnimal.ShowTips = true;
            this.btAnimal.Size = new System.Drawing.Size(100, 88);
            this.btAnimal.Style = Sunny.UI.UIStyle.Custom;
            this.btAnimal.Symbol = 363216;
            this.btAnimal.SymbolOffset = new System.Drawing.Point(-4, 0);
            this.btAnimal.SymbolSize = 30;
            this.btAnimal.TabIndex = 6;
            this.btAnimal.Text = "畜牧";
            this.btAnimal.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAnimal.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // btTour
            // 
            this.btTour.CircleColor = System.Drawing.Color.Fuchsia;
            this.btTour.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTour.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btTour.Location = new System.Drawing.Point(851, 12);
            this.btTour.MinimumSize = new System.Drawing.Size(1, 1);
            this.btTour.Name = "btTour";
            this.btTour.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btTour.Radius = 0;
            this.btTour.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btTour.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btTour.ShowCircleHoverColor = true;
            this.btTour.ShowTips = true;
            this.btTour.Size = new System.Drawing.Size(100, 88);
            this.btTour.Style = Sunny.UI.UIStyle.Custom;
            this.btTour.Symbol = 363212;
            this.btTour.SymbolOffset = new System.Drawing.Point(-2, 0);
            this.btTour.SymbolSize = 30;
            this.btTour.TabIndex = 6;
            this.btTour.Text = "旅游";
            this.btTour.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTour.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // btPlant
            // 
            this.btPlant.CircleColor = System.Drawing.Color.LimeGreen;
            this.btPlant.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlant.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btPlant.Location = new System.Drawing.Point(965, 12);
            this.btPlant.MinimumSize = new System.Drawing.Size(1, 1);
            this.btPlant.Name = "btPlant";
            this.btPlant.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.btPlant.Radius = 0;
            this.btPlant.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.btPlant.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.btPlant.ShowCircleHoverColor = true;
            this.btPlant.ShowTips = true;
            this.btPlant.Size = new System.Drawing.Size(100, 88);
            this.btPlant.Style = Sunny.UI.UIStyle.Custom;
            this.btPlant.Symbol = 362680;
            this.btPlant.SymbolOffset = new System.Drawing.Point(-2, 0);
            this.btPlant.SymbolSize = 30;
            this.btPlant.TabIndex = 6;
            this.btPlant.Text = "种植";
            this.btPlant.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPlant.Click += new System.EventHandler(this.btFamer_Click);
            // 
            // uiHeaderButton8
            // 
            this.uiHeaderButton8.CircleColor = System.Drawing.Color.Crimson;
            this.uiHeaderButton8.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiHeaderButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiHeaderButton8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiHeaderButton8.Location = new System.Drawing.Point(1079, 12);
            this.uiHeaderButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton8.Name = "uiHeaderButton8";
            this.uiHeaderButton8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton8.Radius = 0;
            this.uiHeaderButton8.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton8.ShowCircleHoverColor = true;
            this.uiHeaderButton8.ShowTips = true;
            this.uiHeaderButton8.Size = new System.Drawing.Size(100, 88);
            this.uiHeaderButton8.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton8.Symbol = 61459;
            this.uiHeaderButton8.SymbolSize = 40;
            this.uiHeaderButton8.TabIndex = 6;
            this.uiHeaderButton8.Text = "设置";
            this.uiHeaderButton8.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiHeaderButton8.Click += new System.EventHandler(this.btFamer_Click);
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
        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UIHeaderButton uiHeaderButton8;
        private Sunny.UI.UIHeaderButton btPlant;
        private Sunny.UI.UIHeaderButton btTour;
        private Sunny.UI.UIHeaderButton btAnimal;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
        private Sunny.UI.UIHeaderButton btHouse;
        private Sunny.UI.UIHeaderButton btCompany;
        private Sunny.UI.UIHeaderButton btLand;
    }
}

