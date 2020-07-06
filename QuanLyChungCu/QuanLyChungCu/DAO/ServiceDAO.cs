using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return instance; }
            private set => instance = value;
        }
        private ServiceDAO() { }

        public List<ServiceDTO> GetAll()
        {
            string query = "select * from VIEW_SERVICE";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            var lstFloor = new List<ServiceDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstFloor.Add(new ServiceDTO(row));
            }

            return lstFloor;
        }

        public ServiceDTO GetServiceById(int id)
        {
            string query = $"SELECT * FROM DICHVU WHERE MATANG = {id} ";
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new ServiceDTO(data.Rows[0]);
            }
            return new ServiceDTO();
        }
        public Messeges Add(ServiceDTO f)
        {
            string query = $"EXEC PR_Insert_Service @MALOAIDICHVU , @TENDICHVU , @DONVITINH , @NGUOITAO  ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaLoaiDichVu, f.TenDichVu, f.DonViTinh ,f.CREATE_BY });

            if (data > 0)
            {
                return new Messeges()
                {
                    MessegeContent = "Thành công !",
                    MessegeType = MessegeType.Success
                };
            }

            return new Messeges()
            {
                MessegeContent = "Thất bại !",
                MessegeType = MessegeType.Error
            };
        }
        public Messeges Update(ServiceDTO f)
        {
            string query = $"EXEC PR_Update_Service @ID , @MALOAIDICHVU , @TENDICHVU , @DONVITINH , @NGUOICAPNHAT ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaDichVu , f.MaLoaiDichVu, f.TenDichVu, f.DonViTinh, f.UPDATE_BY });

            if (data > 0)
            {
                return new Messeges()
                {
                    MessegeContent = "Thành công !",
                    MessegeType = MessegeType.Success
                };
            }

            return new Messeges()
            {
                MessegeContent = "Thất bại !",
                MessegeType = MessegeType.Error
            };
        }
    }
}
