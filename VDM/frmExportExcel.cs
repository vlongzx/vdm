using Aspose.Cells;
using com.vdm.form.utils;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{
    public partial class frmExportExcel : UIEditForm
    {
        private ExcelUtil excelUtil;
        private string object_name;
        public frmExportExcel()
        {
            InitializeComponent();
        }
        public frmExportExcel(ExcelUtil excelUtil,string object_name)
        {
            this.excelUtil = excelUtil;
            InitializeComponent();
            this.object_name = object_name;
        }



//        /// <summary>
//        /// 选择文件导出
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btExport_excel_Click(object sender, EventArgs e)
//        {
//            FolderBrowserDialog dialog = new FolderBrowserDialog();
//            dialog.ShowNewFolderButton=false;//关闭新建文件夹
//            dialog.Description = "请选择一个目录作为导出Excel文件的保存路径：";
//            dialog.ShowDialog();
//            string mypath = dialog.SelectedPath.Replace('\\', '/');
//            string fileName = tbFile_name.Text;
//            string password = tbFile_password.Text;
//            if (!string.IsNullOrWhiteSpace(mypath))
//            {
//                string pathFinal = mypath + '/' + fileName + ".xlsx";
//                this.Close();
//                if (pathFinal.Trim() == "" || password.Trim() == "")
//                {
//                    MessageBox.Show("文件名与密码均需要输入！");
//                }
//                else
//                {
//                    bool result = this.excelUtil.exportExcel(pathFinal, password);
//                    if (result)
//                    {
//                        MessageBox.Show("导出成功");
//                    }
//                    else
//                    {
//                        MessageBox.Show("导出失败");
//                    }
//                }

//            }
   
//}

        private void frmExportExcel_Load(object sender, EventArgs e)
        {

        }

        private void frmExportExcel_Load_1(object sender, EventArgs e)
        {

        }



        private void btExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdialog = new SaveFileDialog();
            sdialog.Filter = "Excel文件|*.xlsx";
            DialogResult sdialogresult = sdialog.ShowDialog();
            if (sdialogresult == DialogResult.OK)
            {
                
            }
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tbFile_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedPath = this.folderBrowserDialog.SelectedPath;
                string fileName = object_name + "信息导出_"+ DateTime.Now.ToString("yyyyMMddHHmm") +".xlsx";
                this.tbSavePath.Text = Path.Combine(selectedPath, fileName);
            }
        }

        protected override bool CheckData()
        {
            return CheckEmpty(this.tbFile_password,"文件访问密码不能为空，请输入。")
                && CheckEmpty(this.tbSavePath,"文件保存路径不能为空，请选择。")
                ;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.IsOK == false)
            {
                return;
            }
            // 获取用户所选文件的路径
            string selectedFilePath = this.tbSavePath.Text;
            string password = tbFile_password.Text;
            bool result = this.excelUtil.exportExcel(selectedFilePath, password);
            if (result)
            {
                ShowInfoDialog("导出成功");
            }
            else
            {
                ShowInfoDialog("导出失败");
            }
        }
    }
}
