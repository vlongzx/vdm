using com.vdm.bll;
using com.vdm.common;
using com.vdm.dal;
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
    public partial class frmManagerList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private ManagerBLL managerBLL = null;
        private Hashtable condition = null;
        //高级查询条件
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmManagerList()
        {
            InitializeComponent();
        }

        private Form preForm;
        public frmManagerList(Form preForm)
        {
            InitializeComponent();
            this.preForm = preForm;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formManagerAdd = new frmManagerInfo();
            formManagerAdd.ShowDialog();
            if (formManagerAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
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
            if (LoginInfo.FuncPowerList.Contains("60000") == false)
            {
                this.gbSearch.Visible = false;
                this.gbResult.Visible = false;
            }

            if (LoginInfo.FuncPowerList.Contains("60001") == false)
            {
                this.btAdd.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("60002") == false)
            {
                this.btEdit.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("60003") == false)
            {
                this.btDelete.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("60004") == false)
            {
                this.gbSearch.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("60005") == false)
            {
                this.btImport.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("60006") == false)
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

            //初始化与户主的关系
            dictBLL = new DictBLL();
            //初始化民族
            this.dictBLL = new DictBLL();
            List<KeyValue> list_nation = dictBLL.getDict("nation");
            list_nation.Add(new KeyValue("", ""));
            if (list_nation != null)
            {
                this.cbNation.DataSource = list_nation;
                this.cbNation.DisplayMember = "value";
                this.cbNation.ValueMember = "key";
            }
            //初始化性别

            List<KeyValue> list_sex = dictBLL.getDict("sex");
            if (list_sex != null)
            {
                this.cbSex.DataSource = list_sex;
                this.cbSex.DisplayMember = "value";
                this.cbSex.ValueMember = "key";
            }
            //初始化日期控件
            this.dpBirthday_From.Text = "";
            this.dpBirthday_To.Text = "";
            this.dpJoin_party_time_from.Text = "";
            this.dpJoin_party_time_to.Text = "";
            this.dpEmploy_date_From.Text = "";
            this.dpEmploy_date_To.Text = "";
            //初始化政治面貌
            List<KeyValue> list_politcal_outlook = dictBLL.getDict("politcal_outlook");
            // list_politcal_outlook.Add(new KeyValue("", ""));
            if (list_politcal_outlook != null)
            {
                this.cbPolitcal_outlook.DataSource = list_politcal_outlook;
                this.cbPolitcal_outlook.DisplayMember = "value";
                this.cbPolitcal_outlook.ValueMember = "key";
            }

            //初始化学历
            List<KeyValue> list_education = dictBLL.getDict("education");
            if (list_education != null)
            {
                this.cbEducation.DataSource = list_education;
                this.cbEducation.DisplayMember = "value";
                this.cbEducation.ValueMember = "key";
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
            this.dgManagerList.AutoGenerateColumns = false;
            this.dgManagerList.RowTemplate.Height = 45;
            this.dgManagerList.Columns.Clear();
            this.dgManagerList.AddColumn("编号", "Manager_id");
            this.dgManagerList.AddColumn("姓名", "Manager_name");
            this.dgManagerList.Columns[1].Frozen = true;//冻结前两列
            this.dgManagerList.AddColumn("职务", "Post");
            this.dgManagerList.AddColumn("任职时间", "Employ_date");
            this.dgManagerList.AddColumn("出生日期", "Birthday").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgManagerList.AddColumn("性别", "Sex");
            this.dgManagerList.AddColumn("民族", "Nation");
            this.dgManagerList.AddColumn("政治面貌", "Politcal_outlook");
            this.dgManagerList.AddColumn("入党时间", "Join_party_time").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgManagerList.AddColumn("身份证号", "Idcard");
            this.dgManagerList.AddColumn("联系电话", "Phone_number");
            this.dgManagerList.AddColumn("学历", "Education");
            this.dgManagerList.AddColumn("所属镇", "Town");
            this.dgManagerList.AddColumn("所属村", "Villiage");
            this.dgManagerList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgManagerList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgManagerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            managerBLL = new ManagerBLL();
            //初始化加载数据
            DataTable dt_people = this.managerBLL.getAllManagerDataTable(condition, pageIndex, pageSize);
            int totalCount = this.managerBLL.getTotalManagerCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgManagerList.DataSource = dt_people;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgManagerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int house_id = int.Parse(this.dgManagerList.SelectedRows[0].Cells[0].Value.ToString());

            Form formLandEdit = new frmManagerInfo("EDIT", house_id);
            formLandEdit.ShowDialog();
            if (formLandEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        ///  刷新重新加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            this.tbPost.Text = "";
            this.tbPhone_number.Text = "";
            this.tbManager_name.Text = "";
            this.tbIdcard.Text = "";
            this.cbEducation.SelectedValue = "";
            this.cbNation.SelectedValue = "";
            this.cbPolitcal_outlook.SelectedValue = "";
            this.cbSex.SelectedValue = "";
            this.dpBirthday_From.Text = "";
            this.dpBirthday_To.Text = "";
            this.dpEmploy_date_From.Text = "";
            this.dpEmploy_date_To.Text = "";
            this.dpJoin_party_time_from.Text = "";
            this.dpJoin_party_time_to.Text = "";
            this.cbTown.SelectedValue = "";
            this.cbVillage.SelectedValue = "";

        }

        public override void Init()
        {
            base.Init();
            this.pagination.ActivePage = 1;
        }
        /// <summary>
        ///  删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgManagerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int manager_id = int.Parse(this.dgManagerList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.managerBLL = new ManagerBLL();
                Result result = this.managerBLL.DelManager(manager_id);
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

        /// <summary>
        ///  查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
            string Manager_name = this.tbManager_name.Text.Trim();
            string Sex = this.cbSex.SelectedValue.ToString();
            string Nation = this.cbNation.SelectedValue.ToString();
            string Post = this.tbPost.Text.Trim();
            string Idcard = this.tbIdcard.Text.Trim();
            string Phone_number = this.tbPhone_number.Text.Trim();
            string Birthday_From = this.dpBirthday_From.Text.Trim();
            string Birthday_To = this.dpBirthday_To.Text.Trim();
            string Politcal_outlook = this.cbPolitcal_outlook.SelectedValue.ToString();
            string Education = this.cbEducation.SelectedValue.ToString();
            string Join_party_time_from = this.dpJoin_party_time_from.Text.Trim();
            string Join_party_time_to = this.dpJoin_party_time_to.Text.Trim();
            string Employ_date_From = this.dpEmploy_date_From.Text.Trim();
            string Employ_date_To = this.dpEmploy_date_To.Text.Trim();
            string Village = this.cbVillage.SelectedValue.ToString();
            string Town = this.cbTown.SelectedValue.ToString();

            //------------------------------------------------------------------
            condition.Add("Manager_name", Manager_name);
            condition.Add("Sex", Sex);
            condition.Add("Nation", Nation);
            condition.Add("Post", Post);
            condition.Add("Idcard", Idcard);
            condition.Add("Phone_number", Phone_number);
            condition.Add("Birthday_From", Birthday_From);
            condition.Add("Birthday_To", Birthday_To);
            condition.Add("Politcal_outlook", Politcal_outlook);
            condition.Add("Employ_date_From", Employ_date_From);
            condition.Add("Employ_date_To", Employ_date_To);
            condition.Add("Education", Education);
            condition.Add("Join_party_time_from", Join_party_time_from);
            condition.Add("Join_party_time_to", Join_party_time_to);
            condition.Add("Village", Village);
            condition.Add("Town", Town);
            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
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

        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.MANAGER);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.managerBLL.getAllManager(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgManagerList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.MANAGER);
            ef.ShowDialog();
        }
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            this.pageIndex = pageIndex;
            InitListView(condition, this.pageIndex, this.pageSize);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
