using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DAO
{
    public class FloorDAO
    {
        private static FloorDAO instance;
        public static FloorDAO Instance
        {
            get { if (instance == null) instance = new FloorDAO(); return instance; }
            private set => instance = value;
        }
        private FloorDAO() { }

        public DataTable GetAllFloor()
        {
            string query = "select * from TANGLAU";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
