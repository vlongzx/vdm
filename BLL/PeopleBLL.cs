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
    public class PeopleBLL
    {
        private PeopleDAL peopleDAL = null;

        public PeopleBLL() {
            this.peopleDAL = new PeopleDAL();
        }
        public int getTotalPeople()
        {
            return this.peopleDAL.getTotalPeople();
        }

        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalPeopleIf(Hashtable conditon)
        {
            return this.peopleDAL.getTotalPeopleIf(conditon);
        }



        public List<People> getAllPeopleList(Hashtable condition, int pageIndex, int pageSize)
        {
            List<People> list_people = new List<People>();
            DataTable dt = this.peopleDAL.getAllPeople(condition, pageIndex, pageSize);

            if (dt != null)
            {
                People p = null;
                foreach (DataRow row in dt.Rows)
                {
                    p = MakeObject.MakeObjectToPeople(row);
                    list_people.Add(p);
                }
            }
            return list_people;
        }

        
        public DataTable getAllPeopleDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            List<People> list_people = new List<People>();
            DataTable dt = this.peopleDAL.getAllPeople(condition, pageIndex, pageSize);
            return dt;
        }

        public List<People> getAllPeople(Hashtable condition)
        {
            List<People> list_people = new List<People>();
            DataTable dt = this.peopleDAL.getAllPeople(condition);

            if (dt != null)
            {
                People p = null;
                foreach (DataRow row in dt.Rows)
                {
                    p = MakeObject.MakeObjectToPeople(row);
                    list_people.Add(p);
                }
            }
            return list_people;
        }
        /// <summary>
        ///  根据people_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public People getPeople(int people_id)
        {
            DataTable dt = this.peopleDAL.getPeople(people_id);
            People people = new People();
            DataTable tblSchema = this.peopleDAL.getTableSchema("t_people");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if(dt.Rows[0][ColumnName]== System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        people.GetType().GetProperty(PropertyName).SetValue(people, string.Empty);
                    }
                    else
                    {
                        people.GetType().GetProperty(PropertyName).SetValue(people, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return people;
        }

        public Result AddPeople(People people)
        {
            return this.peopleDAL.CreatePeople(people);
        }

        public Result EditPeople(People people)
        {
            return this.peopleDAL.UpdatePeople(people);
        }

        public Result DelPeople(long people_id)
        {
            return this.peopleDAL.DeletePeople(people_id);
        }
    }
}
