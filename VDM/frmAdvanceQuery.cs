using com.vdm.bll;
using com.vdm.common;
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
    public partial class frmAdvanceQuery : UIEditForm
    {
        frmPeopleList frmpl;
        private DictBLL dictBLL = null;
        private PeopleBLL peopleBLL = null;
        public frmAdvanceQuery()
        {
            InitializeComponent();
        }

        public frmAdvanceQuery(frmPeopleList frmpl)
        {
            InitializeComponent();
            this.frmpl = frmpl;
        }
        private void frmAdvanceQuery_Load(object sender, EventArgs e)
        {
            InitControlData();
        }
        /// <summary>
        /// 初始化高级条件
        /// </summary>
        public void InitControlData()
        {
            //初始化血型
            dictBLL = new DictBLL();
            List<KeyValue> list_blood_type = dictBLL.getDict("blood_type");
            if (list_blood_type != null)
            {
                this.cbBlood_type.DataSource = list_blood_type;
                this.cbBlood_type.DisplayMember = "value";
                this.cbBlood_type.ValueMember = "key";
            }
            //初始化技能培训
            List<KeyValue> list_skill_train = dictBLL.getDict("skill_train");
            if (list_skill_train != null)
            {
                this.cbSkill_train.DataSource = list_skill_train;
                this.cbSkill_train.DisplayMember = "value";
                this.cbSkill_train.ValueMember = "key";
            }
            //初始化就业指导
            List<KeyValue> list_employ_guide = dictBLL.getDict("employ_guide");
            if (list_employ_guide != null)
            {
                this.cbEmploy_guide.DataSource = list_employ_guide;
                this.cbEmploy_guide.DisplayMember = "value";
                this.cbEmploy_guide.ValueMember = "key";
            }

            //初始化是否外出
            this.dictBLL = new DictBLL();
            List<KeyValue> list_work_or_study = dictBLL.getDict("work_or_study");
            list_work_or_study.Add(new KeyValue("", ""));
            if (list_work_or_study != null)
            {
                this.cbWork_or_study.DataSource = list_work_or_study;
                this.cbWork_or_study.DisplayMember = "value";
                this.cbWork_or_study.ValueMember = "key";
            }

            //初始化有无职称
            List<KeyValue> list_is_career_grade = dictBLL.getDict("common_have");
            if (list_is_career_grade != null)
            {
                this.cbIs_career_grade.DataSource = list_is_career_grade;
                this.cbIs_career_grade.DisplayMember = "value";
                this.cbIs_career_grade.ValueMember = "key";
            }
            dictBLL = new DictBLL();
            //初始化日期控件
            dtCareer_get_time.Text = "";
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

            //初始化是否实名认证
            List<KeyValue> list_is_real_name = dictBLL.getDict("is_real_name");
            if (list_is_real_name != null)
            {
                this.cbIs_real_name.DataSource = list_is_real_name;
                this.cbIs_real_name.DisplayMember = "value";
                this.cbIs_real_name.ValueMember = "key";
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



        private void cbWork_or_study_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbWork_or_study.SelectedValue.ToString() == "")
            {
                tbIndustry.Enabled = false;
                tbUnit_or_school.Enabled = false;
                tbWork_study_location.Enabled = false;
            }
            else if (cbWork_or_study.SelectedValue.ToString() != "否")
            {
                tbIndustry.Enabled = true;
                tbUnit_or_school.Enabled = true;
                tbWork_study_location.Enabled = true;
            }
            else
            {
                tbIndustry.Enabled = false;
                tbUnit_or_school.Enabled = false;
                tbWork_study_location.Enabled = false;
            }
        }

        private void cbDisability_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbDisability_type.SelectedValue.ToString() == "")
            {
                tbDisability_reason.Enabled = false;
                cbDisability_grade.Enabled = false;
                cbIs_real_name.Enabled = false;
            }
            else if (cbDisability_type.SelectedValue.ToString() != "无")
            {
                tbDisability_reason.Enabled = true;
                cbDisability_grade.Enabled = true;
                cbIs_real_name.Enabled = true;
            }
            else
            {
                tbDisability_reason.Enabled = false;
                cbDisability_grade.Enabled = false;
                cbIs_real_name.Enabled = false;
            }
        }

        private void cbIs_career_grade_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbIs_career_grade.SelectedValue.ToString() == "")
            {
                tbCareer_grade.Enabled = false;
                dtCareer_get_time.Enabled = false;
            }
            else if (cbIs_career_grade.SelectedValue.ToString() != "无")
            {
                tbCareer_grade.Enabled = true;
                dtCareer_get_time.Enabled = true;
            }
            else
            {
                tbCareer_grade.Enabled = false;
                dtCareer_get_time.Enabled = false;
            }
        }

        private void cbLow_five_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbLow_five.SelectedValue.ToString() == "")
            {
                cbLow_five_grade.Enabled = false;
            }
            else if (cbLow_five.SelectedValue.ToString() != "否")
            {
                cbLow_five_grade.Enabled = true;
            }
            else
            {
                cbLow_five_grade.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //从界面获取高级查询条件
            string Is_real_name = this.cbIs_real_name.SelectedValue.ToString();
            string Blood_type = this.cbBlood_type.SelectedValue.ToString();
            string Religious_belief = this.tbReligious_belief.Text.ToString();
            string Industry = this.tbIndustry.Text.ToString();
            string Unit_or_school = this.tbUnit_or_school.Text.Trim();
            string Work_study_location = this.tbWork_study_location.Text.Trim();
            string Employ_guide = this.cbEmploy_guide.SelectedValue.ToString();
            string Skill_train = this.cbSkill_train.SelectedValue.ToString();
            string Is_career_grade = this.cbIs_career_grade.SelectedValue.ToString();
            string Career_grade = this.tbCareer_grade.Text.Trim();
            string Career_get_time = this.dtCareer_get_time.Text.ToString();
            string Disability_type = this.cbDisability_type.SelectedValue.ToString();
            string Disability_grade = this.cbDisability_grade.SelectedValue.ToString();
            string Disability_reason = this.tbDisability_reason.Text.Trim();
            string Big_ill_help = this.cbBig_ill_help.SelectedValue.ToString();
            string Temporary_help = this.cbTemporary_help.SelectedValue.ToString();
            string Is_unable_old = this.cbIs_unable_old.SelectedValue.ToString();
            string Is_relocation = this.cbIs_relocation.SelectedValue.ToString();
            string Low_five = this.cbLow_five.SelectedValue.ToString();
            string Low_five_grade = this.cbLow_five_grade.SelectedValue.ToString();
            string Military_service = this.cbMilitary_service.SelectedValue.ToString();
            string Work_or_study = this.cbWork_or_study.SelectedValue.ToString();
            frmpl. ConditionAdd("Work_or_study", Work_or_study);
            frmpl.ConditionAdd("Is_real_name", Is_real_name);
            frmpl.ConditionAdd("Blood_type", Blood_type);
            frmpl.ConditionAdd("Religious_belief", Religious_belief);
            frmpl.ConditionAdd("Industry", Industry);
            frmpl.ConditionAdd("Unit_or_school", Unit_or_school);
            frmpl.ConditionAdd("Work_study_location", Work_study_location);
            frmpl.ConditionAdd("Employ_guide", Employ_guide);
            frmpl.ConditionAdd("Skill_train", Skill_train);
            frmpl.ConditionAdd("Is_career_grade", Is_career_grade);
            frmpl.ConditionAdd("Career_grade", Career_grade);
            frmpl.ConditionAdd("Career_get_time", Career_get_time);
            frmpl.ConditionAdd("Disability_type", Disability_type);
            frmpl.ConditionAdd("Disability_grade", Disability_grade);
            frmpl.ConditionAdd("Disability_reason", Disability_reason);
            frmpl.ConditionAdd("Big_ill_help", Big_ill_help);
            frmpl.ConditionAdd("Temporary_help", Temporary_help);
            frmpl.ConditionAdd("Is_unable_old", Is_unable_old);
            frmpl.ConditionAdd("Is_relocation", Is_relocation);
            frmpl.ConditionAdd("Low_five", Low_five);
            frmpl.ConditionAdd("Low_five_grade", Low_five_grade);
            frmpl.ConditionAdd("Military_service", Military_service);
        }
    }
}
