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
    public partial class frmPeopleList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private PeopleBLL peopleBLL = null;
        private Hashtable condition = null;
        //高级查询条件
        private Hashtable conditionAdvance = new Hashtable();
        private int pageIndex = 1;
        private int pageSize = 20;
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
            if (formPeopleAdd.DialogResult == DialogResult.OK)
            {
                InitListView(null, this.pageIndex, this.pageSize);
            }
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            InitControlData();

            InitListView(null, this.pageIndex, this.pageSize);

        }
        public void ConditionAdd(string key, string value)
        {
            this.conditionAdvance.Add(key, value);
        }
        /// <summary>
        /// 初始化基本查询条件
        /// </summary>
        public void InitControlData()
        {

            //初始化与户主的关系
            dictBLL = new DictBLL();
            List<KeyValue> list_relationship = dictBLL.getDict("relationship");
            // list_relationship.Add(new KeyValue("", ""));
            if (list_relationship != null)
            {
                this.cbRelationship.DataSource = list_relationship;
                this.cbRelationship.DisplayMember = "value";
                this.cbRelationship.ValueMember = "key";
            }
            //初始化民族
            this.dictBLL = new DictBLL();
            List<KeyValue> list_nation = dictBLL.getDict("nation");
            list_nation.Add(new KeyValue("", ""));
            if (list_nation != null)
            {
                this.cbNation.DataSource = list_nation;
                this.cbNation.DisplayMember = "value";
                this.cbNation.ValueMember = "key";
            }
            //初始化性别

            List<KeyValue> list_sex = dictBLL.getDict("sex");
            if (list_sex != null)
            {
                this.cbSex.DataSource = list_sex;
                this.cbSex.DisplayMember = "value";
                this.cbSex.ValueMember = "key";
            }
             //初始化日期控件
            this.dpBirthday_From.Text = "";
            this.dpBirthday_To.Text = "";
            this.dpJoin_party_time_from.Text = "";
            this.dpJoin_party_time_to.Text = "";
            //初始化政治面貌
            List<KeyValue> list_politcal_outlook = dictBLL.getDict("politcal_outlook");
            // list_politcal_outlook.Add(new KeyValue("", ""));
            if (list_politcal_outlook != null)
            {
                this.cbPolitcal_outlook.DataSource = list_politcal_outlook;
                this.cbPolitcal_outlook.DisplayMember = "value";
                this.cbPolitcal_outlook.ValueMember = "key";
            }
            //初始化婚姻关系
            List<KeyValue> list_marital_status = dictBLL.getDict("marital_status");
            if (list_marital_status != null)
            {
                this.cbMarital_status.DataSource = list_marital_status;
                this.cbMarital_status.DisplayMember = "value";
                this.cbMarital_status.ValueMember = "key";
            }
            //初始化学历
            List<KeyValue> list_education = dictBLL.getDict("education");
            if (list_education != null)
            {
                this.cbEducation.DataSource = list_education;
                this.cbEducation.DisplayMember = "value";
                this.cbEducation.ValueMember = "key";
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
            cbTown.SelectedValue="";

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
            this.dgPeopleList.AutoGenerateColumns = false;
            this.dgPeopleList.RowTemplate.Height = 45;
            this.dgPeopleList.Columns.Clear();
            this.dgPeopleList.AddColumn("编号", "People_id");
            this.dgPeopleList.AddColumn("姓名", "People_name");
            this.dgPeopleList.Columns[1].Frozen = true;//冻结前两列
            this.dgPeopleList.AddColumn("身份证号", "Idcard");
            this.dgPeopleList.AddColumn("出生日期", "Birthday").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("性别", "Sex");
            this.dgPeopleList.AddColumn("与户主关系", "Relationship");
            this.dgPeopleList.AddColumn("民族", "Nation");
            this.dgPeopleList.AddColumn("政治面貌", "Politcal_outlook");
            this.dgPeopleList.AddColumn("入党时间", "Join_party_time").SetSortMode(DataGridViewColumnSortMode.Automatic); ;
            this.dgPeopleList.AddColumn("联系电话", "Phone_number");
            this.dgPeopleList.AddColumn("是否实名", "Is_real_name");
            this.dgPeopleList.AddColumn("所属镇", "Town");
            this.dgPeopleList.AddColumn("所属村", "Villiage");
            this.dgPeopleList.AddColumn("宗教信仰", "Religious_belief");
            this.dgPeopleList.AddColumn("学历", "Education");
            this.dgPeopleList.AddColumn("血型", "Blood_type");
            this.dgPeopleList.AddColumn("婚姻状况", "Marital_status");
            this.dgPeopleList.AddColumn("是否外出", "Work_or_study");
            this.dgPeopleList.AddColumn("从事行业", "Industry");
            this.dgPeopleList.AddColumn("工作单位/学校名称", "Unit_or_school");
            this.dgPeopleList.AddColumn("工作地点/学习地点", "Work_study_location");
            this.dgPeopleList.AddColumn("技能类型", "Skill_type");
            this.dgPeopleList.AddColumn("就业指导", "Employ_guide");
            this.dgPeopleList.AddColumn("技能培训", "Skill_train");
            this.dgPeopleList.AddColumn("有无职称", "Is_career_grade");
            this.dgPeopleList.AddColumn("职称等级", "Career_grade");
            this.dgPeopleList.AddColumn("职称获得时间", "Career_get_time");
            this.dgPeopleList.AddColumn("残疾分类", "Disability_type");
            this.dgPeopleList.AddColumn("残疾等级", "Disability_grade");
            this.dgPeopleList.AddColumn("因何致残", "Disability_reason");
            this.dgPeopleList.AddColumn("大病救助情况", "Big_ill_help");
            this.dgPeopleList.AddColumn("临时救助情况", "Temporary_help");
            this.dgPeopleList.AddColumn("是否失能老人", "Is_unable_old");
            this.dgPeopleList.AddColumn("是否易地搬迁户", "Is_relocation");
            this.dgPeopleList.AddColumn("低保户/五保户", "Low_five");
            this.dgPeopleList.AddColumn("低保等级/五保类别", "Low_five_grade");
            this.dgPeopleList.AddColumn("备注", "Remark", 100, DataGridViewContentAlignment.MiddleLeft, true);
            this.dgPeopleList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgPeopleList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgPeopleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            peopleBLL = new PeopleBLL();
            //初始化加载数据
            List<People> list_people;
            DataTable dt_people;
            if (condition == null)
            {
                //获得总页数
                this.peopleBLL = new PeopleBLL();

                int totalCount = this.peopleBLL.getTotalPeople();
                this.pagination.PageSize = this.pageSize;
                this.pagination.TotalCount = totalCount;
                //  list_people = this.peopleBLL.getAllPeopleList(pageIndex,pageSize);
                dt_people = this.peopleBLL.getAllPeopleDataTable(pageIndex, pageSize);
            }
            //条件查询
            else
            {
                //获得总页数
                this.peopleBLL = new PeopleBLL();
                int totalCount = this.peopleBLL.getTotalPeopleIf(condition);
                this.pagination.PageSize = this.pageSize;
                this.pagination.TotalCount = totalCount;
                // list_people = this.peopleBLL.getAllPeopleList(condition, pageIndex, pageSize);
                dt_people = this.peopleBLL.getAllPeopleDataTable(condition, pageIndex, pageSize);
            }

            // this.dgPeopleList.DataSource = list_people;
            this.dgPeopleList.DataSource = dt_people; ;

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //获得当前需要编辑的行
            if (this.dgPeopleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要编辑的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int people_id = int.Parse(this.dgPeopleList.SelectedRows[0].Cells[0].Value.ToString());

            Form formPeopleAdd = new frmPeopleInfo("EDIT", people_id);
            formPeopleAdd.ShowDialog();
            if (formPeopleAdd.DialogResult == DialogResult.OK)
            {
                InitListView(condition, this.pageIndex, this.pageSize);
            }
        }
        /// <summary>
        ///  刷新重新加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRefresh_Click(object sender, EventArgs e)
        {
            InitListView(condition, this.pageIndex, this.pageSize);
        }

        public override void Init()
        {
            base.Init();
            this.pagination.ActivePage = 1;
        }
        /// <summary>
        ///  删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            //获得当前需要删除的行

            //获得当前需要编辑的行
            if (this.dgPeopleList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择你要删除的行。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int people_id = int.Parse(this.dgPeopleList.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("确认要删除该行数据吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.peopleBLL = new PeopleBLL();
                Result result = this.peopleBLL.DelPeople(people_id);
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

        /// <summary>
        ///  查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            //从界面获取值基本查询条件封装业务对象
            condition = new Hashtable();
            string People_name = this.tbPeople_name.Text.Trim();
            string Sex = this.cbSex.SelectedValue.ToString();
            string Nation = this.cbNation.SelectedValue.ToString();
            string Relationship = this.cbRelationship.SelectedValue.ToString();
            string Idcard = this.tbIdcard.Text.Trim();
            string Phone_number = this.tbPhone_number.Text.Trim();
            string Birthday_From = this.dpBirthday_From.Text.Trim();
            string Birthday_To = this.dpBirthday_To.Text.Trim();
            string Marital_status = cbMarital_status.SelectedValue.ToString();
            string Politcal_outlook = this.cbPolitcal_outlook.SelectedValue.ToString();
            string Skill_type= tbSkill_type.Text.Trim();
            string Education = this.cbEducation.SelectedValue.ToString();
            string Join_party_time_from = this.dpJoin_party_time_from.Text.Trim();
            string Join_party_time_to = this.dpJoin_party_time_to.Text.Trim();
            string Village = this.cbVillage.SelectedValue.ToString();
            string Town = this.cbTown.SelectedValue.ToString();
                
            //------------------------------------------------------------------
            condition.Add("People_name", People_name);
            condition.Add("Sex", Sex);
            condition.Add("Nation", Nation);
            condition.Add("Relationship", Relationship);
            condition.Add("Idcard", Idcard);
            condition.Add("Phone_number", Phone_number);
            condition.Add("Birthday_From", Birthday_From);
            condition.Add("Birthday_To", Birthday_To);
            condition.Add("Politcal_outlook", Politcal_outlook);
           condition.Add("Marital_status", Marital_status);
            condition.Add("Education", Education);
            condition.Add("Skill_type", Skill_type);
            condition.Add("Join_party_time_from", Join_party_time_from);
            condition.Add("Join_party_time_to", Join_party_time_to);
            condition.Add("Village", Join_party_time_to);
            condition.Add("Town", Join_party_time_to);
            //获取值高级查询条件封装业务对象
            foreach (DictionaryEntry de in conditionAdvance)
            {
                condition.Add(de.Key, de.Value);
            }
            //重置高级查询条件
            conditionAdvance = new Hashtable();
            this.pageIndex = 1;
            this.InitListView(condition, this.pageIndex, this.pageSize);
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExport_Click(object sender, EventArgs e)
        {
            ExcelUtil.Lv = this.InitExportListView(this.condition);
            frmExportExcel ef = new frmExportExcel();
            ef.ShowDialog();
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btImport_Click(object sender, EventArgs e)
        {
            DataTable dt = ExcelUtil.ExcelToDataTable();
            //若有数据
            if (dt.Rows.Count != 0)
            {
                People people = new People();
                peopleBLL = new PeopleBLL();
                try
                {
                    foreach (DataRow dataRow in dt.Rows)
                    {

                        //将excel数据值封装业务对象
                        //------------------基础信息部分---------------------------------

                        people.People_name = dataRow["姓名"].ToString();
                        people.Sex = dataRow["性别"].ToString();
                        people.Nation = dataRow["民族"].ToString();
                        people.Relationship = dataRow["与户主关系"].ToString();
                        people.Birthday = dataRow["出生日期"].ToString();
                        people.Idcard = dataRow["身份证号"].ToString();
                        people.Phone_number = dataRow["联系电话"].ToString();
                        people.Town = dataRow["所属镇"].ToString();
                        people.Villiage = dataRow["所属村"].ToString();
                        people.Marital_status = dataRow["婚姻状况"].ToString();
                        people.Is_real_name = dataRow["是否实名"].ToString();
                        people.Blood_type = dataRow["血型"].ToString();
                        people.Remark = dataRow["备注"].ToString();
                        people.Politcal_outlook = dataRow["政治面貌"].ToString();
                        people.Join_party_time = dataRow["入党时间"].ToString();
                        people.Religious_belief = dataRow["宗教信仰"].ToString();
                        people.Education = dataRow["学历"].ToString();
                        people.Work_or_study = dataRow["工作地点/学习地点"].ToString();
                        people.Industry = dataRow["从事行业"].ToString();
                        people.Unit_or_school = dataRow["工作单位/学校名称"].ToString();
                        people.Work_study_location = dataRow["婚姻状况"].ToString();
                        people.Skill_type = dataRow["技能类型"].ToString();
                        people.Employ_guide = dataRow["就业指导"].ToString();
                        people.Skill_train = dataRow["技能培训"].ToString();
                        people.Is_career_grade = dataRow["有无职称"].ToString();
                        people.Career_grade = dataRow["职称等级"].ToString();
                        people.Career_get_time = dataRow["职称获得时间"].ToString();
                        people.Disability_type = dataRow["残疾分类"].ToString();
                        people.Disability_grade = dataRow["残疾等级"].ToString();
                        people.Disability_reason = dataRow["因何致残"].ToString();
                        people.Big_ill_help = dataRow["大病救助情况"].ToString();
                        people.Temporary_help = dataRow["临时救助情况"].ToString();
                        people.Is_unable_old = dataRow["是否失能老人"].ToString();
                        people.Is_relocation = dataRow["是否易地搬迁户"].ToString();
                        people.Low_five = dataRow["低保户/五保户"].ToString();
                        people.Low_five_grade = dataRow["低保等级/五保类别"].ToString();
                        people.Military_service = dataRow["婚姻状况"].ToString();
                        people.Creater = LoginInfo.CurrentUser.Account;
                        people.Create_datetime = DateTime.Now.ToString();
                        peopleBLL.AddPeople(people);
                    }
                    MessageBox.Show("导入成功");
                    //使用的是全局变量people
                    InitListView(condition, this.pageIndex, this.pageSize);
                    //this.pagination.InitPagination();
                }
                catch
                {
                    MessageBox.Show("导入失败");
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            //清空查询文本框内容
            this.tbPeople_name.Text = "";
            this.cbSex.SelectedValue = "";
            this.cbNation.SelectedValue = "";
            this.cbRelationship.SelectedValue = "";
            this.tbIdcard.Text = "";
            this.tbPhone_number.Text = "";
            this.cbPolitcal_outlook.SelectedValue = "";
           // this.tbReligious_belief.Text = "";
            this.cbEducation.SelectedValue = "";
            this.dpJoin_party_time_from.Text = "";
            this.dpJoin_party_time_to.Text = "";
            this.dpBirthday_From.Text = "";
            this.dpBirthday_To.Text = "";
            this.cbTown.SelectedValue = "";
            this.cbVillage.SelectedValue = "";
            this.tbSkill_type.Text = "";
            this.cbMarital_status.SelectedValue = "";
            //查询所有人员信息
            condition = null;
            InitListView(condition, this.pageIndex, this.pageSize);
        }


        /// <summary>
        /// 初始化要导出的数据
        /// </summary>
        /// <param name="p">查询条件</param>
        /// <returns></returns>
        public ListView InitExportListView(Hashtable condition)
        {
            ListView lvExport = new ListView();
            lvExport.Items.Clear();
            lvExport.Columns.Clear();
            lvExport.View = View.Details;
            lvExport.Columns.Add("姓名", 100);
            lvExport.Columns.Add("身份证号", 260);
            lvExport.Columns.Add("出生日期", 150);
            lvExport.Columns.Add("性别", 100);
            lvExport.Columns.Add("与户主关系", 150, HorizontalAlignment.Center);
            lvExport.Columns.Add("民族", 100, HorizontalAlignment.Center);
            lvExport.Columns.Add("政治面貌", 150);
            lvExport.Columns.Add("入党时间", 150);
            lvExport.Columns.Add("联系电话", 150);
            lvExport.Columns.Add("是否实名", 150);
            lvExport.Columns.Add("所属镇", 150);
            lvExport.Columns.Add("所属村", 150);
            lvExport.Columns.Add("宗教信仰", 150);
            lvExport.Columns.Add("学历", 100);
            lvExport.Columns.Add("血型", 100);
            lvExport.Columns.Add("婚姻状况", 150);
            lvExport.Columns.Add("是否外出", 150);
            lvExport.Columns.Add("从事行业", 150);
            lvExport.Columns.Add("工作单位/学校名称", 300);
            lvExport.Columns.Add("工作地点/学习地点", 300);
            lvExport.Columns.Add("技能类型", 150);
            lvExport.Columns.Add("就业指导", 150);
            lvExport.Columns.Add("技能培训", 150);
            lvExport.Columns.Add("有无职称", 150);
            lvExport.Columns.Add("职称等级", 150);
            lvExport.Columns.Add("职称获得时间", 200);
            lvExport.Columns.Add("残疾分类", 150);
            lvExport.Columns.Add("残疾等级", 150);
            lvExport.Columns.Add("因何致残", 150);
            lvExport.Columns.Add("大病救助情况", 200);
            lvExport.Columns.Add("临时救助情况", 200);
            lvExport.Columns.Add("是否失能老人", 200);
            lvExport.Columns.Add("是否易地搬迁户", 200);
            lvExport.Columns.Add("低保户/五保户", 200);
            lvExport.Columns.Add("低保等级/五保类别", 300);
            lvExport.Columns.Add("备注", 100);
            lvExport.Columns.Add("添加时间", 150);
            lvExport.Columns.Add("添加人", 100);
            peopleBLL = new PeopleBLL();
            //初始化导出ListView数据
            List<People> list_people;
            this.peopleBLL = new PeopleBLL();
            list_people = this.peopleBLL.getAllPeople(condition);

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
                lvi.SubItems.Add(people.Is_career_grade);
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
                lvExport.Items.Add(lvi);
            }
            return lvExport;

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
                int select_village = 0;
                if (this.cbTown.SelectedItem != null )
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
        private void pagination_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            this.pageIndex = pageIndex;
            InitListView(condition, this.pageIndex, this.pageSize);
        }

        private void frmPeopleList_Initialize(object sender, EventArgs e)
        {

        }

        private void dgPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btAdanceSearch_Click(object sender, EventArgs e)
        {
            Form formAdvanceQuery = new frmAdvanceQuery(this);
            formAdvanceQuery.ShowDialog();
        }
    }
}