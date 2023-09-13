using Aspose.Cells;
using Microsoft.VisualBasic;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form.utils
{
  public  class ExcelUtil
    {

        private DataTable dt = null;
        private DataGridView dg = null;
        //要导出的ListView
        private  ListView lv;

            public  ListView Lv
            {
                get
                {
                    return lv;
                }

                set
                {
                    lv = value;
                }
            }
        public ExcelUtil()
        {

        }

        public ExcelUtil(DataGridView dg,DataTable dt)
        {
            this.dt = dt;
            this.dg = dg;
        }


        /// <summary>
        /// ListView导出为Excel表格
        /// </summary>
        /// <param name="path">文件完整路径</param>
        /// <param name="password">文件保护密码</param>
        public bool exportExcel(string path, string password)
        {

            try
            {
                License li = new License();
                li.SetLicense(System.IO.Directory.GetCurrentDirectory() + "\\aspose\\License.lic");//破解证书
                // 创建工作簿
                Workbook book = new Workbook();
                // 创建工作表
                Worksheet sheet = book.Worksheets[0];

                int x = 0;
                foreach (DataGridViewColumn column in dg.Columns)
                {
                    sheet.Cells[0, x++].PutValue(column.HeaderText);
                }

                ////设置excel值
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    for (int j = 0; j < dg.Columns.Count; j++)//每行中的每项
                    {
                        sheet.Cells[i + 1, j].PutValue(dt.Rows[i][dg.Columns[j].DataPropertyName].ToString());
                    }
                }
                // 指定 XOR 加密类型
                book.SetEncryptionOptions(EncryptionType.XOR, 40);

                // 指定强加密类型（RC4，Microsoft Strong Cryptographic Provider）
                book.SetEncryptionOptions(EncryptionType.StrongCryptographicProvider, 128);

                // 密码保护文件
                book.Password = password;
                sheet.AutoFitColumns(); //自适应宽
                book.Save(path);
                GC.Collect();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 选择EXCEL文件并导出为DataTable
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable ExcelToDataTable()
        {
             OpenFileDialog dialog = new OpenFileDialog();
            //过滤选择文件
             dialog.Filter = "EXCEL 文件|*.xlsx";
             DialogResult result = dialog.ShowDialog();
             DataTable dataTable = new DataTable();
            //导入对话框 选择打开
            if (result == DialogResult.OK)
            {
                string filepath = dialog.FileName;
                string pathFinal = filepath.Replace('\\', '/');
                string password = Interaction.InputBox("请输入EXCEL保护密码", "输入密码", "", Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 4);
                Workbook book = new Workbook();
                if(""!=password)
                {
                    try
                    {
                        book.Open(pathFinal, FileFormatType.Excel2007Xlsx, password);
                        //MessageBox.Show("密码正确");
                    }
                    catch
                    {
                        MessageBox.Show("密码错误");
                    }

                    // Excel 中 sheets 数量必须大于 0
                    if (book.Worksheets.Count > 0)
                    {
                        // 导入 Excel 文件中的第一个 sheets 工作表
                        Cells cells = book.Worksheets[0].Cells;
                        // sheets 中的数据必须存在
                        if (cells.MaxDataRow != -1 && cells.MaxDataColumn != -1)
                        {
                            // 方法 ExportDataTable 的参数说明
                            //  要导出的第一个单元格的行号。
                            //  要导出的第一个单元格的列号。
                            //  要导入的行数。
                            //  要导入的列数。
                            //  指示第一行的数据是否导出到DataTable的列名。
                            dataTable = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
                        }
                    }
                }
                return dataTable;
            }
            return dataTable;
        }
        /// <summary>
        ///  重新批量导入方法
        /// </summary>
        /// <param name="fileName">导入文件的全称</param>
        /// <param name="password">导入文件的密码</param>
        /// <returns></returns>
        public static DataTable ExcelToDataTable(string fileName,string password,out string errMessage)
        {
            DataTable dataTable = null;
            Workbook book = new Workbook();
            try
            {
                book.Open(fileName, FileFormatType.Excel2007Xlsx, password);
                // Excel 中 sheets 数量必须大于 0
                if (book.Worksheets.Count > 0)
                {
                    // 导入 Excel 文件中的第一个 sheets 工作表
                    Cells cells = book.Worksheets[0].Cells;
                    // sheets 中的数据必须存在
                    if (cells.MaxDataRow != -1 && cells.MaxDataColumn != -1)
                    {
                        // 方法 ExportDataTable 的参数说明
                        //  要导出的第一个单元格的行号。
                        //  要导出的第一个单元格的列号。
                        //  要导入的行数。
                        //  要导入的列数。
                        //  指示第一行的数据是否导出到DataTable的列名。
                        dataTable = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
                    }
                }
                errMessage = "";
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                MessageBox.Show("文件导入异常：" + "\r\n"+"1、请检查密码是否正确！" + "\r\n" +"2、请检查被导入Excel是否在其它程序打开！" );
            }
            return dataTable;
        }
    }
}
