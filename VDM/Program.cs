using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\db_file\\vdm_data.db") == false)
            {
                MessageBox.Show("数据库文件不存在或路径不正确，请检查。", "运行错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmLogin login = new frmLogin();
            login.InitCheckUpdate();
            //login.ShowDialog();
            //if (login.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new frmMain());
            //}

        }

    }
}
