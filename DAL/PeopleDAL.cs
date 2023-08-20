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
            string sql = "insert into t_people(farmer_id,people_name,idcard,relationship,statues) values(@farmer_id,@people_name,@idcard,@relationship,@statues)";
            SQLiteParameter parameter = null;
            List <SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameter = new SQLiteParameter("@farmer_id", people.Farmer_id);
            parameters.Add(parameter);

            parameter = new SQLiteParameter("@people_name", people.People_name);
            parameters.Add(parameter);

            parameter = new SQLiteParameter("@idcard", people.Idcard);
            parameters.Add(parameter);

            parameter = new SQLiteParameter("@relationship", people.Relationship);
            parameters.Add(parameter);

            parameter = new SQLiteParameter("@statues", people.Statues);
            parameters.Add(parameter);

            return  this.sqlDB.ExecuteNonQuery(sql,CommandType.Text,parameters);
        }
    }
}
