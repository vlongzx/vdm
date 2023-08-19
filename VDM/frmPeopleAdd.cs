using com.vdm.bll;
using com.vdm.common;
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
    public partial class frmPeopleAdd : Form
    {
        private DictBLL dictBLL = null;
         
        public frmPeopleAdd()
        {
            InitializeComponent();
        }

        private void frmPeopleAdd_Load(object sender, EventArgs e)
        {
            //初始化节目控件的值
            dictBLL = new DictBLL();
            //初始化血型
            List<KeyValue> list_blood_type = dictBLL.getDict("blood_type");
            if(list_blood_type != null)
            {
                this.cbBlood_type.DataSource = list_blood_type;
                this.cbBlood_type.DisplayMember = "value";
                this.cbBlood_type.ValueMember = "key";
                
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
