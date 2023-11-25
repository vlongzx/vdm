using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.model
{
  public  class RemoteSqlNotice
    {
       private int noticeId;
       private string noticeTitle;
       private string noticeType;
       private string noticeContent;
        private string status;
        private string createBy;
        private string createTime;
        private string updateBy;
        private string updateTime;
        private string remark;

        public int NoticeId
        {
            get
            {
                return noticeId;
            }

            set
            {
                noticeId = value;
            }
        }

        public string NoticeTitle
        {
            get
            {
                return noticeTitle;
            }

            set
            {
                noticeTitle = value;
            }
        }

        public string NoticeType
        {
            get
            {
                return noticeType;
            }

            set
            {
                noticeType = value;
            }
        }

        public string NoticeContent
        {
            get
            {
                return noticeContent;
            }

            set
            {
                noticeContent = value;
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
    }
}
