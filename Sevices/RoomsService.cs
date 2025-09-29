using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class RoomsService:IRoomsService
{
    private readonly IRoomsRepository _roomRepository;

    public RoomsService(IRoomsRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public Task<IEnumerable<Room>> GetAllRoomsAsync()
    {
        return _roomRepository.GetAllRoomsAsync();
    }

    public Task<Room> GetRoomByIdAsync(int roomId)
    {
        return _roomRepository.GetRoomByIdAsync(roomId);
    }
}