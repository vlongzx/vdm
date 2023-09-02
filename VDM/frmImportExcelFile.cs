using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
using com.vdm.model;
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
    public partial class frmImportExcelFile : UIEditForm
    {
        public frmImportExcelFile()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "老版本Excel文件|*.xls|新版本Excel文件|*.xlsx";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.tbFileName.Text = openFileDialog.FileName;
            }
        }
        /// <summary>
        ///  解析Excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            AnimalBLL animalBLL = null;
            string filename = this.tbFileName.Text;
            string password = this.tbPassword.Text.Trim();
            DataTable dt = ExcelUtil.ExcelToDataTable(filename, password);
            List<Animal> animals = new List<Animal>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Animal animal = new Animal();
                animalBLL = new AnimalBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    animal.Breed_name = dataRow["养殖场（户）名称"].ToString();
                    animal.Town = dataRow["所属镇"].ToString();
                    animal.Villiage = dataRow["所属村"].ToString();
                    animal.Breed_type = dataRow["养殖种类"].ToString();
                    animal.Manager = dataRow["负责人"].ToString();
                    animal.Phone_number = dataRow["联系电话"].ToString();
                    animal.Year_inventory = dataRow["年存栏（设计规模）"].ToString();
                    animal.Year_outbound = dataRow["年出栏（设计规模）"].ToString();
                    animal.Output = double.Parse(dataRow["产值(万元)"].ToString());
                    animal.Total_area = double.Parse(dataRow["占地面积"].ToString());
                    animal.Pen_area = double.Parse(dataRow["圈舍面积"].ToString());
                    animal.Midden_area = double.Parse(dataRow["堆粪场面积"].ToString());
                    animal.Pullttion_area = double.Parse(dataRow["集污池面积"].ToString());
                    animal.Cueernt_inventory = long.Parse(dataRow["现存栏"].ToString());
                    animal.Animal_qualify = dataRow["动物防疫条件合格证"].ToString();
                    animal.Solid_pollution = dataRow["固体污染源排污登记"].ToString();
                    animal.Report_or_filings = dataRow["环评报告或备案"].ToString();
                    animal.Creater = LoginInfo.CurrentUser.Account;
                    animal.Create_datetime = DateTime.Now.ToString();
                    animals.Add(animal);
                }
                Result result = animalBLL.BacthAddAnimal(animals);

                if(result.Count == animals.Count)
                {
                    ShowInfoDialog("导入成功！");
                    frmAnimalList animalList = (frmAnimalList)this.Owner;
                    animalList.InitAnimalList(null);
                }
                else
                {
                    ShowInfoDialog("导入失败！错误信息是："+result.Exception.Message);
                }
            }
        }
    }
}
