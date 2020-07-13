using System;
using System.ComponentModel;
using System.Data;

namespace QuanLyChungCu.DTO
{
    public class DKDV_DinhKyDTO
    {
        public DKDV_DinhKyDTO(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            MaCanHo = row["MACANHO"].ToString();
            MaDichVu = row["MADICHVU"].ToString();
            TrangThai = Common.ServiceStatus.GetValueByName(row["TRANG_THAI"].ToString());
            TenDichVu = row["TENDICHVU"].ToString();
            TenCanHo = row["TENCANHO"].ToString();

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

        public DKDV_DinhKyDTO() { }
        [DisplayName("Mã Đăng Ký")]
        public int ID { get; set; }
        [DisplayName("Mã Dịch Vụ")]
        public string MaDichVu { get; set; }
        public string MaCanHo { get; set; }
        [DisplayName("Căn Hộ")]
        public string TenCanHo { get; set; }
        [DisplayName("Dịch Vụ")]
        public string TenDichVu { get; set; }
        [DisplayName("Ngày Đăng Ký")]
        public DateTime? NGAYTAO { get; set; }
        [DisplayName("Người Tạo")]
        public int? NGUOITAO { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? NGAYCAPNHAT { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? NGUOICAPNHAT { get; set; }
        [DisplayName("Trạng Thái")]
        public string TrangThai { get; set; }
    }
}
