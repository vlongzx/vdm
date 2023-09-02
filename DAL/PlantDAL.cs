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
            if (condition != null)
            {
                if (condition["company_id"].ToString() != "")
                {
                    sql += "    and company_id = @company_id";
                }
                if (condition["principal_category"].ToString() != "")
                {
                    sql += "    and principal_category = @principal_category";
                }
                if (condition["principal_name"].ToString() != "")
                {
                    sql += "    and principal_name = @principal_name";
                }
                if (condition["legal_name"].ToString() != "")
                {
                    sql += "    and legal_name = @legal_name";
                }
                if (condition["registered_trademark"].ToString() != "")
                {
                    sql += "    and registered_trademark = @registered_trademark";
                }
                if (condition["phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition["trade_form"].ToString() != "")
                {
                    sql += "    and trade_form = @trade_form";
                }
                if (condition["address"].ToString() != "")
                {
                    sql += "    and address = @address";
                }
                if (condition["town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["villiage"].ToString() != "")
                {
                    sql += "    and villiage = @villiage";
                }
                if (condition["year_person_count_from"].ToString() != "0" && condition["year_person_count_to"].ToString() != "0")
                {
                    sql += "  and  year_person_count BETWEEN '" + condition["year_person_count_from"].ToString() + "' AND '" + condition["year_person_count_to"].ToString() + "'";
                }
                if (condition["year_trade_income_from"].ToString() != "0" && condition["year_trade_income_to"].ToString() != "0")
                {
                    sql += " and   year_trade_income BETWEEN '" + condition["year_trade_income_from"].ToString() + "' AND '" + condition["year_trade_income_to"].ToString() + "'";
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
                parameters.Add(new SQLiteParameter("@company_id", condition["company_id"]));
                parameters.Add(new SQLiteParameter("@town", condition["town"]));
                parameters.Add(new SQLiteParameter("@villiage", condition["villiage"]));
                parameters.Add(new SQLiteParameter("@principal_category", condition["principal_category"]));
                parameters.Add(new SQLiteParameter("@principal_name", condition["principal_name"]));
                parameters.Add(new SQLiteParameter("@legal_name", condition["legal_name"]));
                parameters.Add(new SQLiteParameter("@registered_trademark", condition["registered_trademark"]));
                parameters.Add(new SQLiteParameter("@address", condition["address"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["phone_number"]));
                parameters.Add(new SQLiteParameter("@trade_form", condition["trade_form"]));
                parameters.Add(new SQLiteParameter("@year_person_count_from", condition["year_person_count_from"]));
                parameters.Add(new SQLiteParameter("@year_person_count_to", condition["year_person_count_to"]));
                parameters.Add(new SQLiteParameter("@year_trade_income_from", condition["year_trade_income_from"]));
                parameters.Add(new SQLiteParameter("@year_trade_income_to", condition["year_trade_income_to"]));

            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
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
            if (condition != null)
            {
                if (condition["company_id"].ToString() != "")
                {
                    sql += "    and company_id = @company_id";
                }
                if (condition["principal_category"].ToString() != "")
                {
                    sql += "    and principal_category = @principal_category";
                }
                if (condition["principal_name"].ToString() != "")
                {
                    sql += "    and principal_name = @principal_name";
                }
                if (condition["legal_name"].ToString() != "")
                {
                    sql += "    and legal_name = @legal_name";
                }
                if (condition["registered_trademark"].ToString() != "")
                {
                    sql += "    and registered_trademark = @registered_trademark";
                }
                if (condition["phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition["trade_form"].ToString() != "")
                {
                    sql += "    and trade_form = @trade_form";
                }
                if (condition["address"].ToString() != "")
                {
                    sql += "    and address = @address";
                }
                if (condition["town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["villiage"].ToString() != "")
                {
                    sql += "    and villiage = @villiage";
                }
                if (condition["year_person_count_from"].ToString() != "0" && condition["year_person_count_to"].ToString() != "0")
                {
                    sql += "  and  year_person_count BETWEEN '" + condition["year_person_count_from"].ToString() + "' AND '" + condition["year_person_count_to"].ToString() + "'";
                }
                if (condition["year_trade_income_from"].ToString() != "0" && condition["year_trade_income_to"].ToString() != "0")
                {
                    sql += " and   year_trade_income BETWEEN '" + condition["year_trade_income_from"].ToString() + "' AND '" + condition["year_trade_income_to"].ToString() + "'";
                }
            }

            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@company_id", condition["company_id"]));
                parameters.Add(new SQLiteParameter("@town", condition["town"]));
                parameters.Add(new SQLiteParameter("@villiage", condition["villiage"]));
                parameters.Add(new SQLiteParameter("@principal_category", condition["principal_category"]));
                parameters.Add(new SQLiteParameter("@principal_name", condition["principal_name"]));
                parameters.Add(new SQLiteParameter("@legal_name", condition["legal_name"]));
                parameters.Add(new SQLiteParameter("@registered_trademark", condition["registered_trademark"]));
                parameters.Add(new SQLiteParameter("@address", condition["address"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["phone_number"]));
                parameters.Add(new SQLiteParameter("@trade_form", condition["trade_form"]));
                parameters.Add(new SQLiteParameter("@year_person_count_from", condition["year_person_count_from"]));
                parameters.Add(new SQLiteParameter("@year_person_count_to", condition["year_person_count_to"]));
                parameters.Add(new SQLiteParameter("@year_trade_income_from", condition["year_trade_income_from"]));
                parameters.Add(new SQLiteParameter("@year_trade_income_to", condition["year_trade_income_to"]));

            }
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
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
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
            DataTable tblSchema = this.getTableSchema("t_tour");
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
    }
}
