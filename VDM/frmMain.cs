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
            AddPage(new frmPeopleList(), 1001);
            AddPage(new frmFamerList(), 1002);
            AddPage(new frmLandList(), 1003);
            AddPage(new frmCompanyList(), 1004);
            AddPage(new frmHouseList(), 1005);
            AddPage(new frmManagerList(), 1010);
            AddPage(new frmSystemSet(), 1009);
            AddPage(new frmAnimalList(), 1008);
            AddPage(new frmTourList(), 1007);
            AddPage(new frmPlantList(), 1006);
        }

        private void tspPeople_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1001);

        }
        private void btManager_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1010);
        }
        /// <summary>
        ///  农户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFamer_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1004);
        }
        private void btHouse_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1005);
        }
        private void btLand_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1003);
        }
        /// <summary>
        ///  系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSystemSet_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1009);
        }

        /// <summary>
        ///  畜牧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnimal_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1008);
        }
        /// <summary>
        /// 旅游
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btTour_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1007);
        }

        private void btPlant_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectPage(1006);
        }
    }
}
