using com.vdm.bll;
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
    public partial class frmLandInfo : UIEditForm
    {
        private DictBLL dictBLL = null;
        private OrgBLL orgBLL = null;
        private LandBLL landBLL = null;
        private string opreation_mode = "ADD";//默认增加操作
        private int land_id = 0;
        public frmLandInfo()
        {
            InitializeComponent();
        }
        public frmLandInfo(string opreation_mode, int land_id)
        {
            InitializeComponent();
            this.opreation_mode = opreation_mode;
            this.land_id = land_id;
        }

        private void frmLandInfo_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            //InitPageControl();

            if (this.opreation_mode == "EDIT")
            {
                landBLL = new LandBLL();
                Land land = this.landBLL.getLand(this.land_id);
                //界面数据绑定
                tbLand_name.Text = "";
                tbName.Text = "";
                tbIdcard.Text = "";
                cbIs_basic_farmland.SelectedValue = "";
                cbLand_type.SelectedValue = "";
                cbLand_grade.SelectedValue = "";
                tbReal_area.Text = "";
                tbEast.Text = "";
                tbWest.Text = "";
                tbNorth.Text = "";
                tbSouth.Text = "";
                tbLand_use_remark.Text = "";
                tbContractor.Text = "";
                tbContract_time.Text = "";
                tbMove_area.Text = "";
                cbMove_type.SelectedValue = "";
                tbMove_price.Text = "";
                dpMove_date.Text = "";
                this.cbVillage.SelectedValue = "";
                this.cbTown.SelectedValue = "";
                this.cbTown.Text = land.Town;
                this.cbVillage.Text = land.Villiage;

            }
        }
    }
}
