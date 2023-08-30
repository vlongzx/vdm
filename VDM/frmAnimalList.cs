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
            InitAnimalList();

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
        private void InitAnimalList()
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
                int select_village = 0;
                if (this.cbTown.SelectedItem != null)
                {
                    KeyValue selectValue = (KeyValue)this.cbTown.SelectedItem;
                    if (selectValue.Key != "")
                    {
                        select_village = int.Parse(selectValue.Key);
                        List<KeyValue> list_village = orgBLL.getOrgByTown(select_village);
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


            this.condition = new Hashtable();

        }
    }
}
