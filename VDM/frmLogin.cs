using com.vdm.bll;
using com.vdm.common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    public partial class frmLogin : UIForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 系统登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text.Trim();

            UserBLL userBLL = new UserBLL();

            int result = userBLL.Login(username, password);

            if(result == 1)
            {
                LoginInfo.CurrentUser.Account = username;
                LoginInfo.CurrentUser.LoginTime = DateTime.Now;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else{
                MessageBox.Show("用户名或者密码错误！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this.btLogin, EventArgs.Empty);
            }
        }
        /// <summary>
        ///  窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.labSystemName.Text = ConfigurationManager.AppSettings["system_name"];
        }
    }
}
