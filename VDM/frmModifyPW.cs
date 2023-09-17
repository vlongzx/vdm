using com.vdm.bll;
using com.vdm.common;
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
    public partial class frmModifyPW : UIEditForm
    {
        public frmModifyPW()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldPassword = this.tbOldPassword.Text.Trim();
            string newPassword = this.tbNewPassword.Text.Trim();
            string confrimPassword = this.tbConfirmNewPassword.Text.Trim();
            UserBLL userBLL = new UserBLL();
            DataTable userdt = userBLL.Login(LoginInfo.CurrentUser.AccountName, oldPassword);
            if (userdt != null && userdt.Rows.Count > 0)
            {
                //密码加密
                string password = MD5Encrypt.MD5Encrypt32(newPassword);
                Result res = userBLL.editPassword(LoginInfo.CurrentUser.AccountName, password);

                if (res.Count == 1)
                {
                    ShowInfoDialog("设置新密码成功。");
                }
                else
                {
                    ShowInfoDialog("设置新密码失败。");
                }
            }
            else
            {
                ShowErrorDialog("输入的原密码不正确，请重新输入。");
            }
        }

        protected override bool CheckData()
        {
            return CheckEmpty(this.tbOldPassword, "请输入原密码。")
                && CheckEmpty(this.tbNewPassword, "请输入新密码。")
                && CheckEmpty(this.tbConfirmNewPassword, "请输入确认新密码。")
                && CheckEquals("新密码和确认新密码不一致，请重现输入。")
                ;
        }

        private bool CheckEquals(string message)
        {
            if (this.tbNewPassword.Text.Equals(this.tbConfirmNewPassword.Text) == false)
            {
                ShowErrorDialog(message);
                return false;
            }
            return true;
        }

        private void frmModifyPW_Load(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (Utils.IsPasswordValid(this.tbNewPassword.Text) == false)
            {
                ShowErrorDialog("密码必须至少有一个大写字母、一个小写字母、一个数字并且长度要大于8位。");
                this.tbNewPassword.Focus();
            }
        }
    }
}
