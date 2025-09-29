using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface IHotelsService
{
    Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    Task<Hotel> GetHotelByIdAsync(int hotelId);
    Task AddHotelAsync(Hotel hotel);
    Task UpdateHotelAsync(Hotel hotel);
    Task DeleteHotelAsync(int hotelId);
}