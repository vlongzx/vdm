using com.vdm.common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class SqlDbHelper
    {
        private string connectionString;
        /// <summary>
        /// 设置数据库连接字符串
        /// </summary>
        public string ConnectionString
        {
            set { connectionString = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlDbHelper()
        {
            this.ConnectionString = "Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\db_file\\vdm_data.db;";

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        public SqlDbHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// 执行一个查询，并返回结果集
        /// </summary>
        /// <param name="sql">要执行的查询SQL文本命令</param>
        /// <returns>返回查询结果集</returns>
        public DataTable ExecuteDataTable(string sql)
        {
            return ExecuteDataTable(sql, CommandType.Text, null);
        }
        /// <summary>
        /// 执行一个查询,并返回查询结果
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <returns>返回查询结果集</returns>
        public DataTable ExecuteDataTable(string sql, CommandType commandType)
        {
            return ExecuteDataTable(sql, commandType, null);
        }
        /// <summary>
        /// 执行一个查询,并返回查询结果
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <param name="parameters">Transact-SQL 语句或存储过程的参数数组</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, CommandType commandType, List<SQLiteParameter> parameters)
        {
            DataTable data = new DataTable();//实例化DataTable，用于装载查询结果集
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.CommandType = commandType;//设置command的CommandType为指定的CommandType
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SQLiteParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    //通过包含查询SQL的SQLiteCommand 实例来实例化SqlDataAdapter
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                    adapter.Fill(data);//填充DataTable
                }
            }
            return data;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public SQLiteDataReader ExecuteReader(string sql)
        {
            return ExecuteReader(sql, CommandType.Text, null);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <returns></returns>
        public SQLiteDataReader ExecuteReader(string sql, CommandType commandType)
        {
            return ExecuteReader(sql, commandType, null);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <param name="parameters">Transact-SQL 语句或存储过程的参数数组</param>
        /// <returns></returns>
        public SQLiteDataReader ExecuteReader(string sql, CommandType commandType, List<SQLiteParameter> parameters)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            //如果同时传入了参数，则添加这些参数
            if (parameters != null)
            {
                foreach (SQLiteParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            connection.Open();
            //CommandBehavior.CloseConnection参数指示关闭Reader对象时关闭与其关联的Connection对象
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        ///  获得指定sql语句的表结构
        /// </summary>
        /// <param name="sql">需要查询的表的无记录sql语句</param>
        /// <returns></returns>
        public DataTable GetTableSchema(string sql)
        {
            DataTable tblSchema;

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SQLiteDataReader rdr = cmd.ExecuteReader(CommandBehavior.KeyInfo))
                    {
                        tblSchema = rdr.GetSchemaTable();
                    }
                    cnn.Close();
                }
            }

            return tblSchema;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public Object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, CommandType.Text, null);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <returns></returns>
        public Object ExecuteScalar(string sql, CommandType commandType)
        {
            return ExecuteScalar(sql, commandType, null);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <param name="parameters">Transact-SQL 语句或存储过程的参数数组</param>
        /// <returns></returns>
        public Object ExecuteScalar(string sql, CommandType commandType, List<SQLiteParameter> parameters)
        {
            object result = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.CommandType = commandType;//设置command的CommandType为指定的CommandType
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (SQLiteParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open();//打开数据库连接
                    result = command.ExecuteScalar();
                }
            }
            return result;//返回查询结果的第一行第一列，忽略其它行和列
        }
        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="sql">要执行的查询SQL文本命令</param>
        /// <returns></returns>
        public Result ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, CommandType.Text, null);
        }
        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <returns></returns>
        public Result ExecuteNonQuery(string sql, CommandType commandType)
        {
            return ExecuteNonQuery(sql, commandType, null);
        }
        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="commandType">要执行的查询语句的类型，如存储过程或者SQL文本命令</param>
        /// <param name="parameters">Transact-SQL 语句或存储过程的参数数组</param>
        /// <returns></returns>
        public Result ExecuteNonQuery(string sql, CommandType commandType, List<SQLiteParameter> parameters)
        {
            Result result = new Result();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();//打开数据库连接
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.CommandType = commandType;//设置command的CommandType为指定的CommandType
                                                          //如果同时传入了参数，则添加这些参数
                        if (parameters != null)
                        {
                            foreach (SQLiteParameter parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }

                        result.Count = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.Information = ex.Message;
            }

            return result;//返回执行增删改操作之后，数据库中受影响的行数
        }
        /// <summary>
        /// 返回当前连接的数据库中所有由用户创建的数据库
        /// </summary>
        /// <returns></returns>
        public DataTable GetTables()
        {
            DataTable data = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();//打开数据库连接
                data = connection.GetSchema("Tables");
            }
            return data;
        }
        /// <summary>
        /// 基于数据库事务执行多条SQL语句
        /// </summary>
        /// <param name="SQLStringList">数据库数组</param>
        /// <returns></returns>
        public Result ExecuteSqlTran(List<SQLStringObject> SQLStringObjectList)
        {
            string msg = "";
            Result result = new Result();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = conn;
                SQLiteTransaction tx = conn.BeginTransaction();
                command.Transaction = tx;
                int count = 0;
                try
                {
                    for (int n = 0; n < SQLStringObjectList.Count; n++)
                    {
                        string strsql = SQLStringObjectList[n].StrSql;
                        List<SQLiteParameter> parameters = SQLStringObjectList[n].Parameter;
                        command.CommandText = strsql;
                        if (parameters != null)
                        {
                            foreach (SQLiteParameter parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        int resultCount = command.ExecuteNonQuery();
                        if (resultCount == 0)
                        {
                            msg += parameters[1].Value.ToString() + "," + parameters[2].Value.ToString() + "......;" + "\r\n";
                        }
                        count += resultCount;
                    }
                    if (count == SQLStringObjectList.Count)
                    {
                        tx.Commit();
                        result.Count = count;
                        result.Information = "批量执行成功";
                    }
                    else
                    {
                        tx.Rollback();
                        result.Count = count;
                        result.Information = "批量执行失败" + "\r\n" + msg + "以上数据存在问题，请检查";

                    }

                }
                catch (System.Data.SqlClient.SqlException E)
                {
                    tx.Rollback();
                    result.Count = count;
                    result.Information = "批量执行发生异常";
                    result.Exception = E;
                }
            }

            return result;
        }

    }
}
