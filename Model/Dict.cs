using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Dict
    {
       private long id;
        private string dict_code;
        private string dict_name;
        private string datakey;
        private string datavalue;
        private int dataindex;

        public long Id
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

        public string Datakey
        {
            get
            {
                return datakey;
            }

            set
            {
                datakey = value;
            }
        }

        public string Datavalue
        {
            get
            {
                return datavalue;
            }

            set
            {
                datavalue = value;
            }
        }

        public int Dataindex
        {
            get
            {
                return dataindex;
            }

            set
            {
                dataindex = value;
            }
        }
    }

}
