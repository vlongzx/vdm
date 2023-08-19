using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
       
            
        }

        private void OpenForm(Form subForm)
        {
            foreach (Control item in this.panelMain.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            subForm.TopLevel = false;// 将子窗体设置为非顶级控件
            subForm.FormBorderStyle = FormBorderStyle.None;//设置无边框
            subForm.Parent = this.panelMain;//设置窗体容器
            subForm.Dock = DockStyle.Fill; //容器大小随着调整窗体大小自动变化
            subForm.Show();
        }

        private void tspPeople_Click(object sender, EventArgs e)
        {
            OpenForm(new frmPeople());
        }
    }
}
