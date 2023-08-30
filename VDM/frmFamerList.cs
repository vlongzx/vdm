using com.vdm.bll;
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
    public partial class frmFamerList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private FamerBLL famerBLL = null;

        //高级查询条件
        private Hashtable condition = null;
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmFamerList()
        {
            InitializeComponent();
        }

        private void frmFamerList_Load(object sender, EventArgs e)
        {
            //InitControlData();

            InitListView(null, this.pageIndex, this.pageSize);
        }

        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView(Hashtable condition, int pageIndex, int pageSize)
        {
            this.dgPeopleList.AutoGenerateColumns = false;
            this.dgPeopleList.RowTemplate.Height = 45;
            this.dgPeopleList.Columns.Clear();
            this.dgPeopleList.AddColumn("编号", "Famer_id");
            this.dgPeopleList.AddColumn("户主姓名", "Holder_name");
            this.dgPeopleList.Columns[1].Frozen = true;//冻结前两列
            this.dgPeopleList.AddColumn("身份证号", "Idcard");
            this.dgPeopleList.AddColumn("联系电话", "Phone_number");
            this.dgPeopleList.AddColumn("家用车辆-品牌", "Car_brand");
            this.dgPeopleList.AddColumn("农用机械类型", "mechine_type");
            this.dgPeopleList.AddColumn("种植作物种类", "plant_type");
            this.dgPeopleList.AddColumn("占地面积(亩)", "plant_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("种植占地地类", "plant_area_type");
            this.dgPeopleList.AddColumn("是否办理设施农用地手续", "is_handle_process");
            this.dgPeopleList.AddColumn("种植产量(斤)", "plant_yield").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("种植产值(元)", "plant_output").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("养殖动物类型", "animal_type");
            this.dgPeopleList.AddColumn("养殖地面积(亩)", "animal_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("养殖数量(头)", "animal_count").SetSortMode(DataGridViewColumnSortMode.Automatic);   
            this.dgPeopleList.AddColumn("养殖占地地类", "animal_area_type");
            this.dgPeopleList.AddColumn("已接种疫苗的动物数量(头/只)", "animal_vaccinate_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("未接种疫苗的动物数量(头/只)", "animal_nvaccinate_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("存栏数量(头/只)", "inventory_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("出栏数量(头/只)", "outbound_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("养殖产出产量(头/只)", "animal_yield").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("养殖产出产值(元)", "animal_output").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("所属镇", "Town");
            this.dgPeopleList.AddColumn("所属村", "Villiage");
            this.dgPeopleList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgPeopleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            famerBLL = new FamerBLL();
            //初始化加载数据
            DataTable dt_people = this.famerBLL.getAllFamerDataTable(condition, pageIndex, pageSize);
            int totalCount = this.famerBLL.getTotalFamerCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgPeopleList.DataSource = dt_people;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
