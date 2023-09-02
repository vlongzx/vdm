using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
 public   class LandBLL
    {
        private LandDAL landDAL = null;

        public LandBLL()
        {
            this.landDAL = new LandDAL();
        }
        //public int getTotalLand()
        //{
        //    return this.landDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalLandCount(Hashtable conditon)
        {
            return this.landDAL.getTotalCount(conditon);
        }
        public DataTable getAllLandDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            DataTable dt = this.landDAL.queryAllLand(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddLand(Land land)
        {
            return this.landDAL.CreateLand(land);
        }
        public Result EditLand(Land land)
        {
            return this.landDAL.UpdateLand(land);
        }

        public Result DelLand(long land_id)
        {
            return this.landDAL.DeleteLand(land_id);
        }
        /// <summary>
        ///  根据land_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Land getLand(int land_id)
        {
            DataTable dt = this.landDAL.getLand(land_id);
            Land land = new Land();
            DataTable tblSchema = this.landDAL.getTableSchema("t_land");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        land.GetType().GetProperty(PropertyName).SetValue(land, string.Empty);
                    }
                    else
                    {
                        land.GetType().GetProperty(PropertyName).SetValue(land, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return land;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Land> getAllLand(Hashtable condition)
        {
            List<Land> list_land = new List<Land>();
            DataTable dt = this.landDAL.getAllLand(condition);
            if (dt != null)
            {
                Land p = null;
                foreach (DataRow row in dt.Rows)
                {
                //    p = MakeObject.MakeObjectToLand(row);
                    list_land.Add(p);
                }
            }
            return list_land;
        }

        public SQLStringObject ImportLandAdd(Land land)
        {
            return this.landDAL.ImportLandAdd(land);
        }
        public Result ImportLand(List<SQLStringObject> SQLStringObjectList)
        {
            return this.landDAL.ImportLand(SQLStringObjectList);
        }
    }
}

