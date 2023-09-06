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
    public class FamerDAL : BaseDAL
    {

        /// <summary>
        ///  获得农户信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_famer where 1 = 1";
            if (condition != null)
            {
                if (condition["Holder_name"].ToString() != "")
                {
                    sql += "    and Holder_name = @Holder_name";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard = @Idcard";
                }
                if (condition["Phone_number"].ToString() != "")
                {
                    sql += "    and Phone_number = @Phone_number";
                }
                if (condition["Car_brand"].ToString() != "")
                {
                    sql += "    and Car_brand =@Car_brand";
                }
                if (condition["Mechine_type"].ToString() != "")
                {
                    sql += "    and Mechine_type like @Mechine_type";
                }
                if (condition["Plant_type"].ToString() != "")
                {
                    sql += "    and Plant_type = @Plant_type";
                }
                if (condition["Plant_area_type"].ToString() != "")
                {
                    sql += "    and Plant_area_type = @Plant_area_type";
                }
                if (condition["Is_handle_process"].ToString() != "")
                {
                    sql += "    and Is_handle_process = @Is_handle_process";
                }
                if (condition["Animal_type"].ToString() != "")
                {
                    sql += "    and Animal_type = @Animal_type";
                }
                if (condition["Animal_area_type"].ToString() != "")
                {
                    sql += "    and Animal_area_type = @Animal_area_type";
                }
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition.ContainsKey("tbPlant_area_From") && condition["tbPlant_area_From"].ToString() != "" && condition["tbPlant_area_To"].ToString() != null)
                {
                    sql += "  and  plant_area BETWEEN '" + condition["tbPlant_area_From"].ToString() + "' AND '" + condition["tbPlant_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_yield_From") && condition["tbPlant_yield_From"].ToString() != "" && condition["tbPlant_yield_To"].ToString() != null)
                {
                    sql += "  and  plant_yield BETWEEN '" + condition["tbPlant_yield_From"].ToString() + "' AND '" + condition["tbPlant_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_output_From") && condition["tbPlant_output_From"].ToString() != "" && condition["tbPlant_output_To"].ToString() != null)
                {
                    sql += "  and  plant_output BETWEEN '" + condition["tbPlant_output_From"].ToString() + "' AND '" + condition["tbPlant_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_area_From") && condition["tbAnimal_area_From"].ToString() != "" && condition["tbAnimal_area_To"].ToString() != null)
                {
                    sql += "  and  Animal_area BETWEEN '" + condition["tbAnimal_area_From"].ToString() + "' AND '" + condition["tbAnimal_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_count_From") && condition["tbAnimal_count_From"].ToString() != "" && condition["tbAnimal_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_count BETWEEN '" + condition["tbAnimal_count_From"].ToString() + "' AND '" + condition["tbAnimal_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_nvaccinate_count_From") && condition["tbAnimal_nvaccinate_count_From"].ToString() != "" && condition["tbAnimal_nvaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_nvaccinate_count BETWEEN '" + condition["tbAnimal_nvaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_nvaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_output_From") && condition["tbAnimal_output_From"].ToString() != "" && condition["tbAnimal_output_To"].ToString() != null)
                {
                    sql += "  and  Animal_output BETWEEN '" + condition["tbAnimal_output_From"].ToString() + "' AND '" + condition["tbAnimal_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_vaccinate_count_From") && condition["tbAnimal_vaccinate_count_From"].ToString() != "" && condition["tbAnimal_vaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_vaccinate_count BETWEEN '" + condition["tbAnimal_vaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_vaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_yield_From") && condition["tbAnimal_yield_From"].ToString() != "" && condition["tbAnimal_yield_To"].ToString() != null)
                {
                    sql += "  and  Animal_yield BETWEEN '" + condition["tbAnimal_yield_From"].ToString() + "' AND '" + condition["tbAnimal_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbInventory_count_From") && condition["tbInventory_count_From"].ToString() != "" && condition["tbInventory_count_To"].ToString() != null)
                {
                    sql += "  and  Inventory_count BETWEEN '" + condition["tbInventory_count_From"].ToString() + "' AND '" + condition["tbInventory_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbOutbound_count_From") && condition["tbOutbound_count_From"].ToString() != "" && condition["tbOutbound_count_To"].ToString() != null)
                {
                    sql += "  and  Outbound_count BETWEEN '" + condition["tbOutbound_count_From"].ToString() + "' AND '" + condition["tbOutbound_count_To"].ToString() + "'";
                }
            }

            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Holder_name", condition["Holder_name"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@Phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@Car_brand", condition["Car_brand"]));
                parameters.Add(new SQLiteParameter("@Mechine_type","%"+ condition["Mechine_type"]+"%"));
                parameters.Add(new SQLiteParameter("@Plant_type", condition["Plant_type"]));
                parameters.Add(new SQLiteParameter("@Plant_area_type", condition["Plant_area_type"]));
                parameters.Add(new SQLiteParameter("@Is_handle_process", condition["Is_handle_process"]));
                parameters.Add(new SQLiteParameter("@Animal_type", condition["Animal_type"]));
                parameters.Add(new SQLiteParameter("@Animal_area_type", condition["Animal_area_type"]));
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
        public DataTable queryAllFamer(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_famer where 1 = 1";
            if (condition != null)
            {
                if (condition["Holder_name"].ToString() != "")
                {
                    sql += "    and Holder_name = @Holder_name";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard = @Idcard";
                }
                if (condition["Phone_number"].ToString() != "")
                {
                    sql += "    and Phone_number = @Phone_number";
                }
                if (condition["Car_brand"].ToString() != "")
                {
                    sql += "    and Car_brand =@Car_brand";
                }
                if (condition["Mechine_type"].ToString() != "")
                {
                    sql += "    and Mechine_type like @Mechine_type";
                }
                if (condition["Plant_type"].ToString() != "")
                {
                    sql += "    and Plant_type = @Plant_type";
                }
                if (condition["Plant_area_type"].ToString() != "")
                {
                    sql += "    and Plant_area_type = @Plant_area_type";
                }
                if (condition["Is_handle_process"].ToString() != "")
                {
                    sql += "    and Is_handle_process = @Is_handle_process";
                }
                if (condition["Animal_type"].ToString() != "")
                {
                    sql += "    and Animal_type = @Animal_type";
                }
                if (condition["Animal_area_type"].ToString() != "")
                {
                    sql += "    and Animal_area_type = @Animal_area_type";
                }
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition.ContainsKey("tbPlant_area_From") && condition["tbPlant_area_From"].ToString() != "" && condition["tbPlant_area_To"].ToString() != null)
                {
                    sql += "  and  plant_area BETWEEN '" + condition["tbPlant_area_From"].ToString() + "' AND '" + condition["tbPlant_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_yield_From") && condition["tbPlant_yield_From"].ToString() != "" && condition["tbPlant_yield_To"].ToString() != null)
                {
                    sql += "  and  plant_yield BETWEEN '" + condition["tbPlant_yield_From"].ToString() + "' AND '" + condition["tbPlant_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_output_From") && condition["tbPlant_output_From"].ToString() != "" && condition["tbPlant_output_To"].ToString() != null)
                {
                    sql += "  and  plant_output BETWEEN '" + condition["tbPlant_output_From"].ToString() + "' AND '" + condition["tbPlant_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_area_From") && condition["tbAnimal_area_From"].ToString() != "" && condition["tbAnimal_area_To"].ToString() != null)
                {
                    sql += "  and  Animal_area BETWEEN '" + condition["tbAnimal_area_From"].ToString() + "' AND '" + condition["tbAnimal_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_count_From") && condition["tbAnimal_count_From"].ToString() != "" && condition["tbAnimal_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_count BETWEEN '" + condition["tbAnimal_count_From"].ToString() + "' AND '" + condition["tbAnimal_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_nvaccinate_count_From") && condition["tbAnimal_nvaccinate_count_From"].ToString() != "" && condition["tbAnimal_nvaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_nvaccinate_count BETWEEN '" + condition["tbAnimal_nvaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_nvaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_output_From") && condition["tbAnimal_output_From"].ToString() != "" && condition["tbAnimal_output_To"].ToString() != null)
                {
                    sql += "  and  Animal_output BETWEEN '" + condition["tbAnimal_output_From"].ToString() + "' AND '" + condition["tbAnimal_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_vaccinate_count_From") && condition["tbAnimal_vaccinate_count_From"].ToString() != "" && condition["tbAnimal_vaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_vaccinate_count BETWEEN '" + condition["tbAnimal_vaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_vaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_yield_From") && condition["tbAnimal_yield_From"].ToString() != "" && condition["tbAnimal_yield_To"].ToString() != null)
                {
                    sql += "  and  Animal_yield BETWEEN '" + condition["tbAnimal_yield_From"].ToString() + "' AND '" + condition["tbAnimal_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbInventory_count_From") && condition["tbInventory_count_From"].ToString() != "" && condition["tbInventory_count_To"].ToString() != null)
                {
                    sql += "  and  Inventory_count BETWEEN '" + condition["tbInventory_count_From"].ToString() + "' AND '" + condition["tbInventory_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbOutbound_count_From") && condition["tbOutbound_count_From"].ToString() != "" && condition["tbOutbound_count_To"].ToString() != null)
                {
                    sql += "  and  Outbound_count BETWEEN '" + condition["tbOutbound_count_From"].ToString() + "' AND '" + condition["tbOutbound_count_To"].ToString() + "'";
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
                parameters.Add(new SQLiteParameter("@Holder_name", condition["Holder_name"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@Phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@Car_brand", condition["Car_brand"]));
                parameters.Add(new SQLiteParameter("@Mechine_type", "%" + condition["Mechine_type"] + "%"));
                parameters.Add(new SQLiteParameter("@Plant_type", condition["Plant_type"]));
                parameters.Add(new SQLiteParameter("@Plant_area_type", condition["Plant_area_type"]));
                parameters.Add(new SQLiteParameter("@Is_handle_process", condition["Is_handle_process"]));
                parameters.Add(new SQLiteParameter("@Animal_type", condition["Animal_type"]));
                parameters.Add(new SQLiteParameter("@Animal_area_type", condition["Animal_area_type"]));
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
        public DataTable getAllFamer(Hashtable condition)
        {
            string sql = "select * from t_famer where 1 = 1";
            if (condition != null)
            {
                if (condition["Holder_name"].ToString() != "")
                {
                    sql += "    and Holder_name = @Holder_name";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard = @Idcard";
                }
                if (condition["Phone_number"].ToString() != "")
                {
                    sql += "    and Phone_number = @Phone_number";
                }
                if (condition["Car_brand"].ToString() != "")
                {
                    sql += "    and Car_brand =@Car_brand";
                }
                if (condition["Mechine_type"].ToString() != "")
                {
                    sql += "    and Mechine_type like @Mechine_type";
                }
                if (condition["Plant_type"].ToString() != "")
                {
                    sql += "    and Plant_type = @Plant_type";
                }
                if (condition["Plant_area_type"].ToString() != "")
                {
                    sql += "    and Plant_area_type = @Plant_area_type";
                }
                if (condition["Is_handle_process"].ToString() != "")
                {
                    sql += "    and Is_handle_process = @Is_handle_process";
                }
                if (condition["Animal_type"].ToString() != "")
                {
                    sql += "    and Animal_type = @Animal_type";
                }
                if (condition["Animal_area_type"].ToString() != "")
                {
                    sql += "    and Animal_area_type = @Animal_area_type";
                }
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition.ContainsKey("tbPlant_area_From") && condition["tbPlant_area_From"].ToString() != "" && condition["tbPlant_area_To"].ToString() != null)
                {
                    sql += "  and  plant_area BETWEEN '" + condition["tbPlant_area_From"].ToString() + "' AND '" + condition["tbPlant_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_yield_From") && condition["tbPlant_yield_From"].ToString() != "" && condition["tbPlant_yield_To"].ToString() != null)
                {
                    sql += "  and  plant_yield BETWEEN '" + condition["tbPlant_yield_From"].ToString() + "' AND '" + condition["tbPlant_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbPlant_output_From") && condition["tbPlant_output_From"].ToString() != "" && condition["tbPlant_output_To"].ToString() != null)
                {
                    sql += "  and  plant_output BETWEEN '" + condition["tbPlant_output_From"].ToString() + "' AND '" + condition["tbPlant_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_area_From") && condition["tbAnimal_area_From"].ToString() != "" && condition["tbAnimal_area_To"].ToString() != null)
                {
                    sql += "  and  Animal_area BETWEEN '" + condition["tbAnimal_area_From"].ToString() + "' AND '" + condition["tbAnimal_area_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_count_From") && condition["tbAnimal_count_From"].ToString() != "" && condition["tbAnimal_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_count BETWEEN '" + condition["tbAnimal_count_From"].ToString() + "' AND '" + condition["tbAnimal_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_nvaccinate_count_From") && condition["tbAnimal_nvaccinate_count_From"].ToString() != "" && condition["tbAnimal_nvaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_nvaccinate_count BETWEEN '" + condition["tbAnimal_nvaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_nvaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_output_From") && condition["tbAnimal_output_From"].ToString() != "" && condition["tbAnimal_output_To"].ToString() != null)
                {
                    sql += "  and  Animal_output BETWEEN '" + condition["tbAnimal_output_From"].ToString() + "' AND '" + condition["tbAnimal_output_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_vaccinate_count_From") && condition["tbAnimal_vaccinate_count_From"].ToString() != "" && condition["tbAnimal_vaccinate_count_To"].ToString() != null)
                {
                    sql += "  and  Animal_vaccinate_count BETWEEN '" + condition["tbAnimal_vaccinate_count_From"].ToString() + "' AND '" + condition["tbAnimal_vaccinate_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbAnimal_yield_From") && condition["tbAnimal_yield_From"].ToString() != "" && condition["tbAnimal_yield_To"].ToString() != null)
                {
                    sql += "  and  Animal_yield BETWEEN '" + condition["tbAnimal_yield_From"].ToString() + "' AND '" + condition["tbAnimal_yield_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbInventory_count_From") && condition["tbInventory_count_From"].ToString() != "" && condition["tbInventory_count_To"].ToString() != null)
                {
                    sql += "  and  Inventory_count BETWEEN '" + condition["tbInventory_count_From"].ToString() + "' AND '" + condition["tbInventory_count_To"].ToString() + "'";
                }
                if (condition.ContainsKey("tbOutbound_count_From") && condition["tbOutbound_count_From"].ToString() != "" && condition["tbOutbound_count_To"].ToString() != null)
                {
                    sql += "  and  Outbound_count BETWEEN '" + condition["tbOutbound_count_From"].ToString() + "' AND '" + condition["tbOutbound_count_To"].ToString() + "'";
                }
            }

            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Holder_name", condition["Holder_name"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@Phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@Car_brand", condition["Car_brand"]));
                parameters.Add(new SQLiteParameter("@Mechine_type", "%" + condition["Mechine_type"] + "%"));
                parameters.Add(new SQLiteParameter("@Plant_type", condition["Plant_type"]));
                parameters.Add(new SQLiteParameter("@Plant_area_type", condition["Plant_area_type"]));
                parameters.Add(new SQLiteParameter("@Is_handle_process", condition["Is_handle_process"]));
                parameters.Add(new SQLiteParameter("@Animal_type", condition["Animal_type"]));
                parameters.Add(new SQLiteParameter("@Animal_area_type", condition["Animal_area_type"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            sql += " order by create_datetime desc";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 创建农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result CreateFamer(Famer famer)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_famer");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "famer_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_famer(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "famer_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, famer.GetType().GetProperty(PropertyName).GetValue(famer, null));
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
        public Result UpdateFamer(Famer famer)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_famer");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "famer_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_famer set " + Utils.JoinStingListToString(listSetValue) + " where famer_id = " + famer.Famer_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, famer.GetType().GetProperty(PropertyName).GetValue(famer, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除农户
        /// </summary>
        /// <param name="famer_id"></param>
        /// <returns></returns>
        public Result DeleteFamer(long famer_id)
        {
            string sql = "delete from t_famer where famer_id=" + famer_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
        public DataTable getFamer(int famer_id)
        {
            string sql = "select * from t_famer where famer_id = " + famer_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns
        public SQLStringObject ImportFamerAdd(Famer famer)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_famer");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "famer_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_famer(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "famer_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, famer.GetType().GetProperty(PropertyName).GetValue(famer, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject = new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportFamer(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }

    }
}
