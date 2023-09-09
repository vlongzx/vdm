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
    public partial class frmHouseInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private HouseBLL houseBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int house_id = 0;
        public frmHouseInfo()
        {
            InitializeComponent();
        }
        public frmHouseInfo(string opreation_mode, int house_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.house_id = house_id;
        }

        private void frmHouseInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                houseBLL = new HouseBLL();
                House house = this.houseBLL.getHouse(this.house_id);
                //界面数据绑定
                tbArea.Text = house.Area.ToString();
                tbHouse_location.Text = house.House_location;
                tbHouse_owner.Text = house.House_owner;
                tbIdcard.Text = house.Idcard;
                cbHouse_is_rent.Text = house.House_is_rent;
                cbHouse_safe_grade.SelectedValue = house.House_safe_grade;
                cbHouse_struction.SelectedValue = house.House_struction;
                cbHouse_type.Text = house.House_type;
                cbIs_my_struct.SelectedValue = house.Is_my_struct;
                cbIs_old_house.SelectedValue = house.Is_old_house;
                dpHouse_build_date.Text = house.House_build_date;
                dpOh_checktime.Text = house.Oh_checktime;
                this.cbTown.Text = house.Town;
                this.cbVillage.Text = house.Villiage;

            }

        }
        public void InitPageControl()
        {
            dictBLL = new DictBLL();
            //初始化日期控件
            this.dpHouse_build_date.Text = "";
            this.dpOh_checktime.Text = "";
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
            //list_town.Add(new KeyValue("", "请选择"));
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            // cbTown.SelectedValue = "";
            cbTown.SelectedValue = LoginInfo.CurrentUser.Town;
            List<KeyValue> list_village = new List<KeyValue>();
          //  list_village.Add(new KeyValue("", "请选择"));
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
                            //this.cbVillage.SelectedValue = "";
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

            return CheckEmpty(tbHouse_owner, "请输入房屋所有人")
                 && CheckEmpty(this.tbIdcard, "请输入房屋所有人身份证号")
                && CheckIDCard(this.tbIdcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckEmpty(tbArea, "请输入房屋面积")
                && CheckEmpty(tbHouse_location, "请输入房屋具体位置")
                   && CheckCB(cbHouse_is_rent, "请选择房屋是否租赁")
                    && CheckCB(cbHouse_safe_grade, "请选择房屋安全等级")
                   && CheckCB(cbHouse_struction, "请选择房屋结构")
                   && CheckCB(cbHouse_type, "请选择房屋类别")
                      && CheckCB(cbIs_my_struct, "请选择是否自建")
                        && CheckEmpty(dpHouse_build_date, "请选择房屋建设时间")
              && CheckCB(cbIs_old_house, "请选择房屋是否古宅")
                       && CheckOldHouse()
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

        protected bool CheckOldHouse()
        {
            if (cbIs_old_house.Text == "是")
            {
                return CheckEmpty(dpOh_checktime, "选择古宅审批时间")
                    ;
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
            House house = new House();
            house.House_id = this.house_id;
            house.Area = int.Parse(tbArea.Text);
            house.House_location = tbHouse_location.Text;
            house.House_owner = tbHouse_owner.Text;
            house.Idcard = tbIdcard.Text;
            house.House_build_date = dpHouse_build_date.Text;
            house.Oh_checktime = dpOh_checktime.Text;
            house.House_is_rent = cbHouse_is_rent.Text;
            house.House_safe_grade = cbHouse_safe_grade.SelectedValue.ToString();
            house.House_struction = cbHouse_struction.SelectedValue.ToString();
            house.House_type = cbHouse_type.SelectedValue.ToString();
            house.Is_my_struct = cbIs_my_struct.SelectedValue.ToString();
            house.Is_old_house = cbIs_old_house.SelectedValue.ToString();
            house.Town = this.cbTown.Text.ToString();
            house.Villiage = this.cbVillage.Text.ToString();
            house.Creater = LoginInfo.CurrentUser.Account;
            house.Create_datetime = DateTime.Now.ToString();
            houseBLL = new HouseBLL();

            if (this.opreation_mode == "ADD")
            {

                if (houseBLL.QueryByIdcard(house.Idcard).Rows.Count != 0)
                {
                    MessageBox.Show("该身份证号码已存在！请检查信息是否正确");
                }
                else
                {
                    Result result = houseBLL.AddHouse(house);
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
                Result result = houseBLL.EditHouse(house);
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

        private void cbIs_old_house_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbIs_old_house.SelectedValue.ToString() == "")
            {
                dpOh_checktime.Enabled = false;
            }
            else if (cbIs_old_house.SelectedValue.ToString() != "否")
            {
               dpOh_checktime.Enabled = true;
            }
            else
            {
                dpOh_checktime.Enabled = false;
            }
        }
    }
}
