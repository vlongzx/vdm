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


        //用户名
        private string _AccountName = "";
        public string AccountName { get { return _AccountName; } set { _AccountName = value; } }
        //用户所属乡镇
        private string _Town= "";
        //用户所属村
        private string _Village = "";
        //登录时间
        private DateTime _LoginTime;
        public DateTime LoginTime { get { return _LoginTime; } set { _LoginTime = value; } }


        private static LoginInfo _CurrentUser = null;


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
    }
}
