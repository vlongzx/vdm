using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.bll
{
    public class PeopleBLL
    {
        private PeopleDAL peopleDAL = null;

        public PeopleBLL() {
            this.peopleDAL = new PeopleDAL();
        }

        /// <summary>
        ///  获得所有的人员信息
        /// </summary>
        /// <returns></returns>
        public List<People> getAllPeople()
        {
            List<People> list_people = new List<People>();
            DataTable dt = this.peopleDAL.getAllPeople();

            if(dt != null)
            {
                People people = null;
                foreach(DataRow row in dt.Rows)
                {
                    people = MakeObject.MakeObjectToPeople(row);
                    list_people.Add(people);
                }
            }
            return list_people;
        }
    }
}
