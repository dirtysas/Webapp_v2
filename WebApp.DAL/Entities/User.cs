namespace WebApp.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}