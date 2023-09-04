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
  public  class HouseBLL
    {
        private HouseDAL houseDAL = null;

        public HouseBLL()
        {
            this.houseDAL = new HouseDAL();
        }
        //public int getTotalHouse()
        //{
        //    return this.houseDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalHouseCount(Hashtable conditon)
        {
            return this.houseDAL.getTotalCount(conditon);
        }
        public DataTable getAllHouseDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            DataTable dt = this.houseDAL.queryAllHouse(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddHouse(House house)
        {
            return this.houseDAL.CreateHouse(house);
        }
        public Result EditHouse(House house)
        {
            return this.houseDAL.UpdateHouse(house);
        }

        public Result DelHouse(long house_id)
        {
            return this.houseDAL.DeleteHouse(house_id);
        }
        /// <summary>
        ///  根据house_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public House getHouse(int house_id)
        {
            DataTable dt = this.houseDAL.getHouse(house_id);
            House house = new House();
            DataTable tblSchema = this.houseDAL.getTableSchema("t_house");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        house.GetType().GetProperty(PropertyName).SetValue(house, string.Empty);
                    }
                    else
                    {
                        house.GetType().GetProperty(PropertyName).SetValue(house, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return house;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable getAllHouse(Hashtable condition)
        {
            List<House> list_house = new List<House>();
            DataTable dt = this.houseDAL.getAllHouse(condition);
            return dt;
        }

        public SQLStringObject ImportHouseAdd(House house)
        {
            return this.houseDAL.ImportHouseAdd(house);
        }
        public Result ImportHouse(List<SQLStringObject> SQLStringObjectList)
        {
            return this.houseDAL.ImportHouse(SQLStringObjectList);
        }
    }
}
