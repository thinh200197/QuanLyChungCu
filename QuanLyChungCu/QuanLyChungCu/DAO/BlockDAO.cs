using System.Data;

namespace ApartmentManager.DAO
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

        public DataTable GetAllBlock()
        {
            string query = "select * from TOANHA";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);            
            return data;
        }
    }
}
