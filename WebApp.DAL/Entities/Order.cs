namespace WebApp.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } 
    }
}

