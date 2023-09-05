﻿using com.vdm.bll;
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
    public partial class frmLandInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private LandBLL landBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int land_id = 0;
        public frmLandInfo()
        {
            InitializeComponent();
        }
        public frmLandInfo(string opreation_mode, int land_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.land_id = land_id;
        }

        private void frmLandInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                landBLL = new LandBLL();
                Land land = this.landBLL.getLand(this.land_id);
                //界面数据绑定
                tbLand_name.Text = land.Land_name;
                tbName.Text = land.Name;
                tbIdcard.Text = land.Idcard;
                cbIs_basic_farmland.SelectedValue = land.Is_basic_farmland;
                cbLand_type.SelectedValue = land.Land_type;
                cbLand_grade.SelectedValue = land.Land_grade;
                tbReal_area.Text = land.Real_area.ToString();
                tbEast.Text = land.East;
                tbWest.Text = land.West;
                tbNorth.Text = land.North;
                tbSouth.Text = land.South;
                tbLand_use_remark.Text = land.Land_use_remark;
                tbContractor.Text = land.Contractor;
                tbContract_time.Text = land.Contract_time;
                tbMove_area.Text = land.Move_area.ToString();
                cbMove_type.SelectedValue = land.Move_type;
                tbMove_price.Text = land.Move_price.ToString();
                dpMove_date.Text = land.Move_date;
                this.cbTown.Text = land.Town;
                this.cbVillage.Text = land.Villiage;

            }
        }
        public void InitPageControl()
        {
            tbContract_time.Enabled = false;
            tbMove_price.Enabled = false;
            tbMove_area.Enabled = false;
            dpMove_date.Enabled = false;
            cbMove_type.Enabled = false;
            dictBLL = new DictBLL();
            //初始化日期控件
            this.dpMove_date.Text = "";
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
                this.cbLand_type.DataSource = list_land_type;
                this.cbLand_type.DisplayMember = "value";
                this.cbLand_type.ValueMember = "key";
            }

            List<KeyValue> list_land_grade = dictBLL.getDict("land_grade");
            if (list_land_grade != null)
            {
                this.cbLand_grade.DataSource = list_land_grade;
                this.cbLand_grade.DisplayMember = "value";
                this.cbLand_grade.ValueMember = "key";
            }


            List<KeyValue> list_move_type = dictBLL.getDict("move_type");
            if (list_move_type != null)
            {
                this.cbMove_type.DataSource = list_move_type;
                this.cbMove_type.DisplayMember = "value";
                this.cbMove_type.ValueMember = "key";
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
            //if (this.opreation_mode == "EDIT" && editFlag)
            //{
            //    editFlag = false;
            //    return;
            //}
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

            return CheckEmpty(tbName, "请输入姓名")
                && CheckIDCard(this.tbIdcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckEmpty(tbLand_name, "请输入地块名称")
                && CheckCB(cbIs_basic_farmland, "请选择是否基本农田")
                 && CheckCB(cbLand_type, "请选择地块类型")
                      && CheckCB(cbLand_grade, "请选择地块等级")
                      && CheckEmpty(tbReal_area, "请输入实测面积")
                      && CheckEmpty(tbEast, "请输入东至")
                      && CheckEmpty(tbSouth, "请输入南至")
                      && CheckEmpty(tbWest, "请输入西至")
                      && CheckEmpty(tbNorth, "请输入北至 ")
                        && CheckEmpty(tbLand_use_remark, "请输入土地用途说明 ")
                     && CheckEmpty(tbLand_use_remark, "请输入土地用途说明 ")
                 && CheckContractor()
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
        protected bool CheckContractor()
        {
            if (tbContractor.Text != "")
            {
                return CheckEmpty(tbContract_time, "请输入承包时间")
                    && CheckEmpty(tbMove_area, "请输入流转面积")
                    && CheckCB(cbMove_type, "请选择流转形式")
                    && CheckEmpty(tbMove_price, "请输入流转价格")
                     && CheckEmpty(dpMove_date, "请输入流转日期")
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
            Land land = new Land();
            land.Land_id = this.land_id;

            land.Land_name = tbLand_name.Text.Trim();
            land.Name = tbName.Text.Trim();
            land.Idcard = tbIdcard.Text.Trim();
            land.Is_basic_farmland = cbIs_basic_farmland.SelectedValue.ToString();
            land.Land_type = cbLand_type.SelectedValue.ToString();
            land.Land_grade = cbLand_grade.SelectedValue.ToString();
            land.Real_area= double.Parse(tbReal_area.Text.Trim());
            land.East = tbEast.Text.Trim();
            land.West = tbWest.Text.Trim();
            land.North = tbNorth.Text.Trim();
            land.South = tbSouth.Text.Trim();
            land.Land_use_remark = tbLand_use_remark.Text.Trim();
            land.Contractor = tbContractor.Text.Trim();
            if(tbContractor.Text.Trim()!="")
            {
                land.Contract_time = tbContract_time.Text.Trim();
                land.Move_area = double.Parse(tbMove_area.Text.Trim());
                land.Move_type = cbMove_type.SelectedValue.ToString();
                land.Move_price = int.Parse(tbMove_price.Text.Trim());
                land.Move_date = dpMove_date.Text.ToString();
            }
            land.Town = this.cbTown.Text.ToString();
            land.Villiage = this.cbVillage.Text.ToString();
            land.Creater = LoginInfo.CurrentUser.Account;
            land.Create_datetime = DateTime.Now.ToString();
            landBLL = new LandBLL();

            if (this.opreation_mode == "ADD")
            {
                Result result = landBLL.AddLand(land);
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
                Result result = landBLL.EditLand(land);
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

        private void tbContractor_TextChanged(object sender, EventArgs e)
        {
            if (tbContractor.Text.Trim() == "")
            {
                tbContract_time.Enabled = false;
                tbMove_price.Enabled = false;
                tbMove_area.Enabled = false;
                dpMove_date.Enabled = false;
                cbMove_type.Enabled = false;
            }
            else
            {
                tbContract_time.Enabled = true;
                tbMove_price.Enabled = true;
                tbMove_area.Enabled = true;
                dpMove_date.Enabled = true;
                cbMove_type.Enabled = true;
            }
        }
    }
}