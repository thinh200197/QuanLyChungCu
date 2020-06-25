using QuanLyChungCu.DTO;
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

        public List<FloorDTO> GetAllFloor()
        {
            string query = "select * from TANGLAU";
            DataTable data =  DataProvider.Instance.ExecuteQuery(query);

            var lstFloor = new List<FloorDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstFloor.Add(new FloorDTO(row));
            }

            return lstFloor;
        }
        public List<FloorDTO> GetAllFloorByMaBlock(string maBlock)
        {
            string query = "select * from TANGLAU where MABLOCK = '" + maBlock + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            var lstFloor = new List<FloorDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstFloor.Add(new FloorDTO(row));
            }

            return lstFloor;
        }
    }
}
