using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
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
    public partial class frmPlantList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private PlantBLL plantBLL = null;
        private Hashtable condition = null;
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmPlantList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlantList_Load(object sender, EventArgs e)
        {
            InitPlantList(null, pageIndex, pageSize);

            InitControls();
        }

        public  void InitPlantList(Hashtable condition, int pageIndex=1, int pageSize=20)
        {
            //初始化dgAnimal
            this.dgPlantList.AutoGenerateColumns = false;
            this.dgPlantList.RowTemplate.Height = 45;
            this.dgPlantList.Columns.Clear();
            this.dgPlantList.AddColumn("种植ID", "plant_id");
            this.dgPlantList.AddColumn("种植类别", "plant_type");
            this.dgPlantList.AddColumn("联系人", "contact_person");
            this.dgPlantList.Columns[2].Frozen = true;//冻结前两列
            this.dgPlantList.AddColumn("所属镇", "town");
            this.dgPlantList.AddColumn("所属村", "village");
            this.dgPlantList.AddColumn("联系人身份证", "idcard");
            this.dgPlantList.AddColumn("联系电话", "phone_number");
            this.dgPlantList.AddColumn("详细地址", "address");
            this.dgPlantList.AddColumn("是否符合规划", "is_plan");
            this.dgPlantList.AddColumn("种植面积", "plant_area");
            this.dgPlantList.AddColumn("种植品种", "plant_brand");
            this.dgPlantList.AddColumn("年产量（斤）", "year_yield");
            this.dgPlantList.AddColumn("产值(万元)", "output");
            this.dgPlantList.AddColumn("销售途径", "sale_way");
            this.dgPlantList.AddColumn("主要虫病害", "insect_ill");
            this.dgPlantList.AddColumn("主要管理和技术措施", "manage_skill_method");
            this.dgPlantList.AddColumn("发展意愿", "develop_willing");
            this.dgPlantList.AddColumn("需要政府解决的问题", "question");
            this.dgPlantList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPlantList.AddColumn("添加人", "Creater");
            this.dgPlantList.AddColumn("备注", "remark");
            //自适应列宽，包括列名和列内容
            this.dgPlantList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            plantBLL = new PlantBLL();
            DataTable dtPlant = plantBLL.getAllPlant(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.plantBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgPlantList.DataSource = dtPlant;
        }
        /// <summary>
        ///  初始化页面控件
        /// </summary>
        private void InitControls()
        {
            this.dictBLL = new DictBLL();

            //初始化发展意愿
            List<KeyValue> list_develop_willing = dictBLL.getDict("develop_willing");
            if (list_develop_willing != null)
            {
                this.cbDevelop_willing.DataSource = list_develop_willing;
                this.cbDevelop_willing.DisplayMember = "value";
                this.cbDevelop_willing.ValueMember = "key";
            }

            //初始化主要虫病害
            List<KeyValue> list_insect_ill = dictBLL.getDict("insect_ill");
            if (list_insect_ill != null)
            {
                this.cbInsect_ill.DataSource = list_insect_ill;
                this.cbInsect_ill.DisplayMember = "value";
                this.cbInsect_ill.ValueMember = "key";
            }

            //初始化是否符合规划
            List<KeyValue> list_is_plan = dictBLL.getDict("is_plan");
            if (list_is_plan != null)
            {
                this.cbIs_plan.DataSource = list_is_plan;
                this.cbIs_plan.DisplayMember = "value";
                this.cbIs_plan.ValueMember = "key";
            }

            List<KeyValue> list_manage_skill_method = dictBLL.getDict("manage_skill_method");
            if (list_manage_skill_method != null)
            {
                foreach (KeyValue kv in list_manage_skill_method)
                {
                    if (kv.Key != "")
                    {
                        ctvManage_skill_method.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }


            //初始化种植品种
            List<KeyValue> list_plant_brand = dictBLL.getDict("plant_brand");
            if (list_plant_brand != null)
            {
                this.cbPlant_brand.DataSource = list_plant_brand;
                this.cbPlant_brand.DisplayMember = "value";
                this.cbPlant_brand.ValueMember = "key";
            }

            //初始化种植类别
            List<KeyValue> list_plant_type = dictBLL.getDict("plant_type");
            if (list_plant_type != null)
            {
                foreach (KeyValue kv in list_plant_type)
                {
                    if (kv.Key != "")
                    {
                        ctvPlant_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }

            //初始化销售途径
            List<KeyValue> list_sale_way = dictBLL.getDict("sale_way");
            if (list_sale_way != null)
            {
                foreach (KeyValue kv in list_sale_way)
                {
                    if (kv.Key != "")
                    {
                        ctvSale_way.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
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
        /// 乡镇选择事件
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
        /// <summary>
        ///  查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            string town = this.cbTown.SelectedValue.ToString();
            string village = this.cbVillage.SelectedValue.ToString();
            double plant_area = 0;
            if(this.tbPlant_area.Text.Trim() != "")
            {
                plant_area = double.Parse(this.tbPlant_area.Text.Trim());
            }
            string plant_brand = this.cbPlant_brand.SelectedValue.ToString();
            string plant_type = this.ctvPlant_type.Text.ToString();
            string contact_person = this.tbContact_person.Text.Trim();
            string idcard = this.tbIdcard.Text.Trim();
            string phone_number = this.tbPhone_number.Text.Trim();
            string address = this.tbAddress.Text.Trim();
            string is_plan = this.cbIs_plan.SelectedValue.ToString();
            double year_yield_from = 0;
            if(this.tbYear_yield_from.Text.Trim() != "")
            {
                year_yield_from = double.Parse(this.tbYear_yield_from.Text.Trim());
            }
            double year_yield_to = 0;
            if (this.tbYear_yield_to.Text.Trim() != "")
            {
                year_yield_to = double.Parse(this.tbYear_yield_to.Text.Trim());
            }
            string sale_way = this.ctvSale_way.Text.ToString();
            double output = 0;
            if(this.tbOutput.Text.Trim() != "")
            {
                output = double.Parse(this.tbOutput.Text.Trim());
            }
            string insect_ill = this.cbInsect_ill.SelectedValue.ToString();
            string manage_skill_method = this.ctvManage_skill_method.Text.ToString();
            string develop_willing = this.cbDevelop_willing.SelectedValue.ToString();

            Hashtable condition = new Hashtable();
            condition.Add("town", town);
            condition.Add("village ", village);
            condition.Add("plant_area", plant_area);
            condition.Add("plant_brand", plant_brand);
            condition.Add("plant_type", plant_type);
            condition.Add("contact_person", contact_person);
            condition.Add("phone_number", phone_number);
            condition.Add("address", address);
            condition.Add("is_plan", is_plan);
            condition.Add("year_yield_from", year_yield_from);
            condition.Add("year_yield_to", year_yield_to);
            condition.Add("sale_way", sale_way);
            condition.Add("output", output);
            condition.Add("insect_ill", insect_ill);
            condition.Add("manage_skill_method", manage_skill_method);
            condition.Add("develop_willing", develop_willing);

            this.plantBLL = new PlantBLL();
            DataTable dtPlant = this.plantBLL.getAllPlant(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.plantBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgPlantList.DataSource = dtPlant;
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            this.tbAddress.Text = "";
            this.tbContact_person.Text = "";
            this.tbIdcard.Text = "";
            this.tbPhone_number.Text = "";
            this.tbPlant_area.Text = "";
            this.tbYear_yield_from.Text = "";
            this.tbYear_yield_to.Text = "";
            this.cbDevelop_willing.SelectedValue = "";
            this.cbInsect_ill.SelectedValue = "";
            this.cbIs_plan.SelectedValue = "";
            this.ctvManage_skill_method.Text = "";
            this.tbOutput.Text = "";
            this.cbPlant_brand.SelectedValue = "";
            this.ctvPlant_type.Text = "";
            this.ctvSale_way.Text = "";
            this.cbTown.SelectedValue = "";
            this.cbVillage.SelectedValue = "";
            
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmPlantInfo tourInfo = new frmPlantInfo();
            tourInfo.Text = "新增种植信息";
            tourInfo.Render();
            tourInfo.ShowDialog();
            if (tourInfo.DialogResult == DialogResult.OK)
            {
                InitPlantList(null, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgPlantList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int plant_id = int.Parse(this.dgPlantList.SelectedRows[0].Cells[0].Value.ToString());

            frmPlantInfo plantInfo = new frmPlantInfo(plant_id);
            plantInfo.Text = "编辑种植信息";
            plantInfo.ShowDialog();
            if (plantInfo.DialogResult == DialogResult.OK)
            {
                InitPlantList(condition, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgPlantList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int plant_id = int.Parse(this.dgPlantList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.plantBLL = new PlantBLL();
                Result result = this.plantBLL.delPlant(plant_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitPlantList(condition, this.pageIndex, this.pageSize);
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            frmImportExcelFile importExcelFile = new frmImportExcelFile(Data_Object_Const.PLANT);
            importExcelFile.Owner = this;
            importExcelFile.ShowDialog();
        }
        /// <summary>
        ///  导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExport_Click(object sender, EventArgs e)
        {
            DataTable dt = this.plantBLL.getAllPlant(this.condition);
            ExcelUtil excelUtil = new ExcelUtil(this.dgPlantList, dt);
            frmExportExcel ef = new frmExportExcel(excelUtil, Data_Object_Const.PLANT);
            ef.ShowDialog();
        }
    }
}
