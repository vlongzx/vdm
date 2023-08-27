using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class DataAuthority
    {
        private long data_authority_id;
        private string data_authority_type;
        private string data_authority_desc;
        private string data_authority_name;

        public long Data_authority_id
        {
            get
            {
                return data_authority_id;
            }

            set
            {
                data_authority_id = value;
            }
        }

        public string Data_authority_type
        {
            get
            {
                return data_authority_type;
            }

            set
            {
                data_authority_type = value;
            }
        }

        public string Data_authority_desc
        {
            get
            {
                return data_authority_desc;
            }

            set
            {
                data_authority_desc = value;
            }
        }

        public string Data_authority_name
        {
            get
            {
                return data_authority_name;
            }

            set
            {
                data_authority_name = value;
            }
        }
    }
}
