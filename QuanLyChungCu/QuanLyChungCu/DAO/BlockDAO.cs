using DevExpress.Xpo.DB.Helpers;
using QuanLyChungCu.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyChungCu.DAO
{
    public class BlockDAO
    {

        private static BlockDAO instance;
        public static BlockDAO Instance
        {
            get { if (instance == null) instance = new BlockDAO(); return instance; }
            private set => instance = value;
        }
        private BlockDAO() { }
        public List<BlockDTO> GetAll()
        {
            string query = "select * from TOANHA";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);

            var lstBlock = new List<BlockDTO>();
            foreach (DataRow row in data.Rows)
            {
                lstBlock.Add(new BlockDTO(row));
            }

            return lstBlock;
        }
        public Messeges Add(BlockDTO b)
        {
            string query = string.Format(
                "INSERT TOANHA(MABLOCK, TENBLOCK, NGAYTAO, NGUOITAO, NGAYCAPNHAT, NGUOICAPNHAT) " +
                "VALUES('{0}', N'{1}', GETDATE(), NULL, NULL, NULL)"
                , b.MaBlock, b.TenBlock);

            var result = DataProvider.Instance.ExecuteNonQuery(query);

            if (result > 0)
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
        public Messeges Update(BlockDTO b)
        {
            string query = string.Format(
                "UPDATE TOANHA " +
                "SET TENBLOCK = N'{1}' , NGAYCAPNHAT = GETDATE() " +
                "WHERE MABLOCK = '{0}'"
                , b.MaBlock, b.TenBlock);

            var result = DataProvider.Instance.ExecuteNonQuery(query);

            if (result > 0)
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
        public BlockDTO GetBlockById(string maBlock)
        {
            string query = $"SELECT * FROM TOANHA WHERE MABLOCK = '{maBlock}'";
            var data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new BlockDTO(data.Rows[0]);
            }
            return new BlockDTO();
        }
    }
}
