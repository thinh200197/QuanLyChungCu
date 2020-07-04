using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public class CuDanDto
    {
       
        public string TENBLOCK { get; set; }
        public string TENTANGLAU { get; set; }
        public string TENCANHO { get; set; }
        public string TENLOAI_CH { get; set; }
        public string DIENTICH { get; set; }
        public string SOPHONGNGU { get; set; }
        public string SONGUOITOIDA { get; set; }
        public string TENCUDAN { get; set; }

        public CuDanDto() { }

        public CuDanDto(DataRow row)
        {
            TENBLOCK = row["TENBLOCK"].ToString();
            TENTANGLAU = row["TENTANGLAU"].ToString();
            TENCANHO = row["TENCANHO"].ToString();
            TENLOAI_CH = row["TENLOAI_CH"].ToString();
            DIENTICH = row["DIENTICH"].ToString();
            SOPHONGNGU = row["SOPHONGNGU"].ToString();
            SONGUOITOIDA = row["SONGUOITOIDA"].ToString();
            TENCUDAN = row["TENCUDAN"].ToString();
        }

        public CuDanDto(string tENBLOCK, string tENTANGLAU, string tENCANHO, string tENLOAI_CH, string dIENTICH, string sOPHONGNGU, string sONGUOITOIDA, string tENCUDAN)
        {
            TENBLOCK = tENBLOCK;
            TENTANGLAU = tENTANGLAU;
            TENCANHO = tENCANHO;
            TENLOAI_CH = tENLOAI_CH;
            DIENTICH = dIENTICH;
            SOPHONGNGU = sOPHONGNGU;
            SONGUOITOIDA = sONGUOITOIDA;
            TENCUDAN = tENCUDAN;
        }
    }
}
