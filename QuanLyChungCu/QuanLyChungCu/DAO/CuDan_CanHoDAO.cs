using QuanLyChungCu.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyChungCu.DAO
{
    public class CuDan_CanHoDAO
    {
        private static CuDan_CanHoDAO instance;
        public static CuDan_CanHoDAO Instance
        {
            get { if (instance == null) instance = new CuDan_CanHoDAO(); return instance; }
            private set => instance = value;
        }
        private CuDan_CanHoDAO() { }

        public List<CuDan_CanHoDTO> GetAll_CuDan_CanHo()
        {
            string query = "select * from CUDAN_CANHO AND NGAYHETO IS NULL";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var resulf = new List<CuDan_CanHoDTO>();
            foreach (DataRow row in data.Rows)
            {
                resulf.Add(new CuDan_CanHoDTO(row));
            }

            return resulf;
        }
        public CuDan_CanHoDTO LayTTNK(int maCuDan, string maCanHo)
        {
            string query = string.Format("SELECT * FROM CUDAN_CANHO WHERE MACUDAN = '{0}' AND MACANHO = '{1}'", maCuDan, maCanHo);
            var data = DataProvider.Instance.ExecuteQuery(query);
            var resulf = new CuDan_CanHoDTO(data.Rows[0]);
            return resulf;
        }

        public CuDan_CanHoDTO LayTTNK_DangO(int maCuDan)
        {
            string query = string.Format("SELECT * FROM [CUDAN-CANHO]  WHERE MACUDAN = {0} AND NGAYHETO IS NULL", maCuDan);
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return new CuDan_CanHoDTO();
            }
            var resulf = new CuDan_CanHoDTO(data.Rows[0]);
            return resulf;
        }
        public bool CapNhatNhanKhau(int maNhanKhau, DateTime ngayVaoO, DateTime ngayHetO)
        {
            string query = string.Format("exec [PR_UPDATE_CUDAN_CANHO] {0},{1},{2}", maNhanKhau, ngayVaoO, ngayHetO);
            var data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

        public bool ThemNhanKhau(int maCuDan,string maCanHo)
        {
            string query = string.Format("exec [PR_INSERT_CUDAN_CANHO] {0},{1}", maCuDan, maCanHo);
            var data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;
        }

        public bool XoaNhanKhau(int ID)
        {
            string query = string.Format("UPDATE [CUDAN-CANHO] SET NGAYHETO = '{0}' WHERE ID = {1}", DateTime.Now.ToString(), ID);
            var data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;
        }
    }
}
