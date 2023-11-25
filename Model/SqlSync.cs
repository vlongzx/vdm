using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
  public  class SqlSync
    {
        private long id;
        private string sql_string;

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


        public string Sql_string
        {
            get
            {
                return sql_string;
            }

            set
            {
                sql_string = value;
            }
        }
    }
}
