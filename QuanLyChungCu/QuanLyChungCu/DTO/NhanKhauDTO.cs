using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class NhanKhauDTO
    {
        
        public string tenBlock;
        public string tenTangLau;
        public string tenCanHo;
        public string dienTich;
        public int soPhongNgu;
        public int soNguoiToiDa;
        public string ngayBatDauO;
        public string ngayHetO;
        public string loaiCanHo;
        public string tenCuDan;
        public string ngaySinh;
        public string sdt;

        [DisplayName("Tòa nhà")]
        public string TenBlock { get => tenBlock; set => tenBlock = value; }
        [DisplayName("Tầng")]
        public string TenTangLau { get => tenTangLau; set => tenTangLau = value; }
        [DisplayName("Căn hộ")]
        public string TenCanHo { get => tenCanHo; set => tenCanHo = value; }
        [DisplayName("Diện tích")]
        public string DienTich { get => dienTich; set => dienTich = value; }
        [DisplayName("Loại phòng")]
        public int SoPhongNgu { get => soPhongNgu; set => soPhongNgu = value; }
        [DisplayName("Người tối đa")]
        public int SoNguoiToiDa { get => soNguoiToiDa; set => soNguoiToiDa = value; }
        [DisplayName("Ngày ở")]
        public string NgayBatDauO {
           get{
                if (ngayBatDauO != null && !string.IsNullOrEmpty(ngayBatDauO.Trim()))
                {
                    return ngayBatDauO = DateTime.Parse(ngayBatDauO.ToString()).ToString("dd/MM/yyyy");
                }
                return ngayBatDauO;
            }
            set{
                ngayBatDauO = value;
            }
        }
        [DisplayName("Ngày đi")]
        public string NgayHetO {
            get
            {
                if (ngayHetO != null && !string.IsNullOrEmpty(ngayHetO.Trim()))
                {
                    ngayHetO = DateTime.Parse(ngayHetO.ToString()).ToString("dd/MM/yyyy");
                }
                return ngayHetO;
            }
            set
            {
                ngayHetO = value;
            }
        }
        [DisplayName("Loại phòng")]
        public string LoaiCanHo { get => loaiCanHo; set => loaiCanHo = value; }
        [DisplayName("Họ và Tên")]
        public string TenCuDan { get => tenCuDan; set => tenCuDan = value; }
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get => sdt; set => sdt = value; }

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
            this.LoaiCanHo = row["TENLOAI_CH"].ToString();
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.NgaySinh = row["NGAYSINH"].ToString();
            this.Sdt = row["SODIENTHOAI"].ToString();
        }

        public NhanKhauDTO(string tenBlock, string tenTangLau, string tenCanHo, string dienTich, int soPhongNgu, int soNguoiToiDa, string ngayBatDauO, string ngayHetO, string loaiCanHo, string tenCuDan, string ngaySinh, string sdt)
        {
           this.TenBlock = tenBlock;
           this.TenTangLau = tenTangLau;
           this.TenCanHo = tenCanHo;
           this.DienTich = dienTich;
           this.SoPhongNgu = soPhongNgu;
           this.SoNguoiToiDa = soNguoiToiDa;
           this.NgayBatDauO = ngayBatDauO;
           this.NgayHetO = ngayHetO;
           this.LoaiCanHo = loaiCanHo;
           this.TenCuDan = tenCuDan;
           this.NgaySinh = ngaySinh;
           this.Sdt = sdt;
        }
    }
}
