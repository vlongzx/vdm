using com.vdm.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
    public class UserBLL
    {
        private UserDAL userDAL;

        public UserBLL()
        {
            this.userDAL = new UserDAL();
        }

        /// <summary>
        ///  用户登录业务逻辑处理
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>
        ///  return 1 表示用户名密码正确
        ///  return 0 表示用户名密码不正确
        ///  return -1 表示存在多个同样用户名的用户
        /// </returns>
        public int Login(string username,string password)
        {
            DataTable dt = this.userDAL.getUserInfo(username);

            if(dt != null && dt.Rows.Count == 1)
            {
                if(dt.Rows[0]["password"].ToString() == password)
                {
                    return 1;
                }
               
            }
            return -1;
        }
    }

}
