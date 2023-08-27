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
            int town_id = int.Parse(this.cbTown.SelectedValue.ToString());
            int village_id = 0;
            if(this.cbVillage.SelectedValue.ToString() != ""){
                village_id = int.Parse(this.cbVillage.SelectedValue.ToString());
            }
            if(password.Equals(confirm_password) == false)
            {
                MessageBox.Show("输入密码和确认密码不一致，请重新输入。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Town_id = town_id;
            user.Village_id = village_id;
            user.Remark = remark;
            if(village_id == 0)
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
            OrgBLL orgBLL = new OrgBLL();
            List<KeyValue> list_town = orgBLL.getOrgByType("乡镇");
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            int select_village = int.Parse(this.cbTown.SelectedValue.ToString());
            List<KeyValue> list_village = orgBLL.getOrgByTown(select_village);
            if (list_village != null)
            {
                this.cbVillage.DataSource = list_village;
                this.cbVillage.DisplayMember = "value";
                this.cbVillage.ValueMember = "key";
            }
            this.tbUsername.Focus();
        }

        private void cbTown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbTown.SelectedValue != null)
            {
                OrgBLL orgBLL = new OrgBLL();
                int select_village = 0;
                if (this.cbTown.SelectedItem != null)
                {
                    KeyValue selectValue = (KeyValue)this.cbTown.SelectedItem;
                    select_village = int.Parse(selectValue.Key);
                }
                List<KeyValue> list_village = orgBLL.getOrgByTown(select_village);
                if (list_village != null)
                {
                    this.cbVillage.DataSource = list_village;
                    this.cbVillage.DisplayMember = "value";
                    this.cbVillage.ValueMember = "key";
                }
            }
        }
    }
}
