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
    }
}
