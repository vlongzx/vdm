using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class BaseDAL
    {
        private SqlDbHelper sqlDbHelper;

        public BaseDAL()
        {
            this.sqlDbHelper = new SqlDbHelper();
        }
        /// <summary>
        ///  获得数据库操作类对象
        /// </summary>
        public SqlDbHelper SqlDbHelper
        {
            get
            {
                return sqlDbHelper;
            }
        }

        /// <summary>
        ///  获得表结构
        /// </summary>
        /// <returns></returns>
        public DataTable getTableSchema(string table_name)
        {
            string schemaSql = "select * from " + table_name + " where 1=0";
            DataTable tblSchema = this.SqlDbHelper.GetTableSchema(schemaSql);
            return tblSchema;
        }
    }
}
