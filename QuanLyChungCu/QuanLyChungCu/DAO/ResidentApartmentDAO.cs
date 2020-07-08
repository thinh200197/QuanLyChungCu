using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class ResidentApartmentDAO
    {
        private static ResidentApartmentDAO instance;
        public static ResidentApartmentDAO Instance
        {
            get { if (instance == null) instance = new ResidentApartmentDAO(); return instance; }
            private set => instance = value;
        }
        private ResidentApartmentDAO() { }

        public DataTable GetAllResidentApartment()
        {
            string query = "select * from [CUDAN-CANHO]";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Insert(string maCanHo,string maCuDan)
        {
            string querySearchCuDan = "SELECT * FROM CUDAN WHERE MACUDAN = '"+ maCuDan+"'";
            string querySearchCanHo = "SELECT * FROM CANHO WHERE MACANHO = '"+ maCanHo+"'";

            var cuDan = DataProvider.Instance.ExecuteQuery(querySearchCuDan, new object[] { maCuDan});
            var canHo = DataProvider.Instance.ExecuteQuery(querySearchCanHo, new object[] { maCanHo });

            if (cuDan == null || canHo == null)
            {
                return false;
            }

            string query = "PR_InserResidentApartment @MaCuDan , @MaCanHo";
            int data = DataProvider.Instance.ExecuteNonQuery(query,new object[]{ maCuDan, maCanHo });
            return data > 0;
        }
        public bool Update(int id ,string maCanHo, string maCuDan, DateTime ngayVaoO,DateTime ngayHetO)
        {
            string query = string.Format("UPDATE [CUDAN-CANHO] " +
                "SET MACANHO = '{0}', MACUDAN = '{1}', NGAYBATDAUO = '{2}', NGAYHETO ='{3}'" +
                "WHERE ID = {4}", maCanHo, maCuDan, ngayVaoO, ngayHetO, id);

            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;
        }
    }
}
