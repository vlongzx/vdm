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
    public partial class frmSetDataPower : UIEditForm
    {
        private DataAuthBLL dataAuthBLL = null;
        private int user_id;
        public frmSetDataPower()
        {
            InitializeComponent();
        }

        public frmSetDataPower(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void frmSetDataPower_Load(object sender, EventArgs e)
        {
            dataAuthBLL = new DataAuthBLL();

            DataTable dt = this.dataAuthBLL.getDataAuthByType("组织类");

            if(dt != null && dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    UICheckBox uc = new UICheckBox();
                    uc.Text = dt.Rows[i]["data_authority_desc"].ToString();
                    uc.Tag = dt.Rows[i]["data_authority_name"].ToString();
                    this.cbgOrgDataAuthor.Items.Add(uc);
                }
            }
        }
    }
}
