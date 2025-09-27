using Travel_Service.Models.Entity;

namespace Travel_Service.Models.Dtos.Response;

public class FlightResponseDto
{
    public Guid FlightId { get; set; }
    public string Airline { get; set; } = string.Empty;
    public string DepartureLocation { get; set; } = string.Empty;
    public string ArrivalLocation { get; set; } = string.Empty;
    public string Amount { get; set; } = string.Empty;
    public FlightClass Class { get; set; }
}