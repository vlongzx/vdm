using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class People
    {
        private long people_id;
        private long farmer_id;
        private string people_name;
        private string idcard;
        private string relationship;
        private string nation;
        private string sex;
        private string birthday;
        private string politcal_outlook;
        private string join_party_time;
        private string phone_number;
        private string religious_belief;
        private string education;
        private string blood_type;
        private string marital_status;
        private string work_or_study;
        private string industry;
        private string unit_or_school;
        private string work_study_location;
        private string skill_type;
        private string employ_guide;
        private string skill_train;
        private string pq_gettime;
        private string military_service;
        private string disability_type;
        private string is_real_name;
        private string disability_grade;
        private string disability_reason;
        private string big_ill_help;
        private string temporary_help;
        private string is_unable_old;
        private string is_relocation;
        private string low_five;
        private string low_five_grade;
        private string remark;
        private string create_datetime;
        private string creater;
        private string last_update_datetime;
        private string last_updater;
        private long statues;
        private string town;
        private string villiage;

        /// <summary>
        ///  人员ID
        /// </summary>
        public long People_id
        {
            get
            {
                return people_id;
            }

            set
            {
                people_id = value;
            }
        }

        /// <summary>
        ///  所属户主，如是户主本周则等于0
        /// </summary>
        public long Farmer_id
        {
            get
            {
                return farmer_id;
            }

            set
            {
                farmer_id = value;
            }
        }

        /// <summary>
        ///  姓名
        /// </summary>
        public string People_name
        {
            get
            {
                return people_name;
            }

            set
            {
                people_name = value;
            }
        }

        /// <summary>
        ///  身份证号码
        /// </summary>
        public string Idcard
        {
            get
            {
                return idcard;
            }

            set
            {
                idcard = value;
            }
        }

        /// <summary>
        ///  与户主的关系
        /// </summary>
        public string Relationship
        {
            get
            {
                return relationship;
            }

            set
            {
                relationship = value;
            }
        }
        /// <summary>
        ///  民族
        /// </summary>
        public string Nation
        {
            get
            {
                return nation;
            }

            set
            {
                nation = value;
            }
        }
        /// <summary>
        ///  性别
        /// </summary>
        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }
        /// <summary>
        ///  出生日期
        /// </summary>
        public string Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }
        /// <summary>
        ///  政治面貌
        /// </summary>
        public string Politcal_outlook
        {
            get
            {
                return politcal_outlook;
            }

            set
            {
                politcal_outlook = value;
            }
        }
        /// <summary>
        ///  入党时间
        /// </summary>
        public string Join_party_time
        {
            get
            {
                return join_party_time;
            }

            set
            {
                join_party_time = value;
            }
        }
        /// <summary>
        ///  联系电话
        /// </summary>
        public string Phone_number
        {
            get
            {
                return phone_number;
            }

            set
            {
                phone_number = value;
            }
        }
        /// <summary>
        ///  宗教信仰
        /// </summary>
        public string Religious_belief
        {
            get
            {
                return religious_belief;
            }

            set
            {
                religious_belief = value;
            }
        }
        /// <summary>
        /// 教育程度
        /// </summary>
        public string Education
        {
            get
            {
                return education;
            }

            set
            {
                education = value;
            }
        }
       /// <summary>
       ///  血型
       /// </summary>
        public string Blood_type
        {
            get
            {
                return blood_type;
            }

            set
            {
                blood_type = value;
            }
        }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string Marital_status
        {
            get
            {
                return marital_status;
            }

            set
            {
                marital_status = value;
            }
        }
        /// <summary>
        ///  是否外出务工/求学
        /// </summary>
        public string Work_or_study
        {
            get
            {
                return work_or_study;
            }

            set
            {
                work_or_study = value;
            }
        }
        /// <summary>
        /// 从事行业
        /// </summary>
        public string Industry
        {
            get
            {
                return industry;
            }

            set
            {
                industry = value;
            }
        }
        /// <summary>
        /// 工作单位/学校名称
        /// </summary>
        public string Unit_or_school
        {
            get
            {
                return unit_or_school;
            }

            set
            {
                unit_or_school = value;
            }
        }
        /// <summary>
        ///  工作地点/学习地点
        /// </summary>
        public string Work_study_location
        {
            get
            {
                return work_study_location;
            }

            set
            {
                work_study_location = value;
            }
        }
        /// <summary>
        /// 技能类型
        /// </summary>
        public string Skill_type
        {
            get
            {
                return skill_type;
            }

            set
            {
                skill_type = value;
            }
        }
        /// <summary>
        /// 有无参加就业指导
        /// </summary>
        public string Employ_guide
        {
            get
            {
                return employ_guide;
            }

            set
            {
                employ_guide = value;
            }
        }
        /// <summary>
        /// 有无参加技能培训
        /// </summary>
        public string Skill_train
        {
            get
            {
                return skill_train;
            }

            set
            {
                skill_train = value;
            }
        }
        /// <summary>
        /// 职称等级及获得时间
        /// </summary>
        public string Pq_gettime
        {
            get
            {
                return pq_gettime;
            }

            set
            {
                pq_gettime = value;
            }
        }
        /// <summary>
        /// 是否服兵役   
        /// </summary>
        public string Military_service
        {
            get
            {
                return military_service;
            }

            set
            {
                military_service = value;
            }
        }
        /// <summary>
        /// 残疾分类
        /// </summary>
        public string Disability_type
        {
            get
            {
                return disability_type;
            }

            set
            {
                disability_type = value;
            }
        }
        /// <summary>
        /// 是否实名认证
        /// </summary>
        public string Is_real_name
        {
            get
            {
                return is_real_name;
            }

            set
            {
                is_real_name = value;
            }
        }
        /// <summary>
        /// 残疾等级
        /// </summary>
        public string Disability_grade
        {
            get
            {
                return disability_grade;
            }

            set
            {
                disability_grade = value;
            }
        }
        /// <summary>
        /// 因何致残
        /// </summary>
        public string Disability_reason
        {
            get
            {
                return disability_reason;
            }

            set
            {
                disability_reason = value;
            }
        }
        /// <summary>
        /// 大病救助情况
        /// </summary>
        public string Big_ill_help
        {
            get
            {
                return big_ill_help;
            }

            set
            {
                big_ill_help = value;
            }
        }
        /// <summary>
        /// 临时救助情况
        /// </summary>
        public string Temporary_help
        {
            get
            {
                return temporary_help;
            }

            set
            {
                temporary_help = value;
            }
        }
        /// <summary>
        /// 是否失能老人
        /// </summary>
        public string Is_unable_old
        {
            get
            {
                return is_unable_old;
            }

            set
            {
                is_unable_old = value;
            }
        }
        /// <summary>
        /// 是否易地搬迁户
        /// </summary>
        public string Is_relocation
        {
            get
            {
                return is_relocation;
            }

            set
            {
                is_relocation = value;
            }
        }
        /// <summary>
        /// 低保户/五保户
        /// </summary>
        public string Low_five
        {
            get
            {
                return low_five;
            }

            set
            {
                low_five = value;
            }
        }
        /// <summary>
        /// 低保等级/五保类别
        /// </summary>
        public string Low_five_grade
        {
            get
            {
                return low_five_grade;
            }

            set
            {
                low_five_grade = value;
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
        /// <summary>
        /// 创建时间    
        /// </summary>
        public string Create_datetime
        {
            get
            {
                return create_datetime;
            }

            set
            {
                create_datetime = value;
            }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creater
        {
            get
            {
                return creater;
            }

            set
            {
                creater = value;
            }
        }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public string Last_update_datetime
        {
            get
            {
                return last_update_datetime;
            }

            set
            {
                last_update_datetime = value;
            }
        }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public string Last_updater
        {
            get
            {
                return last_updater;
            }

            set
            {
                last_updater = value;
            }
        }
        /// <summary>
        /// 状态
        /// </summary>
        public long Statues
        {
            get
            {
                return statues;
            }

            set
            {
                statues = value;
            }
        }
        /// <summary>
        /// 所在乡镇
        /// </summary>
        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }
        }
        /// <summary>
        ///  所在村
        /// </summary>
        public string Villiage
        {
            get
            {
                return villiage;
            }

            set
            {
                villiage = value;
            }
        }
    }
}
