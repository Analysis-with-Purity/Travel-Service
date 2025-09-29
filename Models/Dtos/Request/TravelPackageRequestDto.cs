using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class TravelPackageRequestDto
{
    [Required(ErrorMessage = "Name cannot be empty")]
    public string Name { get; set; }

    public string Description { get; set; }

    [Required(ErrorMessage = "Price cannot be empty")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "HotelId cannot be empty")]
    public Guid HotelId { get; set; }

    [Required(ErrorMessage = "FlightId cannot be empty")]
    public Guid FlightId { get; set; }
}