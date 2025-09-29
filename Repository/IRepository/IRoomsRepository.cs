using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IRoomsRepository
{
    Task<IEnumerable<Room>> GetAllRoomsAsync();
    Task<Room> GetRoomByIdAsync(int roomId);
    Task AddRoomAsync(Room room);
    Task UpdateRoomAsync(Room room);
    Task DeleteRoomAsync(int roomId);
}