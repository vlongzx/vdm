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
            this.user_id = user_id;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text.Trim();
            string password = this.tbPassword.Text;
            string confirm_password = this.tbConfirmPassword.Text;
            string remark = this.tbRemark.Text.Trim();
            string town  =this.cbTown.SelectedValue.ToString();
            string village = this.cbVillage.SelectedValue.ToString();
            int character_id = 0;
            if(this.cbRoel.SelectedValue.ToString() != "")
            {
                character_id = int.Parse(this.cbRoel.SelectedValue.ToString());
            }
            if (password.Equals(confirm_password) == false)
            {
                MessageBox.Show("输入密码和确认密码不一致，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            User user = new User();
            user.Username = username;
            user.Password = password;
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
            Result result = this.userBLL.addUser(user);

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

            roleBLL = new RoleBLL();
            DataTable dt = this.roleBLL.getAllRole();

            if (dt != null && dt.Rows.Count > 0) {
                foreach(DataRow row in dt.Rows)
                {
                    this.cbRoel.Items.Add(new KeyValue(row["role_id"].ToString(), row["role_name"].ToString()));
                }
                this.cbRoel.DisplayMember = "value";
                this.cbRoel.ValueMember = "key";
            }



            this.tbUsername.Focus();
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
