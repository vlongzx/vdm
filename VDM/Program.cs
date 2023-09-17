using com.vdm.AutoUpdater;
using com.vdm.bll;
using com.vdm.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    static class Program
    {
        //定义异步委托
        public delegate void SyncDictDelegate();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\db_file\\vdm_data.db") == false)
            {
                MessageBox.Show("数据库文件不存在或路径不正确，请检查。", "运行错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //判断是否需要初始化账户信息
            UserBLL userBLL = new UserBLL();

            DataTable dt = userBLL.getAllUser();
            if (dt != null && dt.Rows.Count == 0)
            {
                frmInitUserAccount initUserAccount = new frmInitUserAccount();
                initUserAccount.ShowDialog();
            }

            try
            {
                SyncDictDelegate syncDictDelegate = new SyncDictDelegate(DictBLL.syncDict);
                syncDictDelegate.BeginInvoke(null, null);//异步调用
                Thread.Sleep(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int fileCount = 0;
            try
            {
                IAutoUpdater autoUpdater = new com.vdm.AutoUpdater.AutoUpdater();
                fileCount = autoUpdater.CheckUpdaterFileCount();//检查需要更新的文件数量
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message + ex.StackTrace);
            }
            if (fileCount > 0)
            {
                try
                {
                    Process.Start(System.IO.Directory.GetCurrentDirectory() + "\\AutoUpdater.exe");
                }
                catch (Exception ex)
                {
                    LogHelper.Error(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new frmMain());
                }
            }
        }

  

    }
}
