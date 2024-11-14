using AnnonsAB.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using User = AnnonsAB.Entities.User;


namespace AnnonsAB.Repository
{
    public class AdvertRepo
    {
        public List<Advert> GetAdvertList()
        {
            string sql = "select Advert.AdvertID, Advert.UserID, Username, Passwords, FirstName, LastName, Addresses, City, " +
                         "Email, Phone, Advert.CategoryID, CategoryName, Titel, Descriptions, Price, Dates from Advert " +
                         "inner join Users on Advert.UserID = Users.UserID " +
                         "inner join Category on Advert.CategoryID = Category.CategoryID";

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, new List<SqlParameter>());

            List<Advert> adverts = new List<Advert>();

            foreach (DataRow row in data.Rows)
            {
                User user = new User((int)row.ItemArray[1], row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(),
                                          row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString(), row.ItemArray[9].ToString());
                Category category = new Category((int)row.ItemArray[10], row.ItemArray[11].ToString());
                adverts.Add(new Advert((int)row.ItemArray[0], user, category, row.ItemArray[12].ToString(), 
                                            row.ItemArray[13].ToString(), (decimal)row.ItemArray[14], (DateTime)row.ItemArray[15]));
            }
            return adverts;
        }

        public List<Advert> GetUserAdvertList(int userID)
        {
            string sql = "select Advert.AdvertID, Advert.UserID, Username, Passwords, FirstName, LastName, Addresses, City, " +
                         "Email, Phone, Advert.CategoryID, CategoryName, Titel, Descriptions, Price, Dates from Advert " +
                         "inner join Users on Advert.UserID = Users.UserID " +
                         "inner join Category on Advert.CategoryID = Category.CategoryID " +
                         "where Advert.UserID = @UserID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@UserID", + userID));

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);

            List<Advert> adverts = new List<Advert>();

            foreach (DataRow row in data.Rows)
            {
                User user = new User((int)row.ItemArray[1], row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(),
                                          row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString(), row.ItemArray[9].ToString());
                Category category = new Category((int)row.ItemArray[10], row.ItemArray[11].ToString());
                adverts.Add(new Advert((int)row.ItemArray[0], user, category, row.ItemArray[12].ToString(),
                                            row.ItemArray[13].ToString(), (decimal)row.ItemArray[14], (DateTime)row.ItemArray[15]));
            }
            return adverts;
        }

        public List<Advert> SearchAdvert(string searchCondition, string category, string sort)
        {
            string sql = "select Advert.AdvertID, Advert.UserID, Username, Passwords, FirstName, LastName, Addresses, City, Email, " +
                         "Advert.CategoryID, CategoryName, Titel, Descriptions, Price, Dates from Advert " +
                         "inner join Users on Advert.UserID = Users.UserID " +
                         "inner join Category on Advert.CategoryID = Category.CategoryID " +
                         "where CategoryName = @CategoryName AND Titel like @Titel ";

            switch (sort)
            {
                case "Lägsta pris":
                    sql += "order by Price asc";
                    break;
                case "Högsta pris":
                    sql += "order by Price desc";
                    break;
                case "A-Ö":
                    sql += "order by Titel asc";
                    break;
                case "Ö-A":
                    sql += "order by Titel desc";
                    break;
                case "Senaste":
                    sql += "order by Dates desc";
                    break;
                case "Äldsta":
                    sql += "order by Dates asc";
                    break;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Titel", "%" + searchCondition + "%"));
            parameters.Add(new SqlParameter("@CategoryName", category));

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);

            List<Advert> adverts = new List<Advert>();

            foreach (DataRow row in data.Rows)
            {
                User user = new User((int)row.ItemArray[1], row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(),
                                          row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString(), row.ItemArray[9].ToString());
                Category categories = new Category((int)row.ItemArray[9], row.ItemArray[10].ToString());
                adverts.Add(new Advert((int)row.ItemArray[0], user, categories, row.ItemArray[11].ToString(),
                                            row.ItemArray[12].ToString(), (decimal)row.ItemArray[13], (DateTime)row.ItemArray[14]));
            }
                return adverts;
        }

        public void CreateAdvert(int userID, int categoryID, string titel, string descriptions, decimal price, DateTime dates)
        {
            string sql = "insert into Advert(UserID, CategoryID, Titel, Descriptions, Price, Dates) " +
                         "values (@UserID, @CategoryID, @Titel, @Descriptions, @Price, @Dates)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@UserID", userID));
            parameters.Add(new SqlParameter("@CategoryID", categoryID));
            parameters.Add(new SqlParameter("@Titel", titel));
            parameters.Add(new SqlParameter("@Descriptions", descriptions));
            parameters.Add(new SqlParameter("@Price", price));
            parameters.Add(new SqlParameter("@Dates", dates));

            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateAdvert(int advertID, int categoryID, string titel, string descriptions, decimal price)
        {
            string sql = "Update Advert " +
                         "set CategoryID = @CategoryID, Titel = @Titel, " +
                         "Descriptions = @Descriptions, Price = @Price " +
                         "where AdvertID = @advertID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@advertID", advertID));
            parameters.Add(new SqlParameter("@CategoryID", categoryID));
            parameters.Add(new SqlParameter("@Titel", titel));
            parameters.Add(new SqlParameter("@Descriptions", descriptions));
            parameters.Add(new SqlParameter("@Price", price));

            DataContext.ExecuteNonQuery(sql, parameters);
        }

        public void DeleteAdvert(int advertID)
        {
            string sql = "DELETE FROM Advert " +
                         "where AdvertID = @advertID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@advertID", advertID));

            DataContext.ExecuteNonQuery(sql, parameters);
        }
    }
}
