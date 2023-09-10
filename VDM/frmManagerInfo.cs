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
    public partial class frmManagerInfo : UIEditForm
    {

        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private ManagerBLL managerBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int manager_id = 0;
        public frmManagerInfo()
        {
            InitializeComponent();
        }
        public frmManagerInfo(string opreation_mode, int manager_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.manager_id = manager_id;
        }

        private void frmManagerInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                managerBLL = new ManagerBLL();
                Manager manager = this.managerBLL.getManager(this.manager_id);
                //界面数据绑定
                this.tbManager_name.Text = manager.Manager_name;
                this.cbSex.SelectedValue = manager.Sex;
                this.cbNation.SelectedValue = manager.Nation;
                this.cbEducation.SelectedValue = manager.Education;
                this.tbPost.Text = manager.Post;
                this.tbIdcard.Text = manager.Idcard;
                this.tbPhone_number.Text = manager.Phone_number;
                this.cbPolitcal_outlook.SelectedValue = manager.Politcal_outlook;
                this.dpJoin_party_time.Text = manager.Join_party_time;
                this.dpBirthday.Text = manager.Birthday;
                this.dpEmploy_date.Text = manager.Employ_date;
                this.cbTown.Text = manager.Town;
                this.cbVillage.Text = manager.Villiage;

            }

        }
        public void InitPageControl()
        {
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
            this.dpBirthday.Text = "";
            this.dpJoin_party_time.Text = "";
            this.dpEmploy_date.Text = "";
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
           // list_town.Add(new KeyValue("", "请选择"));
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            //cbTown.SelectedValue = "";
            cbTown.SelectedValue = LoginInfo.CurrentUser.Town;

            List<KeyValue> list_village = new List<KeyValue>();
            //list_village.Add(new KeyValue("", "请选择"));
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
                        string pre_org_id = this.orgBLL.getOrgIdByOrgCode(org_code);
                        List<KeyValue> list_village = orgBLL.getOrgByTown(pre_org_id);
                        if (list_village != null)
                        {
                            // list_village.Add(new KeyValue("", "请选择"));
                            this.cbVillage.DataSource = list_village;
                            this.cbVillage.DisplayMember = "value";
                            this.cbVillage.ValueMember = "key";
                            // this.cbVillage.SelectedValue = "";
                            cbVillage.SelectedValue = LoginInfo.CurrentUser.Village;
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

            return CheckEmpty(tbManager_name, "请输入姓名")
                && CheckEmpty(tbIdcard, "请输入身份证号码")
                && CheckIDCard(this.tbIdcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckCB(cbNation, "请选择民族")
                           && CheckCB(cbSex, "请选择性别")
                 && CheckCB(cbPolitcal_outlook, "请选择政治面貌")
                && CheckEmpty(dpBirthday, "请输入出生日期")
                && CheckEmpty(dpEmploy_date, "请输入任职日期")
                && CheckEmpty(tbPhone_number, "请输入联系电话")
                && CheckEmpty(tbPost, "请输入职务")
                && CheckCB(cbEducation, "请选择学历")
                      && CheckCB(cbTown, "请选择所属镇")
                       && CheckCB(cbVillage, "请选择所属村")
                       && CheckPolitcal()
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


        //校验关联字段
        protected bool CheckPolitcal()
        {
            if (cbPolitcal_outlook.Text == "党员")
            {
                return CheckEmpty(dpJoin_party_time, "请选择入党时间");
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
        private void cbPolitcal_outlook_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPolitcal_outlook.SelectedValue.ToString() != "党员")
            {
                dpJoin_party_time.Enabled = false;
            }
            else
            {
                dpJoin_party_time.Enabled = true;
            }
        }
        private void tbIdcard_TextChanged(object sender, EventArgs e)
        {
            string strIDCard = this.tbIdcard.Text.Trim();
            if (strIDCard.Length == 18)
            {
                string strBirthday = strIDCard.Substring(6, 4) + "-" + strIDCard.Substring(10, 2) + "-" + strIDCard.Substring(12, 2);
                dpBirthday.Value = DateTime.Parse(strBirthday);
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //如果数据校验没有通过则直接返回。
            if (this.IsOK == false)
            {
                return;
            }


            //从界面获取值封装业务对象
            Manager manager = new Manager();
            manager.Manager_id = this.manager_id;
            manager.Idcard = tbIdcard.Text;
            manager.Manager_name = tbManager_name.Text;
            manager.Phone_number = tbPhone_number.Text;
            manager.Post = tbPost.Text;
            manager.Join_party_time = dpJoin_party_time.Text;
            manager.Employ_date = dpEmploy_date.Text;
            manager.Birthday = dpBirthday.Text;
            manager.Education = cbEducation.SelectedValue.ToString();
            manager.Nation = cbNation.SelectedValue.ToString();
            manager.Politcal_outlook = cbPolitcal_outlook.SelectedValue.ToString();
            manager.Sex = cbSex.SelectedValue.ToString();
            manager.Town = this.cbTown.Text.ToString();
            manager.Villiage = this.cbVillage.Text.ToString();
            manager.Creater = LoginInfo.CurrentUser.Account;
            manager.Create_datetime = DateTime.Now.ToString();
            managerBLL = new ManagerBLL();

            if (this.opreation_mode == "ADD")
            {
                if (managerBLL.QueryByIdcard(manager.Idcard).Rows.Count != 0)
                {
                    MessageBox.Show("该身份证号码已存在！请检查信息是否正确");
                }
                else
                {
                    Result result = managerBLL.AddManager(manager);
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
              
            }
            else
            {
                Result result = managerBLL.EditManager(manager);
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
