using BookingService.Models;

namespace BookingService.Repositories
{
    public class InMemoryRoomRepository : IRoomRepository
    {
        private readonly List<Room> _rooms;

        public InMemoryRoomRepository()
        {
            _rooms = new List<Room>
            {
                new Room { Id = 1, Number = "101", Type = "Single", PricePerNight = 45.00m, IsAvailable = true, Description = "Cozy single room" },
                new Room { Id = 2, Number = "102", Type = "Double", PricePerNight = 70.00m, IsAvailable = true, Description = "Comfort double with city view" },
                new Room { Id = 3, Number = "201", Type = "Suite",  PricePerNight = 150.00m, IsAvailable = false, Description = "Spacious suite" },
                new Room { Id = 4, Number = "202", Type = "Double", PricePerNight = 80.00m, IsAvailable = true, Description = "Double with balcony" }
            };
        }

        public IEnumerable<Room> GetAvailableRooms()
            => _rooms.Where(r => r.IsAvailable).ToList();
    }
}
