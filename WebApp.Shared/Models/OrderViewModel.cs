namespace WebApp.Shared.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int Price { get; set; } 
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        
        public string UserFullName { get; set; } = string.Empty;
    }
}