using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ServiceCategogyDTO
    {
        public ServiceCategogyDTO(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            MaLoaiDichVu = row["MALOAIDICHVU"].ToString();
            Name = row["TENLOAIDICHVU"].ToString();

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
        public ServiceCategogyDTO() { }
        public int ID { get; set; }
        [DisplayName("Mã Loại Dịch Vụ")]
        public string MaLoaiDichVu { get; set; }
        [DisplayName("Mã Tòa Nhà")]
        public string Name { get; set; }
        [DisplayName("Ngày Tạo")]
        public DateTime? NGAYTAO { get; set; }
        [DisplayName("Người Tạo")]
        public int? NGUOITAO { get; set; }

        [DisplayName("Ngày Cập Nhật")]
        public DateTime? NGAYCAPNHAT { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? NGUOICAPNHAT { get; set; }
    }
}
