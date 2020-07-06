using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;

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

        public Messeges LuuNhanKhau(NhanKhauDTO newNh ,NhanKhauDTO oldNh)
        {
            var cd = new ResidentDTO()
            {
                TenCuDan = newNh.TenCuDan,
                MaCuDan = newNh.MaCuDan,
                Cmnd = newNh.Cmnd_CuDan,
                GioiTinh = newNh.GioiTinh,
                NgaySinh = DateTime.Parse(newNh.NgaySinh),
                Sdt = newNh.Sdt
            };
            var CuDan = ResidentDAO.Instance.GetResidentByCmndOrSdt(cd.Cmnd);
            if (CuDan.MaCuDan > 0)
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Số CMND bị trùng !"
                };
            }
            if (oldNh.ID > 0 && oldNh != null) // Cập nhật Nhân khẩu
            {
                /// Cập nhật bảng CUDAN
                ResidentDAO.Instance.Update(cd);
                /// Cập nhật bảng CUDAN_CANHO
                if (newNh.MaCanHo != oldNh.MaCanHo)
                {
                    var chuyenHo = CuDan_CanHoDAO.Instance.ChuyenCanHo(newNh.ID, oldNh.MaCuDan, newNh.MaCanHo, oldNh.MaCanHo);
                }
            }
            else  // Thêm mới nhân khẩu
            {               
                ResidentDAO.Instance.Add(cd);
                var newCd = ResidentDAO.Instance.GetResidentByCmndOrSdt(cd.Cmnd);
                CuDan_CanHoDAO.Instance.Them(newCd.MaCuDan, newNh.MaCanHo);
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

        //public Messeges Add(NhanKhauDTO nk)
        //{
        //    /// Lưu Bảng CUDAN
        //    /// Lưu Bảng CUDAN_CANHO
        //    /// Cập nhật bảng CANHO
        //}

        //public Messeges Update(NhanKhauDTO nk)
        //{

        //    /// Cập nhật bảng CUDAN_CANHO
        //    var cdch = new CuDan_CanHoDTO() { 
        //        ID = nk.ID,
        //        MaCanHo = nk.
        //    };

        //    var upCdch = CuDan_CanHoDAO.Instance.CapNhat(cdch);
        //    /// Cập nhật bảng CUDAN
        //    /// Cập nhật bảng CANHO
        //}
    }
}
