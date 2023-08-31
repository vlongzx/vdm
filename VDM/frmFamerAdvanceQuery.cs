using com.vdm.bll;
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
    public partial class frmFamerAdvanceQuery  : UIEditForm
    {
        frmFamerList frmfamer;
        private DictBLL dictBLL = null;
        public frmFamerAdvanceQuery()
        {
            InitializeComponent();
        }
        public frmFamerAdvanceQuery(frmFamerList frmfamer)
        {
            InitializeComponent();
            this.frmfamer = frmfamer;
        }
        private void frmFamerAdvanceQuery_Load(object sender, EventArgs e)
        {
            InitControlData();
        }
        /// <summary>
        /// 初始化高级条件
        /// </summary>
        public void InitControlData()
        {
            ////初始化血型
            //dictBLL = new DictBLL();
            //List<KeyValue> list_blood_type = dictBLL.getDict("blood_type");
            //if (list_blood_type != null)
            //{
            //    this.cbBlood_type.DataSource = list_blood_type;
            //    this.cbBlood_type.DisplayMember = "value";
            //    this.cbBlood_type.ValueMember = "key";
            //}

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //从界面获取高级查询条件
            //string Is_real_name = this.cbIs_real_name.SelectedValue.ToString();
            //string Blood_type = this.cbBlood_type.SelectedValue.ToString();
            //string Religious_belief = this.tbReligious_belief.Text.ToString();
            //string Industry = this.tbIndustry.Text.ToString();
            //string Unit_or_school = this.tbUnit_or_school.Text.Trim();
            //string Work_study_location = this.tbWork_study_location.Text.Trim();
            //string Employ_guide = this.cbEmploy_guide.SelectedValue.ToString();
            //string Skill_train = this.cbSkill_train.SelectedValue.ToString();
            //string Is_career_grade = this.cbIs_career_grade.SelectedValue.ToString();
            //string Career_grade = this.tbCareer_grade.Text.Trim();
            //string Career_get_time = this.dtCareer_get_time.Text.ToString();
            //string Disability_type = this.cbDisability_type.SelectedValue.ToString();
            //string Disability_grade = this.cbDisability_grade.SelectedValue.ToString();
            //string Disability_reason = this.tbDisability_reason.Text.Trim();
            //string Big_ill_help = this.cbBig_ill_help.SelectedValue.ToString();
            //string Temporary_help = this.cbTemporary_help.SelectedValue.ToString();
            //string Is_unable_old = this.cbIs_unable_old.SelectedValue.ToString();
            //string Is_relocation = this.cbIs_relocation.SelectedValue.ToString();
            //string Low_five = this.cbLow_five.SelectedValue.ToString();
            //string Low_five_grade = this.cbLow_five_grade.SelectedValue.ToString();
            //string Military_service = this.cbMilitary_service.SelectedValue.ToString();
            //string Work_or_study = this.cbWork_or_study.SelectedValue.ToString();
            //frmpl.ConditionAdd("Work_or_study", Work_or_study);
            //frmpl.ConditionAdd("Is_real_name", Is_real_name);
            //frmpl.ConditionAdd("Blood_type", Blood_type);
            //frmpl.ConditionAdd("Religious_belief", Religious_belief);
            //frmpl.ConditionAdd("Industry", Industry);
            //frmpl.ConditionAdd("Unit_or_school", Unit_or_school);
            //frmpl.ConditionAdd("Work_study_location", Work_study_location);
            //frmpl.ConditionAdd("Employ_guide", Employ_guide);
            //frmpl.ConditionAdd("Skill_train", Skill_train);
            //frmpl.ConditionAdd("Is_career_grade", Is_career_grade);
            //frmpl.ConditionAdd("Career_grade", Career_grade);
            //frmpl.ConditionAdd("Career_get_time", Career_get_time);
            //frmpl.ConditionAdd("Disability_type", Disability_type);
            //frmpl.ConditionAdd("Disability_grade", Disability_grade);
            //frmpl.ConditionAdd("Disability_reason", Disability_reason);
            //frmpl.ConditionAdd("Big_ill_help", Big_ill_help);
            //frmpl.ConditionAdd("Temporary_help", Temporary_help);
            //frmpl.ConditionAdd("Is_unable_old", Is_unable_old);
            //frmpl.ConditionAdd("Is_relocation", Is_relocation);
            //frmpl.ConditionAdd("Low_five", Low_five);
            //frmpl.ConditionAdd("Low_five_grade", Low_five_grade);
            //frmpl.ConditionAdd("Military_service", Military_service);
        }


    }
}
