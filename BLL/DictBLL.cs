using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{

    public class DictBLL
    {
        private DictDAL dictDAL;

        public DictBLL()
        {
            this.dictDAL = new DictDAL();
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
