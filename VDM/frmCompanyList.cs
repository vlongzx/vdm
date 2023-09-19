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
        private CompanyBLL companyBLL = null;

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
            this.dpEstablish_date_From.Text = "";
            this.dpEstablish_date_To.Text = "";
            this.dpLicense_date_From.Text = "";
            this.dpLicense_date_To.Text = "";
            //初始化企业类型
            List<KeyValue> list_company_type = dictBLL.getDict("company_type");
            if (list_company_type != null)
            {
                foreach (KeyValue kv in list_company_type)
                {
                    if (kv.Key != "")
                    {
                        ctvCompany_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }
            //初始化是否龙头企业
            List<KeyValue> list_is_top_company = dictBLL.getDict("is_top_company");
            if (list_is_top_company != null)
            {
                this.cbIs_top_company.DataSource = list_is_top_company;
                this.cbIs_top_company.DisplayMember = "value";
                this.cbIs_top_company.ValueMember = "key";
            }

            List<KeyValue> list_company_status = dictBLL.getDict("company_status");
            if (list_company_status != null)
            {
                this.cbCompany_status.DataSource = list_company_status;
                this.cbCompany_status.DisplayMember = "value";
                this.cbCompany_status.ValueMember = "key";
            }
            List<KeyValue> list_taxpayer_qualification = dictBLL.getDict("taxpayer_qualification");
            if (list_company_status != null)
            {
                this.cbTaxpayer_qualification.DataSource = list_taxpayer_qualification;
                this.cbTaxpayer_qualification.DisplayMember = "value";
                this.cbTaxpayer_qualification.ValueMember = "key";
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
            this.dgCompanyList.AddColumn("编号", "Company_id");
            this.dgCompanyList.AddColumn("企业名称", "Company_name");
            this.dgCompanyList.Columns[1].Frozen = true;//冻结前两列
            this.dgCompanyList.AddColumn("企业类型", "Company_type");
            this.dgCompanyList.AddColumn("企业地址", "Company_address");
            this.dgCompanyList.AddColumn("统一社会信用编码", "Credit_code");
            this.dgCompanyList.AddColumn("工商注册号", "Business_code");
            this.dgCompanyList.AddColumn("营业执照日期", "License_date");
            this.dgCompanyList.AddColumn("组织机构代码", "Organization_code");
            this.dgCompanyList.AddColumn("成立时间", "Establish_date").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("企业法人姓名", "Legal_name");
            this.dgCompanyList.AddColumn("企业法人身份证", "Legal_idcard");
            this.dgCompanyList.AddColumn("企业联系电话", "Company_phone");
            this.dgCompanyList.AddColumn("人员规模", "Staff_size").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("参保人数", "Insure_person_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("产值(万元)", "Output").SetSortMode(DataGridViewColumnSortMode.Automatic).SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgCompanyList.AddColumn("纳税人识别号", "Taxpayer_code");
            this.dgCompanyList.AddColumn("纳税人资质", "Taxpayer_qualification");
            this.dgCompanyList.AddColumn("是否龙头企业", "Is_top_company");
            this.dgCompanyList.AddColumn("企业经营状态", "Company_status");
            this.dgCompanyList.AddColumn("所属镇", "Town");
            this.dgCompanyList.AddColumn("所属村", "Villiage");
            this.dgCompanyList.AddColumn("添加时间", "Create_datetime");
            this.dgCompanyList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgCompanyList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            companyBLL = new CompanyBLL();
            //初始化加载数据
            DataTable dt_people = this.companyBLL.getAllCompanyDataTable(condition, pageIndex, pageSize);
            int totalCount = this.companyBLL.getTotalCompanyCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgCompanyList.DataSource = dt_people;
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
            Form formLandAdd = new frmCompanyInfo();
            formLandAdd.ShowDialog();
            if (formLandAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgCompanyList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int company_id = int.Parse(this.dgCompanyList.SelectedRows[0].Cells[0].Value.ToString());

            Form formLandEdit = new frmCompanyInfo("EDIT", company_id);
            formLandEdit.ShowDialog();
            if (formLandEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }
        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.companyBLL.getAllCompany(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgCompanyList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.COMPANY);
            ef.ShowDialog();
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.COMPANY);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
          string Business_code= tbBusiness_code.Text.Trim();
          string Company_address = tbCompany_address.Text.Trim();
          string Company_name = tbCompany_name.Text.Trim();
          string Company_phone = tbCompany_phone.Text.Trim();
          string Credit_code = tbCredit_code.Text.Trim();
          string Insure_person_count_From = tbInsure_person_count_From.Text.Trim();
          string Insure_person_count_To = tbInsure_person_count_To.Text.Trim();
          string Legal_idcard = tbLegal_idcard.Text.Trim();
          string Legal_name = tbLegal_name.Text.Trim();
          string Organization_code = tbOrganization_code.Text.Trim();
          string Output_From = tbOutput_From.Text.Trim();
          string Output_To = tbOutput_To.Text.Trim();
          string Staff_size_From = tbStaff_size_From.Text.Trim();
          string Staff_size_To = tbStaff_size_To.Text.Trim();
          string Taxpayer_code = tbTaxpayer_code.Text.Trim();
          string Taxpayer_qualification = cbTaxpayer_qualification.SelectedValue.ToString();
          string Company_status = cbCompany_status.SelectedValue.ToString();
          string Company_type = ctvCompany_type.Text.ToString();
          string Is_top_company = cbIs_top_company.SelectedValue.ToString();
          string Establish_date_From = dpEstablish_date_From.Text.Trim();
          string Establish_date_To = dpEstablish_date_To.Text.Trim();
          string License_date_From = dpLicense_date_From.Text.Trim();
          string License_date_To = dpLicense_date_To.Text.Trim();
          string Village = this.cbVillage.SelectedValue.ToString();
          string Town = this.cbTown.SelectedValue.ToString();
        

            //------------------------------------------------------------------
            condition.Add("Business_code", Business_code);
            condition.Add("Company_address", Company_address);
            condition.Add("Company_name", Company_name);
            condition.Add("Company_phone", Company_phone);
            condition.Add("Credit_code", Credit_code);
            condition.Add("Insure_person_count_From", Insure_person_count_From);
            condition.Add("Insure_person_count_To", Insure_person_count_To);
            condition.Add("Legal_idcard", Legal_idcard);
            condition.Add("Legal_name", Legal_name);
            condition.Add("Organization_code", Organization_code);
            condition.Add("Output_From", Output_From);
            condition.Add("Output_To", Output_To);
            condition.Add("Staff_size_From", Staff_size_From);
            condition.Add("Staff_size_To", Staff_size_To);
            condition.Add("Taxpayer_code", Taxpayer_code);
            condition.Add("Taxpayer_qualification", Taxpayer_qualification);
            condition.Add("Company_status", Company_status);
            condition.Add("Company_type", Company_type);
            condition.Add("Is_top_company", Is_top_company);
            condition.Add("Establish_date_From", Establish_date_From);
            condition.Add("Establish_date_To", Establish_date_To);
            condition.Add("License_date_From", License_date_From);
            condition.Add("License_date_To", License_date_To);
            condition.Add("Village", Village);
            condition.Add("Town", Town);

            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgCompanyList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int company_id = int.Parse(this.dgCompanyList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.companyBLL = new CompanyBLL();
                Result result = this.companyBLL.DelCompany(company_id);
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
            tbBusiness_code.Text = "";
            tbCompany_address.Text = "";
            tbCompany_name.Text = "";
            tbCompany_phone.Text = "";
            tbCredit_code.Text = "";
            tbInsure_person_count_From.Text = "";
            tbInsure_person_count_To.Text = "";
            tbLegal_idcard.Text = "";
            tbLegal_name.Text = "";
            tbOrganization_code.Text = "";
            tbOutput_From.Text = "";
            tbOutput_To.Text = "";
            tbStaff_size_From.Text = "";
            tbStaff_size_To.Text = "";
            tbTaxpayer_code.Text = "";
            cbTaxpayer_qualification.SelectedValue = "";
            cbCompany_status.SelectedValue = "";
            ctvCompany_type.Text = "";
            cbIs_top_company.SelectedValue = "";
            dpEstablish_date_From.Text = "";
            dpEstablish_date_To.Text = "";
            dpLicense_date_From.Text = "";
            dpLicense_date_To.Text = "";
            this.cbVillage.SelectedValue = "";
            this.cbTown.SelectedValue = "";
            //清空多选下拉框
            CancelItemSelect(this.ctvCompany_type);
            //查询所有信息
            condition = null;
            InitListView(condition, this.pageIndex, this.pageSize);

        }

    }
}
