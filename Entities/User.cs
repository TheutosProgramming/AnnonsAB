namespace AnnonsAB.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Addresses { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User(int userID, string username, string passwords, string firstName, string lastName, string addresses, string city, string email, string phone)
        {
            UserID = userID;
            Username = username;
            Passwords = passwords;
            FirstName = firstName;
            LastName = lastName;
            Addresses = addresses;
            City = city;
            Email = email;
            Phone = phone;
        }
    }
}
