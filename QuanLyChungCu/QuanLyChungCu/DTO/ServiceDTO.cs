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
        [DisplayName("Mã Dịch Vụ")]
        public int MaDichVu { get; set; }
        [DisplayName("Tên Dịch Vụ")]
        public string TenDichVu { get; set; }
        [DisplayName("Mã Loại Dịch Vụ")]
        public int MaLoaiDichVu { get; set; }
        [DisplayName("Tên Loại Dịch Vụ")]
        public string TenLoaiDichVu { get; set; }
        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime? CREATE_DATE { get; set; }
        [DisplayName("Người Tạo")]
        public int? CREATE_BY { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? UPDATE_DATE { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? UPDATE_BY { get; set; }
        public ServiceDTO(DataRow row)
        {
            MaDichVu = int.Parse(row["ID"].ToString());
            TenDichVu = row["TENDICHVU"].ToString();
            TenLoaiDichVu = row["TENDICHVU"].ToString();
            MaLoaiDichVu = int.Parse(row["MALOAIDICHVU"].ToString());
            DonViTinh = row["DONVITINH"].ToString();

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
        public ServiceDTO() { }
    }
}
