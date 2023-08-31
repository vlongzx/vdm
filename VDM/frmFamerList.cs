﻿using com.vdm.bll;
using com.vdm.common;
using Sunny.UI;
using System;
using System.Collections;
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
    public partial class frmFamerList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private FamerBLL famerBLL = null;

        private Hashtable condition = null;
        //高级查询条件
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmFamerList()
        {
            InitializeComponent();
        }

        private void frmFamerList_Load(object sender, EventArgs e)
        {
            InitControlData();

            InitListView(null, this.pageIndex, this.pageSize);
        }

        /// <summary>
        /// 初始化基本查询条件
        /// </summary>
        public void InitControlData()
        {
            dictBLL = new DictBLL();

            //初始化种植作物种类
            List<KeyValue> list_plant_type = dictBLL.getDict("plant_type_famer");
            if (list_plant_type != null)
            {
                this.cbPlant_type.DataSource = list_plant_type;
                this.cbPlant_type.DisplayMember = "value";
                this.cbPlant_type.ValueMember = "key";
            }
            //初始化占地地类
            List<KeyValue> list_plant_area_type = dictBLL.getDict("plant_area_type");
            if (list_plant_area_type != null)
            {
                this.cbPlant_area_type.DataSource = list_plant_area_type;
                this.cbPlant_area_type.DisplayMember = "value";
                this.cbPlant_area_type.ValueMember = "key";
            }
            //初始化是否办理设施农用地手续
            List<KeyValue> list_is_handle_process = dictBLL.getDict("is_handle_process");
            if (list_is_handle_process != null)
            {
                this.cbIs_handle_process.DataSource = list_is_handle_process;
                this.cbIs_handle_process.DisplayMember = "value";
                this.cbIs_handle_process.ValueMember = "key";
            }

            //初始化政治面貌
            List<KeyValue> list_animal_type = dictBLL.getDict("animal_type_famer");
            if (list_animal_type != null)
            {
                this.cbAnimal_type.DataSource = list_animal_type;
                this.cbAnimal_type.DisplayMember = "value";
                this.cbAnimal_type.ValueMember = "key";
            }
            //初始化养殖占地地类
            List<KeyValue> list_animal_area_type = dictBLL.getDict("animal_area_type");
            if (list_animal_area_type != null)
            {
                this.cbAnimal_area_type.DataSource = list_animal_area_type;
                this.cbAnimal_area_type.DisplayMember = "value";
                this.cbAnimal_area_type.ValueMember = "key";
            }

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
        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView(Hashtable condition, int pageIndex, int pageSize)
        {
            this.dgFamerList.AutoGenerateColumns = false;
            this.dgFamerList.RowTemplate.Height = 45;
            this.dgFamerList.Columns.Clear();
            this.dgFamerList.AddColumn("编号", "Famer_id");
            this.dgFamerList.AddColumn("户主姓名", "Holder_name");
            this.dgFamerList.Columns[1].Frozen = true;//冻结前两列
            this.dgFamerList.AddColumn("身份证号", "Idcard");
            this.dgFamerList.AddColumn("联系电话", "Phone_number");
            this.dgFamerList.AddColumn("家用车辆-品牌", "Car_brand");
            this.dgFamerList.AddColumn("农用机械类型", "mechine_type");
            this.dgFamerList.AddColumn("种植作物种类", "plant_type");
            this.dgFamerList.AddColumn("占地面积(亩)", "plant_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("种植占地地类", "plant_area_type");
            this.dgFamerList.AddColumn("是否办理设施农用地手续", "is_handle_process");
            this.dgFamerList.AddColumn("种植产量(斤)", "plant_yield").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("种植产值(元)", "plant_output").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("养殖动物类型", "animal_type");
            this.dgFamerList.AddColumn("养殖地面积(亩)", "animal_area").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("养殖数量(头)", "animal_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("养殖占地地类", "animal_area_type");
            this.dgFamerList.AddColumn("已接种疫苗的动物数量(头/只)", "animal_vaccinate_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("未接种疫苗的动物数量(头/只)", "animal_nvaccinate_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("存栏数量(头/只)", "inventory_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("出栏数量(头/只)", "outbound_count").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("养殖产出产量(头/只)", "animal_yield").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("养殖产出产值(元)", "animal_output").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("所属镇", "Town");
            this.dgFamerList.AddColumn("所属村", "Villiage");
            this.dgFamerList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgFamerList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgFamerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            famerBLL = new FamerBLL();
            //初始化加载数据
            DataTable dt_people = this.famerBLL.getAllFamerDataTable(condition, pageIndex, pageSize);
            int totalCount = this.famerBLL.getTotalFamerCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgFamerList.DataSource = dt_people;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void btExport_Click(object sender, EventArgs e)
        {

        }

        private void btAdanceSearch_Click(object sender, EventArgs e)
        {
            Form formAdvanceQuery = new frmFamerAdvanceQuery(this);
            formAdvanceQuery.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formFamerAdd = new frmFamerInfo();
            formFamerAdd.ShowDialog();
            if (formFamerAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgFamerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int famer_id = int.Parse(this.dgFamerList.SelectedRows[0].Cells[0].Value.ToString());

            Form formFamerEdit = new frmFamerInfo("EDIT", famer_id);
            formFamerEdit.ShowDialog();
            if (formFamerEdit.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }


        /// <summary>
        /// 乡镇选择发生改变触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgFamerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int famer_id = int.Parse(this.dgFamerList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.famerBLL = new FamerBLL();
                Result result = this.famerBLL.DelFamer(famer_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitListView(condition, this.pageIndex, this.pageSize);
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
