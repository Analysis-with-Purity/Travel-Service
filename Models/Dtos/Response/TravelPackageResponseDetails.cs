namespace Travel_Service.Models.Dtos.Response;

public class TravelPackageResponseDetails
{
    public string Message { get; set; }
    public TravelPackageResponseDto TracvelPackage { get; set; }
    public bool IsSuccess { get; set; }
}