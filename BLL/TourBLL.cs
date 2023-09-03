using com.vdm.common;
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
   public  class TourBLL
    {
        private TourDAL tourDAL = null;

        public TourBLL()
        {
            this.tourDAL = new TourDAL();
        }
        /// <summary>
        ///  根据查询条件获取旅游信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面记录数</param>
        /// <returns></returns>
        public DataTable getAllTour(Hashtable condition,int pageIndex,int pageSize)
        {
            return this.tourDAL.queryAllTour(condition, pageIndex, pageSize);
        }
        /// <summary>
        ///  根据条件获得所有的旅游信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public DataTable getAllTour(Hashtable condition)
        {
            return this.tourDAL.queryAllTour(condition);
        }
        /// <summary>
        ///  获得记录总数
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            return this.tourDAL.getTotalCount(condition);
        }
        /// <summary>
        ///  根据旅游信息ID获得旅游信息对象
        /// </summary>
        /// <param name="tour_id">旅游信息ID</param>
        /// <returns></returns>
        public Tour getTour(int tour_id)
        {
            DataTable dt = this.tourDAL.queryTour(tour_id);
            Tour tour = null;
            if(dt != null && dt.Rows.Count > 0)
            {
                tour = new Tour();
                tour.Address = dt.Rows[0]["address"].ToString();
                tour.Company_id = dt.Rows[0]["company_id"].ToString();
                tour.Creater = dt.Rows[0]["creater"].ToString();
                tour.Create_datetime = dt.Rows[0]["create_datetime"].ToString();
                tour.Legal_name = dt.Rows[0]["legal_name"].ToString();
                tour.Phone_number = dt.Rows[0]["phone_number"].ToString();
                tour.Principal_category = dt.Rows[0]["principal_category"].ToString();
                tour.Principal_name = dt.Rows[0]["principal_name"].ToString();
                tour.Registered_trademark = dt.Rows[0]["registered_trademark"].ToString();
                tour.Tour_id = tour_id;
                tour.Town = dt.Rows[0]["town"].ToString();
                tour.Trade_form = dt.Rows[0]["trade_form"].ToString();
                tour.Village = dt.Rows[0]["village"].ToString();
                tour.Year_person_count = int.Parse(dt.Rows[0]["year_person_count"].ToString());
                tour.Year_trade_income = double.Parse(dt.Rows[0]["year_trade_income"].ToString());
            }
            return tour;
        }
        /// <summary>
        ///  增加旅游信息
        /// </summary>
        /// <param name="tour">旅游信息对象</param>
        /// <returns></returns>
        public Result addTour(Tour tour)
        {
            return this.tourDAL.CreateTour(tour);
        }
        /// <summary>
        ///  批量增加旅游信息
        /// </summary>
        /// <param name="tours">旅游信息对象列表</param>
        /// <returns></returns>
        public Result batchAddTour(List<Tour> tours)
        {
            return this.tourDAL.BatchCreateTour(tours);

        }
        /// <summary>
        ///  编辑旅游信息
        /// </summary>
        /// <param name="tour">旅游信息对象</param>
        /// <returns></returns>
        public Result editTour(Tour tour)
        {
            return this.tourDAL.UpdateTour(tour);
        }
        /// <summary>
        ///  根据信息ID删除旅游信息
        /// </summary>
        /// <param name="tour_id">旅游信息ID</param>
        /// <returns></returns>
        public Result delTour(int tour_id)
        {
            return this.tourDAL.DeleteTour(tour_id);
        }
    }
}
