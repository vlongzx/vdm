using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
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
    public partial class frmVillageList : UIPage
    {
        public frmVillageList()
        {
            InitializeComponent();
        }

        private void frmVillageList_Load(object sender, EventArgs e)
        {
            InitControlData();

            InitListView(null, this.pageIndex, this.pageSize);

            InitFuncPowerControl();
        }

        /// <summary>
        ///  初始化权限控制
        /// </summary>
        private void InitFuncPowerControl()
        {
            if (LoginInfo.FuncPowerList.Contains("70000") == false)
            {
                this.gbSearch.Visible = false;
                this.gbResult.Visible = false;
            }

            if (LoginInfo.FuncPowerList.Contains("70001") == false)
            {
                this.btAdd.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("70002") == false)
            {
                this.btEdit.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("70003") == false)
            {
                this.btDelete.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("70004") == false)
            {
                this.gbSearch.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("70005") == false)
            {
                this.btImport.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("70006") == false)
            {
                this.btExport.Visible = false;
            }
        }

        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private VillageBLL villageBLL = null;

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
            this.cbVilliage.DataSource = list_village;
            this.cbVilliage.DisplayMember = "value";
            this.cbVilliage.ValueMember = "key";

        }
        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView(Hashtable condition, int pageIndex, int pageSize)
        {
            this.dgVillageList.AutoGenerateColumns = false;
            this.dgVillageList.RowTemplate.Height = 45;
            this.dgVillageList.Columns.Clear();
            this.dgVillageList.AddColumn("编号", "Village_id");
            this.dgVillageList.AddColumn("村集体资金", "money").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("林地面积", "foreast_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.Columns[1].Frozen = true;//冻结前两列
            this.dgVillageList.AddColumn("确权耕地面积", "confirm_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("机动耕地面积", "move_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("矿产资源量", "mineral_resource").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("水资源量", "water_resource").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("道路长度", "road_length").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("村集体门店", "shop").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("村集体厂房", "factory").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("学校", "school").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("村组织办公场所", "office").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("村集体设施、设备", "mechine");
            this.dgVillageList.AddColumn("所属镇", "Town");
            this.dgVillageList.AddColumn("所属村", "Villiage");
            this.dgVillageList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgVillageList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgVillageList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            villageBLL = new VillageBLL();
            //初始化加载数据
            DataTable dt_people = this.villageBLL.getAllVillageDataTable(condition, pageIndex, pageSize);
            int totalCount = this.villageBLL.getTotalVillageCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgVillageList.DataSource = dt_people;
        }
        /// <summary>
        /// 乡镇选择发生改变触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbTown.SelectedValue != null)
            {
                orgBLL = new OrgBLL();
                if (this.cbTown.SelectedItem != null)
                {
                    KeyValue selectValue = (KeyValue)this.cbTown.SelectedItem;
                    if (selectValue.Key != "")
                    {
                        string org_code = selectValue.Key;
                        string pre_org_id = this.orgBLL.getOrgIdByOrgCode(org_code);
                        List<KeyValue> list_village = orgBLL.getOrgByTown(pre_org_id);
                        if (list_village != null)
                        {
                            list_village.Add(new KeyValue("", "请选择"));
                            this.cbVilliage.DataSource = list_village;
                            this.cbVilliage.DisplayMember = "value";
                            this.cbVilliage.ValueMember = "key";
                            this.cbVilliage.SelectedValue = "";
                        }
                    }
                    else
                    {
                        List<KeyValue> list_village = new List<KeyValue>();
                        list_village.Add(new KeyValue("", "请选择"));
                        this.cbVilliage.DataSource = list_village;
                        this.cbVilliage.DisplayMember = "value";
                        this.cbVilliage.ValueMember = "key";
                    }
                }
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formLandAdd = new frmVillageInfo();
            formLandAdd.ShowDialog();
            if (formLandAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgVillageList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int village_id = int.Parse(this.dgVillageList.SelectedRows[0].Cells[0].Value.ToString());

            Form formLandEdit = new frmVillageInfo("EDIT", village_id);
            formLandEdit.ShowDialog();
            if (formLandEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }
        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.villageBLL.getAllVillage(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgVillageList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.VILLIAGE);
            ef.ShowDialog();
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.VILLIAGE);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
            string Confirm_area_From = tbConfirm_area_From.Text.Trim();
            string Confirm_area_To = tbConfirm_area_To.Text.Trim();
            string Factory_From = tbFactory_From.Text.Trim();
            string Factory_To = tbFactory_To.Text.Trim();
            string Foreast_area_From = tbForeast_area_From.Text.Trim();
            string Foreast_area_To = tbForeast_area_To.Text.Trim();
            string Mechine = tbMechine.Text.Trim();
            string Mineral_resource_From = tbMineral_resource_From.Text.Trim();
            string Mineral_resource_To = tbMineral_resource_To.Text.Trim();
            string Money_From = tbMoney_From.Text.Trim();
            string Money_To = tbMoney_To.Text.Trim();
            string Move_area_From = tbMove_area_From.Text.Trim();
            string Move_area_To = tbMove_area_To.Text.Trim();
            string Office_From = tbOffice_From.Text.Trim();
            string Office_To = tbOffice_To.Text.Trim();
            string School_From = tbSchool_From.Text.Trim();
            string School_To = tbSchool_To.Text.Trim();
            string Shop_From = tbShop_From.Text.Trim();
            string Shop_To = tbShop_To.Text.Trim();
            string Water_resource_From = tbWater_resource_From.Text.Trim();
            string Water_resource_To = tbWater_resource_To.Text.Trim();
            string Village = this.cbVilliage.SelectedValue.ToString();
            string Town = this.cbTown.SelectedValue.ToString();


            //------------------------------------------------------------------
            condition.Add("Confirm_area_From", Confirm_area_From);
            condition.Add("Confirm_area_To", Confirm_area_To);
            condition.Add("Factory_From", Factory_From);
            condition.Add("Factory_To", Factory_To);
            condition.Add("Foreast_area_From", Foreast_area_From);
            condition.Add("Foreast_area_To", Foreast_area_To);
            condition.Add("Mechine", Mechine);
            condition.Add("Mineral_resource_From", Mineral_resource_From);
            condition.Add("Mineral_resource_To", Mineral_resource_To);
            condition.Add("Money_From", Money_From);
            condition.Add("Money_To", Money_To);
            condition.Add("Move_area_From", Move_area_From);
            condition.Add("Move_area_To", Move_area_To);
            condition.Add("Office_From", Office_From);
            condition.Add("Office_To", Office_To);
            condition.Add("School_From", School_From);
            condition.Add("School_To", School_To);
            condition.Add("Shop_From", Shop_From);
            condition.Add("Shop_To", Shop_To);
            condition.Add("Water_resource_From", Water_resource_From);
            condition.Add("Water_resource_To", Water_resource_To);
            condition.Add("Village", Village);
            condition.Add("Town", Town);

            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgVillageList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int village_id = int.Parse(this.dgVillageList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.villageBLL = new VillageBLL();
                Result result = this.villageBLL.DelVillage(village_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitListView(condition, this.pageIndex, this.pageSize);
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            //清空查询文本框内容
            tbConfirm_area_From.Text = "";
            tbConfirm_area_To.Text = "";
            tbFactory_From.Text = "";
            tbFactory_To.Text = "";
            tbForeast_area_From.Text = "";

            tbForeast_area_To.Text = "";
            tbMechine.Text = "";
            tbMineral_resource_From.Text = "";
            tbMineral_resource_To.Text = "";
            tbMoney_From.Text = "";
            tbMoney_To.Text = "";
            tbMove_area_From.Text = "";
            tbMove_area_To.Text = "";
            tbOffice_From.Text = "";
            tbOffice_To.Text = "";
            tbSchool_From.Text = "";
            tbSchool_To.Text = "";
            tbShop_From.Text = "";
            tbShop_To.Text = "";
            tbWater_resource_From.Text = "";
            tbWater_resource_To.Text = "";
            this.cbVilliage.SelectedValue = "";
            this.cbTown.SelectedValue = "";
            //查询所有信息
            condition = null;
            InitListView(condition, this.pageIndex, this.pageSize);

        }
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            this.pageIndex = pageIndex;
            InitListView(condition, this.pageIndex, this.pageSize);
        }
        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
