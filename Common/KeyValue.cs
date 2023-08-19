using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.common
{
    public class KeyValue
    {
        private string key;
        private string value;

        public KeyValue()
        {

        }

        public KeyValue(string key,string value)
        {
            this.Key = key;
            this.Value = value;
        }
        /// <summary>
        /// 键值对KEY
        /// </summary>
        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }
        /// <summary>
        ///  键值对VALUE
        /// </summary>
        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
