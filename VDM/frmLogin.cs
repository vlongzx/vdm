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

            UserBLL userBLL = new UserBLL();

            int result = userBLL.Login(username, password);

            if(result == 1)
            {
                LoginInfo.CurrentUser.Account = username;
                LoginInfo.CurrentUser.AccountName = username;
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
        /// <summary>
        ///  检查程序更新
        /// </summary>
        public void InitCheckUpdate()
        {
            #region check and download new version program
            bool bHasError = false;
            IAutoUpdater autoUpdater = new com.vdm.AutoUpdater.AutoUpdater();
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                MessageBox.Show("服务器连接失败");
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                MessageBox.Show("下载更新文件错误");
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                MessageBox.Show("升级文件配置错误");
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                MessageBox.Show("下载升级文件错误");
            }
            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("更新过程中出现错误");
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                        //Log the message to your file or database
                    }
                }
                OperProcess op = new OperProcess();
                //启动进程
                op.StartProcess();
            }
            #endregion
        }
    }
}
