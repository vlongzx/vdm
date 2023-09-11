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
    public partial class frmTourList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private TourBLL tourBLL = null;
        private Hashtable condition = null;
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmTourList()
        {
            InitializeComponent();
        }

        private void frmTourList_Load(object sender, EventArgs e)
        {
            InitTourList(null, pageIndex, pageSize);

            InitControls();

            InitFuncPowerControl();
        }

        /// <summary>
        ///  初始化权限控制
        /// </summary>
        private void InitFuncPowerControl()
        {
            if (LoginInfo.FuncPowerList.Contains("90000") == false)
            {
                this.gbSearch.Visible = false;
                this.gbResult.Visible = false;
            }

            if (LoginInfo.FuncPowerList.Contains("90001") == false)
            {
                this.btAdd.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("90002") == false)
            {
                this.btEdit.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("90003") == false)
            {
                this.btDelete.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("90004") == false)
            {
                this.gbSearch.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("90005") == false)
            {
                this.btImport.Visible = false;
            }
            if (LoginInfo.FuncPowerList.Contains("90006") == false)
            {
                this.btExport.Visible = false;
            }
        }

        /// <summary>
        ///  初始化界面控件数据
        /// </summary>
        private void InitControls()
        {
            this.dictBLL = new DictBLL();

            //初始化主体类别
            List<KeyValue> list_principal_category = dictBLL.getDict("principal_category");
            if (list_principal_category != null)
            {
                this.cbPrincipal_category.DataSource = list_principal_category;
                this.cbPrincipal_category.DisplayMember = "value";
                this.cbPrincipal_category.ValueMember = "key";
            }
            //初始化经营形式
            List<KeyValue> list_trade_form = dictBLL.getDict("trade_form");
            if (list_trade_form != null)
            {
                this.cbTrade_form.DataSource = list_trade_form;
                this.cbTrade_form.DisplayMember = "value";
                this.cbTrade_form.ValueMember = "key";
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
        ///  初始化旅游列表
        /// </summary>
        public void InitTourList(Hashtable condition, int pageIndex = 1, int pageSize = 20)
        {
            //初始化dgAnimal
            this.dgTourList.AutoGenerateColumns = false;
            this.dgTourList.RowTemplate.Height = 45;
            this.dgTourList.Columns.Clear();
            this.dgTourList.AddColumn("主体ID", "tour_id");
            this.dgTourList.AddColumn("主体类别", "principal_category");
            this.dgTourList.AddColumn("主体名称", "principal_name");
            this.dgTourList.Columns[2].Frozen = true;//冻结前两列
            this.dgTourList.AddColumn("所属镇", "town");
            this.dgTourList.AddColumn("所属村", "village");
            this.dgTourList.AddColumn("统一社会信用代码", "company_id");
            this.dgTourList.AddColumn("法定代表人姓名", "legal_name");
            this.dgTourList.AddColumn("注册商标", "registered_trademark");
            
            this.dgTourList.AddColumn("联系电话", "phone_number");
            this.dgTourList.AddColumn("经营形式", "trade_form");
            this.dgTourList.AddColumn("联系地址", "address");

            this.dgTourList.AddColumn("年接待旅游（人次）", "year_person_count");
            this.dgTourList.AddColumn("年经营收入（万元）", "year_trade_income");
           
            this.dgTourList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgTourList.AddColumn("添加人", "Creater");
            this.dgTourList.AddColumn("备注", "remark");
            //自适应列宽，包括列名和列内容
            this.dgTourList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            tourBLL = new TourBLL();
            DataTable dtAnimal = tourBLL.getAllTour(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.tourBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgTourList.DataSource = dtAnimal;
        }
        /// <summary>
        ///  查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            string company_id = this.tbCompany_id.Text.Trim();
            string principal_category = this.cbPrincipal_category.SelectedValue.ToString();
            string principal_name = this.tbPrincipal_name.Text.Trim();
            string legal_name = this.tbLegal_name.Text.Trim();
            string town = this.cbTown.SelectedValue.ToString();
            string villiage = this.cbVillage.SelectedValue.ToString();
            string registered_trademark = this.tbRegistered_trademark.Text.Trim();
            string phone_number = this.tbPhone_number.Text.Trim();
            string trade_form = this.cbTrade_form.SelectedValue.ToString();
            string address = this.tbAddress.Text.ToString();
            int year_person_count_from = 0;
            if(this.tbYear_person_count_from.Text.Trim() != "")
            {
                year_person_count_from = int.Parse(this.tbYear_person_count_from.Text.Trim());
            }
            int year_person_count_to = 0;
            if (this.tbYear_person_count_to.Text.Trim() != "")
            {
                year_person_count_to = int.Parse(this.tbYear_person_count_to.Text.Trim());
            }
            double year_trade_income_from = 0;
            if(this.tbYear_trade_income_from.Text.Trim() != "")
            {
                year_trade_income_from = double.Parse(this.tbYear_trade_income_from.Text.Trim());
            }
            double year_trade_income_to = 0;
            if (this.tbYear_trade_income_to.Text.Trim() != "")
            {
                year_trade_income_to = double.Parse(this.tbYear_trade_income_to.Text.Trim());
            }
            //将查询条件添加到hashtable
            this.condition = new Hashtable();
            this.condition.Add("company_id", company_id);
            this.condition.Add("principal_category", principal_category);
            this.condition.Add("principal_name", principal_name);
            this.condition.Add("legal_name", legal_name);
            this.condition.Add("town", town);
            this.condition.Add("villiage", villiage);
            this.condition.Add("registered_trademark", registered_trademark);
            this.condition.Add("phone_number", phone_number);
            this.condition.Add("trade_form", trade_form);
            this.condition.Add("address", address);
            this.condition.Add("year_person_count_from", year_person_count_from);
            this.condition.Add("year_person_count_to", year_person_count_to);
            this.condition.Add("year_trade_income_from", year_trade_income_from);
            this.condition.Add("year_trade_income_to", year_trade_income_to);

            this.tourBLL = new TourBLL();
            DataTable dtTour = this.tourBLL.getAllTour(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.tourBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgTourList.DataSource = dtTour;
        }

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
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            this.tbAddress.Text = "";
            this.tbCompany_id.Text = "";
            this.tbLegal_name.Text = "";
            this.tbPhone_number.Text = "";
            this.tbPrincipal_name.Text = "";
            this.tbRegistered_trademark.Text = "";
            this.tbYear_person_count_from.Text = "";
            this.tbYear_person_count_to.Text = "";
            this.tbYear_trade_income_from.Text = "";
            this.tbYear_trade_income_to.Text = "";
            this.cbPrincipal_category.SelectedValue = "";
            this.cbTown.SelectedValue = "";
            this.cbTrade_form.SelectedValue = "";
            this.cbVillage.SelectedValue = "";
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmTourInfo tourInfo = new frmTourInfo();
            tourInfo.Text = "增加旅游信息";
            tourInfo.Render();
            tourInfo.ShowDialog();
            if (tourInfo.DialogResult == DialogResult.OK)
            {
                InitTourList(null, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgTourList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int breed_id = int.Parse(this.dgTourList.SelectedRows[0].Cells[0].Value.ToString());

            frmTourInfo tourInfo = new frmTourInfo(breed_id);
            tourInfo.Text = "编辑旅游信息";
            tourInfo.ShowDialog();
            if (tourInfo.DialogResult == DialogResult.OK)
            {
                InitTourList(condition, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgTourList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int tour_id = int.Parse(this.dgTourList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.tourBLL = new TourBLL();
                Result result = this.tourBLL.delTour(tour_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   InitTourList(condition, this.pageIndex, this.pageSize);
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.TOUR);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.tourBLL.getAllTour(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgTourList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.TOUR);
            ef.ShowDialog();
        }
    }
}
