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
    public partial class frmSystemSet : UIPage
    {
        private OrgBLL orgBLL = null;
        private UserBLL userBLL = null;
        public frmSystemSet()
        {
            InitializeComponent();
            
            //初始化组织树
            this.orgBLL = new OrgBLL();
            List<KeyValue> listTown = this.orgBLL.getOrgByType("乡镇");
            if(listTown != null)
            {
                foreach(KeyValue town in listTown)
                {
                    this.tvOrg.Nodes.Add(town.Key, town.Value);
                    List<KeyValue> listVillage = this.orgBLL.getOrgByTown(int.Parse(town.Key));
                    if(listVillage != null)
                    {
                        foreach (KeyValue village in listVillage)
                        {
                            this.tvOrg.Nodes[town.Key].Nodes.Add(village.Key, village.Value);
                        }
                    }
                }
            }

            //初始化用户列表
            this.userBLL = new UserBLL();
            DataTable dt = this.userBLL.getAllUser();
            this.dgUser.AutoGenerateColumns = false;
            this.dgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUser.RowTemplate.Height = 45;
            this.dgUser.AddColumn("用户ID", "user_id");
            this.dgUser.AddColumn("用户名", "username");
            this.dgUser.AddColumn("账号级别", "level");
            this.dgUser.AddColumn("所在乡镇", "town_name").SetFixedMode(150);
            this.dgUser.AddColumn("所在村", "village_name").SetFixedMode(150);
            this.dgUser.AddColumn("备注", "remark").SetFixedMode(300);
            this.Pagination.PageSize = 20;
            this.Pagination.TotalCount = dt.Rows.Count;
            this.dgUser.DataSource = dt;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmUserinfo userInfo = new frmUserinfo();
            userInfo.Text = "添加新用户";
            userInfo.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int user_id = int.Parse(this.dgUser.SelectedRows[0].Cells[0].Value.ToString());
            frmUserinfo userInfo = new frmUserinfo(user_id);
            userInfo.Text = "编辑用户信息";
            userInfo.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int user_id = int.Parse(this.dgUser.SelectedRows[0].Cells[0].Value.ToString());

            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.userBLL = new UserBLL();
                Result result = this.userBLL.delUser(user_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
    }
}
