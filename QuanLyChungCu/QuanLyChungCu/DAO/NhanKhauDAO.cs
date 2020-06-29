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

        public Messges ThemNhanKhau(int Id , ResidentDTO cuDan, string maCanHo)
        {
            string queryLayTTCD = "SELECT * FROM CUDAN WHERE CHUNGMINHNHANDAN = '" + cuDan.Cmnd + "'";
            var cuDanBD = DataProvider.Instance.ExecuteQuery(queryLayTTCD);
            if (Id > 0)
            {
                var old_CD = new ResidentDTO(cuDanBD.Rows[0]);
                cuDan.MaCuDan = old_CD.MaCuDan;
                var cuDanDangO = CuDan_CanHoDAO.Instance.LayTTNK_DangO(old_CD.MaCuDan);

                // Cập nhật thông tin cư dân
                ResidentDAO.Instance.UpdateResident(cuDan);

                // Cập nhật thông tin cư dân ở căn hộ

                    // khác căn hộ
                    var cnNgayHetO = CuDan_CanHoDAO.Instance.CapNhatNhanKhau(Id, cuDanDangO.ID, cuDanDangO.NgayVaoO, DateTime.Now.ToShortDateString());
                    var isAdd = CuDan_CanHoDAO.Instance.ThemNhanKhau(cuDanDangO.MaCuDan, maCanHo);
                    // trùng căn hộ


            }
            else
            {
                if (cuDanBD.Rows.Count > 0)
                {
                    return new Messges() {
                        MessegeType = MessegeType.Error,
                        MessegeContent = "Số CMND bị trùng !"
                    };
                }
                //thêm cư dân
                Messges themCuDan = ResidentDAO.Instance.AddResident(cuDan);

                if (themCuDan.MessegeType == MessegeType.Error)
                {
                    return themCuDan;
                }

                //-thêm nhân khẩu
                var cuDanVuaThem = ResidentDAO.Instance.GetResidentByCMND(cuDan.Cmnd);
                var themNhanKhau = CuDan_CanHoDAO.Instance.ThemNhanKhau(cuDanVuaThem.MaCuDan, maCanHo);

                if (themNhanKhau.MessegeType == MessegeType.Error)
                {
                    return themNhanKhau;
                }

                //-cập nhật căn hộ(số người)
                var nhanKhau = ApartmentDAO.Instance.CapNhatSoNguoiO(maCanHo,1);

                if (nhanKhau.MessegeType == MessegeType.Error)
                {
                    return nhanKhau;
                }

            }
            return new Messges()
            {
                MessegeType = MessegeType.Success,
                MessegeContent = "Cập nhật thành công."
            };
            //var resulf = false;
            //// TRƯỜNG HỢP CẬP NHẬT


            //if (cuDanBD.Rows.Count > 0)
            //{
            //    var old_CD = new ResidentDTO(cuDanBD.Rows[0]);
            //    cuDan.MaCuDan = old_CD.MaCuDan;
            //    var cuDanDangO = CuDan_CanHoDAO.Instance.LayTTNK_DangO(old_CD.MaCuDan);
            //    if (cuDanDangO.ID < 0)
            //    {
            //        return false;
            //    }

            //    ResidentDAO.Instance.UpdateResident(cuDan);

            //    // cập nhật nhân khẩu
            //   
            //    resulf = cnNgayHetO && isAdd;
            //}
            //// TRƯỜNG HỢP THÊM

            //else
            //{
            //    // thêm cư dân


            //    // Lấy thông tin cư dân vừa thêm

            //    // thêm nhân khẩu

            //    resulf = themCuDan && themNhanKhau;
            //}
            //return resulf;
        }
    }
}
