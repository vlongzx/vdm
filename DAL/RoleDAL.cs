using com.vdm.common;
using com.vdm.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.vdm.dal
{
    public class RoleDAL:BaseDAL
    {
        /// <summary>
        ///  获得所有角色
        /// </summary>
        /// <returns></returns>
        public DataTable queryAllRole()
        {
            string sql = "select * from t_role";

            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        public DataTable queryRole(string role_id)
        {
            string sql = "select * from t_role where role_id = '"+ role_id+"'";

            return this.SqlDbHelper.ExecuteDataTable(sql);
        }


        public DataTable queryRoleFuncPower(string role_id)
        {
            string sql = "select * from t_character_funtion_authority where character_id = '" + role_id + "'";

            return this.SqlDbHelper.ExecuteDataTable(sql);
        }

        public Result  createRole(Role role,List<string> ListFunction_ID) 
        {
            //构建sql语句
            List<string> listColumnName = new List<string>();
            List<string> listParameter = new List<string>();
            DataTable tblSchema = this.getTableSchema("t_role");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    listColumnName.Add(row["ColumnName"].ToString());
                    listParameter.Add("@" + row["ColumnName"].ToString());
                }
            }
            string sql = "insert into t_role(" + Utils.JoinStingListToString(listColumnName) + ") values(" + Utils.JoinStingListToString(listParameter) + ")";

            //构建参数值
            SQLiteParameter parameter = null;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, role.GetType().GetProperty(PropertyName).GetValue(role, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sso = new SQLStringObject(sql, parameters);

            List<SQLStringObject> listSSO = new List<SQLStringObject>();
            listSSO.Add(sso);//将新增角色sql语句加入列表

            List<SQLiteParameter> child_parameters = null;
            if (ListFunction_ID != null)
            {
                foreach (string function_id in ListFunction_ID)
                {
                    child_parameters = new List<SQLiteParameter>();
                    string strSql = "insert into t_character_funtion_authority(character_id,function_id) values(@character_id,@function_id)";
                    child_parameters.Add( new SQLiteParameter("@character_id", role.Role_id));
                    child_parameters.Add(new SQLiteParameter("@function_id", function_id));
                    sso = new SQLStringObject(strSql, child_parameters);
                    listSSO.Add(sso);//将角色和功能权限对应关系加入列表

                }
            }

            return this.SqlDbHelper.ExecuteSqlTran(listSSO);
        }

        public Result updateRole(Role role, List<string> ListFunction_ID)
        {
            //构建sql语句
            //构建参数值
            List<string> listSetValue = new List<string>();
            SQLiteParameter parameter = null;
            DataTable tblSchema = this.getTableSchema("t_role");
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    //过滤掉主键
                    if (row["ColumnName"].ToString() == "role_id")
                    {
                        continue;
                    }
                    listSetValue.Add(row["ColumnName"].ToString() + "=@" + row["ColumnName"].ToString());
                }
            }
            string sql = "update t_role set " + Utils.JoinStingListToString(listSetValue) + " where role_id = '" + role.Role_id+"'";

            //构建参数值
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (tblSchema != null)
            {
                foreach (DataRow row in tblSchema.Rows)
                {
                    string ColumnName = row["ColumnName"].ToString();
                    string PropertyName = Utils.Capitalize(row["ColumnName"].ToString());
                    parameter = new SQLiteParameter("@" + ColumnName, role.GetType().GetProperty(PropertyName).GetValue(role, null));
                    parameters.Add(parameter);
                }
            }
            SQLStringObject sso = new SQLStringObject(sql, parameters);

            List<SQLStringObject> listSSO = new List<SQLStringObject>();
            listSSO.Add(sso);//将新增角色sql语句加入列表

            //先删除，再插入
            sql = "delete from t_character_funtion_authority where character_id = @character_id";
            List<SQLiteParameter> del_parameters = new List<SQLiteParameter>();
            del_parameters.Add(new SQLiteParameter("@character_id", role.Role_id));
            sso = new SQLStringObject(sql, del_parameters);
            listSSO.Add(sso);//删除语句加入列表

            //处理对应关系表
            List<SQLiteParameter> child_parameters = new List<SQLiteParameter>();
            if (ListFunction_ID != null)
            {
                foreach (string function_id in ListFunction_ID)
                {
                    child_parameters = new List<SQLiteParameter>();
                    sql = "insert into t_character_funtion_authority(character_id,function_id) values(@character_id,@function_id)";
                    child_parameters.Add(new SQLiteParameter("@character_id", role.Role_id));
                    child_parameters.Add(new SQLiteParameter("@function_id", function_id));
                    sso = new SQLStringObject(sql, child_parameters);
                    listSSO.Add(sso);//将角色和功能权限对应关系加入列表

                }
            }

            return this.SqlDbHelper.ExecuteSqlTran(listSSO);
        }

        public Result deleteRole(string  role_id)
        {
            List<SQLStringObject> listSSO = new List<SQLStringObject>();
            //先删除关系表
            string sql = "delete from t_character_funtion_authority where character_id = @character_id";
            List<SQLiteParameter> del_parameters = new List<SQLiteParameter>();
            del_parameters.Add(new SQLiteParameter("@character_id", role_id));
            SQLStringObject sso = new SQLStringObject(sql, del_parameters);
            listSSO.Add(sso);//删除语句加入列表


            sql = "delete from t_role where role_id=@role_id";
            List<SQLiteParameter>  parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@role_id", role_id));
            sso = new SQLStringObject(sql, parameters);
            listSSO.Add(sso);//删除语句加入列表


            return this.SqlDbHelper.ExecuteSqlTran(listSSO);
        }
    }
}
