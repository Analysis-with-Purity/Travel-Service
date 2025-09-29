namespace Travel_Service.Models.Dtos.Response;

public class HotelResponseDto
{
    public Guid HotelId { get; set; }
    public string HotelName { get; set; }
    public string Location { get; set; }
    public decimal PricePerNight { get; set; }
    public int AvailableRooms { get; set; }
}