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
    public partial class frmPesonInfo : UIForm
    {
        public frmPesonInfo()
        {
            InitializeComponent();
        }

        private void frmPesonInfo_Load(object sender, EventArgs e)
        {
            this.labLevelName.Text = LoginInfo.CurrentUser.Level;
            this.labRealName.Text = LoginInfo.CurrentUser.RealName;
            this.labRoleName.Text = LoginInfo.CurrentUser.RealName;
            this.labTown.Text = LoginInfo.CurrentUser.RealName;
            this.labUserName.Text = LoginInfo.CurrentUser.AccountName;
            this.labVillage.Text = LoginInfo.CurrentUser.Village;
        }
    }
}
