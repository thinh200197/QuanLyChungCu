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

        public bool ThemNhanKhau(ResidentDTO cuDan, string maCanHo, ResidentDTO chuHo)
        {
            var resulf = false;
            // TRƯỜNG HỢP CẬP NHẬT
            string queryLayTTCD = "SELECT * FROM CUDAN WHERE CHUNGMINHNHANDAN = '" + cuDan.Cmnd + "'";
            var cuDanBD = DataProvider.Instance.ExecuteQuery(queryLayTTCD);

            if (cuDanBD.Rows.Count > 0)
            {
                var old_CD = new ResidentDTO(cuDanBD.Rows[0]);
                cuDan.MaCuDan = old_CD.MaCuDan;
                var cuDanDangO = CuDan_CanHoDAO.Instance.LayTTNK_DangO(old_CD.MaCuDan);
                if (cuDanDangO.ID < 0)
                {
                    return false;
                }

                ResidentDAO.Instance.UpdateResident(cuDan);

                // cập nhật nhân khẩu
                var cnNgayHetO = CuDan_CanHoDAO.Instance.CapNhatNhanKhau(cuDanDangO.ID, cuDanDangO.NgayVaoO.Value, DateTime.Now);
                var isAdd = CuDan_CanHoDAO.Instance.ThemNhanKhau(cuDanDangO.MaCuDan, maCanHo);
                resulf = cnNgayHetO && isAdd;
            }
            // TRƯỜNG HỢP THÊM

            else
            {
                // thêm cư dân
                var themCuDan = ResidentDAO.Instance.AddResident(cuDan);

                // Lấy thông tin cư dân vừa thêm
                var cuDanVuaThem = ResidentDAO.Instance.GetResidentByCMND(cuDan.Cmnd);
                // thêm nhân khẩu
                var themNhanKhau = CuDan_CanHoDAO.Instance.ThemNhanKhau(cuDanVuaThem.MaCuDan, maCanHo);
                resulf = themCuDan && themNhanKhau;
            }
            return resulf;
        }
    }
}
