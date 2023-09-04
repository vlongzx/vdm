using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.vdm.common;
using com.vdm.model;

using System.Collections;

using System.Data;

using com.vdm.dal;

namespace com.vdm.bll
{
    public class ManagerBLL
    {
        private ManagerDAL managerDAL = null;

        public ManagerBLL()
        {
            this.managerDAL = new ManagerDAL();
        }
        //public int getTotalManager()
        //{
        //    return this.managerDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalManagerCount(Hashtable conditon)
        {
            return this.managerDAL.getTotalCount(conditon);
        }
        public DataTable getAllManagerDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            DataTable dt = this.managerDAL.queryAllManager(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddManager(Manager manager)
        {
            return this.managerDAL.CreateManager(manager);
        }
        public Result EditManager(Manager manager)
        {
            return this.managerDAL.UpdateManager(manager);
        }

        public Result DelManager(long manager_id)
        {
            return this.managerDAL.DeleteManager(manager_id);
        }
        /// <summary>
        ///  根据manager_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Manager getManager(int manager_id)
        {
            DataTable dt = this.managerDAL.getManager(manager_id);
            Manager manager = new Manager();
            DataTable tblSchema = this.managerDAL.getTableSchema("t_manager");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        manager.GetType().GetProperty(PropertyName).SetValue(manager, string.Empty);
                    }
                    else
                    {
                        manager.GetType().GetProperty(PropertyName).SetValue(manager, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return manager;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable getAllManager(Hashtable condition)
        {
            List<Manager> list_manager = new List<Manager>();
            DataTable dt = this.managerDAL.getAllManager(condition);
            return dt;
        }

        public SQLStringObject ImportManagerAdd(Manager manager)
        {
            return this.managerDAL.ImportManagerAdd(manager);
        }
        public Result ImportManager(List<SQLStringObject> SQLStringObjectList)
        {
            return this.managerDAL.ImportManager(SQLStringObjectList);
        }
    }
}
