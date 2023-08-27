using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class DictDAL
    {
        private SqlDbHelper sqlDB;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DictDAL()
        {
            this.sqlDB = new SqlDbHelper();
        }
        /// <summary>
        ///  根据字典项标识获得键值对
        /// </summary>
        /// <param name="dict_code">字典项标识</param>
        /// <returns>
        /// 键值对数据表
        /// </returns>
        public DataTable getDict(string dict_code)
        {
            string sql = "select key,value from t_dict where dict_code  in ( '"+ dict_code +"','common')";
            sql += " order by `index` asc";
            return this.sqlDB.ExecuteDataTable(sql);
        }
    }
}
