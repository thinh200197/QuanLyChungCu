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
        public string maCuDan;
        public string tenCuDan;
        public DateTime ngaySinh;
        public string sdt;
        public string cmnd;

        public string MaCuDan { get => maCuDan; set => maCuDan = value; }
        public string TenCuDan { get => tenCuDan; set => tenCuDan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public ResidentDTO(string maCuDan,string tenCuDan, DateTime ngaySinh, string sdt, string cmnd)
        {
            this.MaCuDan = maCuDan;
            this.TenCuDan = tenCuDan;
            this.NgaySinh = ngaySinh;
            this.Sdt = sdt;
            this.Cmnd = cmnd;
        }
        public ResidentDTO (DataRow data)
        {
            this.MaCuDan = data["MACUDAN"].ToString();
            this.TenCuDan = data["TENCUDAN"].ToString();
            this.NgaySinh = DateTime.Parse(data["NGAYSINH"].ToString());
            this.Sdt = data["SODIENTHOAI"].ToString();
            this.Cmnd = data["CHUNGMINHNHANDAN"].ToString();
        }
        public ResidentDTO() { }
    }
}
