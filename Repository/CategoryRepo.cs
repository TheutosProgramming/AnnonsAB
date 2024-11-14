using AnnonsAB.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AnnonsAB.Repository
{
    public class CategoryRepo
    {
        public List<Category> GetCategoryList()
        {
            string sql = "Select CategoryID, CategoryName " +
                         "From Category";  

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());

            List<Category> category = new List<Category>();

            foreach (DataRow row in data.Rows)
            {
                category.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return category;
        }
    }
}
