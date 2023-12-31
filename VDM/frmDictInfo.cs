﻿using com.vdm.bll;
using com.vdm.common;
using com.vdm.model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.vdm.form
{

    public partial class frmDictInfo : UIEditForm
    {
        private string dict_code;
        private string dict_name;
        private DictBLL dictBLL;
        private int id = 0;
        public frmDictInfo()
        {
            InitializeComponent();
        }
        public frmDictInfo(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public frmDictInfo(string dict_code,string dict_name)
        {
            this.dict_code = dict_code;
            this.dict_name = dict_name;

            InitializeComponent();
        }

        private void frmDictInfo_Load(object sender, EventArgs e)
        {

            if (dict_code == "0")
            {
                this.tbDict_code.ReadOnly = false;
                this.tbDict_name.ReadOnly = false;
            }
            else
            {
                this.tbDict_code.Text = dict_code;
                this.tbDict_name.Text = dict_name;
            }
            this.dictBLL = new DictBLL();
            Dict dict = this.dictBLL.getDictById(id);
            if (dict != null)
            {
                this.tbDict_code.Text = dict.Dict_code;
                this.tbDict_name.Text = dict.Dict_name;
                this.btKey.Text = dict.Datakey;
                this.btValue.Text = dict.Datavalue;
                this.btIndex.Text = dict.Dataindex.ToString();
            }
        }

        protected override bool CheckData()
        {

            return CheckEmpty(btKey, "请输入键") 
                && CheckEmpty(btValue, "请输入值")
                && CheckEmpty(btIndex, "请输入索引")
                ;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(this.IsOK == false)
            {
                return;
            }
            string dict_code = this.tbDict_code.Text;
            string dict_name = this.tbDict_name.Text;
            string key = this.btKey.Text.Trim();
            string value = this.btValue.Text.Trim();
            int index = int.Parse(this.btIndex.Text.Trim());

            Dict dict = new Dict();
            dict.Id = id;
            dict.Dict_code = dict_code;
            dict.Dict_name = dict_name;
            dict.Datakey = key;
            dict.Datavalue = value;
            dict.Dataindex = index;

            this.dictBLL = new DictBLL();
            if(id == 0)//id=0代表新增
            {
                Result result = this.dictBLL.addDict(dict);
                if (result.Count == 1)
                {
                    MessageBox.Show("保存成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
            else
            {
                Result result = this.dictBLL.editDict(dict);
                if (result.Count == 1)
                {
                    MessageBox.Show("保存成功。", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Information, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Error(result.Information, result.Exception);
                }
            }
        }
    }
}
