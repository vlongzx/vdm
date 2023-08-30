using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
  public  class FamerBLL
    {
        private FamerDAL famerDAL = null;

        public FamerBLL()
        {
            this.famerDAL = new FamerDAL();
        }
        //public int getTotalFamer()
        //{
        //    return this.famerDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalFamerCount(Hashtable conditon)
        {
            return this.famerDAL.getTotalCount(conditon);
        }
        public DataTable getAllFamerDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            List<Famer> list_people = new List<Famer>();
            DataTable dt = this.famerDAL.queryAllFamer(condition, pageIndex, pageSize);
            return dt;
        }

    }
}
