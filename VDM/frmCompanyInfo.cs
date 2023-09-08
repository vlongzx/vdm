using com.vdm.bll;
using com.vdm.common;
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

    public partial class frmCompanyInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private CompanyBLL companyBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int company_id = 0;
        public frmCompanyInfo()
        {
            InitializeComponent();
        }
        public frmCompanyInfo(string opreation_mode, int company_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.company_id = company_id;
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                companyBLL = new CompanyBLL();
                Company company = this.companyBLL.getCompany(this.company_id);
                //界面数据绑定
                tbBusiness_code.Text = company.Business_code;
                tbCompany_address.Text = company.Company_address;
                tbCompany_name.Text = company.Company_name;
                tbCompany_phone.Text = company.Company_phone;
                tbCredit_code.Text = company.Credit_code;
                tbInsure_person_count.Text = company.Insure_person_count.ToString();
                tbLegal_idcard.Text = company.Legal_idcard;
                tbLegal_name.Text = company.Legal_name;
                tbOrganization_code.Text = company.Organization_code;
                tbOutput.Text = company.Output.ToString();
                tbStaff_size.Text = company.Staff_size.ToString();
                tbTaxpayer_code.Text = company.Taxpayer_code;
                cbTaxpayer_qualification.SelectedValue = company.Taxpayer_qualification;
                cbCompany_status.SelectedValue = company.Company_status;
                // cbCompany_type.SelectedValue = company.Company_type;
                ctvCompany_type.Text = company.Company_type;
                cbIs_top_company.SelectedValue = company.Is_top_company;
                dpEstablish_date.Text = company.Establish_date;
                dpLicense_date.Text = company.License_date;
                this.cbTown.SelectedValue = company.Town;
                this.cbVillage.SelectedValue = company.Villiage;


            }
        }


        public void InitPageControl()
        {
            dictBLL = new DictBLL();
            //初始化日期控件
            this.dpEstablish_date.Text = "";
            this.dpLicense_date.Text = "";
            //初始化企业类型
            List<KeyValue> list_company_type = dictBLL.getDict("company_type");
            //if (list_company_type != null)
            //{
            //    this.cbCompany_type.DataSource = list_company_type;
            //    this.cbCompany_type.DisplayMember = "value";
            //    this.cbCompany_type.ValueMember = "key";
            //}
            if (list_company_type != null)
            {
                foreach(KeyValue kv in list_company_type)
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
                        int pre_org_id = this.orgBLL.getOrgIdByOrgCode(org_code);
                        List<KeyValue> list_village = orgBLL.getOrgByTown(pre_org_id);
                        if (list_village != null)
                        {
                            // list_village.Add(new KeyValue("", "请选择"));
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
        ///  重写数据验证方法
        /// </summary>
        /// <returns></returns>
        protected override bool CheckData()
        {

            return CheckEmpty(tbBusiness_code, "请输入工商注册号")
                && CheckIDCard(this.tbLegal_idcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckEmpty(tbCompany_address, "请输入企业地址")
                && CheckEmpty(tbCompany_name, "请输入企业名称")
                      && CheckEmpty(tbCompany_phone, "请输入企业联系电话")
                      && CheckEmpty(tbCredit_code, "请输入统一社会信用编码")
                      && CheckEmpty(tbInsure_person_count, "请输入参保人数")
                        && CheckEmpty(tbLegal_name, "请输入企业法人姓名 ")
                     && CheckEmpty(tbOrganization_code, "请输入组织机构代码 ")
                                           && CheckEmpty(tbOutput, "请输入产值(万元)")
                      && CheckEmpty(tbStaff_size, "请输入人员规模 ")
                        && CheckEmpty(tbTaxpayer_code, "请输入纳税人识别号")
                     && CheckCB(cbTaxpayer_qualification, "请选择纳税人资质")
                              && CheckCB(cbCompany_status, "请选择企业经营状态")
                                                    && CheckCB(cbIs_top_company, "请选择是否龙头企业")
                                                          //   && CheckCB(cbCompany_type, "请选择企业类型")
                                                          && CheckCTV(ctvCompany_type, "请选择企业类型")
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
        protected bool CheckCTV(UIComboTreeView uictv, string Message)
        {
            if (uictv.Text == "")
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
            Company company = new Company();
            company.Company_id = this.company_id;
            company.Business_code = tbBusiness_code.Text;
            company.Company_address = tbCompany_address.Text;
            company.Company_name = tbCompany_name.Text;
            company.Company_phone = tbCompany_phone.Text;
            company.Credit_code = tbCredit_code.Text;
            company.Insure_person_count= int.Parse(tbInsure_person_count.Text) ;
            company.Legal_idcard = tbLegal_idcard.Text;
            company.Legal_name = tbLegal_name.Text;
            company.Organization_code = tbOrganization_code.Text;
            company.Output= double.Parse(tbOutput.Text) ;
            company.Staff_size= int.Parse(tbStaff_size.Text);
            company.Taxpayer_code = tbTaxpayer_code.Text;
           company.Establish_date= dpEstablish_date.Text;
            company.License_date = dpLicense_date.Text;
            company.Taxpayer_qualification = cbTaxpayer_qualification.Text;
            company.Company_status = cbCompany_status.SelectedValue.ToString();
           // company.Company_type = cbCompany_type.SelectedValue.ToString();
            company.Company_type = ctvCompany_type.Text;
            company.Is_top_company = cbIs_top_company.SelectedValue.ToString();
            company.Town = this.cbTown.Text.ToString();
            company.Villiage = this.cbVillage.Text.ToString();
            company.Creater = LoginInfo.CurrentUser.Account;
            company.Create_datetime = DateTime.Now.ToString();
            companyBLL = new CompanyBLL();

            if (this.opreation_mode == "ADD")
            {
                Result result = companyBLL.AddCompany(company);
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
                Result result = companyBLL.EditCompany(company);
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
    }
}
