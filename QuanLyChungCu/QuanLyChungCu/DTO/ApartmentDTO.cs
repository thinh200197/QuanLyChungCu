using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ApartmentDTO
    {
        [DisplayName("Mã Căn Hộ")]
        public string MaCanHo { get; set; }
        [DisplayName("Mã Tầng Lầu")]
        public string MaTangLau { get; set; }
        [DisplayName("Mã Tòa nhà")]
        public string MaBlock { get; set; }
        [DisplayName("Mã Loại Căn Hộ")]
        public string MaLoaiCanHo { get; set; }
        [DisplayName("Tên Căn Hộ")]
        public string TenCanHo { get; set; }
        [DisplayName("Số Người Đang Ở")]
        public int SoNguoiO { get; set; }
        [DisplayName("Chủ Hộ")]
        public int ChuHo { get; set; }
        [DisplayName("Tên Tầng Lầu")]
        public string TenTangLau { get; set; }
        [DisplayName("Tên Loại Căng Hộ")]
        public string TenLoaiCanHo { get; set; }
        [DisplayName("Tên Chủ Hộ")]
        public string TenChuHo { get; set; }
        [DisplayName("CMND Chủ Hộ")]
        public string CmndChuHo { get; set; }

        public ApartmentDTO() { }

        public ApartmentDTO(DataRow row) 
        {
            MaCanHo = row["MACANHO"].ToString();
            MaTangLau = row["MATANGLAU"].ToString();
            MaLoaiCanHo = row["MALOAI_CH"].ToString();
            TenCanHo = row["TENCANHO"].ToString();
            SoNguoiO = int.Parse(row["SONGUOIO"].ToString());
            ChuHo = int.Parse(row["CHUHO"].ToString());
            MaBlock = row["MABLOCK"].ToString();
            TenTangLau = row["TENTANGLAU"].ToString();
            TenLoaiCanHo = row["TENLOAI_CH"].ToString();
            TenChuHo = row["TENCHUHO"].ToString();
            CmndChuHo = row["CMND_CHUHO"].ToString();
        }
    }
}
