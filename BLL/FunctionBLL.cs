using com.vdm.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
    public class FunctionBLL
    {
        private FunctionDAL functionDAL = null;

        public  FunctionBLL()
        {
            this.functionDAL = new FunctionDAL();
        }
        /// <summary>
        ///  获得所有的功能权限
        /// </summary>
        /// <returns></returns>
        public DataTable getAllFunction()
        {
            return this.functionDAL.queryAllFunction();
        }

        /// <summary>
        ///  根据父功能权限ID获得其下的所有子功能权限
        /// </summary>
        /// <param name="pre_function_id">父功能权限ID</param>
        /// <returns></returns>
        public DataTable getFunctionBypreFunctionID(string pre_function_id)
        {
            return this.functionDAL.queryFunctionBypreFunctionID(pre_function_id);
        }

        public DataTable getFunctionBypreFunctionCode(string function_code)
        {
            return this.functionDAL.queryFunctionBypreFunctionCode(function_code);
        }
    }
}
