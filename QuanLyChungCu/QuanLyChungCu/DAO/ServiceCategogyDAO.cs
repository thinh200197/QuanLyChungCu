using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyChungCu.DAO
{
    public class ServiceCategogyDAO
    {
        private static ServiceCategogyDAO instance;
        public static ServiceCategogyDAO Instance
        {
            get { if (instance == null) instance = new ServiceCategogyDAO(); return instance; }
            private set => instance = value;
        }
        private ServiceCategogyDAO() { }

        public List<ServiceCategogyDTO> GetAll()
        {
            string query = "select * from LOAIDICHVU";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            var lst = new List<ServiceCategogyDTO>();
            foreach (DataRow row in data.Rows)
            {
                lst.Add(new ServiceCategogyDTO(row));
            }

            return lst;
        }

        public ServiceCategogyDTO GetFoolById(string Id)
        {
            string query = $"SELECT * FROM LOAIDICHVU WHERE ID = '{Id}' ";
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new ServiceCategogyDTO(data.Rows[0]);
            }
            return new ServiceCategogyDTO();
        }
        public Messeges Add(ServiceCategogyDTO f)
        {
            string query = $"EXEC PR_Insert_ServiceCategogy @MALOAIDICHVU , @TENLOAIDICHVU , @NGUOITAO  ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaLoaiDichVu,f.Name, 0 });

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
        public Messeges Update(ServiceCategogyDTO f)
        {
            if (f.ID <= 0)
            {
                throw new Exception("Chọn dòng cập nhật trước thực hiện chức năng này.") ;
            }

            string query = $"EXEC PR_Update_ServiceCategogy @ID , @MALOAIDICHVU , @TENLOAIDICHVU , @NGUOICAPNHAT ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {f.ID , f.MaLoaiDichVu, f.Name, 0 });

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
