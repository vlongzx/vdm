using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class FunctionDAL:BaseDAL
    {
        public FunctionDAL()
        {

        }
        /// <summary>
        ///  查询所有的功能权限
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllFunction()
        {
            string sql = "select * from t_function";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
    }
}
