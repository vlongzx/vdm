using com.vdm.bll;
using com.vdm.common;
using Sunny.UI;
using System;
using System.Collections;
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
    public partial class frmTourList : UIPage
    {
        private OrgBLL orgBLL = null;
        private DictBLL dictBLL = null;
        private TourBLL tourBLL = null;
        private Hashtable condition = null;
        private int pageIndex = 1;
        private int pageSize = 20;
        public frmTourList()
        {
            InitializeComponent();
        }

        private void frmTourList_Load(object sender, EventArgs e)
        {
            InitAnimalList(null, pageIndex, pageSize);

            InitControls();
        }

        /// <summary>
        ///  初始化界面控件数据
        /// </summary>
        private void InitControls()
        {
            this.dictBLL = new DictBLL();

            //初始化主体类别
            List<KeyValue> list_principal_category = dictBLL.getDict("principal_category");
            if (list_principal_category != null)
            {
                this.cbPrincipal_category.DataSource = list_principal_category;
                this.cbPrincipal_category.DisplayMember = "value";
                this.cbPrincipal_category.ValueMember = "key";
            }
            //初始化经营形式
            List<KeyValue> list_trade_form = dictBLL.getDict("trade_form");
            if (list_trade_form != null)
            {
                this.cbTrade_form.DataSource = list_trade_form;
                this.cbTrade_form.DisplayMember = "value";
                this.cbTrade_form.ValueMember = "key";
            }
        }

        /// <summary>
        ///  初始化旅游列表
        /// </summary>
        public void InitAnimalList(Hashtable condition, int pageIndex = 1, int pageSize = 20)
        {
            //初始化dgAnimal
            this.dgTourList.AutoGenerateColumns = false;
            this.dgTourList.RowTemplate.Height = 45;
            this.dgTourList.Columns.Clear();
            this.dgTourList.AddColumn("主体类别", "principal_category");
            this.dgTourList.AddColumn("主体名称", "principal_name");
            this.dgTourList.Columns[1].Frozen = true;//冻结前两列
            this.dgTourList.AddColumn("统一社会信用代码", "company_id");
            this.dgTourList.AddColumn("法定代表人姓名", "legal_name");
            this.dgTourList.AddColumn("注册商标", "registered_trademark");
            
            this.dgTourList.AddColumn("联系电话", "phone_number");
            this.dgTourList.AddColumn("经营形式", "trade_form");
            this.dgTourList.AddColumn("联系地址", "address");

            this.dgTourList.AddColumn("年接待旅游（人次）", "year_person_count");
            this.dgTourList.AddColumn("年经营收入（万元）", "year_trade_income");
           
            this.dgTourList.AddColumn("添加时间", "Create_datetime").SetSortMode(DataGridViewColumnSortMode.Automatic);
            this.dgTourList.AddColumn("添加人", "Creater");
            //自适应列宽，包括列名和列内容
            this.dgTourList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            tourBLL = new TourBLL();
            DataTable dtAnimal = tourBLL.getAllTour(condition, pageIndex, pageSize);
            //获得总页数
            int totalCount = this.tourBLL.getTotalCount(condition);
            this.pagination.PageSize = this.pageSize;
            this.pagination.TotalCount = totalCount;
            this.dgTourList.DataSource = dtAnimal;
        }
    }
}
