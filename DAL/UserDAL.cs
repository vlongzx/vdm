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

        /// <summary>
        ///  获得所有用户
        /// </summary>
        /// <returns></returns>
        public DataTable getAllUser()
        {
            string sql = "select a.*,b.org_name as town_name,c.org_name as village_name from t_user as a inner join t_org as b on a.town_id = b.org_id left join t_org as c on a.village_id=c.org_id";
            DataTable dt = this.sdh.ExecuteDataTable(sql);

            return dt;
        }
    }
}
