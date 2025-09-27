using System.ComponentModel.DataAnnotations;
using Travel_Service.Models.Entity;

namespace Travel_Service.Models.Dtos.Request;

public class FlightRequestDto
{
    [Required(ErrorMessage = "Airline cannot be empty")]
    public string Airline { get; set; } = string.Empty;


    [Required(ErrorMessage = "Departure location cannot be empty")]
    public string DepartureLocation { get; set; } = string.Empty;


    [Required(ErrorMessage = "Arrival location cannot be empty")]
    public string ArrivalLocation { get; set; } = string.Empty;


    [Required(ErrorMessage = "Amount cannot be empty")]
    public string Amount { get; set; } = string.Empty;


    [Required(ErrorMessage = "Flight class is required")]
    public FlightClass Class { get; set; }
    
}