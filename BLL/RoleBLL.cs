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
    public class RoleBLL
    {
        private RoleDAL roleDAL = null;
        public RoleBLL()
        {
            this.roleDAL = new RoleDAL();
        }

        public DataTable getAllRole()
        {
            return this.roleDAL.queryAllRole();
        }

        public DataTable getRoleFuncPower(string role_id)
        {
            return this.roleDAL.queryRoleFuncPower(role_id);
        }

        public Result delRole(int role_id)
        {
            return this.roleDAL.deleteRole(role_id);
        }

        public Result editRole(Role role, List<string> ListFunction_ID)
        {
            return this.roleDAL.updateRole(role, ListFunction_ID);
        }


        public Result addRole(Role role,List<string> listKV)
        {
            return this.roleDAL.createRole(role, listKV);
        }

        public Role getRole(string  role_id)
        {
            DataTable dt = this.roleDAL.queryRole(role_id);
            Role role = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                role = new Role();
                role.Role_id = role_id;
                role.Role_name = dt.Rows[0]["role_name"].ToString();
                role.Role_type = dt.Rows[0]["role_type"].ToString();
                role.Remark = dt.Rows[0]["remark"].ToString();
            }

            return role;
        }
    }
}
