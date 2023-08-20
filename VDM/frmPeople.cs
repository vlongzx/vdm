using com.vdm.bll;
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
    public partial class frmPeople : Form
    {
        private PeopleBLL peopleBLL = null;
        public frmPeople()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form formPeopleAdd = new frmPeopleAdd();
            formPeopleAdd.ShowDialog();
            if(formPeopleAdd.DialogResult == DialogResult.OK)
            {
                InitListView();
            }
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            InitListView();
        }
        /// <summary>
        ///  初始化ListView
        /// </summary>
        public void InitListView()
        {
            this.lvPeople.Items.Clear();
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
            this.lvPeople.Columns.Add("职称等级及获得时间", 300);
            this.lvPeople.Columns.Add("残疾分类", 150);
            this.lvPeople.Columns.Add("残疾等级", 150);
            this.lvPeople.Columns.Add("因何致残", 150);
            this.lvPeople.Columns.Add("大病救助情况", 200);
            this.lvPeople.Columns.Add("临时救助情况", 200);
            this.lvPeople.Columns.Add("是否失能老人", 200);
            this.lvPeople.Columns.Add("是否易地搬迁户", 200);
            this.lvPeople.Columns.Add("低保户/五保户", 200);
            this.lvPeople.Columns.Add("低保等级/五保类别", 300);
            this.lvPeople.Columns.Add("添加时间", 150);
            this.lvPeople.Columns.Add("添加人", 100);

            peopleBLL = new PeopleBLL();
            //初始化加载数据
            List<People> list_people = this.peopleBLL.getAllPeople();
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
                lvi.SubItems.Add(people.Pq_gettime);
                lvi.SubItems.Add(people.Disability_type);
                lvi.SubItems.Add(people.Disability_grade);
                lvi.SubItems.Add(people.Disability_reason);
                lvi.SubItems.Add(people.Big_ill_help);
                lvi.SubItems.Add(people.Temporary_help);
                lvi.SubItems.Add(people.Is_unable_old);
                lvi.SubItems.Add(people.Is_relocation);
                lvi.SubItems.Add(people.Low_five);
                lvi.SubItems.Add(people.Low_five_grade);
                lvi.SubItems.Add(people.Create_datetime);
                lvi.SubItems.Add(people.Creater);
                this.lvPeople.Items.Add(lvi);
            }
        }
    }
}