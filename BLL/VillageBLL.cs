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
    public class VillageBLL
    {
        private VillageDAL villageDAL = null;

        public VillageBLL()
        {
            this.villageDAL = new VillageDAL();
        }
        //public int getTotalVillage()
        //{
        //    return this.villageDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalVillageCount(Hashtable conditon)
        {
            return this.villageDAL.getTotalCount(conditon);
        }
        public DataTable getAllVillageDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            DataTable dt = this.villageDAL.queryAllVillage(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddVillage(Village village)
        {
            return this.villageDAL.CreateVillage(village);
        }
        public Result EditVillage(Village village)
        {
            return this.villageDAL.UpdateVillage(village);
        }

        public Result DelVillage(long village_id)
        {
            return this.villageDAL.DeleteVillage(village_id);
        }
        /// <summary>
        ///  根据village_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Village getVillage(int village_id)
        {
            DataTable dt = this.villageDAL.getVillage(village_id);
            Village village = new Village();
            DataTable tblSchema = this.villageDAL.getTableSchema("t_village");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        village.GetType().GetProperty(PropertyName).SetValue(village, string.Empty);
                    }
                    else
                    {
                        village.GetType().GetProperty(PropertyName).SetValue(village, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return village;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable getAllVillage(Hashtable condition)
        {
            List<Village> list_village = new List<Village>();
            DataTable dt = this.villageDAL.getAllVillage(condition);
            return dt;
        }

        public SQLStringObject ImportVillageAdd(Village village)
        {
            return this.villageDAL.ImportVillageAdd(village);
        }
        public Result ImportVillage(List<SQLStringObject> SQLStringObjectList)
        {
            return this.villageDAL.ImportVillage(SQLStringObjectList);
        }
    }
}
