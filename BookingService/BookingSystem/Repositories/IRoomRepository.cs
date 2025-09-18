using BookingService.Models;

namespace BookingService.Repositories
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAvailableRooms();
    }
}