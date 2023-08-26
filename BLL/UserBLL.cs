using com.vdm.dal;
using com.vdm.model;
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

        /// <summary>
        ///  获得所有的用户
        /// </summary>
        /// <returns></returns>
        public List<User> getAllUser()
        {
            DataTable dt = this.userDAL.getAllUser();
            List<User> listUser = new List<User>();
            User user;
            if (dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    user = new User();
                    user.User_id = row["user_id"].ToString();
                    user.Username = row["username"].ToString();
                    user.Town_id = int.Parse(row["town_id"].ToString());
                    user.Village_id = int.Parse(row["village_id"].ToString());
                    user.Remark = row["remark"].ToString();
                    user.Town_name = row["town_name"].ToString();
                    user.Village_name = row["village_name"].ToString();
                    if(row["village_id"].ToString() == "0")
                    {
                        user.Level = "乡镇级";
                    }
                    else
                    {
                        user.Level = "村级";
                    }
                    listUser.Add(user);
                }
            }
            return listUser;
        }
    }

}
