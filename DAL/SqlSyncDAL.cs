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
    public class SqlSyncDAL : BaseDAL
    {
        public Result BatchCreateSqlSync(List<SqlSync> sqlSyncs)
        {
            List<SQLStringObject> SQLStringObjectList = null;
            if (sqlSyncs != null)
            {
                SQLStringObjectList = new List<SQLStringObject>();
                SQLStringObject sqlStringObject = null;
                SQLiteParameter parameter = null;
                List<SQLiteParameter> parameters = null;
                //构建删除sql语句
                //string sql = "delete from t_sql_sync";
                parameters = new List<SQLiteParameter>();
                sqlStringObject = new SQLStringObject();
                //sqlStringObject.StrSql = sql;
                //sqlStringObject.Parameter = parameters;
                //SQLStringObjectList.Add(sqlStringObject);

                //构建批量插入sql
                foreach (SqlSync sqlSync in sqlSyncs)
                {
                    //构建sql语句
                    List<string> listColumnName = new List<string>();
                    List<string> listParameter = new List<string>();
                    DataTable tblSchema = this.getTableSchema("t_sql_sync");
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            listColumnName.Add(row["ColumnName"].ToString());
                            listParameter.Add("@" + row["ColumnName"].ToString());
                        }
                    }
                    string sql = "insert into t_sql_sync(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

                    //构建参数值
                    parameters = new List<SQLiteParameter>();
                    if (tblSchema != null)
                    {
                        foreach (DataRow row in tblSchema.Rows)
                        {
                            string ColumnName = row["ColumnName"].ToString();
                            string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                            parameter = new SQLiteParameter("@" + ColumnName, sqlSync.GetType().GetProperty(PropertyName).GetValue(sqlSync, null));
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


        public Result BatchExecuteSql(List<SqlSync> sqlSyncs)
        {
            List<string> sqlStrList = new List<string>();
            foreach (SqlSync sqlSync in sqlSyncs)
            {
                sqlStrList.Add(sqlSync.Sql_string);
            }
            return this.SqlDbHelper.ExecuteSqlTranDirect(sqlStrList);
        }
        /// <summary>
        ///  创建t_sql_sync表
        /// </summary>
        /// <returns></returns>
        public Result CreateTableSqlSync( )
        {
            string sqlCreateTable = "CREATE TABLE if not exists \"t_sql_sync\"(\"id\"  INTEGER NOT NULL,\"sql_string\"  TEXT,PRIMARY KEY(\"id\"))";
            return this.SqlDbHelper.ExecuteNonQuery(sqlCreateTable);
        }

        public DataTable QueryById(long id)
        {
            string sql = "select * from t_sql_sync where id = "  + id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
    }
}
