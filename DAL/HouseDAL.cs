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
   public class HouseDAL : BaseDAL
    {
        /// <summary>
        ///  获得信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_house where 1 = 1";
            if (condition != null)
            {
                if (condition["House_location"].ToString() != "")
                {
                    sql += "    and House_location = @House_location";
                }
                if (condition["House_owner"].ToString() != "")
                {
                    sql += "    and House_owner = @House_owner";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard =@Idcard";
                }
                if (condition["House_is_rent"].ToString() != "")
                {
                    sql += "    and House_is_rent =@House_is_rent";
                }
                if (condition["House_safe_grade"].ToString() != "")
                {
                    sql += "    and House_safe_grade = @House_safe_grade";
                }
                if (condition["House_struction"].ToString() != "")
                {
                    sql += "    and House_struction = @House_struction";
                }
                if (condition["House_type"].ToString() != "")
                {
                    sql += "    and House_type = @House_type";
                }
                if (condition["Is_my_struct"].ToString() != "")
                {
                    sql += "    and Is_my_struct = @Is_my_struct";
                }
                if (condition["Is_old_house"].ToString() != "")
                {
                    sql += "    and Is_old_house = @Is_old_house";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["House_build_date_From"].ToString() != "" && condition["House_build_date_To"].ToString() != null)
                {
                    sql += "  and  House_build_date BETWEEN '" + condition["House_build_date_From"].ToString() + "' AND '" + condition["House_build_date_To"].ToString() + "'";
                }
                if (condition["Oh_checktime_From"].ToString() != "" && condition["Oh_checktime_To"].ToString() != null)
                {
                    sql += "  and  Oh_checktime BETWEEN '" + condition["Oh_checktime_From"].ToString() + "' AND '" + condition["Oh_checktime_To"].ToString() + "'";
                }
                if (condition["Area_From"].ToString() != "" && condition["Area_To"].ToString() != null)
                {
                    sql += "  and  Area BETWEEN '" + condition["Area_From"].ToString() + "' AND '" + condition["Area_To"].ToString() + "'";
                }

            }

            sql += " order by create_datetime desc";
        
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@House_location", condition["House_location"]));
                parameters.Add(new SQLiteParameter("@House_owner", condition["House_owner"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@House_is_rent", condition["House_is_rent"]));
                parameters.Add(new SQLiteParameter("@House_safe_grade", condition["House_safe_grade"]));
                parameters.Add(new SQLiteParameter("@House_struction", condition["House_struction"]));
                parameters.Add(new SQLiteParameter("@House_type", condition["House_type"]));
                parameters.Add(new SQLiteParameter("@Is_my_struct", condition["Is_my_struct"]));
                parameters.Add(new SQLiteParameter("@Is_old_house", condition["Is_old_house"]));
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
        public DataTable queryAllHouse(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_house where 1 = 1";
            if (condition != null)
            {
                if (condition["House_location"].ToString() != "")
                {
                    sql += "    and House_location = @House_location";
                }
                if (condition["House_owner"].ToString() != "")
                {
                    sql += "    and House_owner = @House_owner";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard =@Idcard";
                }
                if (condition["House_is_rent"].ToString() != "")
                {
                    sql += "    and House_is_rent =@House_is_rent";
                }
                if (condition["House_safe_grade"].ToString() != "")
                {
                    sql += "    and House_safe_grade = @House_safe_grade";
                }
                if (condition["House_struction"].ToString() != "")
                {
                    sql += "    and House_struction = @House_struction";
                }
                if (condition["House_type"].ToString() != "")
                {
                    sql += "    and House_type = @House_type";
                }
                if (condition["Is_my_struct"].ToString() != "")
                {
                    sql += "    and Is_my_struct = @Is_my_struct";
                }
                if (condition["Is_old_house"].ToString() != "")
                {
                    sql += "    and Is_old_house = @Is_old_house";
                }
             
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["House_build_date_From"].ToString() != "" && condition["House_build_date_To"].ToString() != null)
                {
                    sql += "  and  House_build_date BETWEEN '" + condition["House_build_date_From"].ToString() + "' AND '" + condition["House_build_date_To"].ToString() + "'";
                }
                if (condition["Oh_checktime_From"].ToString() != "" && condition["Oh_checktime_To"].ToString() != null)
                {
                    sql += "  and  Oh_checktime BETWEEN '" + condition["Oh_checktime_From"].ToString() + "' AND '" + condition["Oh_checktime_To"].ToString() + "'";
                }
                if (condition["Area_From"].ToString() != "" && condition["Area_To"].ToString() != null)
                {
                    sql += "  and  Area BETWEEN '" + condition["Area_From"].ToString() + "' AND '" + condition["Area_To"].ToString() + "'";
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
                parameters.Add(new SQLiteParameter("@House_location", condition["House_location"]));
                parameters.Add(new SQLiteParameter("@House_owner", condition["House_owner"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@House_is_rent", condition["House_is_rent"]));
                parameters.Add(new SQLiteParameter("@House_safe_grade", condition["House_safe_grade"]));
                parameters.Add(new SQLiteParameter("@House_struction", condition["House_struction"]));
                parameters.Add(new SQLiteParameter("@House_type", condition["House_type"]));
                parameters.Add(new SQLiteParameter("@Is_my_struct", condition["Is_my_struct"]));
                parameters.Add(new SQLiteParameter("@Is_old_house", condition["Is_old_house"]));
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
        public DataTable getAllHouse(Hashtable condition)
        {
            string sql = "select * from t_house where 1 = 1";
            if (condition != null)
            {
                if (condition["House_name"].ToString() != "")
                {
                    sql += "    and House_name = @House_name";
                }
                if (condition["Name"].ToString() != "")
                {
                    sql += "    and Name = @Name";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and Idcard = @Idcard";
                }
                if (condition["Is_basic_farmhouse"].ToString() != "")
                {
                    sql += "    and Is_basic_farmhouse =@Is_basic_farmhouse";
                }
                if (condition["House_type"].ToString() != "")
                {
                    sql += "    and House_type =@House_type";
                }
                if (condition["House_grade"].ToString() != "")
                {
                    sql += "    and House_grade = @House_grade";
                }
                if (condition["East"].ToString() != "")
                {
                    sql += "    and East = @East";
                }
                if (condition["West"].ToString() != "")
                {
                    sql += "    and West = @West";
                }
                if (condition["North"].ToString() != "")
                {
                    sql += "    and North = @North";
                }
                if (condition["South"].ToString() != "")
                {
                    sql += "    and South = @South";
                }
                if (condition["House_use_remark"].ToString() != "")
                {
                    sql += "    and House_use_remark = @House_use_remark";
                }
                if (condition["Contractor"].ToString() != "")
                {
                    sql += "    and Contractor = @Contractor";
                }
                if (condition["Move_type"].ToString() != "")
                {
                    sql += "    and Move_type = @Move_type";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Real_area_From"].ToString() != "" && condition["Real_area_To"].ToString() != null)
                {
                    sql += "  and  Real_area BETWEEN '" + condition["Real_area_From"].ToString() + "' AND '" + condition["Real_area_To"].ToString() + "'";
                }
                if (condition["Contract_time_From"].ToString() != "" && condition["Contract_time_To"].ToString() != null)
                {
                    sql += "  and  Contract_time BETWEEN '" + condition["Contract_time_From"].ToString() + "' AND '" + condition["Contract_time_To"].ToString() + "'";
                }
                if (condition["Move_area_From"].ToString() != "" && condition["Move_area_To"].ToString() != null)
                {
                    sql += "  and  Move_area BETWEEN '" + condition["Move_area_From"].ToString() + "' AND '" + condition["Move_area_To"].ToString() + "'";
                }
                if (condition["Move_price_From"].ToString() != "" && condition["Move_price_To"].ToString() != null)
                {
                    sql += "  and  Move_price BETWEEN '" + condition["Move_price_From"].ToString() + "' AND '" + condition["Move_price_To"].ToString() + "'";
                }
                if (condition["Move_date_From"].ToString() != "" && condition["Move_date_To"].ToString() != null)
                {
                    sql += "  and  Move_date BETWEEN '" + condition["Move_date_From"].ToString() + "' AND '" + condition["Move_date_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@House_name", condition["House_name"]));
                parameters.Add(new SQLiteParameter("@Name", condition["Name"]));
                parameters.Add(new SQLiteParameter("@Idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@Is_basic_farmhouse", condition["Is_basic_farmhouse"]));
                parameters.Add(new SQLiteParameter("@House_type", condition["House_type"]));
                parameters.Add(new SQLiteParameter("@House_grade", condition["House_grade"]));
                parameters.Add(new SQLiteParameter("@East", condition["East"]));
                parameters.Add(new SQLiteParameter("@West", condition["West"]));
                parameters.Add(new SQLiteParameter("@North", condition["North"]));
                parameters.Add(new SQLiteParameter("@South", condition["South"]));
                parameters.Add(new SQLiteParameter("@House_use_remark", condition["House_use_remark"]));
                parameters.Add(new SQLiteParameter("@Contractor", condition["Contractor"]));
                parameters.Add(new SQLiteParameter("@Move_type", condition["Move_type"]));
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
        public Result CreateHouse(House house)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_house");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "house_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_house(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "house_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, house.GetType().GetProperty(PropertyName).GetValue(house, null));
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
        public Result UpdateHouse(House house)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_house");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "house_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_house set " + Utils.JoinStingListToString(listSetValue) + " where house_id = " + house.House_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, house.GetType().GetProperty(PropertyName).GetValue(house, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="house_id"></param>
        /// <returns></returns>
        public Result DeleteHouse(long house_id)
        {
            string sql = "delete from t_house where house_id=" + house_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
        public DataTable getHouse(int house_id)
        {
            string sql = "select * from t_house where house_id = " + house_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public SQLStringObject ImportHouseAdd(House house)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_house");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "house_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_house(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "house_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, house.GetType().GetProperty(PropertyName).GetValue(house, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject = new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportHouse(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }
    }
}
