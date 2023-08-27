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
            this.dgUser.RowTemplate.Height = 45;
            this.dgUser.AddColumn("用户ID", "user_id").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgUser.AddColumn("用户名", "username");
            this.dgUser.AddColumn("账号级别", "level");
            this.dgUser.AddColumn("所在乡镇", "town_name").SetFixedMode(150);
            this.dgUser.AddColumn("所在村", "village_name").SetFixedMode(150);
            this.dgUser.AddColumn("备注", "remark").SetFixedMode(300);

            this.dgUser.DataSource = dt;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
