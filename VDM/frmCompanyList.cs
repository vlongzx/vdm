using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
using com.vdm.model;
using Sunny.UI;
using System;
using System.Collections;
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
    public partial class frmCompanyList : UIPage
    {
        public frmCompanyList()
        {
            InitializeComponent();
        }

        private void frmCompanyList_Load(object sender, EventArgs e)
        {
            InitControlData();

            InitListView(null, this.pageIndex, this.pageSize);
        }
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private LandBLL landBLL = null;

        private Hashtable condition = null;
        //高级查询条件
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;


        public void ConditionAdd(string key, string value)
        {
            this.conditionAdvance.Add(key, value);
        }
        /// <summary>
        /// 初始化基本查询条件
        /// </summary>
        public void InitControlData()
        {
            dictBLL = new DictBLL();
            //初始化日期控件
            this.dpMove_date_From.Text = "";
            this.dpMove_date_To.Text = "";
            //初始化种是否基本农田
            List<KeyValue> list_is_basic_farmland = dictBLL.getDict("is_basic_farmland");
            if (list_is_basic_farmland != null)
            {
                this.cbIs_basic_farmland.DataSource = list_is_basic_farmland;
                this.cbIs_basic_farmland.DisplayMember = "value";
                this.cbIs_basic_farmland.ValueMember = "key";
            }
            //初始化地块类型
            List<KeyValue> list_land_type = dictBLL.getDict("land_type");
            if (list_land_type != null)
            {
                this.cbLand_type.DataSource = list_land_type;
                this.cbLand_type.DisplayMember = "value";
                this.cbLand_type.ValueMember = "key";
            }

            List<KeyValue> list_land_grade = dictBLL.getDict("land_grade");
            if (list_land_grade != null)
            {
                this.cbLand_grade.DataSource = list_land_grade;
                this.cbLand_grade.DisplayMember = "value";
                this.cbLand_grade.ValueMember = "key";
            }


            List<KeyValue> list_move_type = dictBLL.getDict("move_type");
            if (list_move_type != null)
            {
                this.cbMove_type.DataSource = list_move_type;
                this.cbMove_type.DisplayMember = "value";
                this.cbMove_type.ValueMember = "key";
            }

            //初始化所在乡镇所在村
            orgBLL = new OrgBLL();
            List<KeyValue> list_town = orgBLL.getOrgByType("乡镇");
            list_town.Add(new KeyValue("", "请选择"));
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            cbTown.SelectedValue = "";

            List<KeyValue> list_village = new List<KeyValue>();
            list_village.Add(new KeyValue("", "请选择"));
            this.cbVillage.DataSource = list_village;
            this.cbVillage.DisplayMember = "value";
            this.cbVillage.ValueMember = "key";

        }
        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView(Hashtable condition, int pageIndex, int pageSize)
        {
            this.dgCompanyList.AutoGenerateColumns = false;
            this.dgCompanyList.RowTemplate.Height = 45;
            this.dgCompanyList.Columns.Clear();
            this.dgCompanyList.AddColumn("编号", "Land_id");
            this.dgCompanyList.AddColumn("地块名称", "Land_name");
            this.dgCompanyList.Columns[1].Frozen = true;//冻结前两列
            this.dgCompanyList.AddColumn("姓名", "Name");
            this.dgCompanyList.AddColumn("身份证号", "Idcard");
            this.dgCompanyList.AddColumn("是否基本农田", "Is_basic_farmland");
            this.dgCompanyList.AddColumn("地块类型", "Land_type");
            this.dgCompanyList.AddColumn("地块等级", "Land_grade");
            this.dgCompanyList.AddColumn("实测面积", "Real_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("东至", "East");
            this.dgCompanyList.AddColumn("南至", "South");
            this.dgCompanyList.AddColumn("西至", "West");
            this.dgCompanyList.AddColumn("北至", "North");
            this.dgCompanyList.AddColumn("土地用途说明", "Land_use_remark");
            this.dgCompanyList.AddColumn("承包方", "Contractor");
            this.dgCompanyList.AddColumn("承包时间", "Contract_time").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("流转面积", "Move_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("流转形式", "Move_type");
            this.dgCompanyList.AddColumn("流转价格", "Move_price").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("流转日期", "Move_date").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("所属镇", "Town");
            this.dgCompanyList.AddColumn("所属村", "Villiage");
            this.dgCompanyList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgCompanyList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            landBLL = new LandBLL();
            //初始化加载数据
            DataTable dt_people = this.landBLL.getAllLandDataTable(condition, pageIndex, pageSize);
            int totalCount = this.landBLL.getTotalLandCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgCompanyList.DataSource = dt_people;
        }

        /// <summary>
        /// 初始化要导出的数据
        /// </summary>
        /// <param name="p">查询条件</param>
        /// <returns></returns>
        public ListView InitExportListView(Hashtable condition)
        {
            ListView lvExport = new ListView();
            lvExport.Items.Clear();
            lvExport.Columns.Clear();
            lvExport.View = View.Details;


            lvExport.Columns.Add("户主姓名");
            lvExport.Columns.Add("身份证号");
            lvExport.Columns.Add("联系电话");
            lvExport.Columns.Add("家用车辆-品牌");
            lvExport.Columns.Add("农用机械类型");
            lvExport.Columns.Add("种植作物种类");
            lvExport.Columns.Add("占地面积(亩)");
            lvExport.Columns.Add("种植占地地类");
            lvExport.Columns.Add("是否办理设施农用地手续");
            lvExport.Columns.Add("种植产量(斤)");
            lvExport.Columns.Add("种植产值(元)");
            lvExport.Columns.Add("养殖动物类型");
            lvExport.Columns.Add("养殖地面积(亩)");
            lvExport.Columns.Add("养殖数量(头)");
            lvExport.Columns.Add("养殖占地地类");
            lvExport.Columns.Add("已接种疫苗的动物数量(头/只)");
            lvExport.Columns.Add("未接种疫苗的动物数量(头/只)");
            lvExport.Columns.Add("存栏数量(头/只)");
            lvExport.Columns.Add("出栏数量(头/只)");
            lvExport.Columns.Add("养殖产出产量(头/只)");
            lvExport.Columns.Add("养殖产出产值(元)");
            lvExport.Columns.Add("所属镇");
            lvExport.Columns.Add("所属村");
            lvExport.Columns.Add("添加时间");
            lvExport.Columns.Add("添加人");
            landBLL = new LandBLL();
            //初始化导出ListView数据
            //  List<Land> list_land;
            //   this.landBLL = new LandBLL();
            //list_land = this.landBLL.getAllLand(condition);

            //    foreach (Land land in list_land)
            {
                //ListViewItem lvi = new ListViewItem();
                //lvi.Tag = land.Land_id;//存储主键
                //lvi.Text = land.Holder_name;
                //lvi.SubItems.Add(land.Idcard);
                //lvi.SubItems.Add(land.Phone_number);
                //lvi.SubItems.Add(land.Car_brand);
                //lvi.SubItems.Add(land.Mechine_type);
                //lvi.SubItems.Add(land.Plant_type);
                //lvi.SubItems.Add(land.Plant_area.ToString());
                //lvi.SubItems.Add(land.Plant_yield.ToString());
                //lvi.SubItems.Add(land.Plant_output.ToString());
                //lvi.SubItems.Add(land.Plant_area_type.ToString());
                //lvi.SubItems.Add(land.Is_handle_process.ToString());
                //lvi.SubItems.Add(land.Animal_type.ToString());
                //lvi.SubItems.Add(land.Animal_area.ToString());
                //lvi.SubItems.Add(land.Animal_count.ToString());
                //lvi.SubItems.Add(land.Animal_vaccinate_count.ToString());
                //lvi.SubItems.Add(land.Animal_nvaccinate_count.ToString());
                //lvi.SubItems.Add(land.Inventory_count.ToString());
                //lvi.SubItems.Add(land.Outbound_count.ToString());
                //lvi.SubItems.Add(land.Animal_yield.ToString());
                //lvi.SubItems.Add(land.Animal_output.ToString());
                //lvi.SubItems.Add(land.Animal_area_type.ToString());
                //lvi.SubItems.Add(land.Town);
                //lvi.SubItems.Add(land.Villiage);
                //lvi.SubItems.Add(land.Creater);
                //lvi.SubItems.Add(land.Create_datetime);
                //lvExport.Items.Add(lvi);
            }
            return lvExport;

        }



        /// <summary>
        /// 乡镇选择发生改变触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTown_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.LAND);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }
    }
}
