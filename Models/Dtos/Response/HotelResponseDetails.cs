namespace Travel_Service.Models.Dtos.Response;

public class HotelResponseDetails
{
    public string Message { get; set; }
    public HotelResponseDto Hotel { get; set; }
    public bool IsSuccess { get; set; }
}

