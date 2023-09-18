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
    public partial class frmUserinfo : UIEditForm
    {
        private int flag = 0;
        private int user_id = 0;
        private UserBLL userBLL = null;
        private RoleBLL roleBLL = null;
        private OrgBLL orgBLL = null;
        public frmUserinfo()
        {
            InitializeComponent();
        }

        public frmUserinfo(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        protected override bool CheckData()
        {
            return CheckEmpty(this.tbUsername,"用户名不能为空。")
                ;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text.Trim();
            string realname = this.tbRealName.Text.Trim();
            string remark = this.tbRemark.Text.Trim();
            string town  =this.cbTown.SelectedValue.ToString();
            string village = this.cbVillage.SelectedValue.ToString();
            string  character_id = this.cbRoel.SelectedValue.ToString();

            
            
            User user = new User();
            user.Username = username;
            user.Realname = realname;
            user.Town = town;
            user.Village = village;
            user.Character_id = character_id;
            user.Remark = remark;
            if(village == "")
            {
                user.Level = "乡镇级";
            }
            else
            {
                user.Level = "村级";
            }
            this.userBLL = new UserBLL();
            Result result = null;

            if(user_id == 0)
            {
                string password = this.tbPassword.Text.Trim();
                string confirm_password = this.tbConfirmPassword.Text;
                if(password == "")
                {
                    MessageBox.Show("密码不能为空，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Utils.IsPasswordValid(this.tbPassword.Text) == false)
                {
                    ShowErrorDialog("密码必须至少有一个大写字母、一个小写字母、一个数字并且长度要大于8位。");
                    //this.tbPassword.Focus();
                    return;
                }
                if (password.Equals(confirm_password) == false)
                {
                    MessageBox.Show("输入密码和确认密码不一致，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                    user.Password = MD5Encrypt.MD5Encrypt32(password);
                    result = this.userBLL.addUser(user);

            }
            else
            {
                string password = this.tbPassword.Text.Trim();
                string confirm_password = this.tbConfirmPassword.Text;
                if (password == "")
                {
                    MessageBox.Show("密码不能为空，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Utils.IsPasswordValid(this.tbPassword.Text) == false)
                {
                    ShowErrorDialog("密码必须至少有一个大写字母、一个小写字母、一个数字并且长度要大于8位。");
                    //this.tbPassword.Focus();
                    return;
                }
                if (password.Equals(confirm_password) == false)
                {
                    MessageBox.Show("输入密码和确认密码不一致，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                user.Password = MD5Encrypt.MD5Encrypt32(password);
                user.User_id = user_id;
                result = this.userBLL.editUser(user);
            }

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

        private void frmUserinfo_Load(object sender, EventArgs e)
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

            roleBLL = new RoleBLL();
            DataTable dt = this.roleBLL.getAllRole();

            if (dt != null && dt.Rows.Count > 0) {
                this.cbRoel.DataSource = dt;
                this.cbRoel.DisplayMember = "role_name";
                this.cbRoel.ValueMember = "role_id";
            }

            if (user_id != 0)
            {
                this.userBLL = new UserBLL();
                User user = this.userBLL.getUser(user_id);
                this.tbUsername.Text = user.Username;
                this.tbRealName.Text = user.Realname;
                this.tbRemark.Text = user.Remark;
                this.cbRoel.SelectedValue = user.Character_id;
                this.cbTown.SelectedValue = user.Town;
                this.cbVillage.SelectedValue = user.Village;
                //this.tbPassword.Text = user.Password;
                //this.tbConfirmPassword.Text = user.Password;
                //this.tbPassword.Enabled = false;
                //this.tbConfirmPassword.Enabled = false;
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
                           // this.cbVillage.SelectedValue = "";
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

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (Utils.IsPasswordValid(this.tbPassword.Text) == false)
            {
                ShowErrorDialog("密码必须至少有一个大写字母、一个小写字母、一个数字并且长度要大于8位。");
                //this.tbPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
