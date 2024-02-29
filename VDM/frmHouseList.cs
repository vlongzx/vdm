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
    public partial class frmHouseList : UIPage
    {
        public frmHouseList()
        {
            InitializeComponent();
        }

        private void frmHouseList_Load(object sender, EventArgs e)
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
            if (LoginInfo.FuncPowerList.Contains("50000") == false)
            {
                this.gbSearch.Visible = false;
                this.gbResult.Visible = false;
            }

            if (LoginInfo.FuncPowerList.Contains("50001") == false)
            {
                this.btAdd.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("50002") == false)
            {
                this.btEdit.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("50003") == false)
            {
                this.btDelete.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("50004") == false)
            {
                this.gbSearch.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("50005") == false)
            {
                this.btImport.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("50006") == false)
            {
                this.btExport.Visible = false;
            }
        }

        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private HouseBLL houseBLL = null;

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
            this.dpHouse_build_date_From.Text = "";
            this.dpHouse_build_date_To.Text = "";
            this.dpOh_checktime_From.Text = "";
            this.dpOh_checktime_To.Text = "";

            List<KeyValue> list_house_is_rent = dictBLL.getDict("common_is");
            if (list_house_is_rent != null)
            {
                this.cbHouse_is_rent.DataSource = list_house_is_rent;
                this.cbHouse_is_rent.DisplayMember = "value";
                this.cbHouse_is_rent.ValueMember = "key";
            }

            List<KeyValue> list_house_safe_grade = dictBLL.getDict("house_safe_grade");
            if (list_house_safe_grade != null)
            {
                this.cbHouse_safe_grade.DataSource = list_house_safe_grade;
                this.cbHouse_safe_grade.DisplayMember = "value";
                this.cbHouse_safe_grade.ValueMember = "key";
            }

            List<KeyValue> list_house_struction = dictBLL.getDict("house_struction");
            if (list_house_struction != null)
            {
                this.cbHouse_struction.DataSource = list_house_struction;
                this.cbHouse_struction.DisplayMember = "value";
                this.cbHouse_struction.ValueMember = "key";
            }
            List<KeyValue> list_house_type = dictBLL.getDict("house_type");
            if (list_house_type != null)
            {
                this.cbHouse_type.DataSource = list_house_type;
                this.cbHouse_type.DisplayMember = "value";
                this.cbHouse_type.ValueMember = "key";
            }
            List<KeyValue> list_is_my_struct = dictBLL.getDict("common_is");
            if (list_is_my_struct != null)
            {
                this.cbIs_my_struct.DataSource = list_is_my_struct;
                this.cbIs_my_struct.DisplayMember = "value";
                this.cbIs_my_struct.ValueMember = "key";
            }
            List<KeyValue> list_is_old_house = dictBLL.getDict("common_is");
            if (list_is_old_house != null)
            {
                this.cbIs_old_house.DataSource = list_is_old_house;
                this.cbIs_old_house.DisplayMember = "value";
                this.cbIs_old_house.ValueMember = "key";
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
            this.dgHouseList.AutoGenerateColumns = false;
            this.dgHouseList.RowTemplate.Height = 45;
            this.dgHouseList.Columns.Clear();
            this.dgHouseList.AddColumn("编号", "House_id");
            this.dgHouseList.AddColumn("房屋所有人", "House_owner");
            this.dgHouseList.Columns[1].Frozen = true;//冻结前两列
            this.dgHouseList.AddColumn("身份证号", "Idcard");
            this.dgHouseList.AddColumn("房屋面积(平方米)", "Area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgHouseList.AddColumn("房屋类别", "House_type");
            this.dgHouseList.AddColumn("房屋具体位置", "House_location");
            this.dgHouseList.AddColumn("房屋结构", "House_struction");
            this.dgHouseList.AddColumn("房屋安全等级", "House_safe_grade");
            this.dgHouseList.AddColumn("房屋是否租赁", "House_is_rent");
            this.dgHouseList.AddColumn("房屋是否自建", "Is_my_struct");
            this.dgHouseList.AddColumn("房屋建设时间", "House_build_date").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgHouseList.AddColumn("是否古宅", "Is_old_house");
            this.dgHouseList.AddColumn("古宅审批时间", "Oh_checktime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgHouseList.AddColumn("所属镇", "Town");
            this.dgHouseList.AddColumn("所属村", "Villiage");
            this.dgHouseList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgHouseList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgHouseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            houseBLL = new HouseBLL();
            //初始化加载数据
            DataTable dt_people = this.houseBLL.getAllHouseDataTable(condition, pageIndex, pageSize);
            int totalCount = this.houseBLL.getTotalHouseCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgHouseList.DataSource = dt_people;
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
                            this.cbVillage.DataSource = list_village;
                            this.cbVillage.DisplayMember = "value";
                            this.cbVillage.ValueMember = "key";
                            this.cbVillage.SelectedValue = "";
                        }
                    }
                    else
                    {
                        List<KeyValue> list_village = new List<KeyValue>();
                        list_village.Add(new KeyValue("", "请选择"));
                        this.cbVillage.DataSource = list_village;
                        this.cbVillage.DisplayMember = "value";
                        this.cbVillage.ValueMember = "key";
                    }
                }
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formLandAdd = new frmHouseInfo();
            formLandAdd.ShowDialog();
            if (formLandAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgHouseList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int house_id = int.Parse(this.dgHouseList.SelectedRows[0].Cells[0].Value.ToString());

            Form formLandEdit = new frmHouseInfo("EDIT", house_id);
            formLandEdit.ShowDialog();
            if (formLandEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }
        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.houseBLL.getAllHouse(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgHouseList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.HOUSE);
            ef.ShowDialog();
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.HOUSE);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
            string Area_From = tbArea_From.Text.Trim();
            string Area_To = tbArea_To.Text.Trim();
            string House_location = tbHouse_location.Text.Trim();
            string House_owner = tbHouse_owner.Text.Trim();
            string Idcard = tbIdcard.Text.Trim();
            string House_is_rent = cbHouse_is_rent.SelectedValue.ToString();
            string House_safe_grade = cbHouse_safe_grade.SelectedValue.ToString();
            string House_struction = cbHouse_struction.SelectedValue.ToString();
            string House_type = cbHouse_type.SelectedValue.ToString();
            string Is_my_struct = cbIs_my_struct.SelectedValue.ToString();
            string Is_old_house = cbIs_old_house.SelectedValue.ToString();
            string House_build_date_From = dpHouse_build_date_From.Text.Trim();
            string House_build_date_To = dpHouse_build_date_To.Text.Trim();
            string Oh_checktime_From = dpOh_checktime_From.Text.Trim();
            string Oh_checktime_To = dpOh_checktime_To.Text.Trim();
            string Village = this.cbVillage.SelectedValue.ToString();
            string Town = this.cbTown.SelectedValue.ToString();


            //------------------------------------------------------------------
            condition.Add("Area_From", Area_From);
            condition.Add("Area_To", Area_To);
            condition.Add("House_location", House_location);
            condition.Add("House_owner", House_owner);
            condition.Add("Idcard", Idcard);
            condition.Add("House_is_rent", House_is_rent);
            condition.Add("House_safe_grade", House_safe_grade);
            condition.Add("House_struction", House_struction);
            condition.Add("House_type", House_type);
            condition.Add("Is_my_struct", Is_my_struct);
            condition.Add("Is_old_house", Is_old_house);
            condition.Add("House_build_date_From", House_build_date_From);
            condition.Add("House_build_date_To", House_build_date_To);
            condition.Add("Oh_checktime_From", Oh_checktime_From);
            condition.Add("Oh_checktime_To", Oh_checktime_To);
            condition.Add("Village", Village);
            condition.Add("Town", Town);

            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgHouseList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int house_id = int.Parse(this.dgHouseList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.houseBLL = new HouseBLL();
                Result result = this.houseBLL.DelHouse(house_id);
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
            tbArea_From.Text = "";
            tbArea_To.Text = "";
            tbHouse_location.Text = "";
            tbHouse_owner.Text = "";
            tbIdcard.Text = "";
            cbHouse_is_rent.SelectedValue = "";
            cbHouse_safe_grade.SelectedValue = "";
            cbHouse_struction.SelectedValue = "";
            cbHouse_type.SelectedValue = "";
            cbIs_my_struct.SelectedValue = "";
            cbIs_old_house.SelectedValue = "";
            dpHouse_build_date_From.Text = "";
            dpHouse_build_date_To.Text = "";
            dpOh_checktime_From.Text = "";
            dpOh_checktime_To.Text = "";
            this.cbVillage.SelectedValue = "";
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
    }
}
