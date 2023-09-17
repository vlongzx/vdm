using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{

    public class DictBLL
    {
        private DictDAL dictDAL;
        private const string URL = "";
        public DictBLL()
        {
            this.dictDAL = new DictDAL();
        }

        public static void syncDict()
        {
            string url = ConfigurationManager.AppSettings["Sysc_Dict_Url"];
            try
            {
                string response = HttpGet(url);
                dynamic json = JsonConvert.DeserializeObject(response);

                string total = json.total;

                Newtonsoft.Json.Linq.JArray row = json.rows;

                List<RemoteDict> listRemoteDict = DeserializeJsonToList<RemoteDict>(row.ToString());
                DictDAL dictDAL = new DictDAL();
                if (listRemoteDict != null)
                {
                    List<Dict> dicts = new List<Dict>();
                    Dict dict = null;
                    for (int i = 0; i < listRemoteDict.Count; i++)
                    {
                        dict = new Dict();
                        dict.Dataindex = listRemoteDict[i].DictSort;
                        dict.Datakey = listRemoteDict[i].DictLabel;
                        dict.Datavalue = listRemoteDict[i].DictValue;
                        dict.Dict_code = listRemoteDict[i].DictType;
                        dict.Dict_name = listRemoteDict[i].DictType;
                        dicts.Add(dict);
                    }
                    dictDAL.BatchCreateDict(dicts);
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
        ///  根据字典项标识获取键值对
        /// </summary>
        /// <param name="dict_code">字典项标识</param>
        /// <returns></returns>
        public List<KeyValue> getDict(string dict_code)
        {
            DataTable dtDict = this.dictDAL.getDict(dict_code);
            List<KeyValue> list = new List<KeyValue>();
            if (dtDict != null)
            {
                KeyValue kv = null;
                foreach (DataRow row in dtDict.Rows)
                {
                    string key = row["datakey"].ToString();
                    string value = row["datavalue"].ToString();
                    kv = new KeyValue(key, value);
                    list.Add(kv);
                }
            }
            return list;
        }

        /// <summary>
        ///  根据字典项标识获取值(不获取键)
        /// </summary>
        /// <param name="dict_code">字典项标识</param>
        /// <returns></returns>
        public List<string> getDictCheckBox(string dict_code)
        {
            DataTable dtDict = this.dictDAL.getDictCheckBox(dict_code);
            List<string> list = new List<string>();
            if (dtDict != null)
            {
                foreach (DataRow row in dtDict.Rows)
                {
                    string dataValue = row["datavalue"].ToString();
                    list.Add(dataValue);
                }
            }
            return list;
        }


        public Dict getDictById(int id)
        {
            Dict dict = null;
            DataTable dt =  this.dictDAL.getDictById(id);
            if(dt != null && dt.Rows.Count > 0)
            {
                dict = new Dict();
                dict.Id = int.Parse(dt.Rows[0]["id"].ToString());
                dict.Dict_code = dt.Rows[0]["dict_code"].ToString();
                dict.Dict_name = dt.Rows[0]["dict_name"].ToString();
                dict.Datakey = dt.Rows[0]["datakey"].ToString();
                dict.Datavalue = dt.Rows[0]["datavalue"].ToString();
                dict.Dataindex = int.Parse(dt.Rows[0]["dataindex"].ToString());
            }
            return dict;
        }
        /// <summary>
        ///  获得不重复的字典项
        /// </summary>
        /// <returns></returns>
        public DataTable getDistinctDict()
        {
            return this.dictDAL.getDistinctDict();
        }

        /// <summary>
        ///  获得所有字典项
        /// </summary>
        /// <returns></returns>
        public DataTable getAllDict()
        {
            return this.dictDAL.getAllDict();
        }

        public DataTable getDictByCode(string dict_code)
        {
            return this.dictDAL.getDictByCode(dict_code);
        }

        public Result addDict(Dict dict)
        {
            return this.dictDAL.CreateDict(dict);
        }

        public Result editDict(Dict dict)
        {
            return this.dictDAL.UpdateDict(dict);
        }

        public Result DelDict(int id)
        {
            return this.dictDAL.DeleteDict(id);
        }
    }
}
