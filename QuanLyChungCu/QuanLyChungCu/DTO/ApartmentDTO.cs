using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ApartmentDTO
    {
        public ApartmentDTO(string maCanHo, string maTangLau, string maLoaiCanHo, string tenCanHo, string soNguoiO, string chuHo)
        {
            MaCanHo = maCanHo;
            MaTangLau = maTangLau;
            MaLoaiCanHo = maLoaiCanHo;
            TenCanHo = tenCanHo;
            SoNguoiO = soNguoiO;
            ChuHo = chuHo;
        }

        public string MaCanHo { get; set; }
        public string MaTangLau { get; set; }
        public string MaLoaiCanHo { get; set; }
        public string TenCanHo { get; set; }
        public string SoNguoiO { get; set; }
        public string ChuHo { get; set; }

        public ApartmentDTO() { }

        public ApartmentDTO(DataRow row) 
        {
            MaCanHo = row["MACANHO"].ToString();
            MaTangLau = row["MATANGLAU"].ToString();
            MaLoaiCanHo = row["MALOAICANHO"].ToString();
            TenCanHo = row["TENCANHO"].ToString();
            SoNguoiO = row["SONGUOIO"].ToString();
            ChuHo = row["CHUHO"].ToString();
        }
    }
}
