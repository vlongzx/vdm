using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form.utils
{
    class ExcelUtil
    {

            //要导出的ListView
            private static ListView lv;

            public static ListView Lv
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

            /// <summary>
            /// ListView导出为Excel表格
            /// </summary>
            /// <param name="path">文件完整路径</param>
            /// <param name="password">文件保护密码</param>
            public static void exportExcel(string path, string password)
            {

                Aspose.Cells.License li = new Aspose.Cells.License();
            ;
                li.SetLicense(System.IO.Directory.GetCurrentDirectory() + "\\aspose\\License.lic");//破解证书
                                                    // 创建工作簿
                Workbook book = new Workbook();
                // 创建工作表
                Worksheet sheet = book.Worksheets[0];

                int x = 0;
                foreach (ColumnHeader header in lv.Columns)
                {
                    sheet.Cells[0, x++].PutValue(header.Text);
                }

                ////设置excel值
                int rowLenth = lv.Items.Count;//行数
                for (int i = 0; i < rowLenth; i++)//遍历listView1的每一行
                {

                    for (int j = 0; j < lv.Items[i].SubItems.Count; j++)//每行中的每项
                    {
                        sheet.Cells[i + 1, j].PutValue(lv.Items[i].SubItems[j].Text);
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
            }
        }
}
