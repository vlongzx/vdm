using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.vdm.common;
using com.vdm.model;

using System.Collections;

using System.Data;
using System.Data.SQLite;

namespace com.vdm.dal
{
    public class ManagerDAL : BaseDAL
    {
        /// <summary>
        ///  获得信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_manager where 1 = 1";
            if (condition != null)
            {
                if (condition.ContainsKey("People_name") && condition["People_name"].ToString() != "")
                {
                    sql += "    and people_name = @people_name";
                }
                if (condition.ContainsKey("Sex") && condition["Sex"].ToString() != "")
                {
                    sql += "    and sex = @sex";
                }
                if (condition.ContainsKey("Nation") && condition["Nation"].ToString() != "")
                {
                    sql += "    and nation = @nation";
                }
                if (condition.ContainsKey(" Post") && condition["Post"].ToString() != "")
                {
                    sql += "    and Post = @Post";
                }
                if (condition.ContainsKey("Politcal_outlook") && condition["Politcal_outlook"].ToString() != "")
                {
                    sql += "    and politcal_outlook = @politcal_outlook";
                }
                if (condition.ContainsKey("Phone_number") && condition["Phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition.ContainsKey("Idcard") && condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard = @idcard";
                }
                if (condition.ContainsKey("Village") && condition["Village"].ToString() != "")
                {
                    sql += "    and village = @village";
                }
                if (condition.ContainsKey("Town") && condition["Town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition.ContainsKey("Education") && condition["Education"].ToString() != "")
                {
                    sql += "    and education = @education";
                }
                if (condition.ContainsKey("Birthday_From") && condition["Birthday_From"].ToString() != "" && condition.ContainsKey("Birthday_To") && condition["Birthday_To"].ToString() != null)
                {
                    sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
                }
                if (condition.ContainsKey("Join_party_time_from") && condition["Join_party_time_from"].ToString() != "" && condition.ContainsKey("Join_party_time_to") && condition["Join_party_time_to"].ToString() != null)
                {
                    sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
                }
                if (condition.ContainsKey("Employ_date_From") && condition["Employ_date_From"].ToString() != "" && condition.ContainsKey("Employ_date_To") && condition["Employ_date_To"].ToString() != null)
                {
                    sql += " and   Employ_date BETWEEN '" + condition["Employ_date_From"].ToString() + "' AND '" + condition["Employ_date_To"].ToString() + "'";
                }
            }
            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
                parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
                parameters.Add(new SQLiteParameter("@post", condition["Post"]));
                parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
                parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@education", condition["Education"]));
                parameters.Add(new SQLiteParameter("@town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@village", condition["Village"]));
            }
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }

        /// <summary>
        ///  获得所有农户（空条件或者条件查询）
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllManager(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_manager where 1 = 1";
            if (condition != null)
            {
                if (condition.ContainsKey("People_name") && condition["People_name"].ToString() != "")
                {
                    sql += "    and people_name = @people_name";
                }
                if (condition.ContainsKey("Sex") && condition["Sex"].ToString() != "")
                {
                    sql += "    and sex = @sex";
                }
                if (condition.ContainsKey("Nation") && condition["Nation"].ToString() != "")
                {
                    sql += "    and nation = @nation";
                }
                if (condition.ContainsKey(" Post") && condition["Post"].ToString() != "")
                {
                    sql += "    and Post = @Post";
                }
                if (condition.ContainsKey("Politcal_outlook") && condition["Politcal_outlook"].ToString() != "")
                {
                    sql += "    and politcal_outlook = @politcal_outlook";
                }
                if (condition.ContainsKey("Phone_number") && condition["Phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition.ContainsKey("Idcard") && condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard = @idcard";
                }
                if (condition.ContainsKey("Village") && condition["Village"].ToString() != "")
                {
                    sql += "    and village = @village";
                }
                if (condition.ContainsKey("Town") && condition["Town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition.ContainsKey("Education") && condition["Education"].ToString() != "")
                {
                    sql += "    and education = @education";
                }
                if (condition.ContainsKey("Birthday_From") && condition["Birthday_From"].ToString() != "" && condition.ContainsKey("Birthday_To") && condition["Birthday_To"].ToString() != null)
                {
                    sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
                }
                if (condition.ContainsKey("Join_party_time_from") && condition["Join_party_time_from"].ToString() != "" && condition.ContainsKey("Join_party_time_to") && condition["Join_party_time_to"].ToString() != null)
                {
                    sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
                }
                if (condition.ContainsKey("Employ_date_From") && condition["Employ_date_From"].ToString() != "" && condition.ContainsKey("Employ_date_To") && condition["Employ_date_To"].ToString() != null)
                {
                    sql += " and   Employ_date BETWEEN '" + condition["Employ_date_From"].ToString() + "' AND '" + condition["Employ_date_To"].ToString() + "'";
                }
            }
            sql += " order by create_datetime desc";
            int offset = 0;
            int totalPeople = this.getTotalCount(condition);
            if (pageIndex > 1)
            {
                offset = (pageIndex - 1) * pageSize;
            }
            int limit = 1;
            int pageCount = totalPeople % pageSize > 0 ? totalPeople / pageSize + 1 : totalPeople / pageSize;
            if (pageIndex + 1 <= pageCount)
            {
                limit = pageSize;
            }
            else
            {
                limit = totalPeople - (pageCount - 1) * pageSize;
            }
            sql += "  limit  " + limit;
            sql += "  offset  " + offset;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
                parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
                parameters.Add(new SQLiteParameter("@post", condition["Post"]));
                parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
                parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@education", condition["Education"]));
                parameters.Add(new SQLiteParameter("@town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 条件查询(导出按钮使用)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllManager(Hashtable condition)
        {
            string sql = "select * from t_manager where 1 = 1";
            if (condition != null)
            {
                if (condition.ContainsKey("People_name") && condition["People_name"].ToString() != "")
                {
                    sql += "    and people_name = @people_name";
                }
                if (condition.ContainsKey("Sex") && condition["Sex"].ToString() != "")
                {
                    sql += "    and sex = @sex";
                }
                if (condition.ContainsKey("Nation") && condition["Nation"].ToString() != "")
                {
                    sql += "    and nation = @nation";
                }
                if (condition.ContainsKey(" Post") && condition["Post"].ToString() != "")
                {
                    sql += "    and Post = @Post";
                }
                if (condition.ContainsKey("Politcal_outlook") && condition["Politcal_outlook"].ToString() != "")
                {
                    sql += "    and politcal_outlook = @politcal_outlook";
                }
                if (condition.ContainsKey("Phone_number") && condition["Phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition.ContainsKey("Idcard") && condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard = @idcard";
                }
                if (condition.ContainsKey("Village") && condition["Village"].ToString() != "")
                {
                    sql += "    and village = @village";
                }
                if (condition.ContainsKey("Town") && condition["Town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition.ContainsKey("Education") && condition["Education"].ToString() != "")
                {
                    sql += "    and education = @education";
                }
                if (condition.ContainsKey("Birthday_From") && condition["Birthday_From"].ToString() != "" && condition.ContainsKey("Birthday_To") && condition["Birthday_To"].ToString() != null)
                {
                    sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
                }
                if (condition.ContainsKey("Join_party_time_from") && condition["Join_party_time_from"].ToString() != "" && condition.ContainsKey("Join_party_time_to") && condition["Join_party_time_to"].ToString() != null)
                {
                    sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
                }
                if (condition.ContainsKey("Employ_date_From") && condition["Employ_date_From"].ToString() != "" && condition.ContainsKey("Employ_date_To") && condition["Employ_date_To"].ToString() != null)
                {
                    sql += " and   Employ_date BETWEEN '" + condition["Employ_date_From"].ToString() + "' AND '" + condition["Employ_date_To"].ToString() + "'";
                }
            }
            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
                parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
                parameters.Add(new SQLiteParameter("@post", condition["Post"]));
                parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
                parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@education", condition["Education"]));
                parameters.Add(new SQLiteParameter("@town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 创建农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result CreateManager(Manager manager)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_manager");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "manager_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_manager(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "manager_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, manager.GetType().GetProperty(PropertyName).GetValue(manager, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result UpdateManager(Manager manager)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_manager");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "manager_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_manager set " + Utils.JoinStingListToString(listSetValue) + " where manager_id = " + manager.Manager_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, manager.GetType().GetProperty(PropertyName).GetValue(manager, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="manager_id"></param>
        /// <returns></returns>
        public Result DeleteManager(long manager_id)
        {
            string sql = "delete from t_manager where manager_id=" + manager_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
        public DataTable getManager(int manager_id)
        {
            string sql = "select * from t_manager where manager_id = " + manager_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public SQLStringObject ImportManagerAdd(Manager manager)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_manager");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "manager_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_manager(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "manager_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, manager.GetType().GetProperty(PropertyName).GetValue(manager, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject = new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportManager(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }
    }
}
