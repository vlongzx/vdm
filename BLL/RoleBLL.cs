using com.vdm.dal;
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
    }
}
