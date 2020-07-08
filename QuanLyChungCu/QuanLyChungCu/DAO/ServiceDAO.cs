using DevExpress.Data.Async.Helpers;
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

        #region Danh mục Dịch vụ
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
            string query = $"SELECT * FROM DICHVU WHERE ID = {id} ";
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
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaLoaiDichVu, f.TenDichVu, f.DonViTinh, 0 });

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
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaDichVu, f.MaLoaiDichVu, f.TenDichVu, f.DonViTinh, 0 });

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
        #endregion

        #region Đăng Ký Dịch Vụ Công Cộng
        public List<DKDV_DinhKyDTO> GetAll_DinhKy()
        {
            string query = "select * from VIEW_DKDV_DINHKY ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            var result = new List<DKDV_DinhKyDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new DKDV_DinhKyDTO(row));
            }

            return result;
        }

        public Messeges Add_DVDK(DKDV_DinhKyDTO request)
        {
            // validate
            var dv = DataProvider.Instance.ExecuteQuery($"SELECT * FROM DANGKY_DINHKY WHERE MADICHVU = {request.MaDichVu} and MACANHO = {request.MaCanHo}");
            if (dv.Rows.Count > 0)
            {
                return new Messeges() {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thông tin đã tồn tại"
                };
            }
            // add
            string query = $"EXEC PR_INSERT_DVDK @MADICHVU , @MACANHO , @TRANG_THAI , @STAFF ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { request.MaDichVu , request.MaCanHo , request .TrangThai , request.CREATE_BY});

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

        public Messeges Update_DVDK(DKDV_DinhKyDTO request)
        {
            // validate

            /// trường hợp thay đổi nhưng bị trùng mã căn hộ và mã dịch vụ
            var dv = DataProvider.Instance.ExecuteQuery($"SELECT * FROM DANGKY_DINHKY WHERE MADICHVU = {request.MaDichVu} and MACANHO = {request.MaCanHo}");
            if (dv.Rows.Count > 0)
            {
                var dichVu = dv.Rows[0];
                if (request.TrangThai == dichVu["TRANG_THAI"].ToString())
                {

                }


                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thông tin đã tồn tại"
                };
            }

            string query = $"EXEC PR_UPDATE_DVDK @ID , @MADICHVU , @MACANHO , @TRANG_THAI , @STAFF ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { request.ID, request.MaDichVu , request.MaCanHo, request.TrangThai, request.UPDATE_BY});

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
        
        #endregion

        #region Đăng Ký Dịch Vụ Định Kỳ

        #endregion


    }
}
