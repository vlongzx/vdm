using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.vdm.common;
using com.vdm.model;

using System.Collections;

using System.Data;
using System.Data.SQLite;

namespace com.vdm.dal
{
    public class VillageDAL : BaseDAL
    {
        /// <summary>
        ///  获得信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_village where 1 = 1";
            if (condition != null)
            {
                if (condition["Mechine"].ToString() != "")
                {
                    sql += "    and Mechine = @Mechine";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Villiage = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Confirm_area_From"].ToString() != "" && condition["Confirm_area_To"].ToString() != null)
                {
                    sql += "  and  Confirm_area BETWEEN '" + condition["Confirm_area_From"].ToString() + "' AND '" + condition["Confirm_area_To"].ToString() + "'";
                }
                if (condition["Factory_From"].ToString() != "" && condition["Factory_To"].ToString() != null)
                {
                    sql += "  and  Factory BETWEEN '" + condition["Factory_From"].ToString() + "' AND '" + condition["Factory_To"].ToString() + "'";
                }
                if (condition["Foreast_area_From"].ToString() != "" && condition["Foreast_area_To"].ToString() != null)
                {
                    sql += "  and  Foreast_area BETWEEN '" + condition["Foreast_area_From"].ToString() + "' AND '" + condition["Foreast_area_To"].ToString() + "'";
                }
                if (condition["Mineral_resource_From"].ToString() != "" && condition["Mineral_resource_To"].ToString() != null)
                {
                    sql += "  and  Mineral_resource BETWEEN '" + condition["Mineral_resource_From"].ToString() + "' AND '" + condition["Mineral_resource_To"].ToString() + "'";
                }
                if (condition["Money_From"].ToString() != "" && condition["Money_To"].ToString() != null)
                {
                    sql += "  and  Money BETWEEN '" + condition["Money_From"].ToString() + "' AND '" + condition["Money_To"].ToString() + "'";
                }
                if (condition["Move_area_From"].ToString() != "" && condition["Move_area_To"].ToString() != null)
                {
                    sql += "  and  Move_area BETWEEN '" + condition["Move_area_From"].ToString() + "' AND '" + condition["Move_area_To"].ToString() + "'";
                }
                if (condition["Office_From"].ToString() != "" && condition["Office_To"].ToString() != null)
                {
                    sql += "  and  Office BETWEEN '" + condition["Office_From"].ToString() + "' AND '" + condition["Office_To"].ToString() + "'";
                }
                if (condition["School_From"].ToString() != "" && condition["School_To"].ToString() != null)
                {
                    sql += "  and  School BETWEEN '" + condition["School_From"].ToString() + "' AND '" + condition["School_To"].ToString() + "'";
                }
                if (condition["Shop_From"].ToString() != "" && condition["Shop_To"].ToString() != null)
                {
                    sql += "  and  Shop BETWEEN '" + condition["Shop_From"].ToString() + "' AND '" + condition["Shop_To"].ToString() + "'";
                }
                if (condition["Water_resource_From"].ToString() != "" && condition["Water_resource_To"].ToString() != null)
                {
                    sql += "  and  Water_resource BETWEEN '" + condition["Water_resource_From"].ToString() + "' AND '" + condition["Water_resource_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Mechine", condition["Mechine"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }

        /// <summary>
        ///  获得所有农户（空条件或者条件查询）
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllVillage(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_village where 1 = 1";
            if (condition != null)
            {
                if (condition["Mechine"].ToString() != "")
                {
                    sql += "    and Mechine = @Mechine";
                }
   
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Villiage = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Confirm_area_From"].ToString() != "" && condition["Confirm_area_To"].ToString() != null)
                {
                    sql += "  and  Confirm_area BETWEEN '" + condition["Confirm_area_From"].ToString() + "' AND '" + condition["Confirm_area_To"].ToString() + "'";
                }
                if (condition["Factory_From"].ToString() != "" && condition["Factory_To"].ToString() != null)
                {
                    sql += "  and  Factory BETWEEN '" + condition["Factory_From"].ToString() + "' AND '" + condition["Factory_To"].ToString() + "'";
                }
                if (condition["Foreast_area_From"].ToString() != "" && condition["Foreast_area_To"].ToString() != null)
                {
                    sql += "  and  Foreast_area BETWEEN '" + condition["Foreast_area_From"].ToString() + "' AND '" + condition["Foreast_area_To"].ToString() + "'";
                }
                if (condition["Mineral_resource_From"].ToString() != "" && condition["Mineral_resource_To"].ToString() != null)
                {
                    sql += "  and  Mineral_resource BETWEEN '" + condition["Mineral_resource_From"].ToString() + "' AND '" + condition["Mineral_resource_To"].ToString() + "'";
                }
                if (condition["Money_From"].ToString() != "" && condition["Money_To"].ToString() != null)
                {
                    sql += "  and  Money BETWEEN '" + condition["Money_From"].ToString() + "' AND '" + condition["Money_To"].ToString() + "'";
                }
                if (condition["Move_area_From"].ToString() != "" && condition["Move_area_To"].ToString() != null)
                {
                    sql += "  and  Move_area BETWEEN '" + condition["Move_area_From"].ToString() + "' AND '" + condition["Move_area_To"].ToString() + "'";
                }
                if (condition["Office_From"].ToString() != "" && condition["Office_To"].ToString() != null)
                {
                    sql += "  and  Office BETWEEN '" + condition["Office_From"].ToString() + "' AND '" + condition["Office_To"].ToString() + "'";
                }
                if (condition["School_From"].ToString() != "" && condition["School_To"].ToString() != null)
                {
                    sql += "  and  School BETWEEN '" + condition["School_From"].ToString() + "' AND '" + condition["School_To"].ToString() + "'";
                }
                if (condition["Shop_From"].ToString() != "" && condition["Shop_To"].ToString() != null)
                {
                    sql += "  and  Shop BETWEEN '" + condition["Shop_From"].ToString() + "' AND '" + condition["Shop_To"].ToString() + "'";
                }
                if (condition["Water_resource_From"].ToString() != "" && condition["Water_resource_To"].ToString() != null)
                {
                    sql += "  and  Water_resource BETWEEN '" + condition["Water_resource_From"].ToString() + "' AND '" + condition["Water_resource_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";
            int offset = 0;
            int totalPeople = this.getTotalCount(condition);
            if (pageIndex > 1)
            {
                offset = (pageIndex - 1) * pageSize;
            }
            int limit = 1;
            int pageCount = totalPeople % pageSize > 0 ? totalPeople / pageSize + 1 : totalPeople / pageSize;
            if (pageIndex + 1 <= pageCount)
            {
                limit = pageSize;
            }
            else
            {
                limit = totalPeople - (pageCount - 1) * pageSize;
            }
            sql += "  limit  " + limit;
            sql += "  offset  " + offset;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Mechine", condition["Mechine"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 条件查询(导出按钮使用)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllVillage(Hashtable condition)
        {
            string sql = "select * from t_village where 1 = 1";
            if (condition != null)
            {
                if (condition["Mechine"].ToString() != "")
                {
                    sql += "    and Mechine = @Mechine";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Villiage = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Confirm_area_From"].ToString() != "" && condition["Confirm_area_To"].ToString() != null)
                {
                    sql += "  and  Confirm_area BETWEEN '" + condition["Confirm_area_From"].ToString() + "' AND '" + condition["Confirm_area_To"].ToString() + "'";
                }
                if (condition["Factory_From"].ToString() != "" && condition["Factory_To"].ToString() != null)
                {
                    sql += "  and  Factory BETWEEN '" + condition["Factory_From"].ToString() + "' AND '" + condition["Factory_To"].ToString() + "'";
                }
                if (condition["Foreast_area_From"].ToString() != "" && condition["Foreast_area_To"].ToString() != null)
                {
                    sql += "  and  Foreast_area BETWEEN '" + condition["Foreast_area_From"].ToString() + "' AND '" + condition["Foreast_area_To"].ToString() + "'";
                }
                if (condition["Mineral_resource_From"].ToString() != "" && condition["Mineral_resource_To"].ToString() != null)
                {
                    sql += "  and  Mineral_resource BETWEEN '" + condition["Mineral_resource_From"].ToString() + "' AND '" + condition["Mineral_resource_To"].ToString() + "'";
                }
                if (condition["Money_From"].ToString() != "" && condition["Money_To"].ToString() != null)
                {
                    sql += "  and  Money BETWEEN '" + condition["Money_From"].ToString() + "' AND '" + condition["Money_To"].ToString() + "'";
                }
                if (condition["Move_area_From"].ToString() != "" && condition["Move_area_To"].ToString() != null)
                {
                    sql += "  and  Move_area BETWEEN '" + condition["Move_area_From"].ToString() + "' AND '" + condition["Move_area_To"].ToString() + "'";
                }
                if (condition["Office_From"].ToString() != "" && condition["Office_To"].ToString() != null)
                {
                    sql += "  and  Office BETWEEN '" + condition["Office_From"].ToString() + "' AND '" + condition["Office_To"].ToString() + "'";
                }
                if (condition["School_From"].ToString() != "" && condition["School_To"].ToString() != null)
                {
                    sql += "  and  School BETWEEN '" + condition["School_From"].ToString() + "' AND '" + condition["School_To"].ToString() + "'";
                }
                if (condition["Shop_From"].ToString() != "" && condition["Shop_To"].ToString() != null)
                {
                    sql += "  and  Shop BETWEEN '" + condition["Shop_From"].ToString() + "' AND '" + condition["Shop_To"].ToString() + "'";
                }
                if (condition["Water_resource_From"].ToString() != "" && condition["Water_resource_To"].ToString() != null)
                {
                    sql += "  and  Water_resource BETWEEN '" + condition["Water_resource_From"].ToString() + "' AND '" + condition["Water_resource_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";
      
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Mechine", condition["Mechine"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 创建农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result CreateVillage(Village village)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_village");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "village_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_village(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "village_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, village.GetType().GetProperty(PropertyName).GetValue(village, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result UpdateVillage(Village village)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_village");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "village_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_village set " + Utils.JoinStingListToString(listSetValue) + " where village_id = " + village.Village_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, village.GetType().GetProperty(PropertyName).GetValue(village, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="village_id"></param>
        /// <returns></returns>
        public Result DeleteVillage(long village_id)
        {
            string sql = "delete from t_village where village_id=" + village_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
        public DataTable getVillage(int village_id)
        {
            string sql = "select * from t_village where village_id = " + village_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public SQLStringObject ImportVillageAdd(Village village)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_village");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "village_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_village(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "village_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, village.GetType().GetProperty(PropertyName).GetValue(village, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject = new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportVillage(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }
    }
}
