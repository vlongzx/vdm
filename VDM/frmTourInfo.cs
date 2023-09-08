using com.vdm.bll;
using com.vdm.common;
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
    public partial class frmTourInfo : UIEditForm
    {
        private int tour_id;
        private TourBLL tourBLL = null;
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        public frmTourInfo()
        {
            InitializeComponent();
        }

        public frmTourInfo(int tour_id)
        {
            InitializeComponent();
            this.tour_id = tour_id;
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
        ///  重写数据验证方法
        /// </summary>
        /// <returns></returns>
        protected override bool CheckData()
        {

            return CheckEmpty(tbAddress, "请输入地址")
                 && CheckEmpty(this.tbCompany_id, "请输入统一社会信用代码")
                && CheckIDCard(this.tbLegal_name, "请输入法定代表人姓名")
                && CheckEmpty(tbPhone_number, "请输入联系电话")
                && CheckEmpty(tbPrincipal_name, "请输入主体名称")
                   && CheckEmpty(tbRegistered_trademark, "请输入注册商标")
                    && CheckEmpty(tbYear_person_count, "请输入年接待旅游（人次）")
                   && CheckEmpty(tbYear_trade_income, "请输入年经营收入（万元）")
                   && CheckCB(cbPrincipal_category, "请选择主体类别")
                      && CheckCB(cbTrade_form, "请选择经营形式")
                      && CheckCB(cbTown, "请选择所属镇")
                       && CheckCB(cbVillage, "请选择所属村")

                ;
        }

        //校验下拉框是否选择
        protected bool CheckCB(UIComboBox uicb, string Message)
        {
            if (uicb.Text == "请选择")
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }

        /// <summary>
        ///  验证身份证合法性
        /// </summary>
        /// <param name="tbIDCard"></param>
        /// <param name="Message"></param>
        /// <returns></returns>
        protected bool CheckIDCard(UITextBox tbIDCard, string Message)
        {
            //验证输入的身份证是否合法
            if (tbIDCard.Text.Trim() != "" && Utils.IsIDCard(tbIDCard.Text.Trim()) == false)
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //如果数据校验没有通过则直接返回。
            if (this.IsOK == false)
            {
                return;
            }
            //从界面获取值封装业务对象
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
            int year_person_count = 0;
            if (this.tbYear_person_count.Text.Trim() != "")
            {
                year_person_count = int.Parse(this.tbYear_person_count.Text.Trim());
            }

            double year_trade_income = 0;
            if (this.tbYear_trade_income.Text.Trim() != "")
            {
                year_trade_income = double.Parse(this.tbYear_trade_income.Text.Trim());
            }
            string remark = this.tbRemark.Text;

            Tour tour = new Tour();
            tour.Address = address;
            tour.Company_id = company_id;
            tour.Legal_name = legal_name;
            tour.Phone_number = phone_number;
            tour.Principal_category = principal_category;
            tour.Principal_name = principal_name;
            tour.Registered_trademark = registered_trademark;
            tour.Remark = remark;
            tour.Town = town;
            tour.Trade_form = trade_form;
            tour.Village = villiage;
            tour.Year_person_count = year_person_count;
            tour.Year_trade_income = year_trade_income;

            tourBLL = new TourBLL();
            
            if (this.tour_id == 0)//代表是新增
            {
                tour.Creater = LoginInfo.CurrentUser.AccountName;
                tour.Create_datetime = DateTime.Now.ToString();

                Result result = this.tourBLL.addTour(tour);
                if (result.Count == 1)
                {
                    MessageBox.Show("保存成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
            else
            {
                tour.Last_updater = LoginInfo.CurrentUser.AccountName;
                tour.Last_update_datetime = DateTime.Now.ToString();
                tour.Tour_id = this.tour_id;
                Result result = tourBLL.editTour(tour);
                if (result.Count == 1)
                {
                    MessageBox.Show("编辑成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
       /// <summary>
       /// 加载
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmTourInfo_Load(object sender, EventArgs e)
        {
            InitControls();

            if(tour_id != 0)
            {
                this.tourBLL = new TourBLL();
                Tour tour = this.tourBLL.getTour(tour_id);

                if (tour != null)
                {
                    this.tbAddress.Text = tour.Address;
                    this.tbCompany_id.Text = tour.Company_id;
                    this.tbLegal_name.Text = tour.Legal_name;
                    this.tbPhone_number.Text = tour.Phone_number;
                    this.tbPrincipal_name.Text = tour.Principal_name;
                    this.tbRegistered_trademark.Text = tour.Registered_trademark;
                    this.tbYear_person_count.Text = tour.Year_person_count.ToString();
                    this.tbYear_trade_income.Text = tour.Year_trade_income.ToString();
                    this.cbPrincipal_category.SelectedValue = tour.Principal_category;
                    this.cbTown.SelectedValue = tour.Town;
                    this.cbTrade_form.SelectedValue = tour.Trade_form;
                    this.cbVillage.SelectedValue = tour.Village;
                    this.tbRemark.Text = tour.Remark;
                }
            }
            
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
                        int pre_org_id = this.orgBLL.getOrgIdByOrgCode(org_code);
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
    }
}
