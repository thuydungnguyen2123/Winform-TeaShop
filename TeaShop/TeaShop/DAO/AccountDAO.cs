using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); //hàm mã hóa pass

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            //var list = hasData.ToString();
            //list.Reverse();

            //string query = "USP_Login @userName , @passWord";

            //DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
