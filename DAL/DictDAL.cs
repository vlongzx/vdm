using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class DictDAL:BaseDAL
    {
        private SqlDbHelper sqlDB;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DictDAL()
        {
            this.sqlDB = new SqlDbHelper();
        }
        /// <summary>
        ///  根据字典项标识获得键值对
        /// </summary>
        /// <param name="dict_code">字典项标识</param>
        /// <returns>
        /// 键值对数据表
        /// </returns>
        public DataTable getDict(string dict_code)
        {
            string sql = "select datakey,datavalue from t_dict where dict_code  in ( '" + dict_code + "','common')";
            sql += " order by `dataindex` asc";
            return this.sqlDB.ExecuteDataTable(sql);
        }
        public DataTable getDictCheckBox(string dict_code)
        {
            string sql = "select datavalue from t_dict where dict_code ="+"'"+dict_code+"'";
            sql += " order by `dataindex` asc";
            return this.sqlDB.ExecuteDataTable(sql);
        }
        public DataTable getDictById(int id)
        {
            string sql = "select * from t_dict  where id = "+ id;
            return this.sqlDB.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 获得不重复的字典项
        /// </summary>
        /// <returns></returns>
        public DataTable getDistinctDict()
        {
            string sql = "select DISTINCT dict_code,dict_name from t_dict ORDER BY id ASC";
            return this.sqlDB.ExecuteDataTable(sql);
        }


        /// <summary>
        /// 获得所有字典项
        /// </summary>
        /// <returns></returns>
        public DataTable getAllDict()
        {
            string sql = "select * from t_dict ORDER BY id ASC";
            return this.sqlDB.ExecuteDataTable(sql);
        }
        /// <summary>
        ///  根据标识获得所有字典项
        /// </summary>
        /// <returns></returns>
        public DataTable getDictByCode(string dict_code)
        {
            string sql = "select * from t_dict where dict_code= '"+ dict_code +"' ORDER BY id ASC";
            return this.sqlDB.ExecuteDataTable(sql);
        }

        public Result CreateDict(Dict dict)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_dict");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_dict(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, dict.GetType().GetProperty(PropertyName).GetValue(dict, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public Result BatchCreateDict(List<Dict> dicts)
        {

            List<SQLStringObject> SQLStringObjectList = null;
            if (dicts != null)
            {
                SQLStringObjectList = new List<SQLStringObject>();
                SQLStringObject sqlStringObject = null;
                SQLiteParameter parameter = null;
                List<SQLiteParameter> parameters = null;
                //构建删除sql语句
                string sql = "delete from t_dict";
                parameters = new List<SQLiteParameter>();
                sqlStringObject = new SQLStringObject();
                sqlStringObject.StrSql = sql;
                sqlStringObject.Parameter = parameters;
                SQLStringObjectList.Add(sqlStringObject);

                //构建批量插入sql
                foreach (Dict dict in dicts)
                {
                    //构建sql语句
                    List<string> listColumnName = new List<string>();
                    List<string> listParameter = new List<string>();
                    DataTable tblSchema = this.getTableSchema("t_dict");
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            //过滤掉主键
                            if (row["ColumnName"].ToString() == "id")
                            {
                                continue;
                            }
                            listColumnName.Add(row["ColumnName"].ToString());
                            listParameter.Add("@" + row["ColumnName"].ToString());
                        }
                    }
                    sql = "insert into t_dict(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

                    //构建参数值
                    parameters = new List<SQLiteParameter>();
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            if (row["ColumnName"].ToString() == "id")
                            {
                                continue;
                            }
                            string ColumnName = row["ColumnName"].ToString();
                            string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                            parameter = new SQLiteParameter("@" + ColumnName, dict.GetType().GetProperty(PropertyName).GetValue(dict, null));
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

        public Result UpdateDict(Dict dict)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_dict");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_dict set " + Utils.JoinStingListToString(listSetValue) + " where id = " + dict.Id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, dict.GetType().GetProperty(PropertyName).GetValue(dict, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public Result DeleteDict(int id)
        {
            string sql = "delete from t_dict where id = "+ id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
    }
}
