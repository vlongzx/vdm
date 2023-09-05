using com.vdm.common;
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


        public User getUser(int user_id)
        {
            DataTable dt = this.userDAL.getUser(user_id);
            User user = null;
            if(dt != null && dt.Rows.Count > 0)
            {
                user = new User();
                user.User_id = user_id;
                user.Username = dt.Rows[0]["username"].ToString();
                user.Village = dt.Rows[0]["village"].ToString();
                user.Town = dt.Rows[0]["town"].ToString();
                user.Level = dt.Rows[0]["level"].ToString();
                user.Remark = dt.Rows[0]["remark"].ToString();
                user.Character_id =int.Parse(dt.Rows[0]["character_id"].ToString());
            }
            return user;
        }

        /// <summary>
        ///  获得所有的用户
        /// </summary>
        /// <returns></returns>
        public DataTable getAllUser()
        {
            DataTable dt = this.userDAL.getAllUser();
            List<User> listUser = new List<User>();
            return dt;
        }
        /// <summary>
        ///  增加新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Result addUser(User user)
        {
            return this.userDAL.CreateUser(user);
        }

        public Result editUser(User user)
        {
            return this.userDAL.UpdateUser(user);
        }

        public Result delUser(int user_id)
        {
            return this.userDAL.DeleteUser(user_id);
        }
    }

}
