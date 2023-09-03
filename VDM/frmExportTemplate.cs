using Aspose.Cells;
using com.vdm.common;
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
    public partial class frmExportTemplate : UIEditForm
    {
        private string object_name;
        public frmExportTemplate()
        {
            InitializeComponent();
        }

        public frmExportTemplate(string object_name)
        {
            InitializeComponent();
            this.object_name = object_name;
        }

        private void frmExportTemplate_Load(object sender, EventArgs e)
        {

        }


        private void lbInformation_Click(object sender, EventArgs e)
        {

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            DialogResult result =  this.folderBrowserDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string selectedPath = this.folderBrowserDialog.SelectedPath;
                string fileName = object_name + "信息导入模板.xlsx";
                this.tbSavePath.Text = Path.Combine(selectedPath, fileName);
            }
           
        }
        protected override bool CheckData()
        {
            return CheckEmpty(this.tbPassword, "请输入模板文件的访问密码。")
                && CheckEmpty(this.tbSavePath, "请选择模板文件保存路径。");
        }

        /// <summary>
        ///  导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.IsOK == false)
            {
                return;
            }
            Aspose.Cells.License li = new Aspose.Cells.License();
            li.SetLicense(System.IO.Directory.GetCurrentDirectory() + "\\aspose\\License.lic");//破解证书
            string mypath = this.tbSavePath.Text;
            string password = tbPassword.Text;
            Workbook book = new Workbook();
            switch (this.object_name)
            {
                case Data_Object_Const.ANIMAL:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\畜牧信息导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.COMPANY:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.FAMER:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.HOUSE:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.LAND:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.PEOPLE:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.PLANT:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\种植信息导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                case Data_Object_Const.TOUR:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\旅游信息导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
                default:
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);
                    break;
            }

            try
            {
                book.Password = password;
                book.Save(mypath);
                ShowInfoDialog("导出模板成功。");
            }
            catch(Exception ex)
            {
                ShowErrorDialog("导出模板失败，错误信息：" + ex.Message);
            }
        }
    }
}
