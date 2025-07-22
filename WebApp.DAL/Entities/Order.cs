namespace WebApp.DAL.Entities
{
    public class Order
    {
        public Order()
        {
            User = new User();
        }
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

