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
    public class PeopleDAL
    {
        private SqlDbHelper sqlDB;

        public PeopleDAL()
        {
            this.sqlDB = new SqlDbHelper();
        }

        /// <summary>
        ///  获取所有的人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable getAllPeople()
        {
            string sql = "select * from t_people order by create_datetime desc";

            return this.sqlDB.ExecuteDataTable(sql);
        }

        public DataTable getAllPeople(People people)
        {
            string sql = "select * from t_people where 1 = 1";
            if(people.People_name != "")
            {
                sql += "    and people_name = @people_name";
            }
            if (people.Sex != "")
            {
                sql += "    and sex = @sex";
            }
            if (people.Politcal_outlook != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (people.Phone_number != "")
            {
                sql += "    and phone_number = @phone_number";
            }
            if (people.Idcard != "")
            {
                sql += "    and idcard = @idcard";
            }
            if (people.Religious_belief != "")
            {
                sql += "    and religious_belief = @religious_belief";
            }
            if (people.Education != "")
            {
                sql += "    and education = @education";
            }
            sql +=" order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", people.People_name));
            parameters.Add(new SQLiteParameter("@sex", people.Sex));
            parameters.Add(new SQLiteParameter("@politcal_outlook", people.Politcal_outlook));
            parameters.Add(new SQLiteParameter("@phone_number", people.Phone_number));
            parameters.Add(new SQLiteParameter("@idcard", people.Idcard));
            parameters.Add(new SQLiteParameter("@religious_belief", people.Religious_belief));
            parameters.Add(new SQLiteParameter("@education", people.Education));

            return this.sqlDB.ExecuteDataTable(sql,CommandType.Text, parameters);
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
