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
    public class PlantBLL
    {
        private PlantDAL plantDAL = null;

        public PlantBLL()
        {
            this.plantDAL = new PlantDAL();
        }
        /// <summary>
        /// 根据条件查询种植信息
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面记录数</param>
        /// <returns></returns>
        public DataTable getAllPlant(Hashtable condition,int pageIndex,int pageSize)
        {
            return this.plantDAL.queryAllPlant(condition, pageIndex, pageSize);
        }
        /// <summary>
        /// 根据条件获得所有的种植信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable getAllPlant(Hashtable condition)
        {
            return this.plantDAL.queryAllPlant(condition);
        }
        public bool getPlantByIdCard(string IdCard,long Plant_id)
        {
            DataTable dt =  this.plantDAL.queryPlantByIdCard(IdCard, Plant_id);

            if (dt != null && dt.Rows.Count > 0)
            {
                //判断是否是当前编辑的记录
                foreach (DataRow row in dt.Rows)
                {
                    if (row["plant_id"].ToString() == Plant_id.ToString())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


        public Plant getPlant(int plant_id)
        {
            DataTable dt = this.plantDAL.queryPlant(plant_id);
            Plant plant = null;
            if(dt != null && dt.Rows.Count > 0)
            {
                plant = new Plant();
                plant.Address = dt.Rows[0]["Address"].ToString();
                plant.Contact_person = dt.Rows[0]["Contact_person"].ToString();
                plant.Creater = dt.Rows[0]["Creater"].ToString();
                plant.Create_datetime = dt.Rows[0]["Create_datetime"].ToString();
                plant.Develop_willing = dt.Rows[0]["Develop_willing"].ToString();
                plant.Insect_ill = dt.Rows[0]["Insect_ill"].ToString();
                plant.Is_plan = dt.Rows[0]["Is_plan"].ToString();
                plant.Idcard = dt.Rows[0]["Idcard"].ToString();
                plant.Last_updater = dt.Rows[0]["Last_updater"].ToString();
                plant.Last_update_datetime = dt.Rows[0]["Last_update_datetime"].ToString();
                plant.Manage_skill_method = dt.Rows[0]["Manage_skill_method"].ToString();
                plant.Output = double.Parse(dt.Rows[0]["Output"].ToString());
                plant.Phone_number = dt.Rows[0]["Phone_number"].ToString();
                plant.Plant_area = double.Parse(dt.Rows[0]["Plant_area"].ToString());
                plant.Plant_brand = dt.Rows[0]["Plant_brand"].ToString();
                plant.Plant_id = long.Parse(dt.Rows[0]["Plant_id"].ToString());
                plant.Plant_type = dt.Rows[0]["Plant_type"].ToString();
                plant.Question = dt.Rows[0]["Question"].ToString();
                plant.Remark = dt.Rows[0]["Remark"].ToString();
                plant.Sale_way = dt.Rows[0]["Sale_way"].ToString();
                plant.Town = dt.Rows[0]["Town"].ToString();
                plant.Village = dt.Rows[0]["Village"].ToString();
                plant.Year_yield = double.Parse(dt.Rows[0]["Year_yield"].ToString());

            }

            return plant;
        }
        /// <summary>
        /// 根据查询条件获得总记录数
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            return this.plantDAL.getTotalCount(condition);
        }
        /// <summary>
        /// 增加种植信息
        /// </summary>
        /// <param name="plant">种植信息对象</param>
        /// <returns></returns>
        public Result addPlant(Plant plant)
        {
            return this.plantDAL.createPlant(plant);

        }
        /// <summary>
        ///  批量增加种植信息
        /// </summary>
        /// <param name="plants">种植信息对象列表</param>
        /// <returns></returns>
        public Result batchAddPlant(List<Plant> plants)
        {
            return this.plantDAL.batchCreatePlant(plants);
        }

        /// <summary>
        /// 编辑种植信息
        /// </summary>
        /// <param name="plant">种植信息对象</param>
        /// <returns></returns>
        public Result editPlant(Plant plant)
        {
            return this.plantDAL.updatePlant(plant);
        }
        /// <summary>
        ///  删除种植信息
        /// </summary>
        /// <param name="plant_id">种植信息ID</param>
        /// <returns></returns>
        public Result delPlant(int plant_id)
        {
            return this.plantDAL.deletePlant(plant_id);
        }
        /// <summary>
        ///  删除所有种植信息
        /// </summary>
        /// <returns></returns>
        public Result deleteAll()
        {
            return this.plantDAL.deleteAll();
        }


    }
}
