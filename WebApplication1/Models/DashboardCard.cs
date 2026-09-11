namespace DashboardAdmin.Models
{
    public class DashboardCard
    {
        public int Id { get; set; }
        public required string Title { get; set; }  // ✅
        public decimal Value { get; set; }
        public Trend Trend { get; set; }
        public required string Unit { get; set; }   // ✅
        public required string Description { get; set; }  // ✅
    }
}