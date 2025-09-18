using BookingService.Models;
using BookingService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepository _repo;
        private readonly ILogger<RoomsController> _logger;

        public RoomsController(IRoomRepository repo, ILogger<RoomsController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetAvailableRooms()
        {
            _logger.LogInformation("GetAvailableRooms called");
            var rooms = _repo.GetAvailableRooms();
            return Ok(rooms);
        }
    }
}
