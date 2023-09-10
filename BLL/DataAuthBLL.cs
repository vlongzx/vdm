using com.vdm.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
    public class DataAuthBLL
    {
        private DataAuthDAL  dataAuthDAL = null;

        public DataAuthBLL()
        {
            this.dataAuthDAL = new DataAuthDAL();
        }
        /// <summary>
        ///  获得所有的数据权限
        /// </summary>
        /// <returns></returns>
        public DataTable getAllDataAuth()
        {
            return this.dataAuthDAL.queryAllDataAuth();
        }

        public DataTable getDataAuthByType(string type)
        {
            return this.dataAuthDAL.queryDataAuthByType(type);
        }
    }
}
