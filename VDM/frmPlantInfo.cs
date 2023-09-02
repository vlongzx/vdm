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
    public partial class frmPlantInfo : UIEditForm
    {
        private int plant_id;
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private PlantBLL plantBLL = null;
        public frmPlantInfo()
        {
            InitializeComponent();
        }

        public frmPlantInfo(int plant_id)
        {
            InitializeComponent();
            this.plant_id = plant_id;
        }
        /// <summary>
        ///  窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlantInfo_Load(object sender, EventArgs e)
        {
            InitControls();

            if(this.plant_id != 0)
            {
                this.plantBLL = new PlantBLL();
                Plant plant = this.plantBLL.getPlant(this.plant_id);
                if (plant != null)
                {
                    this.tbAddress.Text = plant.Address;
                    this.tbContact_person.Text = plant.Contact_person;
                    this.tbIdcard.Text = plant.Idcard;
                    this.tbOutput.Text = plant.Output.ToString();
                    this.tbPhone_number.Text = plant.Phone_number;
                    this.tbPlant_area.Text = plant.Plant_area.ToString();
                    this.tbQuestion.Text = plant.Question;
                    this.tbRemark.Text = plant.Remark;
                    this.tbYear_yield.Text = plant.Year_yield.ToString();
                    this.cbDevelop_willing.SelectedValue = plant.Develop_willing;
                    this.cbInsect_ill.SelectedValue = plant.Insect_ill;
                    this.cbIs_plan.SelectedValue = plant.Is_plan;
                    this.cbManage_skill_method.SelectedValue = plant.Manage_skill_method;
                    this.cbPlant_brand.SelectedValue = plant.Plant_brand;
                    this.cbPlant_type.SelectedValue = plant.Plant_type;
                    this.cbSale_way.SelectedValue = plant.Sale_way;
                    this.cbTown.SelectedValue = plant.Town;
                    this.cbVillage.SelectedValue = plant.Village;
                }
            }
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

            //初始化是否符合规划
            List<KeyValue> list_manage_skill_method = dictBLL.getDict("manage_skill_method");
            if (list_manage_skill_method != null)
            {
                this.cbManage_skill_method.DataSource = list_manage_skill_method;
                this.cbManage_skill_method.DisplayMember = "value";
                this.cbManage_skill_method.ValueMember = "key";
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
                this.cbPlant_type.DataSource = list_plant_type;
                this.cbPlant_type.DisplayMember = "value";
                this.cbPlant_type.ValueMember = "key";
            }

            //初始化销售途径
            List<KeyValue> list_sale_way = dictBLL.getDict("sale_way");
            if (list_sale_way != null)
            {
                this.cbSale_way.DataSource = list_sale_way;
                this.cbSale_way.DisplayMember = "value";
                this.cbSale_way.ValueMember = "key";
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
        ///  确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string town = this.cbTown.SelectedValue.ToString();
            string village = this.cbVillage.SelectedValue.ToString();
            double plant_area = 0;
            if (this.tbPlant_area.Text.Trim() != null)
            {
                plant_area = double.Parse(this.tbPlant_area.Text.Trim());
            }
            string plant_brand = this.cbPlant_brand.SelectedValue.ToString();
            string plant_type = this.cbPlant_type.SelectedValue.ToString();
            string contact_person = this.tbContact_person.Text.Trim();
            string idcard = this.tbIdcard.Text.Trim();
            string phone_number = this.tbPhone_number.Text.Trim();
            string address = this.tbAddress.Text.Trim();
            string is_plan = this.cbIs_plan.SelectedValue.ToString();
            double year_yield =  double.Parse(this.tbYear_yield.Text.Trim());
            string sale_way = this.cbSale_way.SelectedValue.ToString();
            double output = 0;
            if (this.tbOutput.Text.Trim()!= "")
            {
                output = double.Parse(this.tbOutput.Text.Trim());
            }
            string insect_ill = this.cbInsect_ill.SelectedValue.ToString();
            string manage_skill_method = this.cbManage_skill_method.SelectedValue.ToString();
            string develop_willing = this.cbDevelop_willing.SelectedValue.ToString();
            string question = this.tbQuestion.Text;
            string remark = this.tbRemark.Text;

            Plant plant = new Plant();
            plant.Address = address;
            plant.Contact_person = contact_person;
           
            plant.Develop_willing = develop_willing;
            plant.Idcard = idcard;
            plant.Insect_ill = insect_ill;
            plant.Is_plan = is_plan;
            plant.Manage_skill_method = manage_skill_method;
            plant.Output = output;
            plant.Phone_number = phone_number;
            plant.Plant_area = plant_area;
            plant.Plant_brand = plant_brand;
            plant.Plant_type = plant_type;
            plant.Question = question;
            plant.Remark = remark;
            plant.Sale_way = sale_way;
            plant.Town = town;
            plant.Village = village;
            plant.Year_yield = year_yield;

            plantBLL = new PlantBLL();

            if (this.plant_id == 0)//代表是新增
            {
                plant.Creater = LoginInfo.CurrentUser.AccountName;
                plant.Create_datetime = DateTime.Now.ToString();

                Result result = this.plantBLL.addPlant(plant);
                if (result.Count == 1)
                {
                    MessageBox.Show("保存成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
            else
            {
                plant.Last_updater = LoginInfo.CurrentUser.AccountName;
                plant.Last_update_datetime = DateTime.Now.ToString();
                plant.Plant_id = this.plant_id;
                Result result = plantBLL.editPlant(plant);
                if (result.Count == 1)
                {
                    MessageBox.Show("编辑成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }

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
    }
}
