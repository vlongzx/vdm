
using com.vdm.common;
using com.vdm.dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using com.vdm.model;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace com.vdm.bll
{
  public  class SqlSyncBLL
    {
        private SqlSyncDAL sqlSyncDAL = null;
        public SqlSyncBLL()
        {
            this.sqlSyncDAL = new SqlSyncDAL();
        }

        //同步sql语句
        public static void syncNotice()
        {

            string url = ConfigurationManager.AppSettings["Sysc_Notice_Url"];
            try
            {
                string response = HttpGet(url);
                dynamic json = JsonConvert.DeserializeObject(response);

                string total = json.total;

                Newtonsoft.Json.Linq.JArray row = json.rows;
                List<RemoteSqlNotice> listRemoteSqlNotice = DeserializeJsonToList<RemoteSqlNotice>(row.ToString());
                SqlSyncDAL sqlSyncDAL = new SqlSyncDAL();
                //0、创建t_sql_sync表
                sqlSyncDAL.CreateTableSqlSync();
                if (listRemoteSqlNotice != null)
                {
                    List<SqlSync> sqlSyncs = new List<SqlSync>();
                    SqlSync sqlSync = null;
                    for (int i = 0; i < listRemoteSqlNotice.Count; i++)
                    {
                        sqlSync = new SqlSync();
                        sqlSync.Id = listRemoteSqlNotice[i].NoticeId;
                        sqlSync.Sql_string = listRemoteSqlNotice[i].NoticeContent;
                        if (sqlSyncDAL.QueryById(sqlSync.Id).Rows.Count==0)
                        {
                            //若本地表不存在该条数据
                            sqlSyncs.Add(sqlSync);
                        }
                    }
                    if (sqlSyncs.Count != 0)
                    {
     

                        //1、批量插入
                        sqlSyncDAL.BatchCreateSqlSync(sqlSyncs);
                        //2、执行新增的sql语句:新增、删除、修改
                        sqlSyncDAL.BatchExecuteSql(sqlSyncs);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message + ex.StackTrace);
            }
        }
        /// <summary>
        ///  发起HTTP请求
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string HttpGet(string Url)
        {
            string retString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var responseText = response.GetResponseStream();
                //获取内容
                retString = new StreamReader(responseText).ReadToEnd();

                return retString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new Newtonsoft.Json.JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

        /// <summary>
        /// 增加sql语句同步信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public Result CreateTableSqlSync( )
        {
            return this.sqlSyncDAL.CreateTableSqlSync();
        }
    }
}
