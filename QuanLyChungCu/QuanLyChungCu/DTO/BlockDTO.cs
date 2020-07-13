using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class BlockDTO
    {
        [DisplayName("Mã Tòa Nhà")]
        public string MaBlock { get; set; }
        [DisplayName("Tên Tòa Nhà")]
        public string TenBlock { get; set; }
        [DisplayName("Ngày Tạo")]
        public DateTime? NGAYTAO { get; set; }
        [DisplayName("Người Tạo")]
        public int? NGUOITAO { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? NGAYCAPNHAT { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? NGUOICAPNHAT { get; set; }
        public BlockDTO(DataRow row)
        {
            MaBlock = row["MABLOCK"].ToString();
                TenBlock = row["TENBLOCK"].ToString();

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
        public BlockDTO() { }
       
    }
}
