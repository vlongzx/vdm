using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class OrgDAL
    {
        private SqlDbHelper sqlDB;

        public OrgDAL()
        {
            this.sqlDB = new SqlDbHelper();
        }
        public DataTable getAllOrg()
        {
            string sql = "select * from t_org";

            return this.sqlDB.ExecuteDataTable(sql);
        }
        /// <summary>
        ///  根据组织类型获取组织信息
        /// </summary>
        /// <param name="org_type">组织类型</param>
        /// <returns></returns>
        public DataTable getOrgByType(string org_type)
        {
            string sql = "select * from t_org where org_type = '" + org_type + "'";

            return this.sqlDB.ExecuteDataTable(sql);
        }

        /// <summary>
        ///  根据乡镇ID获得对于的村信息
        /// </summary>
        /// <param name="org_pre_id"></param>
        /// <returns></returns>
        public DataTable getOrgByTown(string org_pre_id)
        {
            string sql = "select * from t_org where org_pre_id = '" + org_pre_id+"'" ;

            return this.sqlDB.ExecuteDataTable(sql);
        }
        /// <summary>
        ///  根据org_code获得id
        /// </summary>
        /// <param name="org_code"></param>
        /// <returns></returns>
        public string  getOrgIdByOrgCode(string org_code)
        {
            string sql = "select org_id from t_org where org_code = '" + org_code + "'";
            DataTable dt = this.sqlDB.ExecuteDataTable(sql);
            if(dt != null && dt.Rows.Count>0)
            {
                return dt.Rows[0]["org_id"].ToString();
            }
            return "0";
        }
    }
}
