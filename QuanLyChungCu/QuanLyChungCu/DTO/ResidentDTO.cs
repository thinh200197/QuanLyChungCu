using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DTO
{
    public class ResidentDTO
    {
        public string MaCuDan { get; set; }
        public string TenCuDan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public bool GioiTinh { get; set; }
   
        public ResidentDTO(DataRow row)
        {
            this.MaCuDan = row["MACUDAN"].ToString();
            this.TenCuDan = row["TENCUDAN"].ToString();
            this.NgaySinh = DateTime.Parse(row["NGAYSINH"].ToString());
            this.Sdt = row["SODIENTHOAI"].ToString();
            this.Cmnd = row["CHUNGMINHNHANDAN"].ToString();
            this.GioiTinh = bool.Parse(row["GIOITINH"].ToString());
        }
        public ResidentDTO() { }

        public ResidentDTO(string maCuDan, string tenCuDan, DateTime ngaySinh, string sdt, string cmnd, bool gioiTinh)
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
