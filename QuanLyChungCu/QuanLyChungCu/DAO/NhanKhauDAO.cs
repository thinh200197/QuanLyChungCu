using QuanLyChungCu.DAO;
using QuanLyChungCu.DTO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class NhanKhauDAO
    {
        private static NhanKhauDAO instance;
        public static NhanKhauDAO Instance
        {
            get { if (instance == null) instance = new NhanKhauDAO(); return instance; }
            private set => instance = value;
        }
        private NhanKhauDAO() { }

        public List<NhanKhauDTO> DanhSachNhanKhau()
        {
            string query = "SELECT* from VIEW_NhanKhau";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            var lstNhanKhau = new List<NhanKhauDTO>();

            if (data == null)
            {
                return lstNhanKhau;
            }

            foreach (DataRow item in data.Rows)
            {
                var nhanKhau = new NhanKhauDTO(item);
                lstNhanKhau.Add(nhanKhau);
            }
            return lstNhanKhau;
        }

        public Messeges ThemNhanKhau(int id, ResidentDTO cd, string maCanHo)
        {
            // Lấy thông tin 
            //var CanHo = ApartmentDAO.Instance.GetApartmentByMaCanHo(maCanHo);
            var CuDan_CanHo = CuDan_CanHoDAO.Instance.Lay_TT_ID(id);

            //Kiểm tra dữ liệu đầu vào
            var validate = KiemTraDauVao(id, cd, maCanHo);
            if (validate.MessegeType == MessegeType.Error)
            {
                return validate;
            }

            // Thực hiện thêm

            if (id > 0)
            {
                //  Kiểm tra rule Cập nhật
                cd.MaCuDan = CuDan_CanHo.MaCuDan;
                var cuDanDangO = CuDan_CanHoDAO.Instance.LayTTNK_DangO(CuDan_CanHo.MaCuDan);

                // Cập nhật thông tin cư dân
                ResidentDAO.Instance.UpdateResident(cd);

                // Cập nhật thông tin cư dân ở căn hộ

                //// trùng căn hộ
                if (maCanHo != CuDan_CanHo.MaCanHo)
                {
                    CuDan_CanHoDAO.Instance.CapNhatNgayHetO(id);
                    ApartmentDAO.Instance.CapNhatSoNguoiO(cuDanDangO.MaCanHo, -1);
                    var isAdd = CuDan_CanHoDAO.Instance.Them(cuDanDangO.MaCuDan, maCanHo);
                    ApartmentDAO.Instance.CapNhatSoNguoiO(maCanHo, 1);
                }
            }
            else
            {
                //  Kiểm tra rule Thêm
                var CuDan = ResidentDAO.Instance.GetResidentByCMND(cd.Cmnd);
                if (CuDan.MaCuDan > 0)
                {
                    return new Messeges()
                    {
                        MessegeType = MessegeType.Error,
                        MessegeContent = "Số CMND bị trùng !"
                    };
                }

                // thêm cư dân
                Messeges themCuDan = ResidentDAO.Instance.AddResident(cd);

                if (themCuDan.MessegeType == MessegeType.Error)
                {
                    return themCuDan;
                }

                //-thêm nhân khẩu
                var cuDanVuaThem = ResidentDAO.Instance.GetResidentByCMND(cd.Cmnd);
                var themNhanKhau = CuDan_CanHoDAO.Instance.Them(cuDanVuaThem.MaCuDan, maCanHo);

                if (themNhanKhau.MessegeType == MessegeType.Error)
                {
                    return themNhanKhau;
                }

                //-cập nhật căn hộ(số người)
                ApartmentDAO.Instance.CapNhatSoNguoiO(maCanHo, 1);
            }

            return new Messeges()
            {
                MessegeType = MessegeType.Success,
                MessegeContent = "Cập nhật thành công."
            };
        }

        public Messeges KiemTraDauVao(int Id, ResidentDTO cd, string maCanHo)
        {

            if (string.IsNullOrEmpty(cd.Cmnd))
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Nhập CMND!"
                };
            }

            if (string.IsNullOrEmpty(cd.TenCuDan))
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Success,
                    MessegeContent = "Nhập Tên cư dân."
                };
            }

            if (string.IsNullOrEmpty(maCanHo))
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Success,
                    MessegeContent = "Chọn Căn hộ."
                };
            }
            if (string.IsNullOrEmpty(cd.TenCuDan))
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Success,
                    MessegeContent = "Nhập Tên cư dân."
                };
            }

            return new Messeges()
            {
                MessegeType = MessegeType.Success,
            };
        }
    }
}
