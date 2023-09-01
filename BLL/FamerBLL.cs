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
    public class FamerBLL
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
            DataTable dt = this.famerDAL.queryAllFamer(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddFamer(Famer famer)
        {
            return this.famerDAL.CreateFamer(famer);
        }
        public Result EditFamer(Famer famer)
        {
            return this.famerDAL.UpdateFamer(famer);
        }

        public Result DelFamer(long famer_id)
        {
            return this.famerDAL.DeleteFamer(famer_id);
        }
        /// <summary>
        ///  根据famer_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Famer getFamer(int famer_id)
        {
            DataTable dt = this.famerDAL.getFamer(famer_id);
            Famer famer = new Famer();
            DataTable tblSchema = this.famerDAL.getTableSchema("t_famer");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        famer.GetType().GetProperty(PropertyName).SetValue(famer, string.Empty);
                    }
                    else
                    {
                        famer.GetType().GetProperty(PropertyName).SetValue(famer, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return famer;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Famer> getAllFamer(Hashtable condition)
        {
            List<Famer> list_famer = new List<Famer>();
            DataTable dt = this.famerDAL.getAllFamer(condition);
            if (dt != null)
            {
                Famer p = null;
                foreach (DataRow row in dt.Rows)
                {
                    p = MakeObject.MakeObjectToFamer(row);
                    list_famer.Add(p);
                }
            }
            return list_famer;
        }
    }
}
