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
    public partial class frmFamerInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private FamerBLL famerBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int famer_id = 0;
        public frmFamerInfo()
        {
            InitializeComponent();
        }
        public frmFamerInfo(string opreation_mode, int famer_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.famer_id = famer_id;
        }
        private void frmFamerAdd_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                famerBLL = new FamerBLL();
                Famer famer = this.famerBLL.getFamer(this.famer_id);
                //界面数据绑定
                this.tbHolder_name.Text = famer.Holder_name;
                tbIdcard.Text = famer.Idcard;
                tbPhone_number.Text = famer.Phone_number;
                tbCar_brand.Text = famer.Car_brand;
                tbMechine_type.Text = famer.Mechine_type;
                ctvPlant_type.Text = famer.Plant_type;

                tbPlant_area.Text = famer.Plant_area.ToString();
                tbPlant_yield.Text = famer.Plant_yield.ToString();
                tbPlant_output.Text = famer.Plant_output.ToString();

                ctvPlant_area_type.Text = famer.Plant_area_type;
                cbIs_handle_process.SelectedValue = famer.Is_handle_process;
                ctvAnimal_type.Text = famer.Animal_type;

                tbAnimal_area.Text = famer.Animal_area.ToString();
                tbAnimal_count.Text = famer.Animal_count.ToString();
                tbAnimal_vaccinate_count.Text = famer.Animal_vaccinate_count.ToString();
                tbAnimal_nvaccinate_count.Text = famer.Animal_nvaccinate_count.ToString();
                tbInventory_count.Text = famer.Inventory_count.ToString();
                tbOutbound_count.Text = famer.Outbound_count.ToString();
                tbAnimal_yield.Text = famer.Animal_yield.ToString();
                tbAnimal_output.Text = famer.Animal_output.ToString();

                ctvAnimal_area_type.Text = famer.Animal_area_type;
                cbIs_handle_process.SelectedValue = famer.Is_handle_process;
                this.cbTown.SelectedValue = famer.Town;
                this.cbVillage.SelectedValue = famer.Villiage;

            }
        }
        /// <summary>
        ///  初始化界面控件的值
        /// </summary>
        private void InitPageControl()
        {
            tbAnimal_area.Enabled = false;
            tbAnimal_count.Enabled = false;
            ctvAnimal_area_type.Enabled = false;
            tbAnimal_vaccinate_count.Enabled = false;
            tbAnimal_nvaccinate_count.Enabled = false;
            tbInventory_count.Enabled = false;
            tbOutbound_count.Enabled = false;
            tbAnimal_yield.Enabled = false;
            tbAnimal_output.Enabled = false;
            tbPlant_area.Enabled = false;
            ctvPlant_area_type.Enabled = false;
            cbIs_handle_process.Enabled = false;
            tbPlant_yield.Enabled = false;
            tbPlant_output.Enabled = false;
            dictBLL = new DictBLL();

            //初始化种植作物种类
            List<KeyValue> list_plant_type = dictBLL.getDict("plant_type_famer");
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

  
            List<KeyValue> list_plant_area_type = dictBLL.getDict("plant_area_type");
            if (list_plant_area_type != null)
            {
                foreach (KeyValue kv in list_plant_area_type)
                {
                    if (kv.Key != "")
                    {
                        ctvPlant_area_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }
            //初始化是否办理设施农用地手续
            List<KeyValue> list_is_handle_process = dictBLL.getDict("is_handle_process");
            if (list_is_handle_process != null)
            {
                this.cbIs_handle_process.DataSource = list_is_handle_process;
                this.cbIs_handle_process.DisplayMember = "value";
                this.cbIs_handle_process.ValueMember = "key";
            }


            List<KeyValue> list_animal_type = dictBLL.getDict("animal_type_famer");
            if (list_animal_type != null)
            {
                foreach (KeyValue kv in list_animal_type)
                {
                    if (kv.Key != "")
                    {
                        ctvAnimal_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }
            //初始化养殖占地地类
            List<KeyValue> list_animal_area_type = dictBLL.getDict("animal_area_type");
            if (list_animal_area_type != null)
            {
                foreach (KeyValue kv in list_animal_area_type)
                {
                    if (kv.Key != "")
                    {
                        ctvAnimal_area_type.TreeView.Nodes.Add(kv.Key, kv.Value);
                    }
                }
            }

            //初始化所在乡镇所在村
            orgBLL = new OrgBLL();
            List<KeyValue> list_town = orgBLL.getOrgByType("乡镇");
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            //cbTown.SelectedValue = "";
            cbTown.SelectedValue = LoginInfo.CurrentUser.Town;
            List<KeyValue> list_village = new List<KeyValue>();
            //list_village.Add(new KeyValue("", "请选择"));
            this.cbVillage.DataSource = list_village;
            this.cbVillage.DisplayMember = "value";
            this.cbVillage.ValueMember = "key";


        }
        /// <summary>
        /// 乡镇选择发生改变触发该事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTown_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.opreation_mode == "EDIT" && editFlag)
            //{
            //    editFlag = false;
            //    return;
            //}
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
                            // list_village.Add(new KeyValue("", "请选择"));
                            this.cbVillage.DataSource = list_village;
                            this.cbVillage.DisplayMember = "value";
                            this.cbVillage.ValueMember = "key";
                            //   this.cbVillage.SelectedValue = "";
                            cbVillage.SelectedValue = LoginInfo.CurrentUser.Village;
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
        ///  重写数据验证方法
        /// </summary>
        /// <returns></returns>
        protected override bool CheckData()
        {

            return CheckEmpty(tbHolder_name, "请输入农户姓名")
                && CheckIDCard(this.tbIdcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckEmpty(tbPhone_number, "请输入联系电话")
                && CheckCTV(ctvPlant_type, "请选择种植物种类")
                 && CheckCTV(ctvAnimal_type, "请选择种养殖动物类型类")
                 && CheckPlant()
                 && CheckAnimal()

                ;
        }

        //校验下拉框是否选择
        protected bool CheckCB(UIComboBox uicb, string Message)
        {
            if (uicb.Text == "请选择")
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }
        protected bool CheckCTV(UIComboTreeView uictv, string Message)
        {
            if (uictv.Text == "")
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }


        //校验关联字段
        protected bool CheckPlant()
        {
            if (ctvPlant_type.Text != "")
            {
                return CheckEmpty(tbPlant_area, "请输入种植物占地面积")
                    && CheckCTV(ctvPlant_area_type, "请选择种植占地地类")
                    && CheckCB(cbIs_handle_process, "请选择是否办理设施农用地手续")
                    && CheckEmpty(tbPlant_yield, "请输入种植产量")
                     && CheckEmpty(tbPlant_output, "请输入种植产值")
                    ;
            }
            return true;
        }
        protected bool CheckAnimal()
        {
            if (ctvAnimal_type.Text != "")
            {
                return CheckEmpty(tbAnimal_area, "请输入养殖地面积")
                    && CheckEmpty(tbAnimal_count, "请输入养殖数量")
                    && CheckCTV(ctvAnimal_area_type, "请选择养殖占地地类")
                    && CheckEmpty(tbAnimal_vaccinate_count, "请输入已接种疫苗的动物数量")
                    && CheckEmpty(tbAnimal_nvaccinate_count, "请输入未接种疫苗的动物数量")
                    && CheckEmpty(tbInventory_count, "请输入存栏数量")
                    && CheckEmpty(tbOutbound_count, "请输入出栏数量")
                    && CheckEmpty(tbAnimal_yield, "请输入养殖产出产量")
                     && CheckEmpty(tbAnimal_output, "请输入养殖产出产值")
                    ;
            }
            return true;
        }
        /// <summary>
        ///  验证身份证合法性
        /// </summary>
        /// <param name="tbIDCard"></param>
        /// <param name="Message"></param>
        /// <returns></returns>
        protected bool CheckIDCard(UITextBox tbIDCard, string Message)
        {
            //验证输入的身份证是否合法
            if (tbIDCard.Text.Trim() != "" && Utils.IsIDCard(tbIDCard.Text.Trim()) == false)
            {
                ShowWarningDialog(Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ctvPlant_type.Text ); 
                //如果数据校验没有通过则直接返回。
            if (this.IsOK == false)
            {
                return;
            }
            //从界面获取值封装业务对象
            Famer famer = new Famer();
            famer.Famer_id = this.famer_id;
            famer.Holder_name = tbHolder_name.Text.Trim();
            famer.Idcard = tbIdcard.Text.Trim();
            famer.Phone_number = tbPhone_number.Text.Trim();
            famer.Car_brand = tbCar_brand.Text.Trim();
            famer.Mechine_type = tbMechine_type.Text.Trim();
            famer.Plant_type = ctvPlant_type.Text.ToString();
            if (ctvPlant_type.Text != "无; ")
            {
                famer.Plant_area = double.Parse(tbPlant_area.Text.Trim());
                famer.Plant_yield = double.Parse(tbPlant_yield.Text.Trim());
                famer.Plant_output = int.Parse(tbPlant_output.Text.Trim());
            }
            famer.Plant_area_type = ctvPlant_area_type.Text.ToString();
            famer.Is_handle_process = cbIs_handle_process.SelectedValue.ToString();
            famer.Animal_type = ctvAnimal_type.Text.ToString();
            if (ctvAnimal_type.Text != "无; ")
            {

                famer.Animal_area = double.Parse(tbAnimal_area.Text.Trim());
                famer.Animal_count = int.Parse(tbAnimal_count.Text.Trim());
                famer.Animal_vaccinate_count = int.Parse(tbAnimal_vaccinate_count.Text.Trim());
                famer.Animal_nvaccinate_count = int.Parse(tbAnimal_nvaccinate_count.Text.Trim());
                famer.Inventory_count = int.Parse(tbInventory_count.Text.Trim());
                famer.Outbound_count = int.Parse(tbOutbound_count.Text.Trim());
                famer.Animal_yield = int.Parse(tbAnimal_yield.Text.Trim());
                famer.Animal_output = int.Parse(tbAnimal_output.Text.Trim());
            }
            famer.Animal_area_type = ctvAnimal_area_type.Text.ToString();
            famer.Town = this.cbTown.Text.ToString();
            famer.Villiage = this.cbVillage.Text.ToString();
            famer.Creater = LoginInfo.CurrentUser.Account;
            famer.Create_datetime = DateTime.Now.ToString();
            famerBLL = new FamerBLL();

            if (this.opreation_mode == "ADD")
            {
                Result result = famerBLL.AddFamer(famer);
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
                Result result = famerBLL.EditFamer(famer);
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

        private void cbPlant_type_SelectedValueChanged(object sender, EventArgs e)
        {

            if (ctvPlant_type.Text.ToString() == "")
            {
                tbPlant_area.Enabled = false;
                ctvPlant_area_type.Enabled = false;
                cbIs_handle_process.Enabled = false;
                tbPlant_yield.Enabled = false;
                tbPlant_output.Enabled = false;
            }
            else if (ctvPlant_type.Text != "无; ")
            {
                tbPlant_area.Enabled = true;
                ctvPlant_area_type.Enabled = true;
                cbIs_handle_process.Enabled = true;
                tbPlant_yield.Enabled = true;
                tbPlant_output.Enabled = true;
            }
            else
            {
                tbPlant_area.Enabled = false;
                ctvPlant_area_type.Enabled = false;
                cbIs_handle_process.Enabled = false;
                tbPlant_yield.Enabled = false;
                tbPlant_output.Enabled = false;
            }
        }

        private void cbAnimal_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ctvAnimal_type.Text.ToString() == "")
            {
                tbAnimal_area.Enabled = false;
                tbAnimal_count.Enabled = false;
                ctvAnimal_area_type.Enabled = false;
                tbAnimal_vaccinate_count.Enabled = false;
                tbAnimal_nvaccinate_count.Enabled = false;
                tbInventory_count.Enabled = false;
                tbOutbound_count.Enabled = false;
                tbAnimal_yield.Enabled = false;
                tbAnimal_output.Enabled = false;
            }
            else if (ctvAnimal_type.Text.ToString() != "无; ")
            {
                tbAnimal_area.Enabled = true;
                tbAnimal_count.Enabled = true;
                ctvAnimal_area_type.Enabled = true;
                tbAnimal_vaccinate_count.Enabled = true;
                tbAnimal_nvaccinate_count.Enabled = true;
                tbInventory_count.Enabled = true;
                tbOutbound_count.Enabled = true;
                tbAnimal_yield.Enabled = true;
                tbAnimal_output.Enabled = true;
            }
            else
            {
                tbAnimal_area.Enabled = false;
                tbAnimal_count.Enabled = false;
                ctvAnimal_area_type.Enabled = false;
                tbAnimal_vaccinate_count.Enabled = false;
                tbAnimal_nvaccinate_count.Enabled = false;
                tbInventory_count.Enabled = false;
                tbOutbound_count.Enabled = false;
                tbAnimal_yield.Enabled = false;
                tbAnimal_output.Enabled = false;
            }
        }
    }
}
