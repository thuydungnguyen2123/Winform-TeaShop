using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.DAO;

namespace TeaShop
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string UName = txtUsername.Text;
            string PW = txtPass.Text;
            if(Login(UName, PW)) {
                if(PW == "0")
                {
                    FTableManager f = new FTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if(PW == "1"){
                    FAdminManager fam = new FAdminManager();
                    this.Hide();
                    fam.ShowDialog();
                    this.Show();
                }

            }
            
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                this.Close();
            }
        }
        bool Login(string UName, string PW)
        {
            return AccountDAO.Instance.Login(UName, PW);
        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
