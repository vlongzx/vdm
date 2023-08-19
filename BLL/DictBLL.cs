using com.vdm.common;
using com.vdm.dal;
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
            if(dtDict != null )
            {
                KeyValue kv = null;
                foreach(DataRow row in dtDict.Rows)
                {
                    string key = row["key"].ToString();
                    string value = row["value"].ToString();
                    kv = new KeyValue(key,value);
                    list.Add(kv);
                }
            }
            return list;
        }
    }
}
