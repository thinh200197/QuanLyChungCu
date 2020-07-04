using Microsoft.VisualBasic;
using QuanLyChungCu.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyChungCu.DAO
{
    public class ApartmentDAO
    {
        private static ApartmentDAO instance;
        public static ApartmentDAO Instance
        {
            get { if (instance == null) instance = new ApartmentDAO(); return instance; }
            private set => instance = value;
        }
        private ApartmentDAO() { }

        public List<ApartmentDTO> GetAll()
        {
            string query = "SELECT * FROM VIEW_APARTMENT";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var lstApartment = new List<ApartmentDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstApartment.Add(new ApartmentDTO(row));
            }

            return lstApartment;
        }

        public List<ApartmentDTO> GetAllApartmentByLoaiCanHo(string maLoaiCanHo)
        {
            string query = "select * from CANHO where Maloai_CH = '" + maLoaiCanHo + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var lstApartment = new List<ApartmentDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstApartment.Add(new ApartmentDTO(row));
            }

            return lstApartment;
        }    

        public void CapNhatSoNguoiO(string maCanHo , int soNguoi)
        {
            string query = string.Format("UPDATE CANHO SET SONGUOIO = SONGUOIO + {0} WHERE MACANHO = '{1}'", soNguoi,maCanHo);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public ApartmentDTO GetApartmentByMaCanHo(string maCanHo)
        {
            string query = "select * from CANHO where MACANHO = '" + maCanHo + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            return new ApartmentDTO(data.Rows[0]);
        }

        public List<CuDanDto> GetCustomApartment()
        {
            string query = "EXEC GetCustomApartment";
            var data = DataProvider.Instance.ExecuteQuery(query);

            var resulf = new List<CuDanDto>();
            foreach (DataRow row in data.Rows)
            {
                resulf.Add(new CuDanDto(row));
            }

            return resulf;
        }

        public Messeges Add(ApartmentDTO request)
        {
            try
            {
                string query = string.Format("INSERT CANHO (MATANGLAU,MALOAI_CH,TENCANHO,SONGUOIO,CHUHO)" +
              "VALUE ('{0}','{1}','{2}',{3},{4})", request.MaTangLau, request.MaLoaiCanHo, request.TenCanHo,request.SoNguoiO,request.ChuHo);
                int resulf = DataProvider.Instance.ExecuteNonQuery(query);

                if (resulf > 0)
                {
                    return new Messeges()
                    {
                        MessegeType = MessegeType.Success,
                        MessegeContent = "Thành công"
                    };
                }
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thất bại! "
                };
            }
            catch (System.Exception ex)
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thất bại! : " + ex.Message
                };
            }
        }

        public Messeges Update(ApartmentDTO request)
        {
            try
            {
                string query = string.Format(
                    "UPDATE CANHO " +
                    "SET MATANGLAU = '{0}' , MALOAI_CH = '{1}' ,TENCANHO = '{2}',SONGUOIO = {3} ,CHUHO = {4} " +
                    "WHERE MACANHO = '{5}'", 
              request.MaTangLau, request.MaLoaiCanHo, request.TenCanHo, request.SoNguoiO, request.ChuHo,request.MaCanHo);
                int resulf = DataProvider.Instance.ExecuteNonQuery(query);

                if (resulf > 0)
                {
                    return new Messeges()
                    {
                        MessegeType = MessegeType.Success,
                        MessegeContent = "Thành công"
                    };
                }
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thất bại! "
                };
            }
            catch (System.Exception ex)
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Error,
                    MessegeContent = "Thất bại! : " + ex.Message
                };
            }
        }
    }
}
