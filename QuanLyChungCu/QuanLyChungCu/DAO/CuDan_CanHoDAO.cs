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

            var result = new List<CuDan_CanHoDTO>();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new CuDan_CanHoDTO(row));
            }

            return result;
        }
        public CuDan_CanHoDTO LayTTNK(int maCuDan, string maCanHo)
        {
            string query = string.Format("SELECT * FROM CUDAN_CANHO WHERE MACUDAN = '{0}' AND MACANHO = '{1}'", maCuDan, maCanHo);
            var data = DataProvider.Instance.ExecuteQuery(query);
            var result = new CuDan_CanHoDTO(data.Rows[0]);
            return result;
        }

        public CuDan_CanHoDTO LayTTNK_DangO(int maCuDan)
        {
            string query = string.Format("SELECT * FROM [CUDAN-CANHO]  WHERE MACUDAN = {0} AND NGAYHETO IS NULL", maCuDan);
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return new CuDan_CanHoDTO();
            }
            var result = new CuDan_CanHoDTO(data.Rows[0]);
            return result;
        }
        public void CapNhatNgayHetO(int id)
        {
            string query = string.Format(
                "UPDATE [dbo].[CUDAN-CANHO]" +
                "SET NGAYHETO = '{0}' " +
                "WHERE ID = {1}",DateTime.Now,id);
                var data = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public Messeges Them(int maCuDan,string maCanHo)
        {
            string query = string.Format("exec [PR_INSERT_CUDAN_CANHO] {0},{1}", maCuDan, maCanHo);
            var data = DataProvider.Instance.ExecuteNonQuery(query);

            if (data > 0)
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Success,
                    MessegeContent = "Thêm nhân khẩu thành công."
                };
            }

            return new Messeges()
            {
                MessegeType = MessegeType.Error,
                MessegeContent = "Thêm nhân khẩu thất bại."
            };
        }

        public bool XoaNhanKhau(int ID)
        {
            string query = string.Format("UPDATE [CUDAN-CANHO] SET NGAYHETO = '{0}' WHERE ID = {1}", DateTime.Now.ToString(), ID);
            var data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;
        }

        public CuDan_CanHoDTO Lay_TT_ID(int Id)
        {
            string query = "select * from [CUDAN-CANHO] where id = " + Id;
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return new CuDan_CanHoDTO();
            }
            var result = new CuDan_CanHoDTO(data.Rows[0]);
            return result;
        }

        public Messeges CapNhat(CuDan_CanHoDTO cdch)
        {
            string query = string.Format(
                "UPDATE [dbo].[CUDAN-CANHO]" +
                "SET MACANHO = {0}," +
                    "MACUDAN = {1}, " +
                    "NGAYBATDAUO = {2} , " +
                    "NGAYHETO = {3} " +
                "WHERE ID = {4}", cdch.MaCanHo,cdch.MaCuDan,cdch.NgayVaoO,cdch.NgayHetO,cdch.ID);

            var data = DataProvider.Instance.ExecuteNonQuery(query);

            if (data > 0)
            {
                return new Messeges()
                {
                    MessegeType = MessegeType.Success,
                    MessegeContent = "Cập nhật nhân khẩu thành công."
                };
            }

            return new Messeges()
            {
                MessegeType = MessegeType.Error,
                MessegeContent = "Cập nhật nhân khẩu thất bại."
            };
        }
    }
}
