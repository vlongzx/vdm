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
    public partial class frmSystemSet : UIPage
    {
        private OrgBLL orgBLL = null;
        private UserBLL userBLL = null;
        private RoleBLL roleBLL = null;
        private FunctionBLL functionBLL = null;
        public DataAuthBLL dataAuthBLL = null;
        private DictBLL dictBLL = null;
        private string dict_code = null;
        private string dict_name = null;
        private const string MESSAGE = "您还没有权限操作该功能。请联系管理员开通。";
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
                    string pre_org_id = this.orgBLL.getOrgIdByOrgCode(town.Key);
                    List<KeyValue> listVillage = this.orgBLL.getOrgByTown(pre_org_id);
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


            InitOrgTree();


            InitUserList();
            InitRoleList();
            InitFunctionList();

            //this.tabPage5.Hide();
            //InitDataAuthList();

            InitDictList();
        }

        public void InitOrgTree()
        {
            //初始化数据字典树
            this.dictBLL = new DictBLL();
            DataTable dtDict = this.dictBLL.getDistinctDict();
            this.tvDict.Nodes.Clear();
            this.tvDict.Nodes.Add("0", "所有字典项");
            if (dtDict != null)
            {
                foreach (DataRow row in dtDict.Rows)
                {
                    this.tvDict.Nodes[0].Nodes.Add(row["dict_code"].ToString(), row["dict_name"].ToString());
                }
            }
            this.tvDict.ShowLines = true;//显示结构线条
            this.tvDict.ExpandAll(); //全部节点展开
        }


        public void InitUserList()
        {
            //初始化用户列表
            this.userBLL = new UserBLL();
            DataTable dtUser = this.userBLL.getAllUser();
            this.dgUser.AutoGenerateColumns = false;
            this.dgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUser.RowTemplate.Height = 45;
            this.dgUser.Columns.Clear();
            this.dgUser.AddColumn("用户ID", "user_id");
            this.dgUser.AddColumn("用户名", "username");
            this.dgUser.AddColumn("账号级别", "level");
            this.dgUser.AddColumn("角色", "role_name");
            this.dgUser.AddColumn("所在乡镇", "town").SetFixedMode(150);
            this.dgUser.AddColumn("所在村", "village").SetFixedMode(150);
            this.dgUser.AddColumn("备注", "remark").SetFixedMode(300);
            this.Pagination.PageSize = 20;
            this.Pagination.TotalCount = dtUser.Rows.Count;
            this.dgUser.DataSource = dtUser;
        }
        public void InitRoleList()
        {
            //初始化角色列表
            this.roleBLL = new RoleBLL();
            DataTable dtRole = this.roleBLL.getAllRole();
            this.dgRole.AutoGenerateColumns = false;
            this.dgRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRole.RowTemplate.Height = 45;
            this.dgRole.Columns.Clear();
            this.dgRole.AddColumn("角色ID", "role_id");
            this.dgRole.AddColumn("角色名称", "role_name");
            this.dgRole.AddColumn("角色类型", "role_type");
            this.dgRole.AddColumn("备注", "remark").SetFixedMode(300);
            if (dtRole != null)
            {
                this.Pagination.PageSize = 20;
                this.Pagination.TotalCount = dtRole.Rows.Count;
                this.dgRole.DataSource = dtRole;
            }

        }
        public void InitFunctionList()
        {
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
        }
        public void InitDataAuthList()
        {
            //初始化所有的数据权限
            //this.dataAuthBLL = new DataAuthBLL();
            //this.dgDataAuth.AutoGenerateColumns = false;
            //this.dgDataAuth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //this.dgDataAuth.RowTemplate.Height = 45;
            //this.dgDataAuth.AddColumn("数据权限ID", "data_authority_id");
            //this.dgDataAuth.AddColumn("数据权限类型", "data_authority_type");
            //this.dgDataAuth.AddColumn("数据权限标识", "data_authority_name");
            //this.dgDataAuth.AddColumn("数据权限描述", "data_authority_desc");
            //DataTable dtDataAuth = this.dataAuthBLL.getAllDataAuth();
            //if (dtDataAuth != null)
            //{
            //    this.dgDataAuth.DataSource = dtDataAuth;
            //}
        }
        public void InitDictList()
        {
            //初始化字典项列表
            this.dictBLL = new DictBLL();
            this.dgDict.AutoGenerateColumns = false;
            this.dgDict.Columns.Clear();
            this.dgDict.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDict.RowTemplate.Height = 45;
            this.dgDict.AddColumn("ID", "id");
            this.dgDict.AddColumn("字典项标识", "dict_code");
            this.dgDict.AddColumn("字典项名称", "dict_name");
            this.dgDict.AddColumn("键", "datakey");
            this.dgDict.AddColumn("值", "datavalue");
            this.dgDict.AddColumn("顺序", "dataindex");
            DataTable dtDict = this.dictBLL.getAllDict();
            if (dtDict != null)
            {
                this.dgDict.DataSource = dtDict;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmUserinfo userInfo = new frmUserinfo();
            userInfo.Text = "添加新用户";
            userInfo.ShowDialog();
            if (userInfo.DialogResult == DialogResult.OK)
            {
                InitUserList();
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
            string username = this.dgUser.SelectedRows[0].Cells[1].Value.ToString();
            if (username == "admin")
            {
                MessageBox.Show("系统管理员不允许编辑。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int user_id = int.Parse(this.dgUser.SelectedRows[0].Cells[0].Value.ToString());
            frmUserinfo userInfo = new frmUserinfo(user_id);
            userInfo.Text = "编辑用户信息";
            userInfo.ShowDialog();
            if (userInfo.DialogResult == DialogResult.OK)
            {
                InitUserList();
            }
        
    }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断删除的是不是系统管理员
            string username = this.dgUser.SelectedRows[0].Cells[1].Value.ToString();
            if(username == "admin")
            {
                MessageBox.Show("系统管理员不允许删除。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    InitUserList();
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
                string pre_function_id = node.Name.ToString();
                DataTable dtFunction = this.functionBLL.getFunctionBypreFunctionID(pre_function_id);
                if (dtFunction != null)
                {
                    this.dgFunction.DataSource = dtFunction;
                }
            }
        }

        private void tvDict_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.tvDict.SelectedNode;
            if (node != null)
            {
                dict_code = node.Name.ToString();
                DataTable dtDict = this.dictBLL.getDictByCode(dict_code);
                if (dtDict != null)
                {
                    this.dgDict.DataSource = dtDict;
                }
            }
        }
        /// <summary>
        ///  新增字典项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddDict_Click(object sender, EventArgs e)
        {

            TreeNode node = this.tvDict.SelectedNode;
            if (node != null)
            {
                dict_code = node.Name;
                dict_name = node.Text;
            }
            else
            {
                ShowWarningDialog("请选择字典项。");
                return;
            }
            frmDictInfo dictInfo = new frmDictInfo(dict_code, dict_name);
            dictInfo.Render();
            DialogResult  result = dictInfo.ShowDialog();
            if(result == DialogResult.OK)
            {
                
                if(dict_code == "0")
                {
                    InitOrgTree();
                    InitDictList();
                }
                else
                {
                    DataTable dtDict = this.dictBLL.getDictByCode(dict_code);
                    if (dtDict != null)
                    {
                        this.dgDict.DataSource = dtDict;
                    }
                }
            }
        }
        /// <summary>
        ///  编辑字典项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditDict_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgDict.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(this.dgDict.SelectedRows[0].Cells[0].Value.ToString());
            frmDictInfo dictInfo = new frmDictInfo(id);
            dictInfo.Render();
            DialogResult result = dictInfo.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataTable dtDict = null;
                if(dict_code == null)
                {
                    dtDict = this.dictBLL.getAllDict();
                }
                else
                {
                    dtDict = this.dictBLL.getDictByCode(dict_code);
                }
                if (dtDict != null)
                {
                    this.dgDict.DataSource = dtDict;
                }
            }
        }

        private void btDelDict_Click(object sender, EventArgs e)
        {
            if (this.dgDict.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(this.dgDict.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.dictBLL = new DictBLL();
                Result result = this.dictBLL.DelDict(id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtDict = null;
                    if (dict_code == null)
                    {
                        dtDict = this.dictBLL.getAllDict();
                    }
                    else
                    {
                        dtDict = this.dictBLL.getDictByCode(dict_code);
                    }
                    if (dtDict != null)
                    {
                        this.dgDict.DataSource = dtDict;
                    }
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
        /// <summary>
        ///  设置数据权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDataPower_Click(object sender, EventArgs e)
        {
            if (this.dgDict.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要设置的用户。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(this.dgDict.SelectedRows[0].Cells[0].Value.ToString());
 
            frmSetDataPower setDataPower = new frmSetDataPower(id);
            DialogResult result = setDataPower.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataTable dtDict = null;
                if (dict_code == null)
                {
                    dtDict = this.dictBLL.getAllDict();
                }
                else
                {
                    dtDict = this.dictBLL.getDictByCode(dict_code);
                }
                if (dtDict != null)
                {
                    this.dgDict.DataSource = dtDict;
                }
            }

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (this.dgRole.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要设置的角色。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string  role_id = this.dgRole.SelectedRows[0].Cells[0].Value.ToString();
            string role_type = this.dgRole.SelectedRows[0].Cells[2].Value.ToString();
            if (role_type == "系统角色")
            {
                MessageBox.Show("系统角色不允许设置权限。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmSetFuncPower setDataPower = new frmSetFuncPower(role_id);
            DialogResult result = setDataPower.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("功能权限设置成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAddRole_Click(object sender, EventArgs e)
        {
            frmSetFuncPower setFuncPower = new frmSetFuncPower();
            setFuncPower.ShowDialog();
            if (setFuncPower.DialogResult == DialogResult.OK)
            {
                InitRoleList();
            }
        }

        private void btEditRole_Click(object sender, EventArgs e)
        {
            if (this.dgRole.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要设置的角色。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string role_id = this.dgRole.SelectedRows[0].Cells[0].Value.ToString();
            string role_type = this.dgRole.SelectedRows[0].Cells[2].Value.ToString();
            if (role_type == "系统角色")
            {
                MessageBox.Show("系统角色不允许设置权限。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmSetFuncPower setDataPower = new frmSetFuncPower(role_id);
            DialogResult result = setDataPower.ShowDialog();
           
        }

        private void btDelRole_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgRole.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string role_id = this.dgRole.SelectedRows[0].Cells[0].Value.ToString();

            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.roleBLL = new RoleBLL();
                Result result = this.roleBLL.delRole(role_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitUserList();
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.uiTabControl1.SelectedTab.Text == "数据字典")
            {
                if (LoginInfo.FuncPowerList.Contains("12000") == false)
                {
                    ShowInfoDialog(MESSAGE);
                    return;
                }

            }
            if (this.uiTabControl1.SelectedTab.Text == "用户管理")
            {
                if (LoginInfo.FuncPowerList.Contains("13000") == false)
                {
                    ShowInfoDialog(MESSAGE);
                    return;
                }
            }
            if (this.uiTabControl1.SelectedTab.Text == "角色管理")
            {
                if (LoginInfo.FuncPowerList.Contains("13000") == false)
                {
                    ShowInfoDialog(MESSAGE);
                    return;
                }
            }
            if (this.uiTabControl1.SelectedTab.Text == "功能权限")
            {
                if (LoginInfo.FuncPowerList.Contains("14000") == false)
                {
                    ShowInfoDialog(MESSAGE);
                    return;
                }
            }
        }
    }
}
