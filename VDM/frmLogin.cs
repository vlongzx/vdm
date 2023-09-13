using com.vdm.AutoUpdater;
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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

            if(username == "")
            {
                MessageBox.Show("请输入登录用户名！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (password == "")
            {
                MessageBox.Show("请输入登录密码！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UserBLL userBLL = new UserBLL();

            //int result = userBLL.Login(username, password);
            DataTable userdt= userBLL.Login(username, password);
            if (userdt != null)
            {
                LoginInfo.CurrentUser.Account = username;
                LoginInfo.CurrentUser.AccountName = username;
                LoginInfo.CurrentUser.Town = userdt.Rows[0]["town"].ToString();
                LoginInfo.CurrentUser.Village = userdt.Rows[0]["village"].ToString();
                LoginInfo.CurrentUser.RoleName = userdt.Rows[0]["role_name"].ToString();
                LoginInfo.CurrentUser.LoginTime = DateTime.Now;


                //获得当前用户角色对应的功能权限类比
                RoleBLL roleBLL = new RoleBLL();
                DataTable dtFuncPower = roleBLL.getRoleFuncPower(userdt.Rows[0]["character_id"].ToString());
                if(dtFuncPower != null)
                {
                    List<string> funcPowerList = new List<string>();
                    foreach(DataRow row in dtFuncPower.Rows)
                    {
                        funcPowerList.Add(row["function_id"].ToString());
                    }

                    LoginInfo.FuncPowerList = funcPowerList;
                }
               
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
