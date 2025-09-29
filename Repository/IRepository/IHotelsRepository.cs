using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IHotelsRepository
{
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    Task<Hotel> GetHotelByIdAsync(int hotelId);
    Task AddHotelAsync(Hotel hotel);
    Task UpdateHotelAsync(Hotel hotel);
    Task DeleteHotelAsync(int hotelId);
}