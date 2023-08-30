﻿using com.vdm.common;
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
            string sql = "select * from t_animal where 1 = 1";
            if (condition != null)
            {
                if (condition["breed_name"].ToString() != "")
                {
                    sql += "    and breed_name = @breed_name";
                }
                if (condition["town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["villiage"].ToString() != "")
                {
                    sql += "    and villiage = @villiage";
                }
                if (condition["breed_type"].ToString() != "")
                {
                    sql += "    and breed_type = @breed_type";
                }
                if (condition["manager"].ToString() != "")
                {
                    sql += "    and manager = @manager";
                }
                if (condition["phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard = @idcard";
                }
                if (condition["address"].ToString() != "")
                {
                    sql += "    and address = @address";
                }
                if (condition["year_inventory"].ToString() != "")
                {
                    sql += "    and year_inventory = @year_inventory";
                }
                if (condition["year_outbound"].ToString() != "")
                {
                    sql += "    and year_outbound = @year_outbound";
                }
                if (condition["output_from"].ToString() != "" && condition["output_to"].ToString() != "")
                {
                    sql += "  and  output BETWEEN '" + condition["output_from"].ToString() + "' AND '" + condition["output_to"].ToString() + "'";
                }
                if (condition["total_area_from"].ToString() != "" && condition["total_area_to"].ToString() != "")
                {
                    sql += " and   total_area BETWEEN '" + condition["total_area_from"].ToString() + "' AND '" + condition["total_area_to"].ToString() + "'";
                }
                if (condition["total_area_from"].ToString() != "" && condition["total_area_to"].ToString() != "")
                {
                    sql += " and   total_area BETWEEN '" + condition["total_area_from"].ToString() + "' AND '" + condition["total_area_to"].ToString() + "'";
                }
                if (condition["pen_area_from"].ToString() != "" && condition["pen_area_to"].ToString() != "")
                {
                    sql += " and   pen_area BETWEEN '" + condition["pen_area_from"].ToString() + "' AND '" + condition["pen_area_to"].ToString() + "'";
                }
                if (condition["midden_area_from"].ToString() != "" && condition["midden_area_to"].ToString() != "")
                {
                    sql += " and   midden_area BETWEEN '" + condition["midden_area_from"].ToString() + "' AND '" + condition["midden_area_to"].ToString() + "'";
                }
                if (condition["pullttion_area_from"].ToString() != "" && condition["pullttion_area_to"].ToString() != "")
                {
                    sql += " and   pullttion_area_from BETWEEN '" + condition["pullttion_area_from"].ToString() + "' AND '" + condition["pullttion_area_to"].ToString() + "'";
                }
                if (condition["cueernt_inventory_from"].ToString() != "" && condition["cueernt_inventory_to"].ToString() != "")
                {
                    sql += " and   cueernt_inventory BETWEEN '" + condition["cueernt_inventory_from"].ToString() + "' AND '" + condition["cueernt_inventory_to"].ToString() + "'";
                }
                if (condition["animal_qualify"].ToString() != "")
                {
                    sql += "    and animal_qualify = @animal_qualify";
                }
                if (condition["solid_pollution"].ToString() != "")
                {
                    sql += "    and solid_pollution = @solid_pollution";
                }
                if (condition["report_or_filings"].ToString() != "")
                {
                    sql += "    and report_or_filings = @report_or_filings";
                }
            }
            sql += " order by create_datetime desc";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (condition != null)
            {
                parameters.Add(new SQLiteParameter("@breed_name", condition["breed_name"]));
                parameters.Add(new SQLiteParameter("@town", condition["town"]));
                parameters.Add(new SQLiteParameter("@villiage", condition["villiage"]));
                parameters.Add(new SQLiteParameter("@breed_type", condition["breed_type"]));
                parameters.Add(new SQLiteParameter("@manager", condition["manager"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@address", condition["address"]));
                parameters.Add(new SQLiteParameter("@year_inventory", condition["year_inventory"]));
                parameters.Add(new SQLiteParameter("@year_outbound", condition["year_outbound"]));
                parameters.Add(new SQLiteParameter("@output_from", condition["output_from"]));
                parameters.Add(new SQLiteParameter("@output_to", condition["output_to"]));
                parameters.Add(new SQLiteParameter("@total_area_from", condition["total_area_from"]));
                parameters.Add(new SQLiteParameter("@total_area_to", condition["total_area_to"]));
                parameters.Add(new SQLiteParameter("@pen_area_from", condition["pen_area_from"]));
                parameters.Add(new SQLiteParameter("@pen_area_to", condition["pen_area_to"]));
                parameters.Add(new SQLiteParameter("@midden_area_from", condition["midden_area_from"]));
                parameters.Add(new SQLiteParameter("@midden_area_to", condition["midden_area_to"]));
                parameters.Add(new SQLiteParameter("@pullttion_area_from", condition["pullttion_area_from"]));
                parameters.Add(new SQLiteParameter("@pullttion_area_to", condition["pullttion_area_to"]));
                parameters.Add(new SQLiteParameter("@cueernt_inventory_from", condition["cueernt_inventory_from"]));
                parameters.Add(new SQLiteParameter("@cueernt_inventory_to", condition["cueernt_inventory_to"]));
                parameters.Add(new SQLiteParameter("@animal_qualify", condition["animal_qualify"]));
                parameters.Add(new SQLiteParameter("@solid_pollution", condition["solid_pollution"]));
                parameters.Add(new SQLiteParameter("@report_or_filings", condition["report_or_filings"]));
            }
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
            if(condition != null)
            {
                if (condition["breed_name"].ToString() != "")
                {
                    sql += "    and breed_name = @breed_name";
                }
                if (condition["town"].ToString() != "")
                {
                    sql += "    and town = @town";
                }
                if (condition["villiage"].ToString() != "")
                {
                    sql += "    and villiage = @villiage";
                }
                if (condition["breed_type"].ToString() != "")
                {
                    sql += "    and breed_type = @breed_type";
                }
                if (condition["manager"].ToString() != "")
                {
                    sql += "    and manager = @manager";
                }
                if (condition["phone_number"].ToString() != "")
                {
                    sql += "    and phone_number = @phone_number";
                }
                if (condition["Idcard"].ToString() != "")
                {
                    sql += "    and idcard = @idcard";
                }
                if (condition["address"].ToString() != "")
                {
                    sql += "    and address = @address";
                }
                if (condition["year_inventory"].ToString() != "")
                {
                    sql += "    and year_inventory = @year_inventory";
                }
                if (condition["year_outbound"].ToString() != "")
                {
                    sql += "    and year_outbound = @year_outbound";
                }
                if (condition["output_from"].ToString() != "" && condition["output_to"].ToString() != "")
                {
                    sql += "  and  output BETWEEN '" + condition["output_from"].ToString() + "' AND '" + condition["output_to"].ToString() + "'";
                }
                if (condition["total_area_from"].ToString() != "" && condition["total_area_to"].ToString() != "")
                {
                    sql += " and   total_area BETWEEN '" + condition["total_area_from"].ToString() + "' AND '" + condition["total_area_to"].ToString() + "'";
                }
                if (condition["total_area_from"].ToString() != "" && condition["total_area_to"].ToString() != "")
                {
                    sql += " and   total_area BETWEEN '" + condition["total_area_from"].ToString() + "' AND '" + condition["total_area_to"].ToString() + "'";
                }
                if (condition["pen_area_from"].ToString() != "" && condition["pen_area_to"].ToString() != "")
                {
                    sql += " and   pen_area BETWEEN '" + condition["pen_area_from"].ToString() + "' AND '" + condition["pen_area_to"].ToString() + "'";
                }
                if (condition["midden_area_from"].ToString() != "" && condition["midden_area_to"].ToString() != "")
                {
                    sql += " and   midden_area BETWEEN '" + condition["midden_area_from"].ToString() + "' AND '" + condition["midden_area_to"].ToString() + "'";
                }
                if (condition["pullttion_area_from"].ToString() != "" && condition["pullttion_area_to"].ToString() != "")
                {
                    sql += " and   pullttion_area_from BETWEEN '" + condition["pullttion_area_from"].ToString() + "' AND '" + condition["pullttion_area_to"].ToString() + "'";
                }
                if (condition["cueernt_inventory_from"].ToString() != "" && condition["cueernt_inventory_to"].ToString() != "")
                {
                    sql += " and   cueernt_inventory BETWEEN '" + condition["cueernt_inventory_from"].ToString() + "' AND '" + condition["cueernt_inventory_to"].ToString() + "'";
                }
                if (condition["animal_qualify"].ToString() != "")
                {
                    sql += "    and animal_qualify = @animal_qualify";
                }
                if (condition["solid_pollution"].ToString() != "")
                {
                    sql += "    and solid_pollution = @solid_pollution";
                }
                if (condition["report_or_filings"].ToString() != "")
                {
                    sql += "    and report_or_filings = @report_or_filings";
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
                parameters.Add(new SQLiteParameter("@breed_name", condition["breed_name"]));
                parameters.Add(new SQLiteParameter("@town", condition["town"]));
                parameters.Add(new SQLiteParameter("@villiage", condition["villiage"]));
                parameters.Add(new SQLiteParameter("@breed_type", condition["breed_type"]));
                parameters.Add(new SQLiteParameter("@manager", condition["manager"]));
                parameters.Add(new SQLiteParameter("@phone_number", condition["Phone_number"]));
                parameters.Add(new SQLiteParameter("@idcard", condition["Idcard"]));
                parameters.Add(new SQLiteParameter("@address", condition["address"]));
                parameters.Add(new SQLiteParameter("@year_inventory", condition["year_inventory"]));
                parameters.Add(new SQLiteParameter("@year_outbound", condition["year_outbound"]));
                parameters.Add(new SQLiteParameter("@output_from", condition["output_from"]));
                parameters.Add(new SQLiteParameter("@output_to", condition["output_to"]));
                parameters.Add(new SQLiteParameter("@total_area_from", condition["total_area_from"]));
                parameters.Add(new SQLiteParameter("@total_area_to", condition["total_area_to"]));
                parameters.Add(new SQLiteParameter("@pen_area_from", condition["pen_area_from"]));
                parameters.Add(new SQLiteParameter("@pen_area_to", condition["pen_area_to"]));
                parameters.Add(new SQLiteParameter("@midden_area_from", condition["midden_area_from"]));
                parameters.Add(new SQLiteParameter("@midden_area_to", condition["midden_area_to"]));
                parameters.Add(new SQLiteParameter("@pullttion_area_from", condition["pullttion_area_from"]));
                parameters.Add(new SQLiteParameter("@pullttion_area_to", condition["pullttion_area_to"]));
                parameters.Add(new SQLiteParameter("@cueernt_inventory_from", condition["cueernt_inventory_from"]));
                parameters.Add(new SQLiteParameter("@cueernt_inventory_to", condition["cueernt_inventory_to"]));
                parameters.Add(new SQLiteParameter("@animal_qualify", condition["animal_qualify"]));
                parameters.Add(new SQLiteParameter("@solid_pollution", condition["solid_pollution"]));
                parameters.Add(new SQLiteParameter("@report_or_filings", condition["report_or_filings"]));
            }
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
