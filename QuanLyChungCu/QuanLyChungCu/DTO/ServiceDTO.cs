using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ServiceDTO
    {
        public int ID { get; set; }
        [DisplayName("Mã Dịch Vụ")]
        public string MaDichVu { get; set; }
        [DisplayName("Tên Dịch Vụ")]
        public string TenDichVu { get; set; }
        [DisplayName("Mã Loại Dịch Vụ")]
        public string MaLoaiDichVu { get; set; }
        [DisplayName("Tên Loại Dịch Vụ")]
        public string TenLoaiDichVu { get; set; }
        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? NGAYTAO { get; set; }
        [DisplayName("Người Tạo")]
        public int? NGUOITAO { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? NGAYCAPNHAT { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? NGUOICAPNHAT { get; set; }
        public ServiceDTO(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            MaDichVu = row["MADICHVU"].ToString();
            TenDichVu = row["TENDICHVU"].ToString();
            TenLoaiDichVu = row["TENLOAIDICHVU"].ToString();
            MaLoaiDichVu = row["MALOAIDICHVU"].ToString();
            DonViTinh = row["DONVITINH"].ToString();

            NGAYTAO = null;
            NGAYCAPNHAT = null;
            NGUOITAO = null;
            NGUOICAPNHAT = null;

            if (!string.IsNullOrEmpty(row["NGAYTAO"].ToString()))
            {
                NGAYTAO = DateTime.Parse(row["NGAYTAO"].ToString());
            }
            if (!string.IsNullOrEmpty(row["NGAYCAPNHAT"].ToString()))
            {
                NGAYCAPNHAT = DateTime.Parse(row["NGAYCAPNHAT"].ToString());
            }
            if (!string.IsNullOrEmpty(row["NGUOITAO"].ToString()))
            {
                NGUOITAO = int.Parse(row["NGUOITAO"].ToString());
            }
            if (!string.IsNullOrEmpty(row["NGUOICAPNHAT"].ToString()))
            {
                NGUOICAPNHAT = int.Parse(row["NGUOICAPNHAT"].ToString());
            }
        }
        public ServiceDTO() { }
    }
}
