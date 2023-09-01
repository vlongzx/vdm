using com.vdm.bll;
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
    public partial class frmFamerAdvanceQuery  : UIEditForm
    {
        frmFamerList frmfamer;
        private DictBLL dictBLL = null;
        public frmFamerAdvanceQuery()
        {
            InitializeComponent();
        }
        public frmFamerAdvanceQuery(frmFamerList frmfamer)
        {
            InitializeComponent();
            this.frmfamer = frmfamer;
        }
        private void frmFamerAdvanceQuery_Load(object sender, EventArgs e)
        {
            InitControlData();
        }
        /// <summary>
        /// 初始化高级条件
        /// </summary>
        public void InitControlData()
        {

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //从界面获取高级查询条件
            string tbPlant_area_From = this.tbPlant_area_From.Text.Trim();
            string tbPlant_area_To = this.tbPlant_area_To.Text.Trim();
            string tbPlant_yield_From = this.tbPlant_yield_From.Text.Trim();
            string tbPlant_yield_To = this.tbPlant_yield_To.Text.Trim();
            string tbPlant_output_From = this.tbPlant_output_From.Text.Trim();
            string tbPlant_output_To = this.tbPlant_output_To.Text.Trim();
            string tbAnimal_area_From = this.tbAnimal_area_From.Text.Trim();
            string tbAnimal_area_To = this.tbAnimal_area_To.Text.Trim();
            string tbAnimal_count_From = this.tbAnimal_count_From.Text.Trim();
            string tbAnimal_count_To = this.tbAnimal_count_To.Text.Trim();
            string tbAnimal_nvaccinate_count_From = this.tbAnimal_nvaccinate_count_From.Text.Trim();
            string tbAnimal_nvaccinate_count_To = this.tbAnimal_nvaccinate_count_To.Text.Trim();
            string tbAnimal_output_From = this.tbAnimal_output_From.Text.Trim();
            string tbAnimal_output_To = this.tbAnimal_output_To.Text.Trim();
            string tbAnimal_vaccinate_count_From = this.tbAnimal_vaccinate_count_From.Text.Trim();
            string tbAnimal_vaccinate_count_To = this.tbAnimal_vaccinate_count_To.Text.Trim();
            string tbAnimal_yield_From = this.tbAnimal_yield_From.Text.Trim();
            string tbAnimal_yield_To = this.tbAnimal_yield_To.Text.Trim();
            string tbInventory_count_From = this.tbInventory_count_From.Text.Trim();
            string tbInventory_count_To = this.tbInventory_count_To.Text.Trim();
            string tbOutbound_count_From = this.tbOutbound_count_From.Text.Trim();
            string tbOutbound_count_To = this.tbOutbound_count_To.Text.Trim();

           frmfamer.ConditionAdd("tbPlant_area_From", tbPlant_area_From);
           frmfamer.ConditionAdd("tbPlant_area_To", tbPlant_area_To);
           frmfamer.ConditionAdd("tbPlant_yield_From", tbPlant_yield_From);
           frmfamer.ConditionAdd("tbPlant_yield_To", tbPlant_yield_To);
           frmfamer.ConditionAdd("tbPlant_output_From", tbPlant_output_From);
           frmfamer.ConditionAdd("tbPlant_output_To", tbPlant_output_To);
           frmfamer.ConditionAdd("tbAnimal_area_From", tbAnimal_area_From);
           frmfamer.ConditionAdd("tbAnimal_area_To", tbAnimal_area_To);
           frmfamer.ConditionAdd("tbAnimal_count_From", tbAnimal_count_From);
           frmfamer.ConditionAdd("tbAnimal_count_To", tbAnimal_count_To);
           frmfamer.ConditionAdd("tbAnimal_nvaccinate_count_From", tbAnimal_nvaccinate_count_From);
           frmfamer.ConditionAdd("tbAnimal_nvaccinate_count_To", tbAnimal_nvaccinate_count_To);
           frmfamer.ConditionAdd("tbAnimal_output_From", tbAnimal_output_From);
           frmfamer.ConditionAdd("tbAnimal_output_To", tbAnimal_output_To);
           frmfamer.ConditionAdd("tbAnimal_vaccinate_count_From", tbAnimal_vaccinate_count_From);
           frmfamer.ConditionAdd("tbAnimal_vaccinate_count_To", tbAnimal_vaccinate_count_To);
           frmfamer.ConditionAdd("tbAnimal_yield_From", tbAnimal_yield_From);
           frmfamer.ConditionAdd("tbAnimal_yield_To", tbAnimal_yield_To);
           frmfamer.ConditionAdd("tbInventory_count_From", tbInventory_count_From);
           frmfamer.ConditionAdd("tbInventory_count_To", tbInventory_count_To);
           frmfamer.ConditionAdd("tbOutbound_count_From", tbOutbound_count_From);
           frmfamer.ConditionAdd("tbOutbound_count_To", tbOutbound_count_To);
        }


    }
}
