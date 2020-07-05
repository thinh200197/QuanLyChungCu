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
        public DateTime? CREATE_DATE { get; set; }
        [DisplayName("Người Tạo")]
        public int? CREATE_BY { get; set; }
        [DisplayName("Ngày Cập Nhật")]
        public DateTime? UPDATE_DATE { get; set; }
        [DisplayName("Người Cập Nhật")]
        public int? UPDATE_BY { get; set; }
        public BlockDTO(DataRow row)
        {
            MaBlock = row["MABLOCK"].ToString();
                TenBlock = row["TENBLOCK"].ToString();

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
        public BlockDTO() { }
       
    }
}
