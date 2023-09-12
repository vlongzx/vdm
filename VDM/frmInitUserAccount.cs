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
    public partial class frmInitUserAccount : UIForm
    {
        private UserBLL userBLL = null;
        private RoleBLL roleBLL = null;
        private OrgBLL orgBLL = null;
        public frmInitUserAccount()
        {
            InitializeComponent();
        }

        private void frmInitUserAccount_Load(object sender, EventArgs e)
        {
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

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (Utils.IsPasswordValid(this.tbPassword.Text) == false)
            {
                ShowErrorDialog("密码必须至少有一个大写字母、一个小写字母、一个数字并且长度要大于8位。");
                this.tbPassword.Focus();
            }
        }

        private void uiRadioButtonGroup1_ValueChanged(object sender, int index, string text)
        {
            if(text == "乡镇级")
            {
                this.cbVillage.Enabled = false;
            }
            else
            {
                this.cbVillage.Enabled = true;
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



        protected  bool CheckData()
        {

            return  CheckRBG(uiRadioButtonGroup1, "请选择账号级别！")
                   && CheckTB(tbPassword, "密码不能设置为空!")
                    && CheckConfirmPassword(tbPassword,tbConfirmPassword,"输入密码和确认密码不一致，请重新输入！")
                      && CheckTownAndVillage(cbTown, cbVillage, "请选择账号所属乡镇！", "请选择账号所属村！")
                ;
        }


    protected bool CheckConfirmPassword(UITextBox uitbPassword, UITextBox uitbConfirmPassword,string Message)
    {

                if ((uitbPassword.Text).Equals(uitbConfirmPassword.Text) == false)
                {
                    MessageBox.Show(Message, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
        return true;
    }

    protected bool CheckTownAndVillage(UIComboBox uicbTown, UIComboBox uicbVillage, string Message1, string Message2)
        {
            //若选择乡镇级
            if (this.uiRadioButtonGroup1.SelectedIndex == 0)
            {
                if (uicbTown.Text == "请选择")
                {
                    ShowWarningDialog(Message1);
                    return false;
                }
                return true;
            }
            //若选择村级
            else
            {
                if (uicbTown.Text == "请选择")
                {
                    ShowWarningDialog(Message1);
                    return false;
                }
                if (uicbVillage.Text == "请选择")
                {
                    ShowWarningDialog(Message2);
                    return false;
                }
                return true;
            }
        }
        //校验TextBox是否为空
        protected bool CheckTB(UITextBox uitb, string Message)
        {
            if (uitb.Text == "")
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }
        //校验下拉框是否选择
        protected bool CheckRBG(UIRadioButtonGroup uirbg, string Message)
        {
            if (uirbg.SelectedIndex!=0&& uirbg.SelectedIndex != 1)
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }

        private void btInit_Click(object sender, EventArgs e)
        {
            if(!CheckData())
            {
                return;
            }
            string username = this.tbUsername.Text.Trim();
            string password = this.tbPassword.Text;
            string confirm_password = this.tbConfirmPassword.Text;
            string town = this.cbTown.SelectedValue.ToString();
            string village = this.cbVillage.SelectedValue.ToString();
            string character_id = "sys_admin";

            User user = new User();
            user.Username = username;
            user.Password = MD5Encrypt.MD5Encrypt32(password);
            user.Town = town;
            user.Village = village;
            user.Character_id = character_id;
            user.Remark = "系统管理员，不允许删除";
            if (this.uiRadioButtonGroup1.SelectedIndex == 0)
            {
                user.Level = "乡镇级";
            }
            else
            {
                user.Level = "村级";
            }
            this.userBLL = new UserBLL();
            Result result = null;

            result = this.userBLL.addUser(user);

            if (result.Count == 1)
            {
                MessageBox.Show("账号信息初始化成功。\n登录用户名：admin，密码："+ password+",请牢记。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
