namespace BookingService.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Number { get; set; } = "";
        public string Type { get; set; } = ""; // e.g., Single, Double
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? Description { get; set; }
    }
}
