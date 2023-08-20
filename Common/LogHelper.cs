using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//此处是配置log4net配置文件所在位置，很关键，多数是因为此处没有配置对导致无log输出的
//ConfigFile 表示log4net配置文件所在的位置。
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.xml", ConfigFileExtension = "config", Watch = true)]
namespace com.vdm.common
{

        public class LogHelper
        {
            //GetLogger表示log4net配置文件中logger标签中name属性，此处要一致 不然无log输出
            private static readonly log4net.ILog Log = log4net.LogManager.GetLogger("RollingLogFileAppender");
            //  private static readonly log4net.ILog logError = log4net.LogManager.GetLogger("logerror");

            /// <summary>
            /// 记录Info日志
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="ex"></param>
            public static void Info(string msg)
            {
                if (Log.IsInfoEnabled)
                {
                    Log.Info(msg);
                }
            }

            /// <summary>
            /// 记录Fatal日志
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="ex"></param>
            public static void Fatal(string msg)
            {
                if (Log.IsFatalEnabled)
                {
                    Log.Fatal(msg);
                }
            }

            /// <summary>
            /// 记录Debug日志
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="ex"></param>
            public static void Debug(string msg)
            {
                if (Log.IsDebugEnabled)
                {
                    Log.Debug(msg);
                }
            }
            /// <summary>
            /// 记录Warn日志
            /// </summary>
            /// <param name="msg"></param>
            /// <param name="ex"></param>
            public static void Warn(string msg)
            {
                if (Log.IsWarnEnabled)
                {
                    Log.Warn(msg);
                }
            }


            /// <summary>
            /// 记录Error日志
            /// </summary>
            /// <param name="errorMsg"></param>
            /// <param name="ex"></param>
            public static void Error(string info, Exception ex = null)
            {
                if (!string.IsNullOrEmpty(info) && ex == null)
                {
                    Log.ErrorFormat("【附加信息】 : {0}<br>", new object[] { info });
                }
                else if (!string.IsNullOrEmpty(info) && ex != null)
                {
                    string errorMsg = BeautyErrorMsg(ex);
                    Log.ErrorFormat("【附加信息】 : {0}<br>{1}", new object[] { info, errorMsg });
                }
                else if (string.IsNullOrEmpty(info) && ex != null)
                {
                    string errorMsg = BeautyErrorMsg(ex);
                    Log.Error(errorMsg);
                }
            }

            /// <summary>
            /// 美化错误信息
            /// </summary>
            /// <param name="ex">异常</param>
            /// <returns>错误信息</returns>
            private static string BeautyErrorMsg(Exception ex)
            {
                string errorMsg = string.Format("【异常类型】：{0} <br>【异常信息】：{1} <br>【堆栈调用】：{2}", new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });
                errorMsg = errorMsg.Replace("\r\n", "<br>");
                errorMsg = errorMsg.Replace("位置", "<strong style=\"color:red\">位置</strong>");
                return errorMsg;
            }
        }
    }
