using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class ApartmentCategogyDTO
    {
        public ApartmentCategogyDTO(string maloai_CH, string tenloai_CH, int dienTich, int soPhongNgu, int soNguoiToiDa)
        {
            Maloai_CH = maloai_CH;
            Tenloai_CH = tenloai_CH;
            DienTich = dienTich;
            SoPhongNgu = soPhongNgu;
            SoNguoiToiDa = soNguoiToiDa;
        }
        public ApartmentCategogyDTO(DataRow row)
        {
            Maloai_CH = row["MALOAI_CH"].ToString();
            Tenloai_CH = row["TENLOAI_CH"].ToString();
            DienTich = int.Parse(row["DIENTICH"].ToString());
            SoPhongNgu = int.Parse(row["SOPHONGNGU"].ToString());
            SoNguoiToiDa = int.Parse(row["SONGUOITOIDA"].ToString());
        }
        public ApartmentCategogyDTO() { }

        public string Maloai_CH { get; set; }
        public string Tenloai_CH { get; set; }
        public int DienTich { get; set; }
        public int SoPhongNgu { get; set; }
        public int SoNguoiToiDa { get; set; }
    }
}
