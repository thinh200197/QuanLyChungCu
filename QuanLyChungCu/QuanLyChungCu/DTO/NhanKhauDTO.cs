using System;
using System.ComponentModel;
using System.Data;

namespace QuanLyChungCu.DTO
{
    public class NhanKhauDTO
    {
        public int ID { get; set; }
        [DisplayName("Mã Căn hộ")]
        public string MaCanHo { get; set; }
        [DisplayName("Mã Cư Dân")]
        public int MaCuDan { get; set; }
        [DisplayName("Căn hộ")]
        public string TenCanHo { get; set; }
        [DisplayName("Ngày ở")]
        public string NgayBatDauO { get; set; }
        [DisplayName("Ngày đi")]
        public string NgayHetO { get; set; }
        [DisplayName("Họ và Tên")]
        public string TenCuDan { get; set; }
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        [DisplayName("Giới tính")]
        public int GioiTinh { get; set; }
        [DisplayName("CMND_CuDan")]
        public string Cmnd_CuDan { get; set; }
        public NhanKhauDTO(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.MaCanHo = row["MACANHO"].ToString();
            this.MaCuDan = int.Parse(row["MACUDAN"].ToString());
            this.TenCanHo = row["TENCANHO"].ToString();
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.NgayBatDauO = row["NGAYBATDAUO"].ToString();
            this.NgayHetO = row["NGAYHETO"]?.ToString();
            this.Cmnd_CuDan = row["CHUNGMINHNHANDAN"].ToString();
            this.NgaySinh = row["NGAYSINH"].ToString();
            this.Sdt = row["SODIENTHOAI"].ToString();
            this.GioiTinh = bool.Parse(row["GIOITINH"].ToString()) ? 1 : 0; 
        }
        public NhanKhauDTO() { }
    }
}
