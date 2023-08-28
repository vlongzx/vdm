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
   public  class AnimalBLL
    {
        private AnimalDAL animalDAL = null;
        public AnimalBLL()
        {
            this.animalDAL = new AnimalDAL();
        }
        /// <summary>
        ///  获得畜牧信息
        /// </summary>
        /// <param name="breed_id"></param>
        /// <returns></returns>
        public Animal getAnimal(int breed_id)
        {
            DataTable dt = this.animalDAL.queryAnimal(breed_id);
            Animal animal = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                animal = new Animal();
                animal.Breed_id = long.Parse(dt.Rows[0]["breed_id"].ToString());
                animal.Town = dt.Rows[0]["town"].ToString();
                animal.Village = dt.Rows[0]["villiage"].ToString();
                animal.Breed_name = dt.Rows[0]["breed_name"].ToString();
                animal.Breed_type = dt.Rows[0]["breed_type"].ToString();
                animal.Manager = dt.Rows[0]["manager"].ToString();
                animal.Phone_number = dt.Rows[0]["phone_number"].ToString();
                animal.Year_inventory = dt.Rows[0]["year_inventory"].ToString();
                animal.Year_outbound = dt.Rows[0]["year_outbound"].ToString();
                animal.Output = float.Parse(dt.Rows[0]["output"].ToString());
                animal.Total_area = float.Parse(dt.Rows[0]["total_area"].ToString());
                animal.Pen_area = float.Parse(dt.Rows[0]["pen_area"].ToString());
                animal.Midden_area =float.Parse(dt.Rows[0]["midden_area"].ToString());
                animal.Pullttion_area = float.Parse(dt.Rows[0]["pullttion_area"].ToString());
                animal.Cueernt_inventory = long.Parse(dt.Rows[0]["cueernt_inventory"].ToString());
                animal.Animal_qualify = dt.Rows[0]["animal_qualify"].ToString();
                animal.Solid_pollution = dt.Rows[0]["solid_pollution"].ToString();
                animal.Report_or_filings = dt.Rows[0]["report_or_filings"].ToString();
                animal.Create_datetime = dt.Rows[0]["create_datetime"].ToString();
                animal.Creater = dt.Rows[0]["creater"].ToString();
                animal.Last_update_datetime = dt.Rows[0]["last_update_datetime"].ToString();
                animal.Last_updater = dt.Rows[0]["last_updater"].ToString();
            }
            return animal;
        }
        /// <summary>
        ///  获得所有的畜牧
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public DataTable  getAllAnimal(Hashtable condition,int PageIndex, int PageSize)
        {
            return this.animalDAL.queryAllAnimal(condition, PageIndex, PageSize);
        }
        /// <summary>
        ///  增加畜牧
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result addAnimal(Animal animal)
        {
            return this.animalDAL.CreateAnimal(animal);
        }
        /// <summary>
        ///  编辑畜牧
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result editAnimal(Animal animal)
        {
            return this.animalDAL.UpdateAnimal(animal);
        }
        /// <summary>
        ///  删除畜牧
        /// </summary>
        /// <param name="breed_id"></param>
        /// <returns></returns>
        public Result delAnimal(int breed_id)
        {
            return this.animalDAL.DeleteAnimal(breed_id);
        }
    }
}
