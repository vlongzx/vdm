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
            string schemaSql = "select * from t_people where 1=0";
            DataTable tblSchema = this.sqlDB.GetTableSchema(schemaSql);
            if(tblSchema != null)
            {
                foreach(DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if(row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_people("+ Utils.JoinStingListToString(listColumnName) + ") values("+ Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List <SQLiteParameter> parameters = new List<SQLiteParameter>();
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
                    parameter = new SQLiteParameter("@"+ ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
            }

            return  this.sqlDB.ExecuteNonQuery(sql,CommandType.Text,parameters);
        }
    }
}
