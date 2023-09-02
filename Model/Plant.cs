using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Plant
    {
        private long plant_id;
        private string town;
        private string village;
        private double plant_area;
        private string plant_brand;
        private string plant_type;
        private string contact_person;
        private string idcard;
        private string phone_number;
        private string address;
        private string is_plan;
        private double year_yield;
        private string sale_way;
        private double output;
        private string insect_ill;
        private string manage_skill_method;
        private string develop_willing;
        private string question;
        private string create_datetime;
        private string creater;
        private string last_update_datetime;
        private string last_updater;
        private string remark;
        /// <summary>
        /// 种植ID
        /// </summary>
        public long Plant_id
        {
            get
            {
                return plant_id;
            }

            set
            {
                plant_id = value;
            }
        }
        /// <summary>
        /// 所属镇
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
        /// 所属村
        /// </summary>
        public string Village
        {
            get
            {
                return village;
            }

            set
            {
                village = value;
            }
        }
        /// <summary>
        /// 种植面积
        /// </summary>
        public double Plant_area
        {
            get
            {
                return plant_area;
            }

            set
            {
                plant_area = value;
            }
        }
        /// <summary>
        /// 种植品种
        /// </summary>
        public string Plant_brand
        {
            get
            {
                return plant_brand;
            }

            set
            {
                plant_brand = value;
            }
        }
        /// <summary>
        /// 种植类别
        /// </summary>
        public string Plant_type
        {
            get
            {
                return plant_type;
            }

            set
            {
                plant_type = value;
            }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact_person
        {
            get
            {
                return contact_person;
            }

            set
            {
                contact_person = value;
            }
        }
        /// <summary>
        /// 联系电话
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
        /// 详细地址
        /// </summary>
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        /// <summary>
        /// 是否符合规划
        /// </summary>
        public string Is_plan
        {
            get
            {
                return is_plan;
            }

            set
            {
                is_plan = value;
            }
        }
        /// <summary>
        /// 年产量（斤）
        /// </summary>
        public double Year_yield
        {
            get
            {
                return year_yield;
            }

            set
            {
                year_yield = value;
            }
        }
        /// <summary>
        /// 销售途径
        /// </summary>
        public string Sale_way
        {
            get
            {
                return sale_way;
            }

            set
            {
                sale_way = value;
            }
        }
        /// <summary>
        /// 产值(万元)
        /// </summary>
        public double Output
        {
            get
            {
                return output;
            }

            set
            {
                output = value;
            }
        }
        /// <summary>
        /// 主要虫病害
        /// </summary>
        public string Insect_ill
        {
            get
            {
                return insect_ill;
            }

            set
            {
                insect_ill = value;
            }
        }
        /// <summary>
        /// 主要管理和技术措施
        /// </summary>
        public string Manage_skill_method
        {
            get
            {
                return manage_skill_method;
            }

            set
            {
                manage_skill_method = value;
            }
        }
        /// <summary>
        /// 发展意愿
        /// </summary>
        public string Develop_willing
        {
            get
            {
                return develop_willing;
            }

            set
            {
                develop_willing = value;
            }
        }
        /// <summary>
        /// 需要政府解决的问题
        /// </summary>
        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
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
        /// 身份证号码
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
    }
}
