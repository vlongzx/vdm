using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageControl
{

        public partial class Pagination : UserControl
    {
        private int currentPage = 1;
        private int totalPage = 1;
        private int pageSize = 10;
        public delegate void LoadListViewEventHandler(int currentPage,int pageSize,int totalPage);//定义一个委托

        public event LoadListViewEventHandler LoadListView;//声明委托事件
        /// <summary>
        ///  当前页
        /// </summary>
        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                currentPage = value;
            }
        }
        /// <summary>
        ///  总页数
        /// </summary>
        public int TotalPage
        {
            get
            {
                return totalPage;
            }

            set
            {
                totalPage = value;
            }
        }
        /// <summary>
        ///  每页显示记录数量
        /// </summary>
        public int PageSize
        {
            get
            {
                return pageSize;
            }

            set
            {
                pageSize = value;
            }
        }

        public Pagination()
        {
            InitializeComponent();
        }

        private void Pagination_Load(object sender, EventArgs e)
        {
            //初始化cbPageSize
            List<KeyValue> listPageSize = new List<KeyValue>();
            listPageSize.Add(new KeyValue("10", "10"));
            listPageSize.Add(new KeyValue("20", "20"));
            listPageSize.Add(new KeyValue("50", "50"));
            listPageSize.Add(new KeyValue("100", "100"));
            this.cbPageSize.DataSource = listPageSize;
            this.cbPageSize.DisplayMember = "value";
            this.cbPageSize.ValueMember = "key";

            

        }
        /// <summary>
        ///  初始化控件状态
        /// </summary>
        public void InitPagination()
        {
            //初始化控件状态
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共" + this.totalPage + "页";
        }
        /// <summary>
        ///  下一页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNext_Click(object sender, EventArgs e)
        {
            if(this.currentPage < this.totalPage)
            {
                this.CurrentPage = this.CurrentPage + 1;
            }
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共"+ this.totalPage + "页";
            this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
        }
        /// <summary>
        ///  第一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFirst_Click(object sender, EventArgs e)
        {
            this.currentPage = 1;
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共" + this.totalPage + "页";
            this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
        }
        /// <summary>
        ///  最后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnd_Click(object sender, EventArgs e)
        {
            this.currentPage = this.totalPage;
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共" + this.totalPage + "页";
            this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
        }
        /// <summary>
        ///  上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPre_Click(object sender, EventArgs e)
        {
            if (this.currentPage > 1)
            {
                this.CurrentPage = this.CurrentPage - 1;
            }
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共" + this.totalPage + "页";
            this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
        }
        
        /// <summary>
        ///  跳转到指定页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGo_Click(object sender, EventArgs e)
        {
            this.currentPage = int.Parse(this.tbPageIndex.Text.Trim());
            this.labPageIndex.Text = "当前第" + this.currentPage + "页，总共" + this.totalPage + "页";
            this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
        }


        private void cbPageSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbPageSize.SelectedValue != null)
            {
                this.PageSize = int.Parse(this.cbPageSize.SelectedValue.ToString());
                this.LoadListView(this.CurrentPage, this.PageSize, this.TotalPage);
            }
        }

        private void labPageIndex_Click(object sender, EventArgs e)
        {

        }

        private void tbPageIndex_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class KeyValue
    {
        private string key;
        private string value;

        public KeyValue()
        {

        }

        public KeyValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
        /// <summary>
        /// 键值对KEY
        /// </summary>
        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }
        /// <summary>
        ///  键值对VALUE
        /// </summary>
        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
