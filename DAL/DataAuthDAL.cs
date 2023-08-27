using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class DataAuthDAL:BaseDAL
    {
        /// <summary>
        ///  获取所有的数据权限
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllDataAuth()
        {
            string sql = "select * from t_data_authority";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
    }
}
