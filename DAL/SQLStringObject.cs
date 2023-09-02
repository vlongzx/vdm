using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class SQLStringObject
    {
        string strSql = null;
        List<SQLiteParameter> parameters = null;
        public SQLStringObject()
        {

        }

        public SQLStringObject(string strSql, List<SQLiteParameter> parameters)
        {
            this.StrSql = strSql;
            this.Parameter = parameters;
        }
        /// <summary>
        ///  带有@para的Sql字符串
        /// </summary>
        public string StrSql
        {
            get
            {
                return strSql;
            }

            set
            {
                strSql = value;
            }
        }
        /// <summary>
        ///  Sql对于的参数值
        /// </summary>
        public List<SQLiteParameter> Parameter
        {
            get
            {
                return parameters;
            }

            set
            {
                parameters = value;
            }
        }
    }
}
