using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class HotelsService:IHotelsService
{
    private readonly IHotelsRepository _hotelRepository;

    public HotelsService(IHotelsRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }

    public Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        return _hotelRepository.GetAllHotelsAsync();
    }

    public Task<Hotel> GetHotelByIdAsync(int hotelId)
    {
        return _hotelRepository.GetHotelByIdAsync(hotelId);
    }

    public Task AddHotelAsync(Hotel hotel)
    {
        return _hotelRepository.AddHotelAsync(hotel);
    }

    public Task UpdateHotelAsync(Hotel hotel)
    {
        return _hotelRepository.UpdateHotelAsync(hotel);
    }

    public Task DeleteHotelAsync(int hotelId)
    {
        return _hotelRepository.DeleteHotelAsync(hotelId);
    }
}

