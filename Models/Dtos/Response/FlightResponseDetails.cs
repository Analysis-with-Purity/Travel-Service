namespace Travel_Service.Models.Dtos.Response;

public class FlightResponseDetails
{
    public string Message { get; set; }
    public FlightResponseDto FlightResponse { get; set; }
    public bool IsSuccess { get; set; }
}