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
    public class TourDAL : BaseDAL
    {
        /// <summary>
        ///  查询所有的旅游信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">分页索引</param>
        /// <param name="pageSize">分页记录数</param>
        /// <returns></returns>
        public DataTable queryAllTour(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_tour where 1 = 1";
            List<SQLiteParameter> parameters = null;
            sql += this.getConditonSql(condition, pageIndex, pageSize, 1, out parameters);
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  根据条件获得所有的旅游信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public DataTable queryAllTour(Hashtable condition)
        {
            string sql = "select * from t_tour where 1 = 1";
            List<SQLiteParameter> parameters = null;
            sql += this.getConditonSql(condition, 0, 0, 0, out parameters);
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 根据tour_id 查询旅游信息
        /// </summary>
        /// <param name="tour_id">旅游信息ID</param>
        /// <returns></returns>
        public DataTable queryTour(int tour_id)
        {
            string sql = "select * from t_tour where tour_id = " + tour_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        ///  获得记录总数
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_tour where 1 = 1";
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
        ///  生成查询条件和分页部分的SQL语句
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">页面索引，默认为0</param>
        /// <param name="pageSize">页面记录数，默认为0</param>
        /// <param name="mode">模式，0表示不分页，1表示分页</param>
        /// <param name="parameters">输出参数，SQL参数列表</param>
        /// <returns></returns>
        private string getConditonSql(Hashtable condition, int pageIndex, int pageSize,int mode, out List<SQLiteParameter> parameters)
        {
            string sql = "";
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
            if(mode == 1)//代表分页处理
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
            return sql;
        }
        /// <summary>
        ///  创建旅游信息
        /// </summary>
        /// <param name="tour">旅游信息对象</param>
        /// <returns></returns>
        public Result CreateTour(Tour tour)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_tour");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "tour_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_tour(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "tour_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, tour.GetType().GetProperty(PropertyName).GetValue(tour, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  批量提交
        /// </summary>
        /// <param name="tours"></param>
        /// <returns></returns>
        public Result BatchCreateTour(List<Tour> tours)
        {
            List<SQLStringObject> SQLStringObjectList = null;
            if (tours != null)
            {
                SQLStringObjectList = new List<SQLStringObject>();
                SQLStringObject sqlStringObject = null;
                foreach (Tour tour in tours)
                {
                    //构建sql语句
                    List<string> listColumnName = new List<string>();
                    List<string> listParameter = new List<string>();
                    DataTable tblSchema = this.getTableSchema("t_tour");
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            //过滤掉主键
                            if (row["ColumnName"].ToString() == "tour_id")
                            {
                                continue;
                            }
                            listColumnName.Add(row["ColumnName"].ToString());
                            listParameter.Add("@" + row["ColumnName"].ToString());
                        }
                    }
                    string sql = "insert into t_tour(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

                    //构建参数值
                    SQLiteParameter parameter = null;
                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            if (row["ColumnName"].ToString() == "tour_id")
                            {
                                continue;
                            }
                            string ColumnName = row["ColumnName"].ToString();
                            string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                            parameter = new SQLiteParameter("@" + ColumnName, tour.GetType().GetProperty(PropertyName).GetValue(tour, null));
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
        /// 更新旅游信息
        /// </summary>
        /// <param name="tour">旅游信息对象</param>
        /// <returns></returns>
        public Result UpdateTour(Tour tour)
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
                    if (row["ColumnName"].ToString() == "tour_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_tour set " + Utils.JoinStingListToString(listSetValue) + " where tour_id = " + tour.Tour_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, tour.GetType().GetProperty(PropertyName).GetValue(tour, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 删除旅游信息
        /// </summary>
        /// <param name="tour_id">旅游信息ID</param>
        /// <returns></returns>
        public Result DeleteTour(int tour_id)
        {
            string sql = "delete from t_tour where tour_id=" + tour_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
    }
}
