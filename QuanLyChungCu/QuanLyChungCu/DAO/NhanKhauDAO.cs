using ApartmentManager.DAO;
using ApartmentManager.DTO;
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

        public bool ThemNhanKhau(ResidentDTO cuDan,ApartmentDTO canHo,ResidentDTO chuHo)
        {
            string ThemCuDanquery = "PR_InsertResident @tenCuDan, @ngaySinh ,@cmnd ,@sdt,@gioitinh ";
            string CapNhatCanHoquery = "CapNhatNhanKhauCanHo  @MaCuDan , @MaCanHo, @ChuHo ";
            string CapNhatCanHoCuDanquery = "AddResidentToApartment @MaCuDan , @MaCanHo ";


            var data = DataProvider.Instance.ExecuteNonQuery(ThemCuDanquery,new object[] { cuDan.TenCuDan, cuDan.NgaySinh, cuDan.Cmnd, cuDan.Sdt, cuDan.GioiTinh });
            var data1 = DataProvider.Instance.ExecuteNonQuery(CapNhatCanHoquery, new object[] { cuDan.MaCuDan , canHo.MaCanHo , false  });
            var data2 = DataProvider.Instance.ExecuteNonQuery(CapNhatCanHoCuDanquery, new object[] { chuHo.MaCuDan, canHo.MaCanHo });
            
            return data > 0 && data1 > 0 && data2 > 0;
        }
    }
}
