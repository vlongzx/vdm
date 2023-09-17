using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.common
{
    public class LoginInfo
    {
        //用户帐号，登录帐号
        private string _Account = "";
        public string Account { get { return _Account; } set { _Account = value; } }

        private string _RealName = "";
        private string _Password = "";
        //用户名
        private string _AccountName = "";
        public string AccountName { get { return _AccountName; } set { _AccountName = value; } }
        //用户所属乡镇
        private string _Town = "";
        //用户所属村
        private string _Village = "";
        //用户角色
        private string _RoleName = "";
        private string _Level = "";
        //登录时间
        private DateTime _LoginTime;
        public DateTime LoginTime { get { return _LoginTime; } set { _LoginTime = value; } }


        private static LoginInfo _CurrentUser = null;

        private static List<string> _FuncPowerList = new List<string>();


        //应用单件模式，保存用户登录状态
        public static LoginInfo CurrentUser
        {
            get
            {
                if (_CurrentUser == null)
                    _CurrentUser = new LoginInfo();
                return _CurrentUser;
            }
        }

        public string Town
        {
            get
            {
                return _Town;
            }

            set
            {
                _Town = value;
            }
        }

        public string Village
        {
            get
            {
                return _Village;
            }

            set
            {
                _Village = value;
            }
        }
        /// <summary>
        ///  权限列表
        /// </summary>
        public static List<string> FuncPowerList
        {
            get
            {
                return _FuncPowerList;
            }

            set
            {
                _FuncPowerList = value;
            }
        }

        public string RoleName
        {
            get
            {
                return _RoleName;
            }

            set
            {
                _RoleName = value;
            }
        }
        /// <summary>
        ///  姓名
        /// </summary>
        public string RealName
        {
            get
            {
                return _RealName;
            }

            set
            {
                _RealName = value;
            }
        }
        /// <summary>
        /// 账号级别
        /// </summary>
        public string Level
        {
            get
            {
                return _Level;
            }

            set
            {
                _Level = value;
            }
        }
        /// <summary>
        ///  密码
        /// </summary>
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
    }
}
