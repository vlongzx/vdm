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
        private RoleBLL roleBLL = null;
        private FunctionBLL functionBLL = null;
        public DataAuthBLL dataAuthBLL = null;
        public frmSystemSet()
        {
            InitializeComponent();
            
            //初始化组织树
            this.orgBLL = new OrgBLL();
            List<KeyValue> listTown = this.orgBLL.getOrgByType("乡镇");
            if(listTown != null)
            {
                this.tvOrg.Nodes.Clear();
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
            this.tvOrg.ExpandAll();//全部节点展开

            //初始化功能权限树
           
            functionBLL = new FunctionBLL();
            DataTable dtFunction = this.functionBLL.getAllFunction();
            if (dtFunction != null)
            {
                this.tvFunction.Nodes.Clear();
                this.tvFunction.Nodes.Add("0", "功能权限树");
                foreach (DataRow row in dtFunction.Rows)
                {
                    string pre_function_id = row["pre_function_id"].ToString();
                    if(pre_function_id == "0")
                    {
                        this.tvFunction.Nodes[0].Nodes.Add(row["function_id"].ToString(), row["function_name"].ToString());
                    }
                    else
                    {
                        TreeNode[] nodes =  this.tvFunction.Nodes.Find(pre_function_id, true);
                        if(nodes != null && nodes.Length > 0)
                        {
                            foreach(TreeNode node in nodes)
                            {
                                node.Nodes.Add(row["function_id"].ToString(), row["function_name"].ToString());
                            }
                        }
                    }
                }
            }
            this.tvFunction.ShowLines = true;//显示结构线条
            this.tvFunction.ExpandAll(); //全部节点展开



            InitPage();
        }




        public void InitPage()
        {
            //初始化用户列表
            this.userBLL = new UserBLL();
            DataTable dtUser = this.userBLL.getAllUser();
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
            this.Pagination.TotalCount = dtUser.Rows.Count;
            this.dgUser.DataSource = dtUser;

            //初始化角色列表
            this.roleBLL = new RoleBLL();
            DataTable dtRole = this.roleBLL.getAllRole();
            this.dgRole.AutoGenerateColumns = false;
            this.dgRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRole.RowTemplate.Height = 45;
            this.dgRole.AddColumn("角色ID", "role_id");
            this.dgRole.AddColumn("角色名称", "role_name");
            this.dgRole.AddColumn("角色类型", "role_type");
            this.dgRole.AddColumn("备注", "remark").SetFixedMode(300);
            if(dtRole != null)
            {
                this.Pagination.PageSize = 20;
                this.Pagination.TotalCount = dtRole.Rows.Count;
                this.dgRole.DataSource = dtRole;
            }


            //初始化功能权限列表
            this.functionBLL = new FunctionBLL();
            this.dgFunction.AutoGenerateColumns = false;
            this.dgFunction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFunction.RowTemplate.Height = 45;
            this.dgFunction.AddColumn("功能权限ID", "function_id");
            this.dgFunction.AddColumn("父功能权限ID", "pre_function_id");
            this.dgFunction.AddColumn("功能权限编码", "function_code");
            this.dgFunction.AddColumn("功能权限名称", "function_name");
            this.dgFunction.AddColumn("备注", "remark");
            DataTable dtFunction = this.functionBLL.getAllFunction();
            if (dtFunction != null)
            {
                this.dgFunction.DataSource = dtFunction;
            }

            //初始化所有的数据权限
            this.dataAuthBLL = new DataAuthBLL();
            this.dgDataAuth.AutoGenerateColumns = false;
            this.dgDataAuth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDataAuth.RowTemplate.Height = 45;
            this.dgDataAuth.AddColumn("数据权限ID", "data_authority_id");
            this.dgDataAuth.AddColumn("数据权限类型", "data_authority_type");
            this.dgDataAuth.AddColumn("数据权限标识", "data_authority_name");
            this.dgDataAuth.AddColumn("数据权限描述", "data_authority_desc");
            DataTable dtDataAuth = this.dataAuthBLL.getAllDataAuth();
            if (dtDataAuth != null)
            {
                this.dgDataAuth.DataSource = dtDataAuth;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmUserinfo userInfo = new frmUserinfo();
            userInfo.Text = "添加新用户";
            userInfo.ShowDialog();
            if (userInfo.DialogResult == DialogResult.OK)
            {
                InitPage();
            }
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
                    InitPage();
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        ///  功能权限树选择后处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvFunction_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.tvFunction.SelectedNode;
            if(node != null)
            {
                long pre_function_id = long.Parse(node.Name.ToString());
                DataTable dtFunction = this.functionBLL.getFunctionBypreFunctionID(pre_function_id);
                if (dtFunction != null)
                {
                    this.Pagination.PageSize = 20;
                    this.Pagination.TotalCount = dtFunction.Rows.Count;
                    this.dgFunction.DataSource = dtFunction;
                }
            }
        }
    }
}
