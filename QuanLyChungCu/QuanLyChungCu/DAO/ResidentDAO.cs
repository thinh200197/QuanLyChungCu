using ApartmentManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DAO
{
    public class ResidentDAO
    {
        private static ResidentDAO instance;
        public static ResidentDAO Instance
        {
            get { if (instance == null) instance = new ResidentDAO(); return instance; }
            private set => instance = value;
        }
        private ResidentDAO() { }

        public int AddResident()
        {
            return 1;
        }

        public List<ResidentDTO> GetAllResident()
        {
            List<ResidentDTO> residentList = new List<ResidentDTO>();
            string query = "SELECT * FROM CUDAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ResidentDTO resident = new ResidentDTO(item);
                residentList.Add(resident);
            }

            return residentList;
        }

        public ResidentDTO GetResidentByCMND(string cmnd)
        {
            ResidentDTO resident = new ResidentDTO();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CUDAN where [CHUNGMINHNHANDAN] = '"+ cmnd + "'");


            return resident;
        }
        public bool AddResident(ResidentDTO resident)
        {
            string query = "PR_InsertResident";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]{ resident.TenCuDan, resident.NgaySinh, resident.Sdt, resident.Cmnd, resident.GioiTinh });
            return data > 0;
        }

        public int AddResidentToApartment(string maCanHo, string maCuDan)
        {
            string query = "PR_InserCuDan_CanHo  @MaCuDan , @MaCanHo";
            try
            {
                int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCuDan, maCanHo });
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
