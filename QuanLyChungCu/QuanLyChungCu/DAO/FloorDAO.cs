using DevExpress.Xpo.DB.Helpers;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class FloorDAO
    {
        private static FloorDAO instance;
        public static FloorDAO Instance
        {
            get { if (instance == null) instance = new FloorDAO(); return instance; }
            private set => instance = value;
        }
        private FloorDAO() { }

        public List<FloorDTO> GetAll()
        {
            string query = "select * from VIEW_FLOOR";
            DataTable data =  DataProvider.Instance.ExecuteQuery(query);

            var lstFloor = new List<FloorDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstFloor.Add(new FloorDTO(row));
            }

            return lstFloor;
        }
        public List<FloorDTO> GetAllFloorByMaBlock(string maBlock)
        {
            string query = "select * from VIEW_FLOOR where MABLOCK = '" + maBlock + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            var lstFloor = new List<FloorDTO>();

            foreach (DataRow row in data.Rows)
            {
                lstFloor.Add(new FloorDTO(row));
            }

            return lstFloor;
        }

        public FloorDTO GetFoolById(string maTang)
        {
            string query = $"SELECT * FROM TANGLAU WHERE MATANG = '{maTang}' ";
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new FloorDTO(data.Rows[0]);
            }
            return new FloorDTO();
        }
        public Messeges Add(FloorDTO f)
        {
            string query = $"EXEC PR_INSERT_FLOOR @MATANGLAU , @TENTANGLAU , @MABLOCK ";
            int data = DataProvider.Instance.ExecuteNonQuery(query,new object[]{ f.MaTangLau, f.TenTangLau, f.MaBlock });

            if (data > 0 )
            {
                return new Messeges()
                {
                    MessegeContent = "Thành công !",
                    MessegeType = MessegeType.Success
                };
            }

            return new Messeges()
            {
                MessegeContent = "Thất bại !",
                MessegeType = MessegeType.Error
            };
        }
        public Messeges Update(FloorDTO f)
        {
            string query = $"EXEC UPDATE_FLOOR @MATANGLAU , @TENTANGLAU , @MABLOCK ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { f.MaTangLau, f.TenTangLau, f.MaBlock });

            if (data > 0)
            {
                return new Messeges()
                {
                    MessegeContent = "Thành công !",
                    MessegeType = MessegeType.Success
                };
            }

            return new Messeges()
            {
                MessegeContent = "Thất bại !",
                MessegeType = MessegeType.Error
            };
        }
    }
}
