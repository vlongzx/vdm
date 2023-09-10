using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace com.vdm.AutoUpdater
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

        }
    }
}
