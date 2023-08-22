using com.vdm.bll;
using com.vdm.common;
using com.vdm.form.utils;
using com.vdm.model;
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
    public partial class frmPeopleList : Form
    {

        private DictBLL dictBLL = null;
        private PeopleBLL peopleBLL = null;
        private People people = null;
        public frmPeopleList()
        {
            InitializeComponent();
        }

        private Form preForm;
        public frmPeopleList(Form preForm)
        {
            InitializeComponent();
            this.preForm = preForm;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formPeopleAdd = new frmPeopleInfo();
            formPeopleAdd.ShowDialog();
            if(formPeopleAdd.DialogResult == DialogResult.OK)
            {
                InitListView(people);
            }
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            InitControlData();
            InitListView(people);
        }

        public void InitControlData()
        {
            //初始胡民族
            this.dictBLL = new DictBLL();
            List<KeyValue> list_nation = dictBLL.getDict("nation");
            list_nation.Add(new KeyValue("", ""));
            if (list_nation != null)
            {
                this.cbNation.DataSource = list_nation;
                this.cbNation.DisplayMember = "value";
                this.cbNation.ValueMember = "key";
            }
            this.cbNation.SelectedValue = "";
            

            //初始化性别
            List<KeyValue> list_sex = new List<KeyValue>();
            list_sex.Add(new KeyValue("男", "男"));
            list_sex.Add(new KeyValue("女", "女"));
            list_sex.Add(new KeyValue("", ""));
            this.cbSex.DataSource = list_sex;
            this.cbSex.DisplayMember = "value";
            this.cbSex.ValueMember = "key";
            this.cbSex.SelectedValue = "";

            //初始化与户主的关系
            List<KeyValue> list_relationship = dictBLL.getDict("relationship");
            list_relationship.Add(new KeyValue("", ""));
            if (list_relationship != null)
            {
                this.cbRelationship.DataSource = list_relationship;
                this.cbRelationship.DisplayMember = "value";
                this.cbRelationship.ValueMember = "key";
            }
            this.cbRelationship.SelectedValue = "";

            //初始化政治面貌
            List<KeyValue> list_politcal_outlook = dictBLL.getDict("politcal_outlook");
            list_politcal_outlook.Add(new KeyValue("", ""));
            if (list_politcal_outlook != null)
            {
                this.cbPolitcal_outlook.DataSource = list_politcal_outlook;
                this.cbPolitcal_outlook.DisplayMember = "value";
                this.cbPolitcal_outlook.ValueMember = "key";
            }
            this.cbPolitcal_outlook.SelectedValue = "";

            //初始化宗教信仰
            List<KeyValue> list_religious_belief = dictBLL.getDict("religious_belief");
            list_religious_belief.Add(new KeyValue("", ""));
            if (list_religious_belief != null)
            {
                this.cbReligious_belief.DataSource = list_religious_belief;
                this.cbReligious_belief.DisplayMember = "value";
                this.cbReligious_belief.ValueMember = "key";
            }
            this.cbReligious_belief.SelectedValue = "";


            //初始化学历
            List<KeyValue> list_education = dictBLL.getDict("education");
            list_education.Add(new KeyValue("", ""));
            if (list_education != null)
            {
                this.cbEducation.DataSource = list_education;
                this.cbEducation.DisplayMember = "value";
                this.cbEducation.ValueMember = "key";
            }
            this.cbEducation.SelectedValue = "";
        }


        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView(People p)
        {
            this.lvPeople.Items.Clear();
            this.lvPeople.Columns.Clear();
            this.lvPeople.View = View.Details;
            this.lvPeople.Columns.Add("姓名", 100);
            this.lvPeople.Columns.Add("身份证号", 260);
            this.lvPeople.Columns.Add("出生日期", 150);
            this.lvPeople.Columns.Add("性别", 100);
            this.lvPeople.Columns.Add("与户主关系", 150, HorizontalAlignment.Center);
            this.lvPeople.Columns.Add("民族", 100, HorizontalAlignment.Center);
            this.lvPeople.Columns.Add("政治面貌", 150);
            this.lvPeople.Columns.Add("入党时间", 150);
            this.lvPeople.Columns.Add("联系电话", 150);
            this.lvPeople.Columns.Add("是否实名", 150);
            this.lvPeople.Columns.Add("所属镇", 150);
            this.lvPeople.Columns.Add("所属村", 150);
            this.lvPeople.Columns.Add("宗教信仰", 150);
            this.lvPeople.Columns.Add("学历", 100);
            this.lvPeople.Columns.Add("血型", 100);
            this.lvPeople.Columns.Add("婚姻状况", 150);
            this.lvPeople.Columns.Add("是否外出", 150);
            this.lvPeople.Columns.Add("从事行业", 150);
            this.lvPeople.Columns.Add("工作单位/学校名称", 300);
            this.lvPeople.Columns.Add("工作地点/学习地点", 300);
            this.lvPeople.Columns.Add("技能类型", 150);
            this.lvPeople.Columns.Add("就业指导", 150);
            this.lvPeople.Columns.Add("技能培训", 150);
            this.lvPeople.Columns.Add("职称等级", 150);
            this.lvPeople.Columns.Add("职称获得时间", 200);
            this.lvPeople.Columns.Add("残疾分类", 150);
            this.lvPeople.Columns.Add("残疾等级", 150);
            this.lvPeople.Columns.Add("因何致残", 150);
            this.lvPeople.Columns.Add("大病救助情况", 200);
            this.lvPeople.Columns.Add("临时救助情况", 200);
            this.lvPeople.Columns.Add("是否失能老人", 200);
            this.lvPeople.Columns.Add("是否易地搬迁户", 200);
            this.lvPeople.Columns.Add("低保户/五保户", 200);
            this.lvPeople.Columns.Add("低保等级/五保类别", 300);
            this.lvPeople.Columns.Add("备注", 100);
            this.lvPeople.Columns.Add("添加时间", 150);
            this.lvPeople.Columns.Add("添加人", 100);

            peopleBLL = new PeopleBLL();
            //初始化加载数据
            List<People> list_people;
            if (p == null)
            {
                list_people = this.peopleBLL.getAllPeople();
            }
            else
            {
                list_people = this.peopleBLL.getAllPeople(p);
            }
           
            foreach (People people in list_people)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = people.People_id;//存储主键
                lvi.Text = people.People_name;
                lvi.SubItems.Add(people.Idcard);
                lvi.SubItems.Add(people.Birthday);
                lvi.SubItems.Add(people.Sex);
                lvi.SubItems.Add(people.Relationship);
                lvi.SubItems.Add(people.Nation);
                lvi.SubItems.Add(people.Politcal_outlook);
                lvi.SubItems.Add(people.Join_party_time);
                lvi.SubItems.Add(people.Phone_number);
                lvi.SubItems.Add(people.Is_real_name);
                lvi.SubItems.Add(people.Town);
                lvi.SubItems.Add(people.Villiage);
                lvi.SubItems.Add(people.Religious_belief);
                lvi.SubItems.Add(people.Education);
                lvi.SubItems.Add(people.Blood_type);
                lvi.SubItems.Add(people.Marital_status);
                lvi.SubItems.Add(people.Work_or_study);//是否外出
                lvi.SubItems.Add(people.Industry);
                lvi.SubItems.Add(people.Unit_or_school);
                lvi.SubItems.Add(people.Work_study_location);
                lvi.SubItems.Add(people.Skill_type);
                lvi.SubItems.Add(people.Employ_guide);
                lvi.SubItems.Add(people.Skill_train);
                lvi.SubItems.Add(people.Career_grade);
                lvi.SubItems.Add(people.Career_get_time);
                lvi.SubItems.Add(people.Disability_type);
                lvi.SubItems.Add(people.Disability_grade);
                lvi.SubItems.Add(people.Disability_reason);
                lvi.SubItems.Add(people.Big_ill_help);
                lvi.SubItems.Add(people.Temporary_help);
                lvi.SubItems.Add(people.Is_unable_old);
                lvi.SubItems.Add(people.Is_relocation);
                lvi.SubItems.Add(people.Low_five);
                lvi.SubItems.Add(people.Low_five_grade);
                lvi.SubItems.Add(people.Remark);
                lvi.SubItems.Add(people.Create_datetime);
                lvi.SubItems.Add(people.Creater);
                this.lvPeople.Items.Add(lvi);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.lvPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = this.lvPeople.SelectedItems[0];
            int people_id = 0;
            if(item != null)
            {
                people_id = int.Parse(item.Tag.ToString());
            }

            Form formPeopleAdd = new frmPeopleInfo("EDIT", people_id);
            formPeopleAdd.ShowDialog();
            if (formPeopleAdd.DialogResult == DialogResult.OK)
            {
                InitListView(people);
            }
        }
        /// <summary>
        ///  刷新重新加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefresh_Click(object sender, EventArgs e)
        {
            InitListView(people);
        }

        /// <summary>
        ///  删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行
         
            if ( this.lvPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = this.lvPeople.SelectedItems[0];
            int people_id = 0;
            if (item != null)
            {
                people_id = int.Parse(item.Tag.ToString());
                if(MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.peopleBLL = new PeopleBLL();
                    Result result = this.peopleBLL.DelPeople(people_id);
                    if (result.Count == 1)
                    {
                        this.InitListView(people);
                        MessageBox.Show("删除成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除数据发生异常。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogHelper.Error(result.Information, result.Exception);
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
            //从界面获取值封装业务对象
            //------------------基础信息部分---------------------------------
            people = new People();
            people.People_name = this.tbPeople_name.Text.Trim();
            people.Sex = this.cbSex.SelectedValue.ToString();
            people.Nation = this.cbNation.SelectedValue.ToString();
            people.Relationship = this.cbRelationship.SelectedValue.ToString();
            people.Idcard = this.tbIdcard.Text.Trim();
            people.Phone_number = this.tbPhone_number.Text.Trim();
            //------------------------------------------------------------------
            //-----------------政治面貌与宗教信仰
            people.Politcal_outlook = this.cbPolitcal_outlook.SelectedValue.ToString();
            people.Religious_belief = this.cbReligious_belief.SelectedValue.ToString();
            people.Education = this.cbEducation.SelectedValue.ToString();
            //------------------------------------------------------------------
            this.InitListView(people);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExport_Click(object sender, EventArgs e)
        {
            ExcelUtil.Lv = lvPeople;
            frmExportExcel ef = new frmExportExcel();
            ef.ShowDialog();
        }

        private void btImport_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}