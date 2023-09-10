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
    public partial class frmSetFuncPower : UIEditForm
    {
        private FunctionBLL functionBLL = null;
        private RoleBLL roleBLL = null;
        private string role_id = "";
        public frmSetFuncPower()
        {
            InitializeComponent();
        }

        public frmSetFuncPower(string role_id)
        {
            InitializeComponent();
            this.role_id = role_id;
        }

        private void frmSetFuncPower_Load(object sender, EventArgs e)
        {
            //初始化数据字典树
            this.functionBLL = new FunctionBLL();
            DataTable dtFunc = this.functionBLL.getFunctionBypreFunctionID("0");
            this.tvFunc.Nodes.Clear();
            foreach (DataRow row in dtFunc.Rows)
            {
                this.tvFunc.Nodes.Add(row["function_id"].ToString(), row["function_name"].ToString());
                string  pre_function_id = row["function_id"].ToString();//以当前的function_id作为父ID进行查询
                InitFunctionTree(pre_function_id, this.tvFunc.Nodes[row["function_id"].ToString()]);
            }
            this.tvFunc.ExpandAll();//全部节点展开


            if (role_id != "")//表示编辑操作
            {
                this.roleBLL = new RoleBLL();
                Role role = this.roleBLL.getRole(role_id);
                this.tbRole_Name.Text = role.Role_name;

                DataTable dt = this.roleBLL.getRoleFuncPower(role_id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        TreeNode[] nodes = this.tvFunc.Nodes.Find(row["function_id"].ToString(), true);
                        if (nodes != null && nodes.Length > 0)
                        {
                            for (int i = 0; i < nodes.Length; i++)
                            {
                                nodes[i].Checked = true;
                            }
                        }
                    }
                }

            }
        }

        private void  InitFunctionTree(string pre_function_id,TreeNode node)
        {
            DataTable dtChildFunc = this.functionBLL.getFunctionBypreFunctionID(pre_function_id);
            if (dtChildFunc != null && dtChildFunc.Rows.Count > 0)
            {
                foreach (DataRow row_child in dtChildFunc.Rows)
                {
                    node.Nodes.Add(row_child["function_id"].ToString(), row_child["function_name"].ToString());
                    pre_function_id = row_child["function_id"].ToString();
                    InitFunctionTree(pre_function_id, node.Nodes[row_child["function_id"].ToString()]);
                }
            }
        }

        protected override bool CheckData()
        {
            return CheckEmpty(this.tbRole_Name,"角色名称不能为空。");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string role_name = this.tbRole_Name.Text.Trim();
            string role_type = "用户角色";
            

            Role role = new Role();
            
            role.Role_name = role_name;
            role.Role_type = role_type;
            role.Remark = "";

            List<string> listFunctPower = new List<string>();
            foreach (TreeNode node in this.tvFunc.Nodes)
            {
                if(node != null && (node.CheckState() == CheckState.Indeterminate || node.CheckState() == CheckState.Checked ))//选择状态为模糊和选中状态
                {
                    listFunctPower.Add(node.Name);
                    this.getChildNodeSelected(node, listFunctPower);
                }
            }

            this.roleBLL = new RoleBLL();
            Result result = null;
            if (this.role_id == "")
            {
                string id = Utils.GenerateStringID();
                role.Role_id = id;
                result = this.roleBLL.addRole(role, listFunctPower);
            }
            else
            {
                role.Role_id = this.role_id;
                result = this.roleBLL.editRole(role, listFunctPower);
            }


            if (result.Count == 1)
            {
                MessageBox.Show("设置成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.Error(result.Information, result.Exception);
            }
        }

        /// <summary>
        /// 递归获取被选择的功能
        /// </summary>
        /// <param name="node"></param>
        /// <param name="listFunctPower"></param>
        public void getChildNodeSelected(TreeNode node, List<string> listFunctPower)
        {
            foreach (TreeNode childnode in node.Nodes)
            {
                if (childnode != null && childnode.Checked == true)
                {
                    listFunctPower.Add(childnode.Name);

                    this.getChildNodeSelected(childnode, listFunctPower);
                }
            }
        }
    }
}
