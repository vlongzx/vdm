using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class RoleDAL:BaseDAL
    {
        /// <summary>
        ///  获得所有角色
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllRole()
        {
            string sql = "select * from t_role";

            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
    }
}
