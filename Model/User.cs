using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class User
    {
        private int user_id;
        private string username;
        private string password;
        private string level;
        private string  town;
        private string  village;
        private string remark;
        private int character_id;

        /// <summary>
        ///  用户ID
        /// </summary>
        public int User_id
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
        /// <summary>
        ///  角色ID
        /// </summary>
        public int Character_id
        {
            get
            {
                return character_id;
            }

            set
            {
                character_id = value;
            }
        }

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
    }
}
