﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Function
    {
        private long function_id;
        private long pre_function_id;
        private string function_code;
        private string function_name;
        private string remark;

        /// <summary>
        /// 功能ID
        /// </summary>
        public long Function_id
        {
            get
            {
                return function_id;
            }

            set
            {
                function_id = value;
            }
        }
        /// <summary>
        /// 父功能ID
        /// </summary>
        public long Pre_function_id
        {
            get
            {
                return pre_function_id;
            }

            set
            {
                pre_function_id = value;
            }
        }
        /// <summary>
        ///  功能编码
        /// </summary>
        public string Function_code
        {
            get
            {
                return function_code;
            }

            set
            {
                function_code = value;
            }
        }
        /// <summary>
        ///  功能名称
        /// </summary>
        public string Function_name
        {
            get
            {
                return function_name;
            }

            set
            {
                function_name = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
    }
}