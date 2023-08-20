using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.common
{
   public  class Result
    {
        private int count;
        private string information;
        private Exception exception;

        /// <summary>
        ///  操作影响的行数
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        
        /// <summary>
        ///  错误发生的异常
        /// </summary>
        public Exception Exception
        {
            get
            {
                return exception;
            }

            set
            {
                exception = value;
            }
        }
        /// <summary>
        ///  传递的信息
        /// </summary>
        public string Information
        {
            get
            {
                return information;
            }

            set
            {
                information = value;
            }
        }
    }
}
