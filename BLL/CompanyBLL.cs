using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.vdm.common;
using com.vdm.dal;
using com.vdm.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace com.vdm.bll
{
    public class CompanyBLL
    {
        private CompanyDAL companyDAL = null;

        public CompanyBLL()
        {
            this.companyDAL = new CompanyDAL();
        }
        //public int getTotalCompany()
        //{
        //    return this.companyDAL.getTotalCount();
        //}
        /// <summary>
        ///条件查询人员总个数
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public int getTotalCompanyCount(Hashtable conditon)
        {
            return this.companyDAL.getTotalCount(conditon);
        }
        public DataTable getAllCompanyDataTable(Hashtable condition, int pageIndex, int pageSize)
        {
            DataTable dt = this.companyDAL.queryAllCompany(condition, pageIndex, pageSize);
            return dt;
        }

        public Result AddCompany(Company company)
        {
            return this.companyDAL.CreateCompany(company);
        }
        public Result EditCompany(Company company)
        {
            return this.companyDAL.UpdateCompany(company);
        }

        public Result DelCompany(long company_id)
        {
            return this.companyDAL.DeleteCompany(company_id);
        }
        /// <summary>
        ///  根据company_id获得人员信息
        /// </summary>
        /// <param name="people_id"></param>
        /// <returns></returns>
        public Company getCompany(int company_id)
        {
            DataTable dt = this.companyDAL.getCompany(company_id);
            Company company = new Company();
            DataTable tblSchema = this.companyDAL.getTableSchema("t_company");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    string DataType = row["DataType"].ToString();
                    if (dt.Rows[0][ColumnName] == System.DBNull.Value)//如果字段值为空则继续执行
                    {
                        company.GetType().GetProperty(PropertyName).SetValue(company, string.Empty);
                    }
                    else
                    {
                        company.GetType().GetProperty(PropertyName).SetValue(company, dt.Rows[0][ColumnName]);
                    }

                }
            }

            return company;
        }

        /// <summary>
        /// 导出用
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable getAllCompany(Hashtable condition)
        {
            List<Company> list_company = new List<Company>();
            DataTable dt = this.companyDAL.getAllCompany(condition);
            //if (dt != null)
            //{
            //    Company p = null;
            //    foreach (DataRow row in dt.Rows)
            //    {
            //    //    p = MakeObject.MakeObjectToCompany(row);
            //        list_company.Add(p);
            //    }
            //}
            return dt;
        }

        public SQLStringObject ImportCompanyAdd(Company company)
        {
            return this.companyDAL.ImportCompanyAdd(company);
        }
        public Result ImportCompany(List<SQLStringObject> SQLStringObjectList)
        {
            return this.companyDAL.ImportCompany(SQLStringObjectList);
        }
    }
}
