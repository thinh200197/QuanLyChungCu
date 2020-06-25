using System.ComponentModel;
using System.Data;

namespace QuanLyChungCu.DTO
{
    public class NhanKhauDTO
    {

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

        public NhanKhauDTO(DataRow row)
        {
            this.TenBlock = row["TENBLOCK"].ToString();
            this.TenTangLau = row["TENTANGLAU"].ToString();
            this.TenCanHo = row["TENCANHO"].ToString();
            this.DienTich = row["DIENTICH"].ToString();
            this.SoPhongNgu = int.Parse(row["SOPHONGNGU"].ToString());
            this.SoNguoiToiDa = int.Parse(row["SONGUOITOIDA"].ToString());
            this.NgayBatDauO = row["NGAYBATDAUO"].ToString();
            this.NgayHetO = row["NGAYHETO"]?.ToString();
            //this.LoaiCanHo = row["TENLOAI_CH"].ToString();
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.NgaySinh = row["NGAYSINH"].ToString();
            this.Sdt = row["SODIENTHOAI"].ToString();
            this.GioiTinh = bool.Parse(row["GIOITINH"].ToString()) ? "Nam" : "Nữ";
            this.ChuHo = row["TENCHUHO"].ToString();
        }

        public NhanKhauDTO(string tenBlock, string tenTangLau, string tenCanHo, string dienTich,
            int soPhongNgu, int soNguoiToiDa, string ngayBatDauO, string ngayHetO,
            string tenCuDan, string ngaySinh, string sdt, string gioiTinh, string chuHo)
        {
            this.TenBlock = tenBlock;
            this.TenTangLau = tenTangLau;
            this.TenCanHo = tenCanHo;
            this.DienTich = dienTich;
            this.SoPhongNgu = soPhongNgu;
            this.SoNguoiToiDa = soNguoiToiDa;
            this.NgayBatDauO = ngayBatDauO;
            this.NgayHetO = ngayHetO;
            this.TenCuDan = tenCuDan;
            this.NgaySinh = ngaySinh;
            this.Sdt = sdt;
            this.GioiTinh = gioiTinh;
            this.ChuHo = chuHo;
        }
    }
}
