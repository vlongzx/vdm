using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
   public  class ListRemoteDict
    {
        private int total;
        private List<RemoteDict> rows;

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public List<RemoteDict> Rows
        {
            get
            {
                return rows;
            }

            set
            {
                rows = value;
            }
        }
    }
}
