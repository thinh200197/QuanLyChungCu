using System;
using System.ComponentModel;
using System.Data;

namespace QuanLyChungCu.DTO
{
    public class NhanKhauDTO
    {
        public int ID { get; set; }
        [DisplayName("Tòa nhà")]
        public string TenBlock { get; set; }
        [DisplayName("Tầng")]
        public string TenTangLau { get; set; }
        [DisplayName("Căn hộ")]
        public string TenCanHo { get; set; }
        [DisplayName("Diện tích")]
        public string DienTich { get; set; }
        [DisplayName("Số phòng ngủ")]
        public int SoPhongNgu { get; set; }
        [DisplayName("Người tối đa")]
        public int SoNguoiToiDa { get; set; }
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
        public string GioiTinh { get; set; }
        [DisplayName("Chủ Hộ")]
        public string ChuHo { get; set; }
        [DisplayName("CMND_CuDan")]
        public string Cmnd_CuDan { get; set; }
        [DisplayName("CMND_ChuHo")]
        public string Cmnd_ChuHo { get; set; }
        public NhanKhauDTO(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.TenBlock = row["TENBLOCK"].ToString();
            this.TenTangLau = row["TENTANGLAU"].ToString();
            this.TenCanHo = row["TENCANHO"].ToString();
            this.DienTich = row["DIENTICH"].ToString();
            this.SoPhongNgu = int.Parse(row["SOPHONGNGU"].ToString());
            this.SoNguoiToiDa = int.Parse(row["SONGUOITOIDA"].ToString());
            this.NgayBatDauO = row["NGAYBATDAUO"].ToString();
            this.NgayHetO = row["NGAYHETO"]?.ToString();
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.Cmnd_CuDan = row["CMND_CUDAN"].ToString();
            this.NgaySinh = row["NGAYSINH"].ToString();
            this.Sdt = row["SODIENTHOAI"].ToString();
            this.GioiTinh = bool.Parse(row["GIOITINH"].ToString()) ? "Nam" : "Nữ";
            this.ChuHo = row["TENCHUHO"].ToString();
            this.Cmnd_ChuHo = row["CMND_CHUHO"].ToString();
        }

    }
}
