using com.vdm.bll;
using com.vdm.common;
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
    public partial class frmPeopleAdd : Form
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        public frmPeopleAdd()
        {
            InitializeComponent();
        }

        private void frmPeopleAdd_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            InitPageControl();


        }

        /// <summary>
        ///  初始化界面控件的值
        /// </summary>
        private void InitPageControl()
        {
            dictBLL = new DictBLL();
            //初始化血型
            List<KeyValue> list_blood_type = dictBLL.getDict("blood_type");
            if (list_blood_type != null)
            {
                this.cbBlood_type.DataSource = list_blood_type;
                this.cbBlood_type.DisplayMember = "value";
                this.cbBlood_type.ValueMember = "key";
            }

            //初始化性别
            List<KeyValue> list_sex = new List<KeyValue>();
            list_sex.Add(new KeyValue("男", "男"));
            list_sex.Add(new KeyValue("女", "女"));
            this.cbSex.DataSource = list_sex;
            this.cbSex.DisplayMember = "value";
            this.cbSex.ValueMember = "key";

            //初始胡民族
            List<KeyValue> list_nation = dictBLL.getDict("nation");
            if (list_nation != null)
            {
                this.cbNation.DataSource = list_nation;
                this.cbNation.DisplayMember = "value";
                this.cbNation.ValueMember = "key";
            }

            //初始化与户主的关系
            List<KeyValue> list_relationship = dictBLL.getDict("relationship");
            if (list_relationship != null)
            {
                this.cbRelationship.DataSource = list_relationship;
                this.cbRelationship.DisplayMember = "value";
                this.cbRelationship.ValueMember = "key";
            }

            //初始化婚姻关系
            List<KeyValue> list_marital_status = new List<KeyValue>();
            list_marital_status.Add(new KeyValue("已婚", "已婚"));
            list_marital_status.Add(new KeyValue("未婚", "未婚"));
            list_marital_status.Add(new KeyValue("离异", "离异"));
            list_marital_status.Add(new KeyValue("丧偶", "丧偶"));
            this.cbMarital_status.DataSource = list_marital_status;
            this.cbMarital_status.DisplayMember = "value";
            this.cbMarital_status.ValueMember = "key";

            //初始化政治面貌
            List<KeyValue> list_politcal_outlook = dictBLL.getDict("politcal_outlook");
            if (list_politcal_outlook != null)
            {
                this.cbPolitcal_outlook.DataSource = list_politcal_outlook;
                this.cbPolitcal_outlook.DisplayMember = "value";
                this.cbPolitcal_outlook.ValueMember = "key";
            }

            //初始化宗教信仰
            List<KeyValue> list_religious_belief = dictBLL.getDict("religious_belief");
            if (list_religious_belief != null)
            {
                this.cbReligious_belief.DataSource = list_religious_belief;
                this.cbReligious_belief.DisplayMember = "value";
                this.cbReligious_belief.ValueMember = "key";
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
            if (list_town != null)
            {
                this.cbTown.DataSource = list_town;
                this.cbTown.DisplayMember = "value";
                this.cbTown.ValueMember = "key";
            }
            int select_village = int.Parse(this.cbTown.SelectedValue.ToString());
            List<KeyValue> list_village = orgBLL.getOrgByTown(select_village);
            if (list_village != null)
            {
                this.cbVillage.DataSource = list_village;
                this.cbVillage.DisplayMember = "value";
                this.cbVillage.ValueMember = "key";
            }

            //初始化是否外出
            List<KeyValue> list_work_or_study = dictBLL.getDict("work_or_study");
            if (list_work_or_study != null)
            {
                this.cbWork_or_study.DataSource = list_work_or_study;
                this.cbWork_or_study.DisplayMember = "value";
                this.cbWork_or_study.ValueMember = "key";
            }

            //初始化从事行业
            List<KeyValue> list_industry = dictBLL.getDict("industry");
            if (list_industry != null)
            {
                this.cbIndustry.DataSource = list_industry;
                this.cbIndustry.DisplayMember = "value";
                this.cbIndustry.ValueMember = "key";
            }

            //初始化技能类型
            List<KeyValue> list_skill_type = dictBLL.getDict("skill_type");
            if (list_skill_type != null)
            {
                this.cbSkill_type.DataSource = list_skill_type;
                this.cbSkill_type.DisplayMember = "value";
                this.cbSkill_type.ValueMember = "key";
            }

            //初始化就业指导
            List<KeyValue> list_employ_guide = dictBLL.getDict("employ_guide");
            if (list_employ_guide != null)
            {
                this.cbEmploy_guide.DataSource = list_employ_guide;
                this.cbEmploy_guide.DisplayMember = "value";
                this.cbEmploy_guide.ValueMember = "key";
            }

            //初始化技能培训
            List<KeyValue> list_skill_train = dictBLL.getDict("skill_train");
            if (list_skill_train != null)
            {
                this.cbSkill_train.DataSource = list_skill_train;
                this.cbSkill_train.DisplayMember = "value";
                this.cbSkill_train.ValueMember = "key";
            }

            //初始化服兵役
            List<KeyValue> list_military_service = dictBLL.getDict("military_service");
            if (list_military_service != null)
            {
                this.cbMilitary_service.DataSource = list_military_service;
                this.cbMilitary_service.DisplayMember = "value";
                this.cbMilitary_service.ValueMember = "key";
            }

            //初始化残疾分类
            List<KeyValue> list_disability_type = dictBLL.getDict("disability_type");
            if (list_disability_type != null)
            {
                this.cbDisability_type.DataSource = list_disability_type;
                this.cbDisability_type.DisplayMember = "value";
                this.cbDisability_type.ValueMember = "key";
            }

            //初始化残疾等级
            List<KeyValue> list_disability_grade = dictBLL.getDict("disability_grade");
            if (list_disability_grade != null)
            {
                this.cbDisability_grade.DataSource = list_disability_grade;
                this.cbDisability_grade.DisplayMember = "value";
                this.cbDisability_grade.ValueMember = "key";
            }

            //初始化大病救助
            List<KeyValue> list_big_ill_help = dictBLL.getDict("big_ill_help");
            if (list_big_ill_help != null)
            {
                this.cbBig_ill_help.DataSource = list_big_ill_help;
                this.cbBig_ill_help.DisplayMember = "value";
                this.cbBig_ill_help.ValueMember = "key";
            }

            //初始化临时救助
            List<KeyValue> list_temporary_help = dictBLL.getDict("temporary_help");
            if (list_temporary_help != null)
            {
                this.cbTemporary_help.DataSource = list_temporary_help;
                this.cbTemporary_help.DisplayMember = "value";
                this.cbTemporary_help.ValueMember = "key";
            }

            //初始化失能老人
            List<KeyValue> list_is_unable_old = dictBLL.getDict("is_unable_old");
            if (list_is_unable_old != null)
            {
                this.cbIs_unable_old.DataSource = list_is_unable_old;
                this.cbIs_unable_old.DisplayMember = "value";
                this.cbIs_unable_old.ValueMember = "key";
            }

            //初始化异地搬迁
            List<KeyValue> list_is_relocation = dictBLL.getDict("is_relocation");
            if (list_is_relocation != null)
            {
                this.cbIs_relocation.DataSource = list_is_relocation;
                this.cbIs_relocation.DisplayMember = "value";
                this.cbIs_relocation.ValueMember = "key";
            }

            //初始化低保五保
            List<KeyValue> list_low_fiven = dictBLL.getDict("low_five");
            if (list_low_fiven != null)
            {
                this.cbLow_five.DataSource = list_low_fiven;
                this.cbLow_five.DisplayMember = "value";
                this.cbLow_five.ValueMember = "key";
            }

            //初始化低保五保分类
            List<KeyValue> list_low_five_grade = dictBLL.getDict("low_five_grade");
            if (list_low_five_grade != null)
            {
                this.cbLow_five_grade.DataSource = list_low_five_grade;
                this.cbLow_five_grade.DisplayMember = "value";
                this.cbLow_five_grade.ValueMember = "key";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubmit_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  选择乡镇发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbTown.SelectedValue != null)
            {
                orgBLL = new OrgBLL();
                int select_village = int.Parse(this.cbTown.SelectedValue.ToString());
                List<KeyValue> list_village = orgBLL.getOrgByTown(select_village);
                if (list_village != null)
                {
                    this.cbVillage.DataSource = list_village;
                    this.cbVillage.DisplayMember = "value";
                    this.cbVillage.ValueMember = "key";
                }
            }
            

        }
    }
}
