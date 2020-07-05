using QuanLyChungCu.DAO;
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

        public List<ApartmentCategogyDTO> GetAll()
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

        public ApartmentCategogyDTO GetFoolById(string maLoai)
        {
            string query = $"SELECT * FROM LOAICANHO WHERE MALOAI_CH = '{maLoai}' ";
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new ApartmentCategogyDTO(data.Rows[0]);
            }
            return new ApartmentCategogyDTO();
        }
        public Messeges Add(ApartmentCategogyDTO f)
        {
            string query = $"EXEC PR_Insert_ApartmentCategogy @MALOAI_CH , @TENLOAI_CH , @DIENTICH , @SOPHONGNGU , @SONGUOITOIDA ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.Maloai_CH, f.Tenloai_CH, f.DienTich , f.SoPhongNgu, f.SoNguoiToiDa});

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
        public Messeges Update(ApartmentCategogyDTO f)
        {
            string query = $"EXEC PR_Update_ApartmentCategogy @MALOAI_CH , @TENLOAI_CH , @DIENTICH , @SOPHONGNGU , @SONGUOITOIDA ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.Maloai_CH, f.Tenloai_CH, f.DienTich, f.SoPhongNgu, f.SoNguoiToiDa });

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
