using System;
using System.Collections.Generic;
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
        }

        public FloorDTO() { }

        public string MaTangLau { get; set; }
        public string MaBlock { get; set; }
        public string TenTangLau { get; set; }
    }
}
