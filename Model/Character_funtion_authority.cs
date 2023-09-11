using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class Character_funtion_authority
    {
        private long character_id;
        private long function_id;
        /// <summary>
        /// 角色ID
        /// </summary>
        public long Character_id
        {
            get
            {
                return character_id;
            }

            set
            {
                character_id = value;
            }
        }
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
    }
}
