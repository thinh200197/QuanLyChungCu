using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ResidentDTO
    {
        public int MaCuDan { get; set; }
        public string TenCuDan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public int GioiTinh { get; set; }
   
        public ResidentDTO(DataRow row)
        {
            this.MaCuDan = int.Parse(row["MACUDAN"].ToString());
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.NgaySinh = DateTime.Parse(row["NGAYSINH"].ToString());
            this.Sdt = row["SODIENTHOAI"].ToString();
            this.Cmnd = row["CHUNGMINHNHANDAN"].ToString();
            this.GioiTinh = bool.Parse(row["GIOITINH"].ToString()) ? 1 : 0;
        }
        public ResidentDTO() { }

        public ResidentDTO(int maCuDan, string tenCuDan, DateTime ngaySinh, string sdt, string cmnd, int gioiTinh)
        {
            MaCuDan = maCuDan;
            TenCuDan = tenCuDan;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            Cmnd = cmnd;
            GioiTinh = gioiTinh;
        }
    }
}
