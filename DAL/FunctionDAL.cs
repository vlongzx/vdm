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
        ///  查询所有的权限树列表
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllFunction()
        {
            string sql = "select * from t_function";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 根据父功能权限ID获得其下的所有子功能权限
        /// </summary>
        /// <param name="pre_function_id">父功能权限ID</param>
        /// <returns></returns>
        public DataTable queryFunctionBypreFunctionID(string pre_function_id)
        {
            string sql = "select * from t_function where pre_function_id='" + pre_function_id + "'";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

            public DataTable queryFunctionBypreFunctionCode(string function_code)
        {
            string sql = "select * from t_function where function_code='" + function_code + "'";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
    }
}
