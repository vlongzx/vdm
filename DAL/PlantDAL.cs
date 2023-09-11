using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class PlantDAL:BaseDAL
    {
        /// <summary>
        ///  根据条件查询种植信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面显示记录数</param>
        /// <returns></returns>
        public DataTable queryAllPlant(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_plant where 1 = 1";
            List<SQLiteParameter> parameters = null;
            sql += this.getConditonSql(condition, pageIndex, pageSize, 1, out parameters);
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 根据条件获得所有的种植信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public DataTable queryAllPlant(Hashtable condition)
        {
            string sql = "select * from t_plant where 1 = 1";
            List<SQLiteParameter> parameters = null;
            sql += this.getConditonSql(condition, 0, 0, 0, out parameters);
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        ///  生成查询条件和分页部分的SQL语句
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">页面索引，默认为0</param>
        /// <param name="pageSize">页面记录数，默认为0</param>
        /// <param name="mode">模式，0表示不分页，1表示分页</param>
        /// <param name="parameters">输出参数，SQL参数列表</param>
        /// <returns></returns>
        private string getConditonSql(Hashtable condition, int pageIndex, int pageSize, int mode, out List<SQLiteParameter> parameters)
        {
            string sql = "";
            if (condition != null)
            {
                if (condition["plant_area"].ToString() != "0")
                {
                    sql += "    and plant_area = @plant_area";
                }
                if (condition["plant_brand"].ToString() != "")
                {
                    sql += "    and plant_brand = @plant_brand";
                }
                if (condition["plant_type"].ToString() != "")
                {
                    sql += "    and plant_type = @plant_type";
                }
                if (condition["contact_person"].ToString() != "")
                {
                    sql += "    and contact_person like @contact_person";
                }
                if (condition["phone_number"].ToString() != "")
                {
                    sql += "    and phone_number like @phone_number";
                }
                if (condition["address"].ToString() != "")
                {
                    sql += "    and address like @address";
                }
                if (condition["is_plan"].ToString() != "")
                {
                    sql += "    and is_plan = @is_plan";
                }
                if (condition["sale_way"].ToString() != "")
                {
                    sql += "    and sale_way = @sale_way";
                }
                if (condition["output"].ToString() != "0")
                {
                    sql += "    and output = @output";
                }
                if (condition["insect_ill"].ToString() != "")
                {
                    sql += "    and insect_ill = @insect_ill";
                }
                if (condition["manage_skill_method"].ToString() != "")
                {
                    sql += "    and manage_skill_method = @manage_skill_method";
                }
                if (condition["develop_willing"].ToString() != "")
                {
                    sql += "    and develop_willing = @develop_willing";
                }

                if (condition["town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["village"].ToString() != "")
                {
                    sql += "    and village = @village";
                }
                if (condition["year_yield_from"].ToString() != "0" && condition["year_yield_to"].ToString() != "0")
                {
                    sql += "  and  year_yield BETWEEN '" + condition["year_yield_from"].ToString() + "' AND '" + condition["year_yield_to"].ToString() + "'";
                }
            }
            sql += " order by create_datetime desc";
            if(mode == 1)
            {
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
            }
            
            parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@plant_area", condition["plant_area"]));
                parameters.Add(new SQLiteParameter("@plant_brand", condition["plant_brand"]));
                parameters.Add(new SQLiteParameter("@plant_type", condition["plant_type"]));
                parameters.Add(new SQLiteParameter("@contact_person", "%"+condition["contact_person"]+"%"));
                parameters.Add(new SQLiteParameter("@phone_number", "%"+condition["phone_number"]+"%"));
                parameters.Add(new SQLiteParameter("@address", "%"+condition["address"]+"%"));
                parameters.Add(new SQLiteParameter("@is_plan", condition["is_plan"]));
                parameters.Add(new SQLiteParameter("@sale_way", condition["sale_way"]));
                parameters.Add(new SQLiteParameter("@output", condition["output"]));
                parameters.Add(new SQLiteParameter("@insect_ill", condition["insect_ill"]));
                parameters.Add(new SQLiteParameter("@manage_skill_method",condition["manage_skill_method"]));
                parameters.Add(new SQLiteParameter("@develop_willing", condition["develop_willing"]));
                parameters.Add(new SQLiteParameter("@town", condition["town"]));
                parameters.Add(new SQLiteParameter("@village", condition["village"]));

            }
            return sql;
        }
        /// <summary>
        ///  查询种植信息
        /// </summary>
        /// <param name="tour_id">种植信息ID</param>
        /// <returns></returns>
        public DataTable queryPlant(int plant_id)
        {
            string sql = "select * from t_plant where plant_id = " + plant_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 根据提交获得种植记录数
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_plant where 1 = 1";
            List<SQLiteParameter> parameters = null;
            sql += this.getConditonSql(condition, 0, 0, 0, out parameters);
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        ///  创建种植信息
        /// </summary>
        /// <param name="plant">种植信息对象</param>
        /// <returns></returns>
        public Result createPlant(Plant plant)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_plant");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "plant_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_plant(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "plant_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, plant.GetType().GetProperty(PropertyName).GetValue(plant, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 批量创建种植信息
        /// </summary>
        /// <param name="plants">种植信息对象列表</param>
        /// <returns></returns>
        public Result batchCreatePlant(List<Plant> plants)
        {
            List<SQLStringObject> SQLStringObjectList = null;
            if (plants != null)
            {
                SQLStringObjectList = new List<SQLStringObject>();
                SQLStringObject sqlStringObject = null;
                foreach (Plant plant in plants)
                {
                    //构建sql语句
                    List<string> listColumnName = new List<string>();
                    List<string> listParameter = new List<string>();
                    DataTable tblSchema = this.getTableSchema("t_plant");
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            //过滤掉主键
                            if (row["ColumnName"].ToString() == "plant_id")
                            {
                                continue;
                            }
                            listColumnName.Add(row["ColumnName"].ToString());
                            listParameter.Add("@" + row["ColumnName"].ToString());
                        }
                    }
                    string sql = "insert into t_plant(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

                    //构建参数值
                    SQLiteParameter parameter = null;
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            if (row["ColumnName"].ToString() == "plant_id")
                            {
                                continue;
                            }
                            string ColumnName = row["ColumnName"].ToString();
                            string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                            parameter = new SQLiteParameter("@" + ColumnName, plant.GetType().GetProperty(PropertyName).GetValue(plant, null));
                            parameters.Add(parameter);
                        }
                    }
                    sqlStringObject = new SQLStringObject();
                    sqlStringObject.StrSql = sql;
                    sqlStringObject.Parameter = parameters;
                    SQLStringObjectList.Add(sqlStringObject);
                }
            }
            return this.SqlDbHelper.ExecuteSqlTranAnimalOrPlant(SQLStringObjectList,"t_plant");
        }
        /// <summary>
        /// 更新种植信息
        /// </summary>
        /// <param name="plant"></param>
        /// <returns></returns>
        public Result updatePlant(Plant plant)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_plant");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "plant_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_plant set " + Utils.JoinStingListToString(listSetValue) + " where plant_id = " + plant.Plant_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, plant.GetType().GetProperty(PropertyName).GetValue(plant, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 删除种植信息
        /// </summary>
        /// <param name="plant_id">种植信息ID</param>
        /// <returns></returns>
        public Result deletePlant(int plant_id)
        {
            string sql = "delete from t_plant where plant_id=" + plant_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }

        public Result deleteAll()
        {
            string sql = "delete from t_plant";
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
    }
}
