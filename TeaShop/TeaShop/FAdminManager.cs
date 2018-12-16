using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.DAO;

namespace TeaShop
{
    public partial class FAdminManager : Form
    {
        public FAdminManager()
        {
            InitializeComponent();
            LoadAccountList();
            LoadThucUongList();
            LoadNhomThucUongList();
        }
        void LoadAccountList()
        {
            string query = "select * from dbo.Account" ;//"EXECUTE dbo.spGetAccountByUserName @username ";
                                                        //DataProvider provider = new DataProvider();
            dgvTK.DataSource = DataProvider.Instance.ExcuteQuery(query);//, new object[] { "miyu" });

        }

        void LoadNhomThucUongList()
        {
            string query = "select * from dbo.ThucUong";

            dgvMon.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void LoadThucUongList()
        {
            string query = "SELECT * FROM [dbo].[NhomThucUong]";

            dgvNhom.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }


    }
    
}
