using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.vdm.common;
using com.vdm.model;

using System.Collections;

using System.Data;
using System.Data.SQLite;

namespace com.vdm.dal
{
    public class CompanyDAL : BaseDAL
    {
        /// <summary>
        ///  获得信息的总数
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int getTotalCount(Hashtable condition)
        {
            string sql = "select * from t_company where 1 = 1";
            if (condition != null)
            {
                if (condition["Business_code"].ToString() != "")
                {
                    sql += "    and Business_code = @Business_code";
                }
                if (condition["Company_address"].ToString() != "")
                {
                    sql += "    and Company_address like @Company_address";
                }
                if (condition["Company_name"].ToString() != "")
                {
                    sql += "    and Company_name = @Company_name";
                }
                if (condition["Company_phone"].ToString() != "")
                {
                    sql += "    and Company_phone =@Company_phone";
                }
                if (condition["Credit_code"].ToString() != "")
                {
                    sql += "    and Credit_code =@Credit_code";
                }
                if (condition["Legal_idcard"].ToString() != "")
                {
                    sql += "    and Legal_idcard = @Legal_idcard";
                }
                if (condition["Legal_name"].ToString() != "")
                {
                    sql += "    and Legal_name like @Legal_name";
                }
                if (condition["Organization_code"].ToString() != "")
                {
                    sql += "    and Organization_code = @Organization_code";
                }
                if (condition["Taxpayer_code"].ToString() != "")
                {
                    sql += "    and Taxpayer_code = @Taxpayer_code";
                }
                if (condition["Taxpayer_qualification"].ToString() != "")
                {
                    sql += "    and Taxpayer_qualification = @Taxpayer_qualification";
                }
                if (condition["Company_status"].ToString() != "")
                {
                    sql += "    and Company_status = @Company_status";
                }
                if (condition["Company_type"].ToString() != "")
                {
                    sql += "    and Company_type = @Company_type";
                }
                if (condition["Is_top_company"].ToString() != "")
                {
                    sql += "    and Is_top_company = @Is_top_company";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Insure_person_count_From"].ToString() != "" && condition["Insure_person_count_To"].ToString() != null)
                {
                    sql += "  and  Insure_person BETWEEN '" + condition["Insure_person_count_From"].ToString() + "' AND '" + condition["Insure_person_count_To"].ToString() + "'";
                }
                if (condition["Output_From"].ToString() != "" && condition["Output_To"].ToString() != null)
                {
                    sql += "  and  Output BETWEEN '" + condition["Output_From"].ToString() + "' AND '" + condition["Output_To"].ToString() + "'";
                }
                if (condition["Staff_size_From"].ToString() != "" && condition["Staff_size_To"].ToString() != null)
                {
                    sql += "  and  Staff_size BETWEEN '" + condition["Staff_size_From"].ToString() + "' AND '" + condition["Staff_size_To"].ToString() + "'";
                }
                if (condition["Establish_date_From"].ToString() != "" && condition["Establish_date_To"].ToString() != null)
                {
                    sql += "  and  License_date BETWEEN '" + condition["License_date_From"].ToString() + "' AND '" + condition["Establish_date_To"].ToString() + "'";
                }
                if (condition["License_date_From"].ToString() != "" && condition["License_date_To"].ToString() != null)
                {
                    sql += "  and  License_date BETWEEN '" + condition["License_date_From"].ToString() + "' AND '" + condition["License_date_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Business_code", condition["Business_code"]));
                parameters.Add(new SQLiteParameter("@Company_address","%"+ condition["Company_address"]+"%"));
                parameters.Add(new SQLiteParameter("@Company_name", condition["Company_name"]));
                parameters.Add(new SQLiteParameter("@Company_phone", condition["Company_phone"]));
                parameters.Add(new SQLiteParameter("@Credit_code", condition["Credit_code"]));
                parameters.Add(new SQLiteParameter("@Legal_idcard", condition["Legal_idcard"]));
                parameters.Add(new SQLiteParameter("@Legal_name", "%"+condition["Legal_name"]+"%"));
                parameters.Add(new SQLiteParameter("@Organization_code", condition["Organization_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_code", condition["Taxpayer_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_qualification", condition["Taxpayer_qualification"]));
                parameters.Add(new SQLiteParameter("@Company_status", condition["Company_status"]));
                parameters.Add(new SQLiteParameter("@Company_type", condition["Company_type"]));
                parameters.Add(new SQLiteParameter("@Is_top_company", condition["Is_top_company"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            DataTable dt = this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }

        /// <summary>
        ///  获得所有农户（空条件或者条件查询）
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllCompany(Hashtable condition, int pageIndex, int pageSize)
        {
            string sql = "select * from t_company where 1 = 1";
            if (condition != null)
            {
                if (condition["Business_code"].ToString() != "")
                {
                    sql += "    and Business_code = @Business_code";
                }
                if (condition["Company_address"].ToString() != "")
                {
                    sql += "    and Company_address like @Company_address";
                }
                if (condition["Company_name"].ToString() != "")
                {
                    sql += "    and Company_name = @Company_name";
                }
                if (condition["Company_phone"].ToString() != "")
                {
                    sql += "    and Company_phone =@Company_phone";
                }
                if (condition["Credit_code"].ToString() != "")
                {
                    sql += "    and Credit_code =@Credit_code";
                }
                if (condition["Legal_idcard"].ToString() != "")
                {
                    sql += "    and Legal_idcard = @Legal_idcard";
                }
                if (condition["Legal_name"].ToString() != "")
                {
                    sql += "    and Legal_name like @Legal_name";
                }
                if (condition["Organization_code"].ToString() != "")
                {
                    sql += "    and Organization_code = @Organization_code";
                }
                if (condition["Taxpayer_code"].ToString() != "")
                {
                    sql += "    and Taxpayer_code = @Taxpayer_code";
                }
                if (condition["Taxpayer_qualification"].ToString() != "")
                {
                    sql += "    and Taxpayer_qualification = @Taxpayer_qualification";
                }
                if (condition["Company_status"].ToString() != "")
                {
                    sql += "    and Company_status = @Company_status";
                }
                if (condition["Company_type"].ToString() != "")
                {
                    sql += "    and Company_type = @Company_type";
                }
                if (condition["Is_top_company"].ToString() != "")
                {
                    sql += "    and Is_top_company = @Is_top_company";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Insure_person_count_From"].ToString() != "" && condition["Insure_person_count_To"].ToString() != null)
                {
                    sql += "  and  Insure_person BETWEEN '" + condition["Insure_person_count_From"].ToString() + "' AND '" + condition["Insure_person_count_To"].ToString() + "'";
                }
                if (condition["Output_From"].ToString() != "" && condition["Output_To"].ToString() != null)
                {
                    sql += "  and  Output BETWEEN '" + condition["Output_From"].ToString() + "' AND '" + condition["Output_To"].ToString() + "'";
                }
                if (condition["Staff_size_From"].ToString() != "" && condition["Staff_size_To"].ToString() != null)
                {
                    sql += "  and  Staff_size BETWEEN '" + condition["Staff_size_From"].ToString() + "' AND '" + condition["Staff_size_To"].ToString() + "'";
                }
                if (condition["Establish_date_From"].ToString() != "" && condition["Establish_date_To"].ToString() != null)
                {
                    sql += "  and  License_date BETWEEN '" + condition["License_date_From"].ToString() + "' AND '" + condition["Establish_date_To"].ToString() + "'";
                }
                if (condition["License_date_From"].ToString() != "" && condition["License_date_To"].ToString() != null)
                {
                    sql += "  and  License_date BETWEEN '" + condition["License_date_From"].ToString() + "' AND '" + condition["License_date_To"].ToString() + "'";
                }


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
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Business_code", condition["Business_code"]));
                parameters.Add(new SQLiteParameter("@Company_address", "%" + condition["Company_address"] + "%"));
                parameters.Add(new SQLiteParameter("@Company_name", condition["Company_name"]));
                parameters.Add(new SQLiteParameter("@Company_phone", condition["Company_phone"]));
                parameters.Add(new SQLiteParameter("@Credit_code", condition["Credit_code"]));
                parameters.Add(new SQLiteParameter("@Legal_idcard", condition["Legal_idcard"]));
                parameters.Add(new SQLiteParameter("@Legal_name", "%" + condition["Legal_name"] + "%"));
                parameters.Add(new SQLiteParameter("@Organization_code", condition["Organization_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_code", condition["Taxpayer_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_qualification", condition["Taxpayer_qualification"]));
                parameters.Add(new SQLiteParameter("@Company_status", condition["Company_status"]));
                parameters.Add(new SQLiteParameter("@Company_type", condition["Company_type"]));
                parameters.Add(new SQLiteParameter("@Is_top_company", condition["Is_top_company"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }

        /// <summary>
        /// 条件查询(导出按钮使用)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public DataTable getAllCompany(Hashtable condition)
        {
            string sql = "select * from t_company where 1 = 1";
            if (condition != null)
            {
                if (condition["Business_code"].ToString() != "")
                {
                    sql += "    and Business_code = @Business_code";
                }
                if (condition["Company_address"].ToString() != "")
                {
                    sql += "    and Company_address like @Company_address";
                }
                if (condition["Company_name"].ToString() != "")
                {
                    sql += "    and Company_name = @Company_name";
                }
                if (condition["Company_phone"].ToString() != "")
                {
                    sql += "    and Company_phone =@Company_phone";
                }
                if (condition["Credit_code"].ToString() != "")
                {
                    sql += "    and Credit_code =@Credit_code";
                }
                if (condition["Legal_idcard"].ToString() != "")
                {
                    sql += "    and Legal_idcard = @Legal_idcard";
                }
                if (condition["Legal_name"].ToString() != "")
                {
                    sql += "    and Legal_name like @Legal_name";
                }
                if (condition["Organization_code"].ToString() != "")
                {
                    sql += "    and Organization_code = @Organization_code";
                }
                if (condition["Taxpayer_code"].ToString() != "")
                {
                    sql += "    and Taxpayer_code = @Taxpayer_code";
                }
                if (condition["Taxpayer_qualification"].ToString() != "")
                {
                    sql += "    and Taxpayer_qualification = @Taxpayer_qualification";
                }
                if (condition["Company_status"].ToString() != "")
                {
                    sql += "    and Company_status = @Company_status";
                }
                if (condition["Company_type"].ToString() != "")
                {
                    sql += "    and Company_type = @Company_type";
                }
                if (condition["Is_top_company"].ToString() != "")
                {
                    sql += "    and Is_top_company = @Is_top_company";
                }

                if (condition["Village"].ToString() != "")
                {
                    sql += "    and Village = @Village";
                }
                if (condition["Town"].ToString() != "")
                {
                    sql += "    and Town = @Town";
                }

                if (condition["Insure_person_count_From"].ToString() != "" && condition["Insure_person_count_To"].ToString() != null)
                {
                    sql += "  and  Insure_person BETWEEN '" + condition["Insure_person_count_From"].ToString() + "' AND '" + condition["Insure_person_count_To"].ToString() + "'";
                }
                if (condition["Output_From"].ToString() != "" && condition["Output_To"].ToString() != null)
                {
                    sql += "  and  Output BETWEEN '" + condition["Output_From"].ToString() + "' AND '" + condition["Output_To"].ToString() + "'";
                }
                if (condition["Staff_size_From"].ToString() != "" && condition["Staff_size_To"].ToString() != null)
                {
                    sql += "  and  Staff_size BETWEEN '" + condition["Staff_size_From"].ToString() + "' AND '" + condition["Staff_size_To"].ToString() + "'";
                }
                if (condition["Establish_date_From"].ToString() != "" && condition["Establish_date_To"].ToString() != null)
                {
                    sql += "  and  Establish_date BETWEEN '" + condition["Establish_date_From"].ToString() + "' AND '" + condition["Establish_date_To"].ToString() + "'";
                }
                if (condition["License_date_From"].ToString() != "" && condition["License_date_To"].ToString() != null)
                {
                    sql += "  and  License_date BETWEEN '" + condition["License_date_From"].ToString() + "' AND '" + condition["License_date_To"].ToString() + "'";
                }


            }

            sql += " order by create_datetime desc";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@Business_code", condition["Business_code"]));
                parameters.Add(new SQLiteParameter("@Company_address", "%" + condition["Company_address"] + "%"));
                parameters.Add(new SQLiteParameter("@Company_name", condition["Company_name"]));
                parameters.Add(new SQLiteParameter("@Company_phone", condition["Company_phone"]));
                parameters.Add(new SQLiteParameter("@Credit_code", condition["Credit_code"]));
                parameters.Add(new SQLiteParameter("@Legal_idcard", condition["Legal_idcard"]));
                parameters.Add(new SQLiteParameter("@Legal_name", "%" + condition["Legal_name"] + "%"));
                parameters.Add(new SQLiteParameter("@Organization_code", condition["Organization_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_code", condition["Taxpayer_code"]));
                parameters.Add(new SQLiteParameter("@Taxpayer_qualification", condition["Taxpayer_qualification"]));
                parameters.Add(new SQLiteParameter("@Company_status", condition["Company_status"]));
                parameters.Add(new SQLiteParameter("@Company_type", condition["Company_type"]));
                parameters.Add(new SQLiteParameter("@Is_top_company", condition["Is_top_company"]));
                parameters.Add(new SQLiteParameter("@Town", condition["Town"]));
                parameters.Add(new SQLiteParameter("@Village", condition["Village"]));
            }
            return this.SqlDbHelper.ExecuteDataTable(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 创建农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result CreateCompany(Company company)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_company");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "company_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_company(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "company_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, company.GetType().GetProperty(PropertyName).GetValue(company, null));
                    parameters.Add(parameter);
                }
            }

            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        /// 更新农户
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Result UpdateCompany(Company company)
        {
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_company");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "company_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_company set " + Utils.JoinStingListToString(listSetValue) + " where company_id = " + company.Company_id;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, company.GetType().GetProperty(PropertyName).GetValue(company, null));
                    parameters.Add(parameter);
                }

            }
            return this.SqlDbHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
        /// <summary>
        ///  删除
        /// </summary>
        /// <param name="company_id"></param>
        /// <returns></returns>
        public Result DeleteCompany(long company_id)
        {
            string sql = "delete from t_company where company_id=" + company_id;
            return this.SqlDbHelper.ExecuteNonQuery(sql);
        }
        public DataTable getCompany(int company_id)
        {
            string sql = "select * from t_company where company_id = " + company_id;
            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 获得excel每条数据的sql
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public SQLStringObject ImportCompanyAdd(Company company)
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_company");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "company_id")
                    {
                        continue;
                    }
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_company(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    if (row["ColumnName"].ToString() == "company_id")
                    {
                        continue;
                    }
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, company.GetType().GetProperty(PropertyName).GetValue(company, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sqlObject = new SQLStringObject(sql, parameters);
            return sqlObject;
        }

        public Result ImportCompany(List<SQLStringObject> SQLStringObjectList)
        {
            return this.SqlDbHelper.ExecuteSqlTran(SQLStringObjectList);
        }

    }
}
