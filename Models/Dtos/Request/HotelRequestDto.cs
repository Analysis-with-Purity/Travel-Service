using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class HotelRequestDto
{
    [Required(ErrorMessage = "HotelName cannot be empty")]
    public string HotelName { get; set; }

    [Required(ErrorMessage = "Location cannot be empty")]
    public string Location { get; set; }

    [Required(ErrorMessage = "PricePerNight cannot be empty")]
    public decimal PricePerNight { get; set; }

    [Required(ErrorMessage = "AvailableRooms cannot be empty")]
    public int AvailableRooms { get; set; }
}