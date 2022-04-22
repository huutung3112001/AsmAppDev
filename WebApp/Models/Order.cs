namespace WebApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public double TotalPirce { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
