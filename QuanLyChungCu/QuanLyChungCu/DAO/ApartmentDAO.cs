using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class ApartmentDAO
    {
        private static ApartmentDAO instance;
        public static ApartmentDAO Instance
        {
            get { if (instance == null) instance = new ApartmentDAO(); return instance; }
            private set => instance = value;
        }
        private ApartmentDAO() { }

        public List<ApartmentDTO> GetAllApartment()
        {
            string query = "select * from CANHO";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var lstApartment = new List<ApartmentDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstApartment.Add(new ApartmentDTO(row));
            }

            return lstApartment;
        }

        public List<ApartmentDTO> GetAllApartmentByLoaiCanHo(string maLoaiCanHo)
        {
            string query = "select * from CANHO where Maloai_CH = '" + maLoaiCanHo + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var lstApartment = new List<ApartmentDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstApartment.Add(new ApartmentDTO(row));
            }

            return lstApartment;
        }
    }
}
