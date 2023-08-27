using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class UserDAL : BaseDAL
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

        /// <summary>
        ///  创建新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Result CreateUser(User user)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_user");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "user_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_user(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "user_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, user.GetType().GetProperty(PropertyName).GetValue(user, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  根据用户ID删除用户
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        public Result DeleteUser(int user_id)
        {
            string sql = "delete from t_user where user_id=" + user_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
    }
}
