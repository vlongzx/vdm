using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class UserDAL
    {
        private SqlDbHelper sdh;

        public UserDAL()
        {
            this.sdh = new SqlDbHelper();
        }

        /// <summary>
        ///  根据用户名查询用户信息
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable  getUserInfo(string username)
        {
            string sql = "select * from t_user where username = '"+ username+"'";
            DataTable dt = this.sdh.ExecuteDataTable(sql);

            return dt;
        }
    }
}
