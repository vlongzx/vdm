using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Dict
    {
        private int id;
        private string dict_name;
        private string dict_code;
        private string key;
        private string value;
        private int index;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Dict_name
        {
            get
            {
                return dict_name;
            }

            set
            {
                dict_name = value;
            }
        }

        public string Dict_code
        {
            get
            {
                return dict_code;
            }

            set
            {
                dict_code = value;
            }
        }

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

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }
    }
}
