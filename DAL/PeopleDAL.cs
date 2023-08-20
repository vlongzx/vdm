using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
