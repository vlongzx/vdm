using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Tour
    {
        private long tour_id;
        private string company_id;
        private string principal_category;
        private string principal_name;
        private string legal_name;
        private string registered_trademark;
        private string phone_number;
        private string trade_form;
        private string address;
        private int year_person_count;
        private double year_trade_income;
        private string create_datetime;
        private string creater;
        private string last_update_datetime;
        private string last_updater;
        private string town;
        private string villiage;
        private string remark;
        /// <summary>
        /// 旅游信息ID
        /// </summary>
        public long Tour_id
        {
            get
            {
                return tour_id;
            }

            set
            {
                tour_id = value;
            }
        }
        /// <summary>
        /// 企业ID
        /// </summary>
        public string Company_id
        {
            get
            {
                return company_id;
            }

            set
            {
                company_id = value;
            }
        }
        /// <summary>
        /// 主体类别
        /// </summary>
        public string Principal_category
        {
            get
            {
                return principal_category;
            }

            set
            {
                principal_category = value;
            }
        }
        /// <summary>
        /// 主体名称
        /// </summary>
        public string Principal_name
        {
            get
            {
                return principal_name;
            }

            set
            {
                principal_name = value;
            }
        }
        /// <summary>
        /// 法定代表人姓名
        /// </summary>
        public string Legal_name
        {
            get
            {
                return legal_name;
            }

            set
            {
                legal_name = value;
            }
        }
        /// <summary>
        /// 注册商标
        /// </summary>
        public string Registered_trademark
        {
            get
            {
                return registered_trademark;
            }

            set
            {
                registered_trademark = value;
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
        /// 经营形式
        /// </summary>
        public string Trade_form
        {
            get
            {
                return trade_form;
            }

            set
            {
                trade_form = value;
            }
        }
        /// <summary>
        /// 地址
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
        /// 年接待旅游（人次）
        /// </summary>
        public int Year_person_count
        {
            get
            {
                return year_person_count;
            }

            set
            {
                year_person_count = value;
            }
        }
        /// <summary>
        /// 年经营收入（万元）
        /// </summary>
        public double Year_trade_income
        {
            get
            {
                return year_trade_income;
            }

            set
            {
                year_trade_income = value;
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
        /// 所属乡镇
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
    }
}
