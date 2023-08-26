using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class PeopleDAL
    {
        private SqlDbHelper sqlDB;

        public PeopleDAL()
        {
            this.sqlDB = new SqlDbHelper();
        }

        /// <summary>
        /// 获取所有人员个数
        /// </summary>
        /// <returns></returns>
        public int getTotalPeople()
        {
            string sql = "select * from t_people  order by create_datetime desc";
            DataTable dt = this.sqlDB.ExecuteDataTable(sql);
            if(dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        /// 获取条件查询所有人员个数
        /// </summary>
        /// <returns></returns>
        public int getTotalPeopleIf(Hashtable condition)
        {
            string sql = "select * from t_people where 1 = 1";
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name = @people_name";
            }
            if (condition["Sex"].ToString() != "")
            {
                sql += "    and sex = @sex";
            }
            if (condition["Nation"].ToString() != "")
            {
                sql += "    and nation = @nation";
            }
            if (condition["Relationship"].ToString() != "")
            {
                sql += "    and relationship = @relationship";
            }
            if (condition["Politcal_outlook"].ToString() != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (condition["Phone_number"].ToString() != "")
            {
                sql += "    and phone_number = @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard = @idcard";
            }
            if (condition["Religious_belief"].ToString() != "")
            {
                sql += "    and religious_belief = @religious_belief";
            }
            if (condition["Education"].ToString() != "")
            {
                sql += "    and education = @education";
            }
            if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
            {
                sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
            }
            if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
            {
                sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
            }
            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
            parameters.Add(new SQLiteParameter("@nation", condition["nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
            parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
            parameters.Add(new SQLiteParameter("@religious_belief", condition["Religious_belief"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));

            DataTable dt = this.sqlDB.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        ///  分页查询获取所有的人员信息(空条件查询，重置按钮等使用)
        /// </summary>
        /// <returns></returns>
        public DataTable getAllPeople(int pageIndex, int pageSize)
        {
            int offset = 0;
            int totalPeople = this.getTotalPeople();
            if (pageIndex > 1)
            {
                offset =  (pageIndex-1)* pageSize;
            }
            int limit = 1;
            int pageCount = totalPeople % pageSize > 0 ? totalPeople / pageSize + 1 : totalPeople / pageSize;
            if (pageIndex+1 <=  pageCount)
            {
                limit = pageSize;
            }
            else
            {
                limit = totalPeople - (pageCount - 1) * pageSize;
            }
            string sql =  "select * from t_people order by create_datetime desc LIMIT " + limit + " OFFSET " + offset + " ";
            DataTable dt = this.sqlDB.ExecuteDataTable(sql);
            return dt;
        }



        /// <summary>
        /// 条件+分页 查询人员信息（查询按钮使用）
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllPeople(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_people where 1 = 1";
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name = @people_name";
            }
            if (condition["Sex"].ToString() != "")
            {
                sql += "    and sex = @sex";
            }
            if (condition["Nation"].ToString() != "")
            {
                sql += "    and nation = @nation";
            }
            if (condition["Relationship"].ToString() != "")
            {
                sql += "    and relationship = @relationship";
            }
            if (condition["Politcal_outlook"].ToString() != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (condition["Phone_number"].ToString() != "")
            {
                sql += "    and phone_number = @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard = @idcard";
            }
            if (condition["Religious_belief"].ToString() != "")
            {
                sql += "    and religious_belief = @religious_belief";
            }
            if (condition["Education"].ToString() != "")
            {
                sql += "    and education = @education";
            }
            if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
            {
                sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
            }
            if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
            {
                sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
            }

            sql += " order by create_datetime desc";
            int offset = 0;
            int totalPeople = this.getTotalPeopleIf(condition);
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
            sql += "  limit  "+limit;
            sql += "  offset  "+offset;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
            parameters.Add(new SQLiteParameter("@nation", condition["nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
            parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
            parameters.Add(new SQLiteParameter("@religious_belief", condition["Religious_belief"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));

            return this.sqlDB.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 条件查询(导出按钮使用)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllPeople(Hashtable condition)
        {
            string sql = "select * from t_people where 1 = 1";
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name = @people_name";
            }
            if (condition["Sex"].ToString() != "")
            {
                sql += "    and sex = @sex";
            }
            if (condition["Nation"].ToString() != "")
            {
                sql += "    and nation = @nation";
            }
            if (condition["Relationship"].ToString() != "")
            {
                sql += "    and relationship = @relationship";
            }
            if (condition["Politcal_outlook"].ToString() != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (condition["Phone_number"].ToString() != "")
            {
                sql += "    and phone_number = @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard = @idcard";
            }
            if (condition["Religious_belief"].ToString() != "")
            {
                sql += "    and religious_belief = @religious_belief";
            }
            if (condition["Education"].ToString() != "")
            {
                sql += "    and education = @education";
            }
            if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
            {
                sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
            }
            if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
            {
                sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
            }

            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
            parameters.Add(new SQLiteParameter("@nation", condition["nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
            parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
            parameters.Add(new SQLiteParameter("@religious_belief", condition["Religious_belief"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));

            return  this.sqlDB.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        public DataTable getPeople(int people_id)
        {
            string sql = "select * from t_people where people_id = " + people_id;
            return this.sqlDB.ExecuteDataTable(sql);
        }

        /// <summary>
        ///  获得表结构
        /// </summary>
        /// <returns></returns>
        public DataTable getTableSchema()
        {
            string schemaSql = "select * from t_people where 1=0";
            DataTable tblSchema = this.sqlDB.GetTableSchema(schemaSql);
            return tblSchema;
        }


        /// <summary>
        ///  创建一个人员信息
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public Result CreatePeople(People people)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_people(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
            }

            return this.sqlDB.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public Result UpdatePeople(People people)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_people set " + Utils.JoinStingListToString(listSetValue) + " where people_id = " + people.People_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
               
            }
            return this.sqlDB.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }


        public Result DeletePeople(long people_id)
        {
            string sql = "delete from t_people where people_id="+ people_id;
            return this.sqlDB.ExecuteNonQuery(sql);
        }
    }
}
