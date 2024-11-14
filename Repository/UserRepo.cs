using AnnonsAB.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AnnonsAB.Repository
{
    public class UserRepo
    {
        public List<User> Login(string username, string password)
        {
            string sql = "select * from Users where Username = @Username AND Passwords = @Passwords";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username", username));
            parameters.Add(new SqlParameter("@Passwords", password));

            DataTable data = DataContext.ExecuteQueryReturnTable(sql, parameters);

            List<User> user = new();

            foreach (DataRow row in data.Rows)
            {
                user.Add(new User((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), 
                                       row.ItemArray[4].ToString(), row.ItemArray[5].ToString(), row.ItemArray[6].ToString(), row.ItemArray[7].ToString(),
                                       row.ItemArray[8].ToString()));
            }

            return user;
        }

        public void CreateNewUser(string username, string passwords, string firstname, string lastname, string addresses, string city, string email, string phone)
        {
            string sql = "insert into Users(Username, Passwords, FirstName, LastName, Addresses, City, Email, Phone) " +
                         "values (@Username, @Passwords, @FirstName, @LastName, @Addresses, @City, @Email, @Phone)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username", username));
            parameters.Add(new SqlParameter("@Passwords", passwords));
            parameters.Add(new SqlParameter("@FirstName", firstname));
            parameters.Add(new SqlParameter("@LastName", lastname));
            parameters.Add(new SqlParameter("@Addresses", addresses));
            parameters.Add(new SqlParameter("@City", city));
            parameters.Add(new SqlParameter("@Email", email));
            parameters.Add(new SqlParameter("@Phone", phone));

            DataContext.ExecuteNonQuery(sql, parameters);
        }

    }
}
