using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class FloorDTO
    {
        public FloorDTO(string maTangLau, string maBlock, string tenTangLau)
        {
            MaTangLau = maTangLau;
            MaBlock = maBlock;
            TenTangLau = tenTangLau;
        }
        public FloorDTO(DataRow row)
        {
            MaTangLau = row["MATANGLAU"].ToString();
            MaBlock = row["MABLOCK"].ToString();
            TenTangLau = row["TENTANGLAU"].ToString();
            TenToaNha = row["TENBLOCK"].ToString();
        }

        public FloorDTO() { }
        [DisplayName("Mã Tầng")]
        public string MaTangLau { get; set; }
        [DisplayName("Mã Tòa Nhà")]
        public string MaBlock { get; set; }
        [DisplayName("Tên Tầng")]
        public string TenTangLau { get; set; }
        [DisplayName("Tên Tòa Nhà")]
        public string TenToaNha { get; set; }

    }
}
