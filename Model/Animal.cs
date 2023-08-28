using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Animal
    {
        private long breed_id;
        private string town;
        private string village;
        private string breed_name;
        private string breed_type;
        private string manager;
        private string phone_number;
        private string year_inventory;
        private string year_outbound;
        private float output;
        private float total_area;
        private float pen_area;
        private float midden_area;
        private float pullttion_area;
        private long cueernt_inventory;
        private string animal_qualify;
        private string solid_pollution;
        private string report_or_filings;
        private string create_datetime;
        private string creater;
        private string last_update_datetime;
        private string last_updater;
        /// <summary>
        /// 养殖场（户）ID
        /// </summary>
        public long Breed_id
        {
            get
            {
                return breed_id;
            }

            set
            {
                breed_id = value;
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
        /// 养殖场（户）名称
        /// </summary>
        public string Breed_name
        {
            get
            {
                return breed_name;
            }

            set
            {
                breed_name = value;
            }
        }
        /// <summary>
        /// 养殖种类
        /// </summary>
        public string Breed_type
        {
            get
            {
                return breed_type;
            }

            set
            {
                breed_type = value;
            }
        }
        /// <summary>
        /// 负责人
        /// </summary>
        public string Manager
        {
            get
            {
                return manager;
            }

            set
            {
                manager = value;
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
        /// 年存栏（设计规模）
        /// </summary>
        public string Year_inventory
        {
            get
            {
                return year_inventory;
            }

            set
            {
                year_inventory = value;
            }
        }
        /// <summary>
        /// 年出栏（设计规模）
        /// </summary>
        public string Year_outbound
        {
            get
            {
                return year_outbound;
            }

            set
            {
                year_outbound = value;
            }
        }
        /// <summary>
        /// 产值(万元)
        /// </summary>
        public float Output
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
        /// 占地面积
        /// </summary>
        public float Total_area
        {
            get
            {
                return total_area;
            }

            set
            {
                total_area = value;
            }
        }
        /// <summary>
        /// 圈舍面积
        /// </summary>
        public float Pen_area
        {
            get
            {
                return pen_area;
            }

            set
            {
                pen_area = value;
            }
        }
        /// <summary>
        /// 堆粪场面积
        /// </summary>
        public float Midden_area
        {
            get
            {
                return midden_area;
            }

            set
            {
                midden_area = value;
            }
        }
        /// <summary>
        /// 集污池面积
        /// </summary>
        public float Pullttion_area
        {
            get
            {
                return pullttion_area;
            }

            set
            {
                pullttion_area = value;
            }
        }
        /// <summary>
        /// 现存栏
        /// </summary>
        public long Cueernt_inventory
        {
            get
            {
                return cueernt_inventory;
            }

            set
            {
                cueernt_inventory = value;
            }
        }
        /// <summary>
        /// 动物防疫条件合格证
        /// </summary>
        public string Animal_qualify
        {
            get
            {
                return animal_qualify;
            }

            set
            {
                animal_qualify = value;
            }
        }
        /// <summary>
        /// 固体污染源排污登记
        /// </summary>
        public string Solid_pollution
        {
            get
            {
                return solid_pollution;
            }

            set
            {
                solid_pollution = value;
            }
        }
        /// <summary>
        /// 环评报告或备案
        /// </summary>
        public string Report_or_filings
        {
            get
            {
                return report_or_filings;
            }

            set
            {
                report_or_filings = value;
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
    }
}
