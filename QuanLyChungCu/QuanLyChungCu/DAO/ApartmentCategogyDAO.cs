using ApartmentManager.DAO;
using System.Data;

namespace QuanLyChungCu.DAO
{
    public class ApartmentCategogyDAO
    {
        private static ApartmentCategogyDAO instance;
        public static ApartmentCategogyDAO Instance
        {
            get { if (instance == null) instance = new ApartmentCategogyDAO(); return instance; }
            private set => instance = value;
        }
        private ApartmentCategogyDAO() { }

        public DataTable GetAllApartmentCategogy()
        {
            string query = "select * from LOAICANHO";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetAllApartmentCategogyByMaTangLau(string maTangLau)
        {
            string query = "select * from LOAICANHO where MATANGLAU = '" + maTangLau + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
