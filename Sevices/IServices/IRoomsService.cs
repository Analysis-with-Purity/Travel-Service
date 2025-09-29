using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface IRoomsService
{
    Task<IEnumerable<Room>> GetAllRoomsAsync();
    Task<Room> GetRoomByIdAsync(int roomId);
        
}