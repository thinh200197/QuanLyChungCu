using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class BlockDTO
    {
        public string MaBlock { get; set; }
        public string TenBlock { get; set; }
        public BlockDTO(string maBlock, string tenBlock)
        {
            MaBlock = maBlock;
            TenBlock = tenBlock;
        }
        public BlockDTO(DataRow row)
        {
            MaBlock = row["MABLOCK"].ToString();
            TenBlock = row["TENBLOCK"].ToString();
        }
        public BlockDTO() { }

       
    }
}
