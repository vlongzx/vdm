namespace com.vdm.form
{
    partial class frmDictInfo
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tbDict_code = new Sunny.UI.UITextBox();
            this.tbDict_name = new Sunny.UI.UITextBox();
            this.btKey = new Sunny.UI.UITextBox();
            this.btValue = new Sunny.UI.UITextBox();
            this.btIndex = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(57, 81);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(158, 31);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "字典项标识：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(57, 133);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(158, 31);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "字典项名称：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(57, 189);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(80, 31);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "KEY：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(57, 241);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(114, 31);
            this.uiLabel4.TabIndex = 2;
            this.uiLabel4.Text = "VALUE：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(57, 294);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(111, 31);
            this.uiLabel5.TabIndex = 2;
            this.uiLabel5.Text = "INDEX：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDict_code
            // 
            this.tbDict_code.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbDict_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDict_code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDict_code.Location = new System.Drawing.Point(222, 83);
            this.tbDict_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDict_code.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbDict_code.Name = "tbDict_code";
            this.tbDict_code.Padding = new System.Windows.Forms.Padding(5);
            this.tbDict_code.ReadOnly = true;
            this.tbDict_code.ShowText = false;
            this.tbDict_code.Size = new System.Drawing.Size(290, 29);
            this.tbDict_code.TabIndex = 3;
            this.tbDict_code.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDict_code.Watermark = "";
            // 
            // tbDict_name
            // 
            this.tbDict_name.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.tbDict_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDict_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDict_name.Location = new System.Drawing.Point(222, 135);
            this.tbDict_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDict_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbDict_name.Name = "tbDict_name";
            this.tbDict_name.Padding = new System.Windows.Forms.Padding(5);
            this.tbDict_name.ReadOnly = true;
            this.tbDict_name.ShowText = false;
            this.tbDict_name.Size = new System.Drawing.Size(290, 29);
            this.tbDict_name.TabIndex = 3;
            this.tbDict_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbDict_name.Watermark = "";
            // 
            // btKey
            // 
            this.btKey.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.btKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btKey.Location = new System.Drawing.Point(222, 189);
            this.btKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btKey.MinimumSize = new System.Drawing.Size(1, 16);
            this.btKey.Name = "btKey";
            this.btKey.Padding = new System.Windows.Forms.Padding(5);
            this.btKey.ShowText = false;
            this.btKey.Size = new System.Drawing.Size(290, 29);
            this.btKey.TabIndex = 3;
            this.btKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKey.Watermark = "";
            // 
            // btValue
            // 
            this.btValue.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.btValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btValue.Location = new System.Drawing.Point(222, 243);
            this.btValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.btValue.Name = "btValue";
            this.btValue.Padding = new System.Windows.Forms.Padding(5);
            this.btValue.ShowText = false;
            this.btValue.Size = new System.Drawing.Size(290, 29);
            this.btValue.TabIndex = 3;
            this.btValue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValue.Watermark = "";
            // 
            // btIndex
            // 
            this.btIndex.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.btIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btIndex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btIndex.Location = new System.Drawing.Point(222, 296);
            this.btIndex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btIndex.MinimumSize = new System.Drawing.Size(1, 16);
            this.btIndex.Name = "btIndex";
            this.btIndex.Padding = new System.Windows.Forms.Padding(5);
            this.btIndex.ShowText = false;
            this.btIndex.Size = new System.Drawing.Size(290, 29);
            this.btIndex.TabIndex = 3;
            this.btIndex.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIndex.Watermark = "";
            // 
            // frmDictInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btIndex);
            this.Controls.Add(this.btValue);
            this.Controls.Add(this.btKey);
            this.Controls.Add(this.tbDict_name);
            this.Controls.Add(this.tbDict_code);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Name = "frmDictInfo";
            this.Text = "frmDictInfo";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 600, 450);
            this.Load += new System.EventHandler(this.frmDictInfo_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.tbDict_code, 0);
            this.Controls.SetChildIndex(this.tbDict_name, 0);
            this.Controls.SetChildIndex(this.btKey, 0);
            this.Controls.SetChildIndex(this.btValue, 0);
            this.Controls.SetChildIndex(this.btIndex, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox tbDict_code;
        private Sunny.UI.UITextBox tbDict_name;
        private Sunny.UI.UITextBox btKey;
        private Sunny.UI.UITextBox btValue;
        private Sunny.UI.UITextBox btIndex;
    }
}