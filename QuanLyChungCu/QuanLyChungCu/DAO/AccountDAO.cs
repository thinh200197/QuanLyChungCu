using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }
        private AccountDAO() { }

        public bool Login(string userName ,string passWord)
        {
            string query = $"PR_login @username , @password";

            DataTable resulf = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return resulf.Rows.Count > 0;
        }
    }
}
