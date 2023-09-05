using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
    public class OrgBLL
    {
        private OrgDAL orgDAL;

        public OrgBLL()
        {
            this.orgDAL = new OrgDAL();
        }
        public List<Org> getAllOrg()
        {
            List<Org> list_org = new List<Org>();
            DataTable dt = this.orgDAL.getAllOrg();
            if (dt != null)
            {
                Org org = null;
                foreach (DataRow row in dt.Rows)
                {
                    org = new Org();
                    org.Org_id = int.Parse(row["org_id"].ToString());
                    org.Org_name = row["org_name"].ToString();
                    org.Org_type = row["org_type"].ToString();
                    org.Org_pre_id = int.Parse(row["org_pre_id"].ToString());
                    list_org.Add(org);
                }
            }
            return list_org;
        }
        /// <summary>
        ///  根据组织类型获取组织信息
        /// </summary>
        /// <param name="org_type">组织类型</param>
        /// <returns></returns>
        public List<KeyValue> getOrgByType(string org_type)
        {
            List<KeyValue> list_org = new List<KeyValue>();
            DataTable dt = this.orgDAL.getOrgByType(org_type);
            if (dt != null)
            {
                KeyValue kv = null;
                foreach (DataRow row in dt.Rows)
                {
                    kv = new KeyValue(row["org_code"].ToString(), row["org_name"].ToString());
                    list_org.Add(kv);
                }
            }
            return list_org;
        }

        /// <summary>
        ///  根据乡镇ID获得管辖的村列表
        /// </summary>
        /// <param name="org_pre_id"></param>
        /// <returns></returns>
        public List<KeyValue> getOrgByTown(int org_pre_id)
        {
            List<KeyValue> list_org = new List<KeyValue>();
            DataTable dt = this.orgDAL.getOrgByTown(org_pre_id);
            if (dt != null)
            {
                KeyValue kv = null;
                foreach (DataRow row in dt.Rows)
                {
                    kv = new KeyValue(row["org_code"].ToString(), row["org_name"].ToString());
                    list_org.Add(kv);
                }
            }
            return list_org;
        }
        /// <summary>
        ///  根据org_code获得id
        /// </summary>
        /// <param name="org_code"></param>
        /// <returns></returns>
        public int getOrgIdByOrgCode(string org_code)
        {
            return this.orgDAL.getOrgIdByOrgCode(org_code);
        }
    }
}
