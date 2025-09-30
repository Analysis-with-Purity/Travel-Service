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

    // public Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    // {
    //     return _hotelRepository.GetAllHotelsAsync();
    // }

    public async Task<IEnumerable<HotelDto>> GetAllHotelsAsync()
    {
        var hotels = await _hotelRepository.GetAllHotelsAsync();

        // Map entities to DTOs
        return hotels.Select(h => new HotelDto
        {
            Id = h.HotelId,
            Name = h.HotelName,
            Location = h.HotelLocation,
            Rooms = h.Rooms.Select(r => new HotelRoomDto
            {
                Id = r.RoomId,
                RoomType = r.RoomType,
                AvailableUnits = r.AvailableUnits,
                PricePerNight = r.PricePerNight
            }).ToList()
        });
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
public class HotelDto
{
    public int Id { get; set; }               // HotelId
    public string Name { get; set; }          // HotelName
    public string Location { get; set; }      // HotelLocation

    // List of rooms in this hotel
    public List<HotelRoomDto> Rooms { get; set; } = new();
}


    public class HotelRoomDto
    {
        public int Id { get; set; }               // RoomId
        public string RoomType { get; set; }
        public int AvailableUnits { get; set; }
        public decimal PricePerNight { get; set; }  // Matches Room.Price
    }


