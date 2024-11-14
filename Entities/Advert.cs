namespace AnnonsAB.Entities
{
    public class Advert
    {
        public int AdvertID { get; set; }
        public User UserID { get; set; }
        public Category CategoryID { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public Advert(int advertID, User userID, Category categoryID, string titel, string description, decimal price, DateTime date)
        {
            AdvertID = advertID;
            UserID = userID;
            CategoryID = categoryID;
            Titel = titel;
            Description = description;
            Price = price;
            Date = date;
        }
    }
}
