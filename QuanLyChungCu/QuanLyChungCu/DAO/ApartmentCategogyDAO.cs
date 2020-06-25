using ApartmentManager.DAO;
using QuanLyChungCu.DTO;
using System.Collections.Generic;
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

        public List<ApartmentCategogyDTO> GetAllApartmentCategogy()
        {
            string query = "select * from LOAICANHO";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            var lstBlock = new List<ApartmentCategogyDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstBlock.Add(new ApartmentCategogyDTO(row));
            }

            return lstBlock;
        }
        public List<ApartmentCategogyDTO> GetAllApartmentCategogyByMaTangLau(string maTangLau)
        {
            string query = "select * from LOAICANHO where MATANGLAU = '" + maTangLau + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);


            var lstBlock = new List<ApartmentCategogyDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstBlock.Add(new ApartmentCategogyDTO(row));
            }

            return lstBlock;
        }
    }
}
