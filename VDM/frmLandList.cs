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
    public partial class frmLandList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private LandBLL landBLL = null;

        private Hashtable condition = null;
        //高级查询条件
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmLandList()
        {
            InitializeComponent();
        }

        private void frmLandList_Load(object sender, EventArgs e)
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
            if (LoginInfo.FuncPowerList.Contains("20000") == false)
            {
                this.gbSearch.Visible = false;
                this.gbResult.Visible = false;
            }

            if (LoginInfo.FuncPowerList.Contains("20001") == false)
            {
                this.btAdd.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("20002") == false)
            {
                this.btEdit.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("20003") == false)
            {
                this.btDelete.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("20004") == false)
            {
                this.gbSearch.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("20005") == false)
            {
                this.btImport.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("20006") == false)
            {
                this.btExport.Visible = false;
            }
        }

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
                foreach (KeyValue kv in list_land_type)
                {
                    if (kv.Key != "")
                    {
                        ctvLand_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }



            List<KeyValue> list_land_grade = dictBLL.getDict("land_grade");
            if (list_land_grade != null)
            {
                foreach (KeyValue kv in list_land_grade)
                {
                    if (kv.Key != "")
                    {
                        ctvLand_grade.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }



            List<KeyValue> list_move_type = dictBLL.getDict("move_type");
            if (list_move_type != null)
            {
                foreach (KeyValue kv in list_move_type)
                {
                    if (kv.Key != "")
                    {
                        ctvMove_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
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
            this.dgLandList.AutoGenerateColumns = false;
            this.dgLandList.RowTemplate.Height = 45;
            this.dgLandList.Columns.Clear();
            this.dgLandList.AddColumn("编号", "Land_id");
            this.dgLandList.AddColumn("地块名称", "Land_name");
            this.dgLandList.Columns[1].Frozen = true;//冻结前两列
            this.dgLandList.AddColumn("姓名", "Name");
            this.dgLandList.AddColumn("身份证号", "Idcard");
            this.dgLandList.AddColumn("是否基本农田", "Is_basic_farmland");
            this.dgLandList.AddColumn("地块类型", "Land_type");
            this.dgLandList.AddColumn("地块等级", "Land_grade");
            this.dgLandList.AddColumn("实测面积", "Real_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("东至", "East");
            this.dgLandList.AddColumn("南至", "South");
            this.dgLandList.AddColumn("西至", "West");
            this.dgLandList.AddColumn("北至", "North");
            this.dgLandList.AddColumn("土地用途说明", "Land_use_remark");
            this.dgLandList.AddColumn("承包方", "Contractor");
            this.dgLandList.AddColumn("承包时间", "Contract_time").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("流转面积", "Move_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("流转形式", "Move_type");
            this.dgLandList.AddColumn("流转价格", "Move_price").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("流转日期", "Move_date").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("所属镇", "Town");
            this.dgLandList.AddColumn("所属村", "Villiage");
            this.dgLandList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgLandList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgLandList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            landBLL = new LandBLL();
            //初始化加载数据
            DataTable dt_people = this.landBLL.getAllLandDataTable(condition, pageIndex, pageSize);
            int totalCount = this.landBLL.getTotalLandCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgLandList.DataSource = dt_people;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
            string Land_name = tbLand_name.Text.Trim();
            string Name = tbName.Text.Trim();
            string Idcard = tbIdcard.Text.Trim();
            string Is_basic_farmland = cbIs_basic_farmland.SelectedValue.ToString();
            string Land_type = ctvLand_type.Text.Replace(" ", "").Replace(";", "；");
            string Land_grade = ctvLand_grade.Text.Replace(" ", "").Replace(";", "；");
            string Real_area_To = tbReal_area_To.Text.Trim();
            string Real_area_From = tbReal_area_From.Text.Trim();
            string East = tbEast.Text.Trim();
            string West = tbWest.Text.Trim();
            string North = tbNorth.Text.Trim();
            string South = tbSouth.Text.Trim();
            string Land_use_remark = tbLand_use_remark.Text.Trim();
            string Contractor = tbContractor.Text.Trim();
            string Contract_time_To = tbContract_time_To.Text.Trim();
            string Contract_time_From = tbContract_time_From.Text.Trim();
            string Move_area_From = tbMove_area_From.Text.Trim();
            string Move_area_To = tbMove_area_To.Text.Trim();
            string Move_type = ctvMove_type.Text.Replace(" ", "").Replace(";", "；");
            string Move_price_From = tbMove_price_From.Text.Trim();
            string Move_price_To = tbMove_price_To.Text.Trim();
            string Move_date_From = dpMove_date_From.Text.Trim();
            string Move_date_To = dpMove_date_To.Text.Trim();
            string Village = this.cbVillage.SelectedValue.ToString();
            string Town = this.cbTown.SelectedValue.ToString();

            //------------------------------------------------------------------
            condition.Add("Land_name", Land_name);
            condition.Add("Name", Name);
            condition.Add("Idcard", Idcard);
            condition.Add("Is_basic_farmland", Is_basic_farmland);
            condition.Add("Land_type", Land_type);
            condition.Add("Land_grade", Land_grade);
            condition.Add("Real_area_To", Real_area_To);
            condition.Add("Real_area_From", Real_area_From);
            condition.Add("East", East);
            condition.Add("West", West);
            condition.Add("North", North);
            condition.Add("South", South);
            condition.Add("Land_use_remark", Land_use_remark);
            condition.Add("Contractor", Contractor);
            condition.Add("Contract_time_To", Contract_time_To);
            condition.Add("Contract_time_From", Contract_time_From);
            condition.Add("Move_area_From", Move_area_From);
            condition.Add("Move_area_To", Move_area_To);
            condition.Add("Move_type", Move_type);
            condition.Add("Move_price_From", Move_price_From);
            condition.Add("Move_price_To", Move_price_To);
            condition.Add("Move_date_From", Move_date_From);
            condition.Add("Move_date_To", Move_date_To);
            condition.Add("Village", Village);
            condition.Add("Town", Town);

            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.landBLL.getAllLand(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgLandList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.LAND);
            ef.ShowDialog();
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


        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formLandAdd = new frmLandInfo();
            formLandAdd.ShowDialog();
            if (formLandAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgLandList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int land_id = int.Parse(this.dgLandList.SelectedRows[0].Cells[0].Value.ToString());

            Form formLandEdit = new frmLandInfo("EDIT", land_id);
            formLandEdit.ShowDialog();
            if (formLandEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgLandList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int land_id = int.Parse(this.dgLandList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.landBLL = new LandBLL();
                Result result = this.landBLL.DelLand(land_id);
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
        private void CancelItemSelect(UIComboTreeView uct)
        {
            if (uct != null)
            {
                foreach (TreeNode node in uct.Nodes)
                {
                    if (node.Checked == true)
                    {
                        node.Checked = false;
                    }
                }
            }
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            //清空查询文本框内容
            tbLand_name.Text = "";
            tbName.Text = "";
            tbIdcard.Text = "";
            cbIs_basic_farmland.SelectedValue = "";
            ctvLand_type.Text = "";
            ctvLand_grade.Text = "";
            tbReal_area_To.Text = "";
            tbReal_area_From.Text = "";
            tbEast.Text = "";
            tbWest.Text = "";
            tbNorth.Text = "";
            tbSouth.Text = "";
            tbLand_use_remark.Text = "";
            tbContractor.Text = "";
            tbContract_time_To.Text = "";
            tbContract_time_From.Text = "";
            tbMove_area_From.Text = "";
            tbMove_area_To.Text = "";
            ctvMove_type.Text = "";
            tbMove_price_From.Text = "";
            tbMove_price_To.Text = "";
            dpMove_date_From.Text = "";
            dpMove_date_To.Text = "";
            this.cbVillage.SelectedValue = "";
            this.cbTown.SelectedValue = "";
            CancelItemSelect(ctvLand_grade);
            CancelItemSelect(ctvLand_type);
            CancelItemSelect(ctvMove_type);
            //查询所有信息
            condition = null;
            InitListView(condition, this.pageIndex, this.pageSize);

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

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

