using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
using com.vdm.model;
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
    public partial class frmAnimalList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private AnimalBLL animalBLL = null;
        private Hashtable condition = null;
        private int pageIndex = 1;
        private int pageSize = 20;

        

        public frmAnimalList()
        {
            InitializeComponent();
        }

        private void frmAnimalList_Load(object sender, EventArgs e)
        {
            InitAnimalList(null,pageIndex,pageSize);

            InitControls();
        }
        /// <summary>
        ///  初始化界面控件数据
        /// </summary>
        private void InitControls()
        {
            this.dictBLL = new DictBLL();

            //初始化养殖类型
            List<KeyValue> list_breed_type = dictBLL.getDict("breed_type");
            if (list_breed_type != null)
            {
                this.cbBreed_type.DataSource = list_breed_type;
                this.cbBreed_type.DisplayMember = "value";
                this.cbBreed_type.ValueMember = "key";
            }

            //年存栏（设计规模）
            List<KeyValue> list_year_inventory = dictBLL.getDict("year_inventory");
            if (list_year_inventory != null)
            {
                this.cbYear_inventory.DataSource = list_year_inventory;
                this.cbYear_inventory.DisplayMember = "value";
                this.cbYear_inventory.ValueMember = "key";
            }

            //年出栏（设计规模）
            List<KeyValue> list_year_outbound = dictBLL.getDict("year_outbound");
            if (list_year_outbound != null)
            {
                this.cbYear_outbound.DataSource = list_year_outbound;
                this.cbYear_outbound.DisplayMember = "value";
                this.cbYear_outbound.ValueMember = "key";
            }

            //动物防疫条件合格证
            List<KeyValue> list_animal_qualify = dictBLL.getDict("animal_qualify");
            if (list_animal_qualify != null)
            {
                this.cbAnimal_qualify.DataSource = list_animal_qualify;
                this.cbAnimal_qualify.DisplayMember = "value";
                this.cbAnimal_qualify.ValueMember = "key";
            }

            //固体污染源排污登记
            List<KeyValue> list_solid_pollution = dictBLL.getDict("solid_pollution");
            if (list_solid_pollution != null)
            {
                this.cbSolid_pollution.DataSource = list_solid_pollution;
                this.cbSolid_pollution.DisplayMember = "value";
                this.cbSolid_pollution.ValueMember = "key";
            }
            //环评保供
            List<KeyValue> list_report_or_filings = dictBLL.getDict("report_or_filings");
            if (list_solid_pollution != null)
            {
                this.cbReport_or_filings.DataSource = list_report_or_filings;
                this.cbReport_or_filings.DisplayMember = "value";
                this.cbReport_or_filings.ValueMember = "key";
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
        ///  初始化畜牧列表
        /// </summary>
        public void InitAnimalList(Hashtable condition, int pageIndex=1, int pageSize=20)
        {
            //初始化dgAnimal
            this.dgAnimalList.AutoGenerateColumns = false;
            this.dgAnimalList.RowTemplate.Height = 45;
            this.dgAnimalList.Columns.Clear();
            this.dgAnimalList.AddColumn("养殖场（户）ID", "breed_id");
            this.dgAnimalList.AddColumn("养殖场（户）名称", "breed_name");
            this.dgAnimalList.Columns[1].Frozen = true;//冻结前两列
            this.dgAnimalList.AddColumn("养殖种类", "breed_type");
            this.dgAnimalList.AddColumn("负责人", "manager");
            this.dgAnimalList.AddColumn("身份证号码", "idcard");
            this.dgAnimalList.AddColumn("联系地址", "address");
            this.dgAnimalList.AddColumn("联系电话", "phone_number");
            this.dgAnimalList.AddColumn("年存栏（设计规模）", "year_inventory");
            this.dgAnimalList.AddColumn("年出栏（设计规模）", "year_outbound");
            this.dgAnimalList.AddColumn("产值(万元)", "output");
            this.dgAnimalList.AddColumn("占地面积", "total_area");
            this.dgAnimalList.AddColumn("圈舍面积", "pen_area");
            this.dgAnimalList.AddColumn("堆粪场面积", "midden_area");
            this.dgAnimalList.AddColumn("集污池面积", "pullttion_area");
            this.dgAnimalList.AddColumn("现存栏", "cueernt_inventory");
            this.dgAnimalList.AddColumn("动物防疫条件合格证", "animal_qualify");
            this.dgAnimalList.AddColumn("固体污染源排污登记", "solid_pollution");
            this.dgAnimalList.AddColumn("环评报告或备案", "report_or_filings");
            this.dgAnimalList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgAnimalList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgAnimalList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            animalBLL = new AnimalBLL();
            DataTable dtAnimal = animalBLL.getAllAnimal(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.animalBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgAnimalList.DataSource = dtAnimal;
        }
        /// <summary>
        ///  乡镇选择改变事件
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
       ///  查询事件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            string town = this.cbTown.SelectedValue.ToString();
            string villiage = this.cbVillage.SelectedValue.ToString();
            string breed_name = this.tbBreed_name.Text.Trim();
            string breed_type = this.cbBreed_type.SelectedValue.ToString();
            string manager = this.tbManager.Text.Trim();
            string idcard = this.tbIdcard.Text.Trim();
            string address = this.tbAddress.Text.Trim();
            string phone_number = this.tbPhone_number.Text.Trim();
            int year_inventory = 0;
            if (this.cbYear_inventory.SelectedValue.ToString() != "")
            {
                year_inventory = int.Parse(this.cbYear_inventory.SelectedValue.ToString());
            }
            int year_outbound = 0;
            if (this.cbYear_outbound.SelectedValue.ToString() != "")
            {
                year_outbound = int.Parse(this.cbYear_outbound.SelectedValue.ToString());
            }
            float output_from = 0.00f;
            if(this.tbOutput_From.Text.Trim() != "")
            {
                output_from = float.Parse(this.tbOutput_From.Text.Trim());
            }
            
            float output_to = 0.00f;
            if (this.tbOutput_To.Text.Trim()!="")
            {
                output_to = float.Parse(this.tbOutput_To.Text.Trim());
            }
            float total_area_from = 0.00f;
            if (this.tbPen_area_From.Text.Trim()!="")
            {
                total_area_from = float.Parse(this.tbPen_area_From.Text.Trim());
            }
            float total_area_to = 0.00f;
            if (this.tbPen_area_To.Text.Trim()!="")
            {
                total_area_to = float.Parse(this.tbPen_area_To.Text.Trim());
            }
            float pen_area_from = 0.00f;
            if (this.tbPen_area_From.Text.Trim()!="")
            {
                pen_area_from = float.Parse(this.tbPen_area_From.Text.Trim());
            }
            float pen_area_to =0.00f;
            if (this.tbPen_area_To.Text.Trim()!="")
            {
                pen_area_to = float.Parse(this.tbPen_area_To.Text.Trim());
            }
            float midden_area_from = 0.00f;
            if (this.tbMidden_area_From.Text.Trim()!="")
            {
                midden_area_from = float.Parse(this.tbMidden_area_From.Text.Trim());
            }
            float midden_area_to =0.00f;
            if (this.tbMidden_area_To.Text.Trim()!="")
            {
                midden_area_to = float.Parse(this.tbMidden_area_To.Text.Trim());
            }
            float pullttion_area_from = 0.00f;
            if (this.tbPullttion_area_From.Text.Trim()!="")
            {
                pullttion_area_from = float.Parse(this.tbPullttion_area_From.Text.Trim());
            }
            float pullttion_area_to = 0.00f;
            if (this.tbPullttion_area_To.Text.Trim()!="")
            {
                pullttion_area_to = float.Parse(this.tbPullttion_area_To.Text.Trim());
            }
            int cueernt_inventory_from = 0;
            if (this.tbCueernt_inventory_From.Text.Trim()!="")
            {
                cueernt_inventory_from = int.Parse(this.tbCueernt_inventory_From.Text.Trim());
            }
            int cueernt_inventory_to = 0;
            if (this.tbCueernt_inventory_To.Text.Trim()!="")
            {
                cueernt_inventory_to = int.Parse(this.tbCueernt_inventory_To.Text.Trim());
            }
            string animal_qualify = this.cbAnimal_qualify.SelectedValue.ToString();
            string solid_pollution = this.cbSolid_pollution.SelectedValue.ToString();
            string report_or_filings = this.cbReport_or_filings.SelectedValue.ToString();
            //将查询条件添加到hashtable
            this.condition = new Hashtable();
            this.condition.Add("town", town);
            this.condition.Add("villiage", villiage);
            this.condition.Add("breed_name", breed_name);
            this.condition.Add("breed_type", breed_type);
            this.condition.Add("manager", manager);
            this.condition.Add("idcard", idcard);
            this.condition.Add("address", address);
            this.condition.Add("phone_number", phone_number);
            this.condition.Add("year_inventory", year_inventory);
            this.condition.Add("year_outbound", year_outbound);
            this.condition.Add("output_from", output_from);
            this.condition.Add("output_to", output_to);
            this.condition.Add("total_area_from", total_area_from);
            this.condition.Add("total_area_to", total_area_to);
            this.condition.Add("pen_area_from", pen_area_from);
            this.condition.Add("pen_area_to", pen_area_to);
            this.condition.Add("midden_area_from", midden_area_from);
            this.condition.Add("midden_area_to", midden_area_to);
            this.condition.Add("pullttion_area_from", pullttion_area_from);
            this.condition.Add("pullttion_area_to", pullttion_area_to);
            this.condition.Add("cueernt_inventory_from", cueernt_inventory_from);
            this.condition.Add("cueernt_inventory_to", cueernt_inventory_to);
            this.condition.Add("animal_qualify", animal_qualify);
            this.condition.Add("solid_pollution", solid_pollution);
            this.condition.Add("report_or_filings", report_or_filings);

            animalBLL = new AnimalBLL();
            DataTable dtAnimal = animalBLL.getAllAnimal(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.animalBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgAnimalList.DataSource = dtAnimal;
        }
        /// <summary>
        ///  新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmAnimalInfo animalInfo = new frmAnimalInfo();
            animalInfo.Render();
            animalInfo.ShowDialog();
            if (animalInfo.DialogResult == DialogResult.OK)
            {
                InitAnimalList(null, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        ///   编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgAnimalList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int breed_id = int.Parse(this.dgAnimalList.SelectedRows[0].Cells[0].Value.ToString());

            frmAnimalInfo animalInfo = new frmAnimalInfo(breed_id);
            animalInfo.ShowDialog();
            if (animalInfo.DialogResult == DialogResult.OK)
            {
                InitAnimalList(condition, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgAnimalList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int breed_id = int.Parse(this.dgAnimalList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.animalBLL = new AnimalBLL();
                Result result = this.animalBLL.delAnimal(breed_id);
                if (result.Count == 1)
                {
                    MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitAnimalList(condition, this.pageIndex, this.pageSize);
                }
                else
                {
                    MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
        /// <summary>
        ///  导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {

            frmImportExcelFile importExcelFile = new frmImportExcelFile();
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

        }
    }
}
