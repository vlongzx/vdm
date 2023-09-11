using com.vdm.common;
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
    public partial class frmMain : UIHeaderMainFooterFrame
    {
        private const string MESSAGE = "您还没有权限操作该功能。请联系管理员开通。";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //设置关联
            Header.TabControl = MainTabControl;
            Footer.Text = "陕西奥维纳斯软件技术有限公司提供技术支持";
            this.labAccountName.Text ="当前操作员："+ LoginInfo.CurrentUser.AccountName;
            this.lbLoginTime.Text ="登录时间："+ LoginInfo.CurrentUser.LoginTime.ToString();
            //如果没有权限则不展示页面
            if (LoginInfo.FuncPowerList.Contains("10000") == true)
            {
                AddPage(new frmPeopleList(), 1001);
            }
            if (LoginInfo.FuncPowerList.Contains("20000") == true)
            {
                AddPage(new frmFamerList(), 1002);
            }
            if (LoginInfo.FuncPowerList.Contains("30000") == true)
            {
                AddPage(new frmLandList(), 1003);
            }
            if (LoginInfo.FuncPowerList.Contains("40000") == true)
            {
                AddPage(new frmCompanyList(), 1004);
            }
            if (LoginInfo.FuncPowerList.Contains("50000") == true)
            {
                AddPage(new frmHouseList(), 1005);
            }
            if (LoginInfo.FuncPowerList.Contains("60000") == true)
            {
                AddPage(new frmManagerList(), 1010);
            }
            if (LoginInfo.FuncPowerList.Contains("70000") == true)
            {
                AddPage(new frmVillageList(), 1011);
            }
            if (LoginInfo.FuncPowerList.Contains("12000") == true || LoginInfo.FuncPowerList.Contains("13000") == true || LoginInfo.FuncPowerList.Contains("14000") == true || LoginInfo.FuncPowerList.Contains("15000") == true)
            {
                AddPage(new frmSystemSet(), 1009);
            }
            if (LoginInfo.FuncPowerList.Contains("80000") == true)
            {
                AddPage(new frmAnimalList(), 1008);
            }
            if (LoginInfo.FuncPowerList.Contains("90000") == true)
            {
                AddPage(new frmTourList(), 1007);
            }
            if (LoginInfo.FuncPowerList.Contains("11000") == true)
            {
                AddPage(new frmPlantList(), 1006);
            }
           
            
        }

        private void tspPeople_Click(object sender, EventArgs e)
        {
            if(LoginInfo.FuncPowerList.Contains("10000") == false)
            { 
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1001);

        }
        private void btManager_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("60000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1010);
        }
        /// <summary>
        ///  农户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFamer_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("20000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1002);
        }
        private void btCompany_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("40000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1004);
        }
        private void btVillage_Click(object sender, EventArgs e)
        {

            if (LoginInfo.FuncPowerList.Contains("70000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1011);
        }
        private void btHouse_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("50000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1005);
        }
        private void btLand_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("30000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1003);
        }
        /// <summary>
        ///  系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSystemSet_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("12000") == true || LoginInfo.FuncPowerList.Contains("13000") == true|| LoginInfo.FuncPowerList.Contains("14000") == true || LoginInfo.FuncPowerList.Contains("15000") == true)
            {
                MainTabControl.SelectPage(1009);
            }
            else
            {
                ShowInfoDialog(MESSAGE);
                return;
            }

        }

        /// <summary>
        ///  畜牧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnimal_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("80000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1008);
        }
        /// <summary>
        /// 旅游
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTour_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("90000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1007);
        }

        private void btPlant_Click(object sender, EventArgs e)
        {
            if (LoginInfo.FuncPowerList.Contains("11000") == false)
            {
                ShowInfoDialog(MESSAGE);
                return;
            }
            MainTabControl.SelectPage(1006);
        }
    }
}
