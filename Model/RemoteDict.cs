using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
    public class RemoteDict
    {
        private string createBy;
        private string createTime;
        private string updateBy;
        private string updateTime;
        private string remark;
        private string dictCode;
        private int dictSort;
        private string dictLabel;
        private string dictValue;
        private string dictType;
        private string cssClass;
        private string listClass;
        private string isDefault;
        private string status;

        public string CreateBy
        {
            get
            {
                return createBy;
            }

            set
            {
                createBy = value;
            }
        }

        public string CreateTime
        {
            get
            {
                return createTime;
            }

            set
            {
                createTime = value;
            }
        }

        public string UpdateBy
        {
            get
            {
                return updateBy;
            }

            set
            {
                updateBy = value;
            }
        }

        public string UpdateTime
        {
            get
            {
                return updateTime;
            }

            set
            {
                updateTime = value;
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

        public string DictCode
        {
            get
            {
                return dictCode;
            }

            set
            {
                dictCode = value;
            }
        }

        public int DictSort
        {
            get
            {
                return dictSort;
            }

            set
            {
                dictSort = value;
            }
        }

        public string DictLabel
        {
            get
            {
                return dictLabel;
            }

            set
            {
                dictLabel = value;
            }
        }

        public string DictValue
        {
            get
            {
                return dictValue;
            }

            set
            {
                dictValue = value;
            }
        }

        public string DictType
        {
            get
            {
                return dictType;
            }

            set
            {
                dictType = value;
            }
        }

        public string CssClass
        {
            get
            {
                return cssClass;
            }

            set
            {
                cssClass = value;
            }
        }

        public string ListClass
        {
            get
            {
                return listClass;
            }

            set
            {
                listClass = value;
            }
        }

        public string IsDefault
        {
            get
            {
                return isDefault;
            }

            set
            {
                isDefault = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
