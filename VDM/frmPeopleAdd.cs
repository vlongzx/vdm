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
            dictBLL = new DictBLL();
            //初始化血型
            List<KeyValue> list_blood_type = dictBLL.getDict("blood_type");
            if(list_blood_type != null)
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
    }
}
