
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using com.vdm.AutoUpdater;

namespace com.vdm.AutoUpdater
{
    #region The delegate
    public delegate void ShowHandler();
    #endregion

    public class AutoUpdater : IAutoUpdater
    {
        private Config config = null;
        private bool bNeedRestart = false;
        private bool bDownload = false; //是否下载更新
        List<DownloadFileInfo> downloadFileListTemp = null;

        public event ShowHandler OnShow;

        #region 构造函数
        /// <summary>
        ///  构造函数，加载解析本地的更新配置文件
        /// </summary>
        public AutoUpdater()
        {
            config = Config.LoadConfig(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConstFile.FILENAME));
        }
        #endregion

        #region 检查需要更新文件的数量
        /// <summary>
        ///  检查需要更新文件的数量
        /// </summary>
        /// <returns></returns>
        public int   CheckUpdaterFileCount()
        {
            int fileCount = 0;
            if (!config.Enabled)//禁止更新
            {
                return fileCount;
            }
            Dictionary<string, RemoteFile> listRemotFile = ParseRemoteXml(config.ServerUrl);
            List<DownloadFileInfo> downloadList = new List<DownloadFileInfo>();

            foreach (LocalFile file in config.UpdateFileList)
            {
                if (listRemotFile.ContainsKey(file.Path))
                {
                    RemoteFile rf = listRemotFile[file.Path];
                    string v1 = rf.Verison;
                    string v2 = file.Version;
                    if (v1 != v2)
                    {
                        fileCount = fileCount + 1;
                    }
                }
            }
            return fileCount;
        }
        #endregion

        #region 程序更新方法
        /// <summary>
        ///  程序更新
        /// </summary>
        public void Update()
        {
            try
            {
                if (!config.Enabled)
                    return;

                Dictionary<string, RemoteFile> listRemotFile = ParseRemoteXml(config.ServerUrl);//解析服务器更新文件列表
                List<DownloadFileInfo> downloadList = new List<DownloadFileInfo>();

                foreach (LocalFile file in config.UpdateFileList)
                {
                    if (listRemotFile.ContainsKey(file.Path))//存在相同路径的文件
                    {
                        RemoteFile rf = listRemotFile[file.Path];
                        string v1 = rf.Verison;
                        string v2 = file.Version;
                        if (v1 != v2)
                        {
                            downloadList.Add(new DownloadFileInfo(rf.Url, rf.Path, rf.LastVer, rf.Size, rf.Verison));
                            file.Path = rf.Path;
                            file.LastVer = rf.LastVer;
                            file.Size = rf.Size;
                            file.Version = rf.Verison;
                            if (rf.NeedRestart)
                                bNeedRestart = true;

                            bDownload = true;
                        }
                        listRemotFile.Remove(file.Path);
                    }
                }
                //将新增加的文件也加入下载列表
                foreach (RemoteFile file in listRemotFile.Values)
                {
                    downloadList.Add(new DownloadFileInfo(file.Url, file.Path, file.LastVer, file.Size, file.Verison));
                    bDownload = true;
                    config.UpdateFileList.Add(new LocalFile(file.Path, file.LastVer, file.Size, file.Verison));
                    if (file.NeedRestart)
                        bNeedRestart = true;
                }

                downloadFileListTemp = downloadList;

                if (bDownload)
                {
                    OperProcess op = new OperProcess();
                    op.InitUpdateEnvironment(); //验证当前主程序是否运行，如果允许则关闭。
                    if (this.OnShow != null)
                        this.OnShow();
                    StartDownload(downloadList);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RollBack()
        {
            foreach (DownloadFileInfo file in downloadFileListTemp)
            {
                string tempUrlPath = CommonUnitity.GetFolderUrl(file);
                string oldPath = string.Empty;
                try
                {
                    if (!string.IsNullOrEmpty(tempUrlPath))
                    {
                        oldPath = Path.Combine(CommonUnitity.SystemBinUrl + tempUrlPath.Substring(1), file.FileName);
                    }
                    else
                    {
                        oldPath = Path.Combine(CommonUnitity.SystemBinUrl, file.FileName);
                    }

                    if (oldPath.EndsWith("_"))
                        oldPath = oldPath.Substring(0, oldPath.Length - 1);

                    MoveFolderToOld(oldPath + ".old", oldPath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        #endregion

        #region The private method
        string newfilepath = string.Empty;
        private void MoveFolderToOld(string oldPath, string newPath)
        {
            if (File.Exists(oldPath) && File.Exists(newPath))
            {
                System.IO.File.Copy(oldPath, newPath, true);
            }
        }

        private void StartDownload(List<DownloadFileInfo> downloadList)
        {
            DownloadProgress dp = new DownloadProgress(downloadList);
            if (dp.ShowDialog() == DialogResult.OK)
            {
                //Update successfully
                //config.SaveConfig(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConstFile.FILENAME));
                config.SaveConfig(Path.Combine(System.IO.Directory.GetCurrentDirectory(), ConstFile.FILENAME));
                if (bNeedRestart)
                {
                    //Delete the temp folder
                    Directory.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConstFile.TEMPFOLDERNAME), true);

                    MessageBox.Show(ConstFile.APPLYTHEUPDATE, ConstFile.MESSAGETITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CommonUnitity.RestartApplication();
                }
            }
        }

        private Dictionary<string, RemoteFile> ParseRemoteXml(string xml)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(xml);

                Dictionary<string, RemoteFile> list = new Dictionary<string, RemoteFile>();
                foreach (XmlNode node in document.DocumentElement.ChildNodes)
                {
                    list.Add(node.Attributes["path"].Value, new RemoteFile(node));
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }

}