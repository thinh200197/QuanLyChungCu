using ApartmentManager.DAO;
using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DAO
{
    public class NhanKhauDAO
    {
        private static NhanKhauDAO instance;
        public static NhanKhauDAO Instance
        {
            get { if (instance == null) instance = new NhanKhauDAO(); return instance; }
            private set => instance = value;
        }
        private NhanKhauDAO() { }

        public List<NhanKhauDTO> DanhSachNhanKhau()
        {
            string query = "SELECT* from VIEW_NhanKhau";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            var lstNhanKhau = new List<NhanKhauDTO>();

            if (data == null)
            {
                return lstNhanKhau;
            }

            foreach (DataRow item in data.Rows)
            {
                var nhanKhau = new NhanKhauDTO(item);
                lstNhanKhau.Add(nhanKhau);
            }
            return lstNhanKhau;
        }
    }
}
