using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class CuDan_CanHoDTO
    {


        public int ID { get; set; }
        public int MaCuDan { get; set; }
        public string MaCanHo { get; set; }
        public Nullable<DateTime> NgayVaoO { get; set; }
        public Nullable<DateTime> NgayHetO { get; set; }
        public CuDan_CanHoDTO(int iD, int maCuDan, string maCanHo, DateTime ngayVaoO, DateTime ngayHetO)
        {
            ID = iD;
            MaCuDan = maCuDan;
            MaCanHo = maCanHo;
            NgayVaoO = ngayVaoO;
            NgayHetO = ngayHetO;
        }
        public CuDan_CanHoDTO(DataRow row)
        {
            ID = int.Parse(row["ID"].ToString());
            MaCuDan = int.Parse(row["MACUDAN"].ToString());
            MaCanHo = row["MACANHO"].ToString();
            NgayVaoO = DateTime.Parse(row["NGAYBATDAUO"].ToString());
            NgayHetO = row["NGAYHETO"].ToString() != "" ? DateTime.Parse(row["NGAYHETO"].ToString()) : DateTime.Now;
        }
        public CuDan_CanHoDTO() { }
    }
}
