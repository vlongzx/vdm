using com.vdm.form.utils;
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
    public partial class frmExportExcel : Form
    {
        ExcelUtil excelUtil;
        public frmExportExcel()
        {
            InitializeComponent();
        }
        public frmExportExcel(ExcelUtil excelUtil)
        {
            this.excelUtil = excelUtil;
            InitializeComponent();
        }
        /// <summary>
        /// 选择文件导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExport_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton=false;//关闭新建文件夹
            dialog.Description = "请选择一个目录作为导出Excel文件的保存路径：";
            dialog.ShowDialog();
            string mypath = dialog.SelectedPath.Replace('\\', '/');
            string fileName = tbFile_name.Text;
            string password = tbFile_password.Text;
            if (!string.IsNullOrWhiteSpace(mypath))
            {
                string pathFinal = mypath + '/' + fileName + ".xlsx";
                this.Close();
                if (pathFinal.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("文件名与密码均需要输入！");
                }
                else
                {
                    bool result = this.excelUtil.exportExcel(pathFinal, password);
                    if (result)
                    {
                        MessageBox.Show("导出成功");
                    }
                    else
                    {
                        MessageBox.Show("导出失败");
                    }
                }

            }
   
}

        private void frmExportExcel_Load(object sender, EventArgs e)
        {

        }

        private void frmExportExcel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
