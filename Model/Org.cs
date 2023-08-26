using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public  class Org
    {
        private int org_id;
        private string org_name;
        private string org_type;
        private int org_pre_id;
        /// <summary>
        /// 组织ID
        /// </summary>
        public int Org_id
        {
            get
            {
                return org_id;
            }

            set
            {
                org_id = value;
            }
        }
        /// <summary>
        /// 组织名称
        /// </summary>
        public string Org_name
        {
            get
            {
                return org_name;
            }

            set
            {
                org_name = value;
            }
        }
        /// <summary>
        ///  组织类型
        /// </summary>
        public string Org_type
        {
            get
            {
                return org_type;
            }

            set
            {
                org_type = value;
            }
        }
        /// <summary>
        ///  上级组织ID
        /// </summary>
        public int Org_pre_id
        {
            get
            {
                return org_pre_id;
            }

            set
            {
                org_pre_id = value;
            }
        }
    }
}
