using Aspose.Cells;
using com.vdm.bll;
using com.vdm.common;
using com.vdm.dal;
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
    public partial class frmImportExcelFileFamer : UIEditForm
    {
        private string object_name;
        public frmImportExcelFileFamer()
        {
            InitializeComponent();
        }

        public frmImportExcelFileFamer(string object_name)
        {
            InitializeComponent();
            this.object_name = object_name;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            //openFileDialog.Filter = "EXCEL 文件|*.xlsx";
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.FilterIndex = 1;
            OpenFileDialog dialog = new OpenFileDialog();
            //过滤选择文件
            dialog.Filter = "EXCEL 文件|*.xlsx";
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.tbFileName.Text = dialog.FileName;
            }
        }

        protected override bool CheckData()
        {
            return  CheckEmpty(tbFileName, "请选择要导入的文件。");
        }
        /// <summary>
        ///  解析Excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.IsOK == false)
            {
                return;
            }
            string filename = this.tbFileName.Text;
            string password = this.tbPassword.Text.Trim();
            string errMessage = null;
            DataTable dt = ExcelUtil.ExcelToDataTable(filename, password, out errMessage);

            switch (object_name)
            {
                case Data_Object_Const.FAMER:
                    ImportFamerData(dt);
                    break;
                case Data_Object_Const.ANIMAL:
                    ImportAnimalData(dt);
                    break;
                case Data_Object_Const.COMPANY:
                    ImportCompanyData(dt);
                    break;
                case Data_Object_Const.HOUSE:
                    ImportHouseData(dt);
                    break;
                case Data_Object_Const.LAND:
                    ImportLandData(dt);
                    break;
                case Data_Object_Const.PEOPLE:
                    ImportPeopleData(dt);
                    break;
                case Data_Object_Const.PLANT:
                    ImportPlantData(dt);
                    break;
                case Data_Object_Const.TOUR:
                    ImportTourData(dt);
                    break;
                default ://村情
                    ImportVilliageData(dt);
                    break;
            }
        }

        private void ImportVilliageData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportTourData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportPlantData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportPeopleData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportLandData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportHouseData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportCompanyData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void ImportAnimalData(DataTable dt)
        {
            AnimalBLL animalBLL = new AnimalBLL();
            List<Animal> animals = new List<Animal>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Animal animal = new Animal();
                FamerBLL famerBLL = new FamerBLL();
                foreach (DataRow dataRow in dt.Rows)
                {

                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    animal.Address = dataRow["户主姓名"].ToString();
                    animal.Idcard = dataRow["身份证号"].ToString();
                    animal.Phone_number = dataRow["联系电话"].ToString();
                    animal.Animal_qualify = dataRow["动物防疫条件合格证"].ToString();
                    animal.Breed_name = dataRow["养殖场（户）名称"].ToString();
                    animal.Breed_type = dataRow["养殖种类"].ToString();
                    animal.Cueernt_inventory = long.Parse(dataRow["现存栏(亩)"].ToString());
                    animal.Manager = dataRow["负责人"].ToString();
                    animal.Midden_area = double.Parse(dataRow["堆粪场面积"].ToString());
                    animal.Output = double.Parse(dataRow["产值(万元)"].ToString());
                    animal.Pen_area = double.Parse(dataRow["圈舍面积"].ToString());
                    animal.Pullttion_area = double.Parse(dataRow["集污池面积"].ToString());
                    animal.Remark = dataRow["备注"].ToString();
                    animal.Report_or_filings = dataRow["环评报告或备案"].ToString();
                    animal.Solid_pollution = dataRow["固体污染源排污登记"].ToString();
                    animal.Total_area = double.Parse(dataRow["占地面积"].ToString());
                    animal.Year_inventory = dataRow["年存栏（设计规模）"].ToString();
                    animal.Year_outbound = dataRow["年出栏（设计规模）"].ToString();
                    animal.Town = dataRow["所属镇"].ToString();
                    animal.Villiage = dataRow["所属村"].ToString();
                    animal.Creater = LoginInfo.CurrentUser.Account;
                    animal.Create_datetime = DateTime.Now.ToString();

                    animals.Add(animal);
                }
                Result result = animalBLL.BacthAddAnimal(animals);
                if (result.Count == animals.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmAnimalList animalList = (frmAnimalList)this.Owner;
                    animalList.InitAnimalList(null);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Exception.Message);
                }
            }

        }

        private void ImportFamerData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Famer famer = new Famer();
                FamerBLL famerBLL = new FamerBLL();
                foreach (DataRow dataRow in dt.Rows)
                {

                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    famer.Holder_name = dataRow["户主姓名"].ToString();
                    famer.Idcard = dataRow["身份证号"].ToString();
                    famer.Phone_number = dataRow["联系电话"].ToString();
                    famer.Car_brand = dataRow["家用车辆-品牌"].ToString();
                    famer.Mechine_type = dataRow["农用机械类型"].ToString();
                    famer.Plant_type = dataRow["种植作物种类"].ToString();
                    famer.Plant_area = double.Parse(dataRow["占地面积(亩)"].ToString());
                    famer.Plant_yield = double.Parse(dataRow["种植占地地类"].ToString());
                    famer.Plant_output = int.Parse(dataRow["是否办理设施农用地手续"].ToString());
                    famer.Plant_area_type = dataRow["种植产量(斤)"].ToString();
                    famer.Is_handle_process = dataRow["种植产值(元)"].ToString();
                    famer.Animal_type = dataRow["养殖动物类型"].ToString();
                    famer.Animal_area = double.Parse(dataRow["养殖地面积(亩)"].ToString());
                    famer.Animal_count = int.Parse(dataRow["养殖数量(头)"].ToString());
                    famer.Animal_vaccinate_count = int.Parse(dataRow["养殖占地地类"].ToString());
                    famer.Animal_nvaccinate_count = int.Parse(dataRow["已接种疫苗的动物数量(头/只)"].ToString());
                    famer.Inventory_count = int.Parse(dataRow["未接种疫苗的动物数量(头/只)"].ToString());
                    famer.Outbound_count = int.Parse(dataRow["存栏数量(头/只)"].ToString());
                    famer.Animal_yield = int.Parse(dataRow["出栏数量(头/只)"].ToString());
                    famer.Animal_output = int.Parse(dataRow["养殖产出产量(头/只)"].ToString());
                    famer.Animal_area_type = dataRow["养殖产出产值(元)"].ToString();
                    famer.Town = dataRow["所属镇"].ToString();
                    famer.Villiage = dataRow["所属村"].ToString();
                    famer.Creater = LoginInfo.CurrentUser.Account;
                    famer.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = famerBLL.ImportFamerAdd(famer);
                    sqlso.Add(s);
                }
                Result result = famerBLL.ImportFamer(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmFamerList famerList = (frmFamerList)this.Owner;
                    famerList.InitListView(null);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Exception.Message);
                }
            }
        }

        private void btExportTemplate_Click(object sender, EventArgs e)
        {
            UIForm uifm = new frmExportTemplate(this.object_name);
            uifm.ShowDialog();
        }

        private void frmImportExcelFileFamer_Load(object sender, EventArgs e)
        {
            this.lbInformation.ForeColor = Color.Red;
        }
    }
}
