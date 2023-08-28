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
    public class AnimalDAL:BaseDAL
    {
        /// <summary>
        ///  根据畜牧户、场ID获取信息
        /// </summary>
        /// <param name="breed_id"></param>
        /// <returns></returns>
        public DataTable queryAnimal(int breed_id)
        {
            string sql = "select * from t_animal where breed_id = " + breed_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        ///  获得畜牧信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_people where 1 = 1";
            if (condition["People_name"].ToString() != "")
            {
                sql += "    and people_name = @people_name";
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
                sql += "    and phone_number = @phone_number";
            }
            if (condition["Idcard"].ToString() != "")
            {
                sql += "    and idcard = @idcard";
            }
            if (condition["Religious_belief"].ToString() != "")
            {
                sql += "    and religious_belief = @religious_belief";
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
            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@people_name", condition["People_name"]));
            parameters.Add(new SQLiteParameter("@nation", condition["nation"]));
            parameters.Add(new SQLiteParameter("@relationship", condition["relationship"]));
            parameters.Add(new SQLiteParameter("@sex", condition["Sex"]));
            parameters.Add(new SQLiteParameter("@politcal_outlook", condition["Politcal_outlook"]));
            parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
            parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
            parameters.Add(new SQLiteParameter("@religious_belief", condition["Religious_belief"]));
            parameters.Add(new SQLiteParameter("@education", condition["Education"]));

            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        ///  获得所有的畜牧
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllAnimal(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_animal where 1 = 1";
            if (condition["town"].ToString() != "")
            {
                sql += "    and town = @town";
            }
            sql += " order by create_datetime desc";
            int offset = 0;
            int totalPeople = this.getTotalCount(condition);
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
            parameters.Add(new SQLiteParameter("@town", condition["town"]));


            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 创建畜牧
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result  CreateAnimal(Animal animal)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_animal");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "breed_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_animal(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "breed_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, animal.GetType().GetProperty(PropertyName).GetValue(animal, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新畜牧
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result UpdateAnimal(Animal animal)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_animal");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "breed_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_people set " + Utils.JoinStingListToString(listSetValue) + " where breed_id = " + animal.Breed_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, animal.GetType().GetProperty(PropertyName).GetValue(animal, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除畜牧
        /// </summary>
        /// <param name="breed_id"></param>
        /// <returns></returns>
        public Result DeleteAnimal(int breed_id)
        {
            string sql = "delete from t_animal where breed_id=" + breed_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
    }
}
