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
        //public string loaiCanHo;
        public string tenCuDan;
        public string ngaySinh;
        public string sdt;
        public string gioiTinh;
        public string chuHo;

        [DisplayName("Tòa nhà")]
        public string TenBlock { get => tenBlock; set => tenBlock = value; }
        [DisplayName("Tầng")]
        public string TenTangLau { get => tenTangLau; set => tenTangLau = value; }
        [DisplayName("Căn hộ")]
        public string TenCanHo { get => tenCanHo; set => tenCanHo = value; }
        [DisplayName("Diện tích")]
        public string DienTich { get => dienTich; set => dienTich = value; }
        [DisplayName("Số phòng ngủ")]
        public int SoPhongNgu { get => soPhongNgu; set => soPhongNgu = value; }
        [DisplayName("Người tối đa")]
        public int SoNguoiToiDa { get => soNguoiToiDa; set => soNguoiToiDa = value; }
        [DisplayName("Ngày ở")]
        public string NgayBatDauO { get => ngayBatDauO; set => ngayBatDauO = value; }      
        [DisplayName("Ngày đi")]
        public string NgayHetO { get => ngayHetO; set => ngayHetO = value; }       
        [DisplayName("Họ và Tên")]
        public string TenCuDan { get => tenCuDan; set => tenCuDan = value; }
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get => sdt; set => sdt = value; }
        [DisplayName("Giới tính")]
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        [DisplayName("Chủ Hộ")]
        public string ChuHo { get => chuHo; set => chuHo = value; }

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
            this.ChuHo = row["CHUHO"].ToString();
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
