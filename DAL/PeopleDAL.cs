using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class PeopleDAL: BaseDAL
    {
        

        public PeopleDAL()
        {
        }

        /// <summary>
        /// 获取所有人员个数
        /// </summary>
        /// <returns></returns>
        public int getTotalPeople()
        {
            string sql = "select * from t_people  order by create_datetime desc";
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql);
            if(dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        /// 获取条件查询所有人员个数
        /// </summary>
        /// <returns></returns>
        public int getTotalPeopleIf(Hashtable condition)
        {
            string sql = "select * from t_people where 1 = 1";
            //基本查询条件
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name like @people_name";
            }
            if (condition["Sex"].ToString() != "")
            {
                sql += "    and sex = @sex";
            }
            if (condition["Nation"].ToString() != "")
            {
                sql += "    and nation = @nation";
            }
            if (condition["Relationship"].ToString() != "")
            {
                sql += "    and relationship = @relationship";
            }
            if (condition["Politcal_outlook"].ToString() != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (condition["Phone_number"].ToString() != "")
            {
                sql += "    and phone_number like @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard like @idcard";
            }
            if (condition["Skill_type"].ToString() != "")
            {
                sql += "    and skill_type = @skill_type";
            }
            if (condition["Village"].ToString() != "")
            {
                sql += "    and villiage = @village";
            }
            if (condition["Town"].ToString() != "")
            {
                sql += "    and town = @town";
            }
            if (condition["Marital_status"].ToString() != "")
            {
                sql += "    and marital_status = @marital_status";
            }
            if (condition["Education"].ToString() != "")
            {
                sql += "    and education = @education";
            }
            if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
            {
                sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
            }
            if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
            {
                sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
            }

            //高级查询条件
            if (condition.ContainsKey("Work_or_study") && condition["Work_or_study"].ToString() != "")
            {
                sql += "    and Work_or_study = @Work_or_study";
            }
            if (condition.ContainsKey("Religious_belief") && condition["Religious_belief"].ToString() != "")
            {
                sql += "    and Religious_belief like @Religious_belief";
            }
            if (condition.ContainsKey("Is_real_name") && condition["Is_real_name"].ToString() != "")
            {
                sql += "    and Is_real_name = @Is_real_name";
            }
            if (condition.ContainsKey("Blood_type") && condition["Blood_type"].ToString() != "")
            {
                sql += "    and Blood_type = @Blood_type";
            }
            if (condition.ContainsKey("Industry") && condition["Industry"].ToString() != "")
            {
                sql += "    and Industry like @Industry";
            }
            if (condition.ContainsKey("Unit_or_school") && condition["Unit_or_school"].ToString() != "")
            {
                sql += "    and Unit_or_school like @Unit_or_school";
            }
            if (condition.ContainsKey("Work_study_location") && condition["Work_study_location"].ToString() != "")
            {
                sql += "    and Work_study_location like @Work_study_location";
            }
            if (condition.ContainsKey("Employ_guide") && condition["Employ_guide"].ToString() != "")
            {
                sql += "    and Employ_guide = @Employ_guide";
            }
            if (condition.ContainsKey("Skill_train") && condition["Skill_train"].ToString() != "")
            {
                sql += "    and Skill_train = @Skill_train";
            }
            if (condition.ContainsKey("Is_career_grade") && condition["Is_career_grade"].ToString() != "")
            {
                sql += "    and Is_career_grade = @Is_career_grade";
            }
            if (condition.ContainsKey("Career_grade") && condition["Career_grade"].ToString() != "")
            {
                sql += "    and Career_grade like @Career_grade";
            }
            if (condition.ContainsKey("Career_get_time") && condition["Career_get_time"].ToString() != "")
            {
                sql += "    and work_or_study = @work_or_study";
            }
            if (condition.ContainsKey("Disability_type") && condition["Disability_type"].ToString() != "")
            {
                sql += "    and Disability_type = @Disability_type";
            }
            if (condition.ContainsKey("Disability_grade") && condition["Disability_grade"].ToString() != "")
            {
                sql += "    and Disability_grade = @Disability_grade";
            }
            if (condition.ContainsKey("Disability_reason") && condition["Disability_reason"].ToString() != "")
            {
                sql += "    and Disability_reason like @Disability_reason";
            }
            if (condition.ContainsKey("Big_ill_help") && condition["Big_ill_help"].ToString() != "")
            {
                sql += "    and Big_ill_help = @Big_ill_help";
            }
            if (condition.ContainsKey("Temporary_help") && condition["Temporary_help"].ToString() != "")
            {
                sql += "    and Temporary_help = @Temporary_help";
            }
            if (condition.ContainsKey("Is_unable_old") && condition["Is_unable_old"].ToString() != "")
            {
                sql += "    and Is_unable_old = @Is_unable_old";
            }
            if (condition.ContainsKey("Is_relocation") && condition["Is_relocation"].ToString() != "")
            {
                sql += "    and Is_relocation = @Is_relocation";
            }
            if (condition.ContainsKey("Low_five") && condition["Low_five"].ToString() != "")
            {
                sql += "    and Low_five = @Low_five";
            }
            if (condition.ContainsKey("Low_five_grade") && condition["Low_five_grade"].ToString() != "")
            {
                sql += "    and Low_five_grade = @Low_five_grade";
            }
            if (condition.ContainsKey("Military_service") && condition["Military_service"].ToString() != "")
            {
                sql += "    and Military_service = @Military_service";
            }

            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", "%" + condition["People_name"] + "%"));
            parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["Relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", "%" + condition["Phone_number"] + "%"));
            parameters.Add(new SQLiteParameter("@idcard", "%" + condition["Idcard"] + "%"));
            parameters.Add(new SQLiteParameter("@marital_status", condition["Marital_status"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));
            parameters.Add(new SQLiteParameter("@skill_type", condition["Skill_type"]));
            parameters.Add(new SQLiteParameter("@town", condition["Town"]));
            parameters.Add(new SQLiteParameter("@village", condition["Village"]));

            parameters.Add(new SQLiteParameter("@Work_or_study", condition["Work_or_study"]));
            parameters.Add(new SQLiteParameter("@Is_real_name", condition["Is_real_name"]));
            parameters.Add(new SQLiteParameter("@Blood_type", condition["Blood_type"]));
            parameters.Add(new SQLiteParameter("@Religious_belief", "%" + condition["Religious_belief"] + "%"));
            parameters.Add(new SQLiteParameter("@Industry", "%" + condition["Industry"] + "%"));

            parameters.Add(new SQLiteParameter("@Unit_or_school", "%" + condition["Unit_or_school"] + "%"));
            parameters.Add(new SQLiteParameter("@Work_study_location", "%" + condition["Work_study_location"] + "%"));
            parameters.Add(new SQLiteParameter("@Career_grade", "%" + condition["Career_grade"] + "%"));
            parameters.Add(new SQLiteParameter("@Disability_reason", "%" + condition["Disability_reason"] + "%"));

            parameters.Add(new SQLiteParameter("@Employ_guide", condition["Employ_guide"]));
            parameters.Add(new SQLiteParameter("@Skill_train", condition["Skill_train"]));
            parameters.Add(new SQLiteParameter("@Is_career_grade", condition["Is_career_grade"]));
            parameters.Add(new SQLiteParameter("@Career_grade", condition["Career_grade"]));
            parameters.Add(new SQLiteParameter("@Career_get_time", condition["Career_get_time"]));
            parameters.Add(new SQLiteParameter("@Disability_type", condition["Disability_type"]));
            parameters.Add(new SQLiteParameter("@Disability_grade", condition["Disability_grade"]));
            parameters.Add(new SQLiteParameter("@Big_ill_help", condition["Big_ill_help"]));
            parameters.Add(new SQLiteParameter("@Temporary_help", condition["Temporary_help"]));
            parameters.Add(new SQLiteParameter("@Is_unable_old", condition["Is_unable_old"]));
            parameters.Add(new SQLiteParameter("@Is_relocation", condition["Is_relocation"]));
            parameters.Add(new SQLiteParameter("@Low_five", condition["Low_five"]));
            parameters.Add(new SQLiteParameter("@Low_five_grade", condition["Low_five_grade"]));
            parameters.Add(new SQLiteParameter("@Military_service", condition["Military_service"]));


            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        ///  分页查询获取所有的人员信息(空条件查询，重置按钮等使用)
        /// </summary>
        /// <returns></returns>
        public DataTable getAllPeople(int pageIndex, int pageSize)
        {
            int offset = 0;
            int totalPeople = this.getTotalPeople();
            if (pageIndex > 1)
            {
                offset =  (pageIndex-1)* pageSize;
            }
            int limit = 1;
            int pageCount = totalPeople % pageSize > 0 ? totalPeople / pageSize + 1 : totalPeople / pageSize;
            if (pageIndex+1 <=  pageCount)
            {
                limit = pageSize;
            }
            else
            {
                limit = totalPeople - (pageCount - 1) * pageSize;
            }
            string sql =  "select * from t_people order by create_datetime desc LIMIT " + limit + " OFFSET " + offset + " ";
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql);
            return dt;
        }



        /// <summary>
        /// 条件+分页 查询人员信息（查询按钮使用）
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllPeople(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_people where 1 = 1";
            //基本查询条件
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name like @people_name";
            }
            if (condition["Sex"].ToString() != "")
            {
                sql += "    and sex = @sex";
            }
            if (condition["Nation"].ToString() != "")
            {
                sql += "    and nation = @nation";
            }
            if (condition["Relationship"].ToString() != "")
            {
                sql += "    and relationship = @relationship";
            }
            if (condition["Politcal_outlook"].ToString() != "")
            {
                sql += "    and politcal_outlook = @politcal_outlook";
            }
            if (condition["Phone_number"].ToString() != "")
            {
                sql += "    and phone_number like @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard like @idcard";
            }
            if (condition["Skill_type"].ToString() != "")
            {
                sql += "    and skill_type = @skill_type";
            }
            if (condition["Village"].ToString() != "")
            {
                sql += "    and villiage = @village";
            }
            if (condition["Town"].ToString() != "")
            {
                sql += "    and town = @town";
            }
            if (condition["Marital_status"].ToString() != "")
            {
                sql += "    and marital_status = @marital_status";
            }
            if (condition["Education"].ToString() != "")
            {
                sql += "    and education = @education";
            }
            if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
            {
                sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
            }
            if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
            {
                sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
            }

            //高级查询条件
            if (condition.ContainsKey("Work_or_study") && condition["Work_or_study"].ToString() != "")
            {
                sql += "    and Work_or_study = @Work_or_study";
            }
            if (condition.ContainsKey("Religious_belief") && condition["Religious_belief"].ToString() != "")
            {
                sql += "    and Religious_belief like @Religious_belief";
            }
            if (condition.ContainsKey("Is_real_name") && condition["Is_real_name"].ToString() != "")
            {
                sql += "    and Is_real_name = @Is_real_name";
            }
            if (condition.ContainsKey("Blood_type") && condition["Blood_type"].ToString() != "")
            {
                sql += "    and Blood_type = @Blood_type";
            }
            if (condition.ContainsKey("Industry") && condition["Industry"].ToString() != "")
            {
                sql += "    and Industry like @Industry";
            }
            if (condition.ContainsKey("Unit_or_school") && condition["Unit_or_school"].ToString() != "")
            {
                sql += "    and Unit_or_school like @Unit_or_school";
            }
            if (condition.ContainsKey("Work_study_location") && condition["Work_study_location"].ToString() != "")
            {
                sql += "    and Work_study_location like @Work_study_location";
            }
            if (condition.ContainsKey("Employ_guide") && condition["Employ_guide"].ToString() != "")
            {
                sql += "    and Employ_guide = @Employ_guide";
            }
            if (condition.ContainsKey("Skill_train") && condition["Skill_train"].ToString() != "")
            {
                sql += "    and Skill_train = @Skill_train";
            }
            if (condition.ContainsKey("Is_career_grade") && condition["Is_career_grade"].ToString() != "")
            {
                sql += "    and Is_career_grade = @Is_career_grade";
            }
            if (condition.ContainsKey("Career_grade") && condition["Career_grade"].ToString() != "")
            {
                sql += "    and Career_grade like @Career_grade";
            }
            if (condition.ContainsKey("Career_get_time") && condition["Career_get_time"].ToString() != "")
            {
                sql += "    and work_or_study = @work_or_study";
            }
            if (condition.ContainsKey("Disability_type") && condition["Disability_type"].ToString() != "")
            {
                sql += "    and Disability_type = @Disability_type";
            }
            if (condition.ContainsKey("Disability_grade") && condition["Disability_grade"].ToString() != "")
            {
                sql += "    and Disability_grade = @Disability_grade";
            }
            if (condition.ContainsKey("Disability_reason") && condition["Disability_reason"].ToString() != "")
            {
                sql += "    and Disability_reason like @Disability_reason";
            }
            if (condition.ContainsKey("Big_ill_help") && condition["Big_ill_help"].ToString() != "")
            {
                sql += "    and Big_ill_help = @Big_ill_help";
            }
            if (condition.ContainsKey("Temporary_help") && condition["Temporary_help"].ToString() != "")
            {
                sql += "    and Temporary_help = @Temporary_help";
            }
            if (condition.ContainsKey("Is_unable_old") && condition["Is_unable_old"].ToString() != "")
            {
                sql += "    and Is_unable_old = @Is_unable_old";
            }
            if (condition.ContainsKey("Is_relocation") && condition["Is_relocation"].ToString() != "")
            {
                sql += "    and Is_relocation = @Is_relocation";
            }
            if (condition.ContainsKey("Low_five") && condition["Low_five"].ToString() != "")
            {
                sql += "    and Low_five = @Low_five";
            }
            if (condition.ContainsKey("Low_five_grade") && condition["Low_five_grade"].ToString() != "")
            {
                sql += "    and Low_five_grade = @Low_five_grade";
            }
            if (condition.ContainsKey("Military_service") && condition["Military_service"].ToString() != "")
            {
                sql += "    and Military_service = @Military_service";
            }
         
            sql += " order by create_datetime desc";
            int offset = 0;
            int totalPeople = this.getTotalPeopleIf(condition);
            if (pageIndex > 1)
            {
                offset = (pageIndex - 1) * pageSize;
            }
            int limit = 1;
            int pageCount = totalPeople % pageSize > 0 ? totalPeople / pageSize + 1 : totalPeople / pageSize;
            if (pageIndex + 1 <= pageCount)
            {
                limit = pageSize;
            }
            else
            {
                limit = totalPeople - (pageCount - 1) * pageSize;
            }
            sql += "  limit  " + limit;
            sql += "  offset  " + offset;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name","%"+ condition["People_name"]+"%"));
            parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["Relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", "%" + condition["Phone_number"] + "%"));
            parameters.Add(new SQLiteParameter("@idcard", "%" + condition["Idcard"] + "%"));
            parameters.Add(new SQLiteParameter("@marital_status", condition["Marital_status"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));
            parameters.Add(new SQLiteParameter("@skill_type", condition["Skill_type"]));
            parameters.Add(new SQLiteParameter("@town", condition["Town"]));
            parameters.Add(new SQLiteParameter("@village", condition["Village"]));

            parameters.Add(new SQLiteParameter("@Work_or_study", condition["Work_or_study"]));
            parameters.Add(new SQLiteParameter("@Is_real_name", condition["Is_real_name"]));
            parameters.Add(new SQLiteParameter("@Blood_type", condition["Blood_type"]));
            parameters.Add(new SQLiteParameter("@Religious_belief", "%" + condition["Religious_belief"] + "%"));
            parameters.Add(new SQLiteParameter("@Industry", "%" + condition["Industry"] + "%"));

            parameters.Add(new SQLiteParameter("@Unit_or_school", "%" + condition["Unit_or_school"] + "%"));
            parameters.Add(new SQLiteParameter("@Work_study_location", "%" + condition["Work_study_location"] + "%"));
            parameters.Add(new SQLiteParameter("@Career_grade", "%" + condition["Career_grade"] + "%"));
            parameters.Add(new SQLiteParameter("@Disability_reason", "%" + condition["Disability_reason"] + "%"));

            parameters.Add(new SQLiteParameter("@Employ_guide", condition["Employ_guide"]));
            parameters.Add(new SQLiteParameter("@Skill_train", condition["Skill_train"]));
            parameters.Add(new SQLiteParameter("@Is_career_grade", condition["Is_career_grade"]));
            parameters.Add(new SQLiteParameter("@Career_grade", condition["Career_grade"]));
            parameters.Add(new SQLiteParameter("@Career_get_time", condition["Career_get_time"]));
            parameters.Add(new SQLiteParameter("@Disability_type", condition["Disability_type"]));
            parameters.Add(new SQLiteParameter("@Disability_grade", condition["Disability_grade"]));
            parameters.Add(new SQLiteParameter("@Big_ill_help", condition["Big_ill_help"]));
            parameters.Add(new SQLiteParameter("@Temporary_help", condition["Temporary_help"]));
            parameters.Add(new SQLiteParameter("@Is_unable_old", condition["Is_unable_old"]));
            parameters.Add(new SQLiteParameter("@Is_relocation", condition["Is_relocation"]));
            parameters.Add(new SQLiteParameter("@Low_five", condition["Low_five"]));
            parameters.Add(new SQLiteParameter("@Low_five_grade", condition["Low_five_grade"]));
            parameters.Add(new SQLiteParameter("@Military_service", condition["Military_service"]));

            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 条件查询(导出按钮使用)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllPeople(Hashtable condition)
        {
            string sql = "select * from t_people where 1 = 1";
            if (condition!=null)
            {
                //基本查询条件
                if (condition["People_name"].ToString() != "")
                {
                    sql += "    and people_name like @people_name";
                }
                if (condition["Sex"].ToString() != "")
                {
                    sql += "    and sex = @sex";
                }
                if (condition["Nation"].ToString() != "")
                {
                    sql += "    and nation = @nation";
                }
                if (condition["Relationship"].ToString() != "")
                {
                    sql += "    and relationship = @relationship";
                }
                if (condition["Politcal_outlook"].ToString() != "")
                {
                    sql += "    and politcal_outlook = @politcal_outlook";
                }
                if (condition["Phone_number"].ToString() != "")
                {
                    sql += "    and phone_number like @phone_number";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard like @idcard";
                }
                if (condition["Skill_type"].ToString() != "")
                {
                    sql += "    and skill_type = @skill_type";
                }
                if (condition["Village"].ToString() != "")
                {
                    sql += "    and villiage = @village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["Marital_status"].ToString() != "")
                {
                    sql += "    and marital_status = @marital_status";
                }
                if (condition["Education"].ToString() != "")
                {
                    sql += "    and education = @education";
                }
                if (condition["Birthday_From"].ToString() != "" && condition["Birthday_To"].ToString() != null)
                {
                    sql += "  and  birthday BETWEEN '" + condition["Birthday_From"].ToString() + "' AND '" + condition["Birthday_To"].ToString() + "'";
                }
                if (condition["Join_party_time_from"].ToString() != "" && condition["Join_party_time_to"].ToString() != null)
                {
                    sql += " and   join_party_time BETWEEN '" + condition["Join_party_time_from"].ToString() + "' AND '" + condition["Join_party_time_to"].ToString() + "'";
                }

                //高级查询条件
                if (condition.ContainsKey("Work_or_study") && condition["Work_or_study"].ToString() != "")
                {
                    sql += "    and Work_or_study = @Work_or_study";
                }
                if (condition.ContainsKey("Religious_belief") && condition["Religious_belief"].ToString() != "")
                {
                    sql += "    and Religious_belief like @Religious_belief";
                }
                if (condition.ContainsKey("Is_real_name") && condition["Is_real_name"].ToString() != "")
                {
                    sql += "    and Is_real_name = @Is_real_name";
                }
                if (condition.ContainsKey("Blood_type") && condition["Blood_type"].ToString() != "")
                {
                    sql += "    and Blood_type = @Blood_type";
                }
                if (condition.ContainsKey("Industry") && condition["Industry"].ToString() != "")
                {
                    sql += "    and Industry like @Industry";
                }
                if (condition.ContainsKey("Unit_or_school") && condition["Unit_or_school"].ToString() != "")
                {
                    sql += "    and Unit_or_school like @Unit_or_school";
                }
                if (condition.ContainsKey("Work_study_location") && condition["Work_study_location"].ToString() != "")
                {
                    sql += "    and Work_study_location like @Work_study_location";
                }
                if (condition.ContainsKey("Employ_guide") && condition["Employ_guide"].ToString() != "")
                {
                    sql += "    and Employ_guide = @Employ_guide";
                }
                if (condition.ContainsKey("Skill_train") && condition["Skill_train"].ToString() != "")
                {
                    sql += "    and Skill_train = @Skill_train";
                }
                if (condition.ContainsKey("Is_career_grade") && condition["Is_career_grade"].ToString() != "")
                {
                    sql += "    and Is_career_grade = @Is_career_grade";
                }
                if (condition.ContainsKey("Career_grade") && condition["Career_grade"].ToString() != "")
                {
                    sql += "    and Career_grade like @Career_grade";
                }
                if (condition.ContainsKey("Career_get_time") && condition["Career_get_time"].ToString() != "")
                {
                    sql += "    and work_or_study = @work_or_study";
                }
                if (condition.ContainsKey("Disability_type") && condition["Disability_type"].ToString() != "")
                {
                    sql += "    and Disability_type = @Disability_type";
                }
                if (condition.ContainsKey("Disability_grade") && condition["Disability_grade"].ToString() != "")
                {
                    sql += "    and Disability_grade = @Disability_grade";
                }
                if (condition.ContainsKey("Disability_reason") && condition["Disability_reason"].ToString() != "")
                {
                    sql += "    and Disability_reason like @Disability_reason";
                }
                if (condition.ContainsKey("Big_ill_help") && condition["Big_ill_help"].ToString() != "")
                {
                    sql += "    and Big_ill_help = @Big_ill_help";
                }
                if (condition.ContainsKey("Temporary_help") && condition["Temporary_help"].ToString() != "")
                {
                    sql += "    and Temporary_help = @Temporary_help";
                }
                if (condition.ContainsKey("Is_unable_old") && condition["Is_unable_old"].ToString() != "")
                {
                    sql += "    and Is_unable_old = @Is_unable_old";
                }
                if (condition.ContainsKey("Is_relocation") && condition["Is_relocation"].ToString() != "")
                {
                    sql += "    and Is_relocation = @Is_relocation";
                }
                if (condition.ContainsKey("Low_five") && condition["Low_five"].ToString() != "")
                {
                    sql += "    and Low_five = @Low_five";
                }
                if (condition.ContainsKey("Low_five_grade") && condition["Low_five_grade"].ToString() != "")
                {
                    sql += "    and Low_five_grade = @Low_five_grade";
                }
                if (condition.ContainsKey("Military_service") && condition["Military_service"].ToString() != "")
                {
                    sql += "    and Military_service = @Military_service";
                }

                sql += " order by create_datetime desc";

                List<SQLiteParameter> parameters = new List<SQLiteParameter>();
                parameters.Add(new SQLiteParameter("@people_name", "%" + condition["People_name"] + "%"));
                parameters.Add(new SQLiteParameter("@nation", condition["Nation"]));
                parameters.Add(new SQLiteParameter("@relationship", condition["Relationship"]));
                parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
                parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
                parameters.Add(new SQLiteParameter("@phone_number", "%" + condition["Phone_number"] + "%"));
                parameters.Add(new SQLiteParameter("@idcard", "%" + condition["Idcard"] + "%"));
                parameters.Add(new SQLiteParameter("@marital_status", condition["Marital_status"]));
                parameters.Add(new SQLiteParameter("@education", condition["Education"]));
                parameters.Add(new SQLiteParameter("@skill_type", condition["Skill_type"]));
                parameters.Add(new SQLiteParameter("@town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@village", condition["Village"]));

                parameters.Add(new SQLiteParameter("@Work_or_study", condition["Work_or_study"]));
                parameters.Add(new SQLiteParameter("@Is_real_name", condition["Is_real_name"]));
                parameters.Add(new SQLiteParameter("@Blood_type", condition["Blood_type"]));
                parameters.Add(new SQLiteParameter("@Religious_belief", "%" + condition["Religious_belief"] + "%"));
                parameters.Add(new SQLiteParameter("@Industry", "%" + condition["Industry"] + "%"));

                parameters.Add(new SQLiteParameter("@Unit_or_school", "%" + condition["Unit_or_school"] + "%"));
                parameters.Add(new SQLiteParameter("@Work_study_location", "%" + condition["Work_study_location"] + "%"));
                parameters.Add(new SQLiteParameter("@Career_grade", "%" + condition["Career_grade"] + "%"));
                parameters.Add(new SQLiteParameter("@Disability_reason", "%" + condition["Disability_reason"] + "%"));

                parameters.Add(new SQLiteParameter("@Employ_guide", condition["Employ_guide"]));
                parameters.Add(new SQLiteParameter("@Skill_train", condition["Skill_train"]));
                parameters.Add(new SQLiteParameter("@Is_career_grade", condition["Is_career_grade"]));
                parameters.Add(new SQLiteParameter("@Career_grade", condition["Career_grade"]));
                parameters.Add(new SQLiteParameter("@Career_get_time", condition["Career_get_time"]));
                parameters.Add(new SQLiteParameter("@Disability_type", condition["Disability_type"]));
                parameters.Add(new SQLiteParameter("@Disability_grade", condition["Disability_grade"]));
                parameters.Add(new SQLiteParameter("@Big_ill_help", condition["Big_ill_help"]));
                parameters.Add(new SQLiteParameter("@Temporary_help", condition["Temporary_help"]));
                parameters.Add(new SQLiteParameter("@Is_unable_old", condition["Is_unable_old"]));
                parameters.Add(new SQLiteParameter("@Is_relocation", condition["Is_relocation"]));
                parameters.Add(new SQLiteParameter("@Low_five", condition["Low_five"]));
                parameters.Add(new SQLiteParameter("@Low_five_grade", condition["Low_five_grade"]));
                parameters.Add(new SQLiteParameter("@Military_service", condition["Military_service"]));

                return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            }    
            sql += " order by create_datetime desc";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        public DataTable getPeople(int people_id)
        {
            string sql = "select * from t_people where people_id = " + people_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        public DataTable QueryByIdcard(string idcard)
        {
            string sql = "select * from t_people where idcard = " + "'" + idcard + "'";
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        ///  创建一个人员信息
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public Result CreatePeople(People people)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_people");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_people(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public Result UpdatePeople(People people)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_people");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_people set " + Utils.JoinStingListToString(listSetValue) + " where people_id = " + people.People_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
               
            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Result DeletePeople(long people_id)
        {
            string sql = "delete from t_people where people_id="+ people_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }

        public SQLStringObject ImportPeopleAdd(People people)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_people");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_people(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "people_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, people.GetType().GetProperty(PropertyName).GetValue(people, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject=new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportPeople(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }
 

    }
}
