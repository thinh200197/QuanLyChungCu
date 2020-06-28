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

        public List<BlockDTO> GetAllBlock()
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
    }
}
