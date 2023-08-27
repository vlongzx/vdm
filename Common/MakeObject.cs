using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.common
{
    /// <summary>
    /// 将datatable 封装成 model对象
    /// </summary>
    public static class MakeObject
    {
        /// <summary>
        ///  将datatable封装成people对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static People MakeObjectToPeople(DataRow row)
        {
            People people = new People();
            people.Big_ill_help = row["Big_ill_help"].ToString();
            people.Birthday = row["Birthday"].ToString();
            people.Blood_type = row["Blood_type"].ToString();
            people.Creater = row["Creater"].ToString();
            people.Create_datetime = row["Create_datetime"].ToString();
            people.Disability_grade = row["Disability_grade"].ToString();
            people.Disability_reason = row["Disability_reason"].ToString();
            people.Disability_type = row["Disability_type"].ToString();
            people.Education = row["Education"].ToString();
            people.Employ_guide = row["Employ_guide"].ToString();
            people.Farmer_id = int.Parse(row["Farmer_id"].ToString());
            people.Idcard = row["Idcard"].ToString();
            people.Industry = row["Industry"].ToString();
            people.Is_real_name = row["Is_real_name"].ToString();
            people.Is_relocation = row["Is_relocation"].ToString();
            people.Is_unable_old = row["Is_unable_old"].ToString();
            people.Join_party_time = row["Join_party_time"].ToString();
            people.Last_updater = row["Last_updater"].ToString();
            people.Last_update_datetime = row["Last_update_datetime"].ToString();
            people.Low_five = row["Low_five"].ToString();
            people.Low_five_grade = row["Low_five_grade"].ToString();
            people.Marital_status = row["Marital_status"].ToString();
            people.Military_service = row["Military_service"].ToString();
            people.Nation = row["Nation"].ToString();
            people.People_id = int.Parse(row["People_id"].ToString());
            people.People_name = row["People_name"].ToString();
            people.Phone_number = row["Phone_number"].ToString();
            people.Politcal_outlook = row["Politcal_outlook"].ToString();
            people.Career_grade = row["Career_grade"].ToString();
            people.Career_get_time = row["Career_get_time"].ToString();
            people.Relationship = row["Relationship"].ToString();
            people.Religious_belief = row["Religious_belief"].ToString();
            people.Remark = row["Remark"].ToString();
            people.Sex = row["Sex"].ToString();
            people.Skill_train = row["Skill_train"].ToString();
            people.Skill_type = row["Skill_type"].ToString();
            people.Statues = int.Parse(row["Statues"].ToString());
            people.Temporary_help = row["Temporary_help"].ToString();
            people.Unit_or_school = row["Unit_or_school"].ToString();
            people.Work_or_study = row["Work_or_study"].ToString();
            people.Work_study_location = row["Work_study_location"].ToString();

            return people;
        }
    }
}
