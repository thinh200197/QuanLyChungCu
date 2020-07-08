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
            MaCanHo = int.Parse(row["MACANHO"].ToString());
            MaDichVu = int.Parse(row["MADICHVU"].ToString());
            TrangThai = row["TRANG_THAI"].ToString();
            TenDichVu = row["TENDICHVU"].ToString();
            TenCanHo = row["TENCANHO"].ToString();

            CREATE_DATE = null;
            UPDATE_DATE = null;
            CREATE_BY = null;
            UPDATE_BY = null;

            if (!string.IsNullOrEmpty(row["CREATE_DATE"].ToString()))
            {
                CREATE_DATE = DateTime.Parse(row["CREATE_DATE"].ToString());
            }
            if (!string.IsNullOrEmpty(row["UPDATE_DATE"].ToString()))
            {
                UPDATE_DATE = DateTime.Parse(row["UPDATE_DATE"].ToString());
            }
            if (!string.IsNullOrEmpty(row["CREATE_BY"].ToString()))
            {
                CREATE_BY = int.Parse(row["CREATE_BY"].ToString());
            }
            if (!string.IsNullOrEmpty(row["UPDATE_BY"].ToString()))
            {
                UPDATE_BY = int.Parse(row["UPDATE_BY"].ToString());
            }
        }

        public DKDV_DinhKyDTO() { }
        [DisplayName("Mã Dịch Vụ")]

        public int ID { get; set; }
        public int MaDichVu { get; set; }
        public int MaCanHo { get; set; }
        [DisplayName("Trạng Thái")]
        public string TrangThai { get; set; }

        [DisplayName("Dịch Vụ")]
        public string TenDichVu { get; set; }
        [DisplayName("Căn Hộ")]
        public string TenCanHo { get; set; }

        [DisplayName("Ngày Tạo")]
        public DateTime? CREATE_DATE { get; set; }
        [DisplayName("Người Tạo")]
        public int? CREATE_BY { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? UPDATE_DATE { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? UPDATE_BY { get; set; }
    }
}
