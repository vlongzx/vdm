using Aspose.Cells;
using Sunny.UI;
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
    public partial class frmExportTemplate : UIForm
    {
        public frmExportTemplate()
        {
            InitializeComponent();
        }

        private void frmExportTemplate_Load(object sender, EventArgs e)
        {

        }

        private void btTempleExport_Click(object sender, EventArgs e)
        {
            Aspose.Cells.License li = new Aspose.Cells.License();
            li.SetLicense(System.IO.Directory.GetCurrentDirectory() + "\\aspose\\License.lic");//破解证书
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;//关闭新建文件夹
            dialog.Description = "请选择一个目录作为导出Excel文件的保存路径：";
            dialog.ShowDialog();
            string mypath = dialog.SelectedPath.Replace('\\', '/');
            string password = tbPassword.Text;
            if (!string.IsNullOrWhiteSpace(mypath))
            {
                string pathFinal = mypath + '/' + "人员导入模板" + ".xlsx";
                this.Close();
                if (password.Trim() == "")
                {
                    MessageBox.Show("请设置访问密码！");
                }
                else
                {
                    Workbook book = new Workbook();
                    book.Open((System.IO.Directory.GetCurrentDirectory() + "\\aspose\\人员导入模板.xlsx"), FileFormatType.Excel2007Xlsx);

                    try
                    {
                        book.Password = password;
                        book.Save(pathFinal);
                        MessageBox.Show("导出模板成功");
                    }
                    catch
                    {
                        MessageBox.Show("导出模板失败");
                    }
                }
            }
        }
    }
}
