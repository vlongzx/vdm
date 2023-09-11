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
    public partial class frmImportExcelFile : UIEditForm
    {
        private string object_name;
        public frmImportExcelFile()
        {
            InitializeComponent();
        }

        public frmImportExcelFile(string object_name)
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
            return CheckEmpty(tbFileName, "请选择要导入的文件。");
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
                case Data_Object_Const.MANAGER:
                    ImportManagerData(dt);
                    break;
                case Data_Object_Const.VILLIAGE:
                    ImportVillageData(dt);
                    break;
                default://村情
                    ImportVilliageData(dt);
                    break;
            }
        }

        private void ImportVilliageData(DataTable dt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  批量导入旅游信息
        /// </summary>
        /// <param name="dt">旅游信息表</param>
        private void ImportTourData(DataTable dt)
        {
            TourBLL tourBLL = new TourBLL();
            List<Tour> tours = new List<Tour>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Tour tour = new Tour();
                foreach (DataRow dataRow in dt.Rows)
                {

                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    tour.Address = dataRow["联系地址"].ToString();
                    tour.Company_id = dataRow["统一社会信用代码"].ToString();
                    tour.Legal_name = dataRow["法定代表人姓名"].ToString();
                    tour.Phone_number = dataRow["联系电话"].ToString();
                    tour.Principal_category = dataRow["主体类别"].ToString();
                    tour.Principal_name = dataRow["主体名称"].ToString();
                    tour.Registered_trademark = dataRow["注册商标"].ToString();
                    tour.Remark = dataRow["备注"].ToString();
                    tour.Trade_form = dataRow["经营形式"].ToString();
                    tour.Year_person_count = int.Parse(dataRow["年接待旅游（人次）"].ToString());
                    tour.Year_trade_income = double.Parse(dataRow["年经营收入（万元）"].ToString());
                    tour.Town = dataRow["所属镇"].ToString();
                    tour.Village = dataRow["所属村"].ToString();
                    tour.Creater = LoginInfo.CurrentUser.Account;
                    tour.Create_datetime = DateTime.Now.ToString();

                    tours.Add(tour);
                }
                Result result = tourBLL.batchAddTour(tours);
                if (result.Count == tours.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmTourList tourList = (frmTourList)this.Owner;
                    tourList.InitTourList(null);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        /// <summary>
        ///  批量导入种植信息
        /// </summary>
        /// <param name="dt"></param>
        private void ImportPlantData(DataTable dt)
        {
            PlantBLL plantBLL = new PlantBLL();
            ////删除原来表所有数据
            //plantBLL.deleteAll();
            List<Plant> plants = new List<Plant>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Plant plant = new Plant();
                foreach (DataRow dataRow in dt.Rows)
                {

                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    plant.Address = dataRow["详细地址"].ToString();
                    plant.Contact_person = dataRow["联系人"].ToString();
                    plant.Phone_number = dataRow["联系电话"].ToString();
                    plant.Develop_willing = dataRow["发展意愿"].ToString();
                    plant.Idcard = dataRow["联系人身份证"].ToString();
                    plant.Insect_ill = dataRow["主要虫病害"].ToString();
                    plant.Remark = dataRow["备注"].ToString();
                    plant.Is_plan = dataRow["是否符合规划"].ToString();
                    plant.Manage_skill_method = dataRow["主要管理和技术措施"].ToString();
                    plant.Output = double.Parse(dataRow["产值(万元)"].ToString());
                    plant.Plant_area = double.Parse(dataRow["种植面积"].ToString());
                    plant.Town = dataRow["所属镇"].ToString();
                    plant.Village = dataRow["所属村"].ToString();
                    plant.Plant_brand = dataRow["种植品种"].ToString();
                    plant.Plant_type = dataRow["种植类别"].ToString();
                    plant.Question = dataRow["需要政府解决的问题"].ToString();
                    plant.Sale_way = dataRow["销售途径"].ToString();
                    plant.Year_yield = double.Parse(dataRow["年产量（斤）"].ToString());
                    plant.Creater = LoginInfo.CurrentUser.Account;
                    plant.Create_datetime = DateTime.Now.ToString();

                    plants.Add(plant);
                }
                Result result = plantBLL.batchAddPlant(plants);
                if (result.Count == plants.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmPlantList plantList = (frmPlantList)this.Owner;
                    plantList.InitPlantList(null);
                }
                else
                {
                    //  ShowInfoDialog("导入失败。错误信息：" + result.Exception.Message);
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }

        private void ImportPeopleData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                People people = new People();
                PeopleBLL peopleBLL = new PeopleBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    people.People_name = dataRow["姓名 "].ToString();
                    people.Idcard = dataRow["身份证号"].ToString();
                    people.Birthday = dataRow["出生日期"].ToString();
                    people.Sex = dataRow["性别"].ToString();
                    people.Relationship = dataRow["与户主关系"].ToString();
                    people.Nation = dataRow["民族"].ToString();
                    people.Politcal_outlook = dataRow["政治面貌"].ToString();
                    people.Join_party_time = dataRow["入党时间"].ToString();
                    people.Phone_number = dataRow["联系电话"].ToString();
                    people.Is_real_name = dataRow["是否实名"].ToString();
                    people.Religious_belief = dataRow["宗教信仰"].ToString();
                    people.Blood_type = dataRow["血型"].ToString();
                    people.Marital_status = dataRow["婚姻状况"].ToString();

                    people.Work_or_study = dataRow["是否外出"].ToString();
                    people.Industry = dataRow["从事行业"].ToString();
                    people.Unit_or_school = dataRow["工作单位/学校名称"].ToString();
                    people.Work_study_location = dataRow["工作地点/学习地点"].ToString();
                    people.Skill_type = dataRow["技能类型"].ToString();
                    people.Employ_guide = dataRow["就业指导"].ToString();
                    people.Skill_train = dataRow["技能培训"].ToString();
                    people.Is_career_grade = dataRow["有无职称"].ToString();
                    people.Career_grade = dataRow["职称等级"].ToString();
                    people.Career_get_time = dataRow["职称获得时间"].ToString();
                    people.Disability_type = dataRow["残疾分类"].ToString();
                    people.Disability_grade = dataRow["残疾等级"].ToString();
                    people.Disability_reason = dataRow["因何致残"].ToString();
                    people.Big_ill_help = dataRow["大病救助情况"].ToString();
                    people.Temporary_help = dataRow["临时救助情况"].ToString();
                    people.Is_unable_old = dataRow["是否失能老人"].ToString();
                    people.Is_relocation = dataRow["是否易地搬迁户"].ToString();
                    people.Low_five_grade = dataRow["低保等级/五保类别"].ToString();
                    people.Low_five = dataRow["低保户/五保户"].ToString();
                    people.Remark = dataRow["备注"].ToString();


                    people.Town = dataRow["所属镇"].ToString();
                    people.Villiage = dataRow["所属村"].ToString();
                    people.Creater = LoginInfo.CurrentUser.Account;
                    people.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = peopleBLL.ImportPeopleAdd(people);
                    sqlso.Add(s);
                }
                Result result = peopleBLL.ImportPeople(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmPeopleList peopleList = (frmPeopleList)this.Owner;
                    peopleList.InitListView(null, 1, 20);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }

        private void ImportLandData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Land land = new Land();
                LandBLL landBLL = new LandBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    land.Name = dataRow["姓名"].ToString();
                    land.Idcard = dataRow["身份证号"].ToString();
                    land.Land_name = dataRow["地块名称"].ToString();
                    land.Is_basic_farmland = dataRow["是否基本农田"].ToString();
                    land.Land_type = dataRow["地块类型"].ToString();
                    land.Land_grade = dataRow["地块等级"].ToString();
                    land.Real_area = double.Parse(dataRow["实测面积"].ToString());
                    land.East = dataRow["东至"].ToString();
                    land.South = dataRow["南至"].ToString();
                    land.West = dataRow["西至"].ToString();
                    land.North = dataRow["北至"].ToString();
                    land.Land_use_remark = dataRow["土地用途说明"].ToString();
                    land.Contractor = dataRow["承包方"].ToString();
                    if (dataRow["承包方"].ToString() != "")
                    {
                        land.Contract_time = dataRow["承包时间"].ToString();
                        land.Move_area = double.Parse(dataRow["流转面积"].ToString());
                        land.Move_type = dataRow["流转形式"].ToString();
                        land.Move_price = int.Parse(dataRow["流转价格"].ToString());
                        land.Move_date = dataRow["流转日期"].ToString();
                    }

                    land.Town = dataRow["所属镇"].ToString();
                    land.Villiage = dataRow["所属村"].ToString();
                    land.Creater = LoginInfo.CurrentUser.Account;
                    land.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = landBLL.ImportLandAdd(land);
                    sqlso.Add(s);
                }
                Result result = landBLL.ImportLand(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmLandList landList = (frmLandList)this.Owner;
                    landList.InitListView(null, 1, 20);
                }
                else
                {
                    //ShowInfoDialog("导入失败。错误信息：" + result.Exception.Message);
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        private void ImportManagerData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Manager manager = new Manager();
                ManagerBLL managerBLL = new ManagerBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    manager.Manager_name = dataRow["姓名"].ToString();
                    manager.Post = dataRow["职务"].ToString();
                    manager.Employ_date = dataRow["任职时间"].ToString();
                    manager.Birthday = dataRow["出生日期"].ToString();
                    manager.Sex = dataRow["性别"].ToString();
                    manager.Nation = dataRow["民族"].ToString();
                    manager.Politcal_outlook = dataRow["政治面貌"].ToString();
                    manager.Join_party_time = dataRow["入党时间"].ToString();
                    manager.Idcard = dataRow["身份证号"].ToString();
                    manager.Phone_number = dataRow["联系电话"].ToString();
                    manager.Education = dataRow["学历"].ToString();
                    manager.Town = dataRow["所属镇"].ToString();
                    manager.Villiage = dataRow["所属村"].ToString();
                    manager.Creater = LoginInfo.CurrentUser.Account;
                    manager.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = managerBLL.ImportManagerAdd(manager);
                    sqlso.Add(s);
                }
                Result result = managerBLL.ImportManager(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmManagerList managerList = (frmManagerList)this.Owner;
                    managerList.InitListView(null, 1, 20);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        private void ImportHouseData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                House house = new House();
                HouseBLL houseBLL = new HouseBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    house.House_owner = dataRow["房屋所有人"].ToString();
                    house.Idcard = dataRow["身份证号"].ToString();
                    house.Area = int.Parse(dataRow["房屋面积(平方米)"].ToString());
                    house.House_type = dataRow["房屋类别"].ToString();
                    house.House_location = dataRow["房屋具体位置"].ToString();
                    house.House_struction = dataRow["房屋结构"].ToString();
                    house.House_safe_grade = dataRow["房屋安全等级"].ToString();
                    house.House_is_rent = dataRow["房屋是否租赁"].ToString();
                    house.Is_my_struct = dataRow["房屋是否自建"].ToString();
                    house.House_build_date = dataRow["房屋建设时间"].ToString();
                    house.Is_old_house = dataRow["是否古宅"].ToString();
                    house.Oh_checktime = dataRow["古宅审批时间"].ToString();
                    house.Town = dataRow["所属镇"].ToString();
                    house.Villiage = dataRow["所属村"].ToString();
                    house.Creater = LoginInfo.CurrentUser.Account;
                    house.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = houseBLL.ImportHouseAdd(house);
                    sqlso.Add(s);
                }
                Result result = houseBLL.ImportHouse(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmHouseList houseList = (frmHouseList)this.Owner;
                    houseList.InitListView(null, 1, 20);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        private void ImportVillageData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Village village = new Village();
                VillageBLL villageBLL = new VillageBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    village.Money = double.Parse(dataRow["村集体资金"].ToString());
                    village.Foreast_area = double.Parse(dataRow["林地面积"].ToString());
                    village.Confirm_area = double.Parse(dataRow["确权耕地面积"].ToString());
                    village.Move_area = double.Parse(dataRow["机动耕地面积"].ToString());
                    village.Mineral_resource = double.Parse(dataRow["矿产资源量"].ToString());
                    village.Water_resource = double.Parse(dataRow["水资源量"].ToString());
                    village.Road_length = double.Parse(dataRow["道路长度"].ToString());
                    village.Shop = double.Parse(dataRow["村集体门店"].ToString());
                    village.Factory = double.Parse(dataRow["村集体厂房"].ToString());
                    village.School = double.Parse(dataRow["学校"].ToString());
                    village.Office = double.Parse(dataRow["村组织办公场所"].ToString());
                    village.Mechine = dataRow["村集体设施、设备"].ToString();
                    village.Town = dataRow["所属镇"].ToString();
                    village.Villiage = dataRow["所属村"].ToString();
                    village.Creater = LoginInfo.CurrentUser.Account;
                    village.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = villageBLL.ImportVillageAdd(village);
                    sqlso.Add(s);
                }
                Result result = villageBLL.ImportVillage(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmVillageList villageList = (frmVillageList)this.Owner;
                    villageList.InitListView(null, 1, 20);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        private void ImportCompanyData(DataTable dt)
        {
            List<SQLStringObject> sqlso = new List<SQLStringObject>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Company company = new Company();
                CompanyBLL companyBLL = new CompanyBLL();
                foreach (DataRow dataRow in dt.Rows)
                {
                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    company.Company_name = dataRow["企业名称"].ToString();
                    company.Company_type = dataRow["企业类型"].ToString();
                    company.Company_address = dataRow["企业地址"].ToString();
                    company.Credit_code = dataRow["统一社会信用编码"].ToString();
                    company.Business_code = dataRow["工商注册号"].ToString();
                    company.License_date = dataRow["营业执照日期"].ToString();
                    company.Organization_code = dataRow["组织机构代码"].ToString();
                    company.Establish_date = dataRow["成立时间"].ToString();
                    company.Legal_name = dataRow["企业法人姓名"].ToString();
                    company.Legal_idcard = dataRow["企业法人身份证"].ToString();
                    company.Company_phone = dataRow["企业联系电话"].ToString();
                    company.Staff_size = int.Parse(dataRow["人员规模"].ToString());
                    company.Insure_person_count = int.Parse(dataRow["参保人数"].ToString());
                    company.Output = double.Parse(dataRow["产值(万元)"].ToString());
                    company.Taxpayer_code = dataRow["纳税人识别号"].ToString();
                    company.Taxpayer_qualification = dataRow["纳税人资质"].ToString();
                    company.Is_top_company = dataRow["是否龙头企业"].ToString();
                    company.Company_status = dataRow["企业经营状态"].ToString();
                    company.Town = dataRow["所属镇"].ToString();
                    company.Villiage = dataRow["所属村"].ToString();
                    company.Creater = LoginInfo.CurrentUser.Account;
                    company.Create_datetime = DateTime.Now.ToString();

                    SQLStringObject s = companyBLL.ImportCompanyAdd(company);
                    sqlso.Add(s);
                }
                Result result = companyBLL.ImportCompany(sqlso);
                if (result.Count == sqlso.Count)
                {
                    ShowInfoDialog("导入成功。");
                    frmCompanyList companyList = (frmCompanyList)this.Owner;
                    companyList.InitListView(null, 1, 20);
                }
                else
                {
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
                }
            }
        }
        /// <summary>
        ///  批量导入畜牧信息
        /// </summary>
        /// <param name="dt">畜牧信息表</param>
        private void ImportAnimalData(DataTable dt)
        {
            AnimalBLL animalBLL = new AnimalBLL();
            //删除原来表所有数据
            List<Animal> animals = new List<Animal>();
            //若有数据
            if (dt != null && dt.Rows.Count != 0)
            {
                Animal animal = new Animal();
                foreach (DataRow dataRow in dt.Rows)
                {

                    //将excel数据值封装业务对象
                    //------------------基础信息部分---------------------------------
                    animal.Address = dataRow["地址"].ToString();
                    animal.Idcard = dataRow["身份证号"].ToString();
                    animal.Phone_number = dataRow["联系电话"].ToString();
                    animal.Animal_qualify = dataRow["动物防疫条件合格证"].ToString();
                    animal.Breed_name = dataRow["养殖场（户）名称"].ToString();
                    animal.Breed_type = dataRow["养殖种类"].ToString();
                    animal.Cueernt_inventory = long.Parse(dataRow["现存栏"].ToString());
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
                    animal.Village = dataRow["所属村"].ToString();
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
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
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
                    if (dataRow["种植作物种类"].ToString() != "无")
                    {

                        famer.Plant_area_type = dataRow["种植占地地类"].ToString();
                        famer.Is_handle_process = dataRow["是否办理设施农用地手续"].ToString();
                        famer.Plant_area = double.Parse(dataRow["占地面积(亩)"].ToString());
                        famer.Plant_yield = double.Parse(dataRow["种植产量(斤)"].ToString());
                        famer.Plant_output = int.Parse(dataRow["种植产值(元)"].ToString());
                    }

                    famer.Animal_type = dataRow["养殖动物类型"].ToString();
                    if (dataRow["养殖动物类型"].ToString() != "无")
                    {
                        famer.Animal_area = double.Parse(dataRow["养殖地面积(亩)"].ToString());
                        famer.Animal_count = int.Parse(dataRow["养殖数量(头)"].ToString());
                        famer.Animal_vaccinate_count = int.Parse(dataRow["已接种疫苗的动物数量(头/只)"].ToString());
                        famer.Animal_nvaccinate_count = int.Parse(dataRow["未接种疫苗的动物数量(头/只)"].ToString());
                        famer.Inventory_count = int.Parse(dataRow["存栏数量(头/只)"].ToString());
                        famer.Outbound_count = int.Parse(dataRow["出栏数量(头/只)"].ToString());
                        famer.Animal_yield = int.Parse(dataRow["养殖产出产量(头/只)"].ToString());
                        famer.Animal_output = int.Parse(dataRow["养殖产出产值(元)"].ToString());
                        famer.Animal_area_type = dataRow["养殖占地地类"].ToString();
                    }
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
                    ShowInfoDialog("导入失败。错误信息：" + result.Information);
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
