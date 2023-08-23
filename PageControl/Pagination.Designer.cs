namespace PageControl
{
    partial class Pagination
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btFirst = new System.Windows.Forms.Button();
            this.btPre = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.tbPageIndex = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPageSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labPageIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFirst
            // 
            this.btFirst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFirst.Location = new System.Drawing.Point(585, 8);
            this.btFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(107, 47);
            this.btFirst.TabIndex = 1;
            this.btFirst.Text = "第一页";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPre
            // 
            this.btPre.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPre.Location = new System.Drawing.Point(700, 8);
            this.btPre.Margin = new System.Windows.Forms.Padding(4);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(105, 47);
            this.btPre.TabIndex = 1;
            this.btPre.Text = "上一页";
            this.btPre.UseVisualStyleBackColor = true;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNext.Location = new System.Drawing.Point(813, 8);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(120, 47);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "下一页";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btEnd.Location = new System.Drawing.Point(941, 8);
            this.btEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(133, 47);
            this.btEnd.TabIndex = 1;
            this.btEnd.Text = "最后一页";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // tbPageIndex
            // 
            this.tbPageIndex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPageIndex.Location = new System.Drawing.Point(1083, 12);
            this.tbPageIndex.Margin = new System.Windows.Forms.Padding(4);
            this.tbPageIndex.Name = "tbPageIndex";
            this.tbPageIndex.Size = new System.Drawing.Size(79, 44);
            this.tbPageIndex.TabIndex = 2;
            this.tbPageIndex.TextChanged += new System.EventHandler(this.tbPageIndex_TextChanged);
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGo.Location = new System.Drawing.Point(1168, 8);
            this.btGo.Margin = new System.Windows.Forms.Padding(4);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(89, 47);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "跳转";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "每页";
            // 
            // cbPageSize
            // 
            this.cbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbPageSize.FormattingEnabled = true;
            this.cbPageSize.Location = new System.Drawing.Point(115, 16);
            this.cbPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbPageSize.Name = "cbPageSize";
            this.cbPageSize.Size = new System.Drawing.Size(73, 41);
            this.cbPageSize.TabIndex = 4;
            this.cbPageSize.SelectionChangeCommitted += new System.EventHandler(this.cbPageSize_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(197, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "条";
            // 
            // labPageIndex
            // 
            this.labPageIndex.AutoSize = true;
            this.labPageIndex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPageIndex.Location = new System.Drawing.Point(284, 21);
            this.labPageIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPageIndex.Name = "labPageIndex";
            this.labPageIndex.Size = new System.Drawing.Size(95, 33);
            this.labPageIndex.TabIndex = 3;
            this.labPageIndex.Text = "第1页";
            this.labPageIndex.Click += new System.EventHandler(this.labPageIndex_Click);
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPageSize);
            this.Controls.Add(this.labPageIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPageIndex);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPre);
            this.Controls.Add(this.btFirst);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(1279, 65);
            this.Load += new System.EventHandler(this.Pagination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.TextBox tbPageIndex;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPageIndex;
    }
}
