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
    public partial class frmAnimalInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private AnimalBLL animalBLL = null;
        private long breed_id = 0;
        public frmAnimalInfo()
        {
            InitializeComponent();
        }
        public frmAnimalInfo(long breed_id)
        {
            InitializeComponent();
            this.breed_id = breed_id;
        }

        private void frmAnimalInfo_Load(object sender, EventArgs e)
        {
            //初始化界面控件
            InitPageControl();

            this.animalBLL = new AnimalBLL();
            Animal animal = this.animalBLL.getAnimal(this.breed_id);
            if(animal != null)
            {
                this.tbAddress.Text = animal.Address;
                this.tbBreed_name.Text = animal.Breed_name;
                this.tbCueernt_inventory.Text = animal.Cueernt_inventory.ToString();
                this.tbIdcard.Text = animal.Idcard;
                this.tbManager.Text = animal.Manager;
                this.tbMidden_area.Text = animal.Midden_area.ToString();
                this.tbOutput.Text = animal.Output.ToString();
                this.tbPen_area.Text = animal.Pen_area.ToString();
                this.tbPhone_number.Text = animal.Phone_number;
                this.tbPullttion_area.Text = animal.Pullttion_area.ToString();
                this.tbRemark.Text = animal.Remark;
                this.tbTotal_area.Text = animal.Total_area.ToString();
                this.cbAnimal_qualify.SelectedValue = animal.Animal_qualify;
                this.cbBreed_type.SelectedValue = animal.Breed_type;
                this.cbReport_or_filings.SelectedValue = animal.Report_or_filings;
                this.cbSolid_pollution.SelectedValue = animal.Solid_pollution;
                this.cbTown.SelectedValue = animal.Town;
                this.cbVillage.SelectedValue = animal.Village;
                this.tbYear_inventory.Text = animal.Year_inventory;
                this.tbYear_outbound.Text = animal.Year_outbound;
            }

        }

        /// <summary>
        ///  初始化界面控件的值
        /// </summary>
        private void InitPageControl()
        {
            dictBLL = new DictBLL();
            //养殖种类
            List<KeyValue> list_breed_type = dictBLL.getDict("animal_type");
            if (list_breed_type != null)
            {
                this.cbBreed_type.DataSource = list_breed_type;
                this.cbBreed_type.DisplayMember = "value";
                this.cbBreed_type.ValueMember = "key";
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

            //环评报告或备案
            List<KeyValue> list_report_or_filings = dictBLL.getDict("report_or_filings");
            if (list_report_or_filings != null)
            {
                this.cbReport_or_filings.DataSource = list_report_or_filings;
                this.cbReport_or_filings.DisplayMember = "value";
                this.cbReport_or_filings.ValueMember = "key";
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
            cbTown.SelectedValue = LoginInfo.CurrentUser.Town;
            List<KeyValue> list_village = new List<KeyValue>();
            //list_village.Add(new KeyValue("", "请选择"));
            this.cbVillage.DataSource = list_village;
            this.cbVillage.DisplayMember = "value";
            this.cbVillage.ValueMember = "key";
        }

        protected override bool CheckData()
        {

            return CheckEmpty(tbAddress, "请输入养殖场（户）地址")
                 && CheckEmpty(this.tbBreed_name, "请输入养殖场（户）名称")
                && CheckIDCard(this.tbIdcard, "您输入的身份证号码不合法，请重新输入。")
                && CheckEmpty(tbCueernt_inventory, "请输入现存栏")
                && CheckEmpty(tbManager, "请输入负责人")
                   && CheckEmpty(tbMidden_area, "请输入堆粪场面积")
                    && CheckEmpty(tbOutput, "请输入产值(万元)")
                   && CheckEmpty(tbPen_area, "请输入圈舍面积")
                   && CheckEmpty(tbPhone_number, "请输入联系电话")
                      && CheckEmpty(tbPullttion_area, "请输入集污池面积")
              && CheckEmpty(tbTotal_area, "请输入占地面积")
                              && CheckEmpty(tbYear_inventory, "请输入年存栏（设计规模）")
                && CheckEmpty(tbYear_outbound, "请输入年出栏（设计规模）")
                             && CheckCB(cbAnimal_qualify, "请选择房屋类别")
                  && CheckCB(cbBreed_type, "请选择养殖种类")
         && CheckCB(cbReport_or_filings, "请选择环评报告或备案")
           && CheckCB(cbSolid_pollution, "请选择固体污染源排污登记")
                       && CheckCB(cbAnimal_qualify, "请选择动物防疫条件合格证")
                      && CheckCB(cbTown, "请选择所属镇")
                       && CheckCB(cbVillage, "请选择所属村")
                       && IsExistRecord(this.tbIdcard.Text.Trim());

                ;
        }

        public bool IsExistRecord(string IdCard)
        {
            //判断当前增加的身份证号码有没有畜牧登记信息，如果有给与提示
            bool isExist = this.animalBLL.getAnimalByIdCard(IdCard);

            if (isExist == true)
            {
                DialogResult res = MessageBox.Show("身份证编号：" + IdCard + "已存在畜牧登记信息，是否确认添加？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            //如果数据校验没有通过则直接返回。
            if (this.IsOK == false)
            {
                return;
            }
            //从界面获取值封装业务对象
            Animal animal = new Animal();
            animal.Breed_id = this.breed_id;
            animal.Address = this.tbAddress.Text.Trim();
            animal.Animal_qualify = this.cbAnimal_qualify.SelectedValue.ToString();
            animal.Breed_name = this.tbBreed_name.Text.Trim();
            animal.Breed_type = this.cbBreed_type.SelectedValue.ToString();
            animal.Creater = LoginInfo.CurrentUser.AccountName;
            animal.Create_datetime = DateTime.Now.ToString();
            animal.Town = this.cbTown.SelectedValue.ToString();
            animal.Village = this.cbVillage.SelectedValue.ToString();
            animal.Cueernt_inventory = 0;
            if (this.tbCueernt_inventory.Text.Trim() != "")
            {
                animal.Cueernt_inventory = long.Parse(this.tbCueernt_inventory.Text.Trim());
            }
            animal.Idcard = this.tbIdcard.Text.Trim();
            animal.Manager = this.tbManager.Text.Trim();
            animal.Midden_area = 0;
            if (this.tbMidden_area.Text.Trim() != "")
            {
                animal.Midden_area = double.Parse(this.tbMidden_area.Text.Trim());
            }
            animal.Output = 0;
            if (this.tbOutput.Text.Trim() != "")
            {
                animal.Output = double.Parse(this.tbOutput.Text.Trim());
            }
            animal.Pen_area = 0;
            if (this.tbPen_area.Text.Trim() != "")
            {
                animal.Pen_area = double.Parse(this.tbPen_area.Text.Trim());
            }
            animal.Phone_number = this.tbPhone_number.Text.Trim();
            animal.Pullttion_area = 0;
            if (this.tbPullttion_area.Text.Trim() != "")
            {
                animal.Pullttion_area = double.Parse(this.tbPullttion_area.Text.Trim());
            }
            animal.Total_area = 0;
            if (this.tbTotal_area.Text.Trim() != "")
            {
                animal.Total_area = double.Parse(this.tbTotal_area.Text.Trim());
            }
            animal.Year_inventory = this.tbYear_inventory.Text;
            animal.Year_outbound = this.tbYear_outbound.Text;
            animal.Solid_pollution = this.cbSolid_pollution.SelectedValue.ToString();
            animal.Report_or_filings = this.cbReport_or_filings.SelectedValue.ToString();
            animal.Remark = this.tbRemark.Text;

            animalBLL = new AnimalBLL();
            if (this.breed_id == 0)//代表是新增
            {


                Result result = animalBLL.addAnimal(animal);
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
                animal.Breed_id = breed_id;
                Result result = animalBLL.editAnimal(animal);
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
                           // list_village.Add(new KeyValue("", "请选择"));
                            this.cbVillage.DataSource = list_village;
                            this.cbVillage.DisplayMember = "value";
                            this.cbVillage.ValueMember = "key";
                            // this.cbVillage.SelectedValue = "";
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
    }
}
