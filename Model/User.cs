using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class User
    {
        private string user_id;
        private string username;
        private string password;
        private string level;
        private int town_id;
        private string town_name;
        private string village_name;
        private int village_id;
        private string remark;

        /// <summary>
        ///  用户ID
        /// </summary>
        public string User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }
        /// <summary>
        ///  用户名
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        /// <summary>
        ///  密码
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        /// <summary>
        ///  所在乡镇ID
        /// </summary>
        public int Town_id
        {
            get
            {
                return town_id;
            }

            set
            {
                town_id = value;
            }
        }
        /// <summary>
        ///  所在村ID
        /// </summary>
        public int Village_id
        {
            get
            {
                return village_id;
            }

            set
            {
                village_id = value;
            }
        }
        /// <summary>
        ///  备注
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
        ///  所在乡镇名称
        /// </summary>
        public string Town_name
        {
            get
            {
                return town_name;
            }

            set
            {
                town_name = value;
            }
        }
        /// <summary>
        ///  所在村名称
        /// </summary>
        public string Village_name
        {
            get
            {
                return village_name;
            }

            set
            {
                village_name = value;
            }
        }
        /// <summary>
        /// 账号所在级别
        /// </summary>
        public string Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
    }
}
