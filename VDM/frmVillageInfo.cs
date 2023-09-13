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
    public partial class frmVillageInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private VillageBLL villageBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int village_id = 0;
        public frmVillageInfo()
        {
            InitializeComponent();
        }
        public frmVillageInfo(string opreation_mode, int village_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.village_id = village_id;
        }

        private void frmVillageInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                villageBLL = new VillageBLL();
                Village village = this.villageBLL.getVillage(this.village_id);
                //界面数据绑定
                tbConfirm_area.Text = village.Confirm_area.ToString();
                tbFactory.Text = village.Factory.ToString();
                tbForeast_area.Text = village.Foreast_area.ToString();
                tbMechine.Text = village.Mechine;
                tbMineral_resource.Text = village.Mineral_resource.ToString();
                tbMoney.Text = village.Money.ToString();
                tbMove_area.Text = village.Move_area.ToString();
                tbOffice.Text = village.Office.ToString();
                tbRoad_length.Text = village.Road_length.ToString().ToString();
                tbSchool.Text = village.School.ToString();
                tbShop.Text = village.Shop.ToString();
                tbWater_resource.Text = village.Water_resource.ToString();
                this.cbTown.Text = village.Town;
                this.cbVilliage.Text = village.Villiage;

            }

        }
        public void InitPageControl()
        {
            dictBLL = new DictBLL();

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


            List<KeyValue> list_village = new List<KeyValue>();
           // list_village.Add(new KeyValue("", "请选择"));
            this.cbVilliage.DataSource = list_village;
            this.cbVilliage.DisplayMember = "value";
            this.cbVilliage.ValueMember = "key";
            cbTown.SelectedValue = LoginInfo.CurrentUser.Town;
            cbVilliage.SelectedValue = LoginInfo.CurrentUser.Village;

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

                            this.cbVilliage.DataSource = list_village;
                            this.cbVilliage.DisplayMember = "value";
                            this.cbVilliage.ValueMember = "key";
                            list_village.Add(new KeyValue("", "请选择"));
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
        /// <summary>
        ///  重写数据验证方法
        /// </summary>
        /// <returns></returns>
        protected override bool CheckData()
        {

            return CheckEmpty(tbConfirm_area, "请输入确权耕地面积（亩）")
                 && CheckEmpty(this.tbFactory, "请输入村集体厂房（平方米）")
                && CheckEmpty(this.tbForeast_area, "请输入林地面积（亩）")
                && CheckEmpty(tbMechine, "请输入村集体设施、设备")
                && CheckEmpty(tbMineral_resource, "请输入矿产资源量（亩 / 吨 / 立方）")
                   && CheckEmpty(tbMoney, "请输入村集体资金(万元)")
                    && CheckEmpty(tbMove_area, "请输入机动耕地面积（亩）")
                   && CheckEmpty(tbOffice, "请输入村组织办公场所（平方米）")
                   && CheckEmpty(tbRoad_length, "请输入道路长度（公里）")
                      && CheckEmpty(tbSchool, "请输入学校（平方米）")
                        && CheckEmpty(tbShop, "请输入村集体门店（平方米）")
              && CheckEmpty(tbWater_resource, "请输入水资源量（立方 / 秒）")
                      && CheckCB(cbTown, "请选择所属镇")
                       && CheckCB(cbVilliage, "请选择所属村")

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


        private void btnOK_Click(object sender, EventArgs e)
        {
            //如果数据校验没有通过则直接返回。
            if (this.IsOK == false)
            {
                return;
            }


            //从界面获取值封装业务对象
            Village village = new Village();
            village.Village_id = this.village_id;
            village.Mechine = tbMechine.Text;
            village.Confirm_area = double.Parse(tbConfirm_area.Text);
            village.Factory = double.Parse(tbFactory.Text);
            village.Foreast_area = double.Parse(tbForeast_area.Text);
            village.Mineral_resource = double.Parse(tbMineral_resource.Text);
            village.Money = double.Parse(tbMoney.Text);
            village.Move_area = double.Parse(tbMove_area.Text);
            village.Office = double.Parse(tbOffice.Text);
            village.Road_length = double.Parse(tbRoad_length.Text);
            village.School = double.Parse(tbSchool.Text);
            village.Shop = double.Parse(tbShop.Text);
            village.Water_resource = double.Parse(tbWater_resource.Text);
            village.Town = this.cbTown.Text.ToString();
            village.Villiage = this.cbVilliage.Text.ToString();
            village.Creater = LoginInfo.CurrentUser.Account;
            village.Create_datetime = DateTime.Now.ToString();
            villageBLL = new VillageBLL();

            if (this.opreation_mode == "ADD")
            {
                Result result = villageBLL.AddVillage(village);
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
                Result result = villageBLL.EditVillage(village);
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
