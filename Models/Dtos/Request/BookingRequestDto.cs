using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class BookingRequestDto
{
    
    [Required(ErrorMessage = "CustomerId cannot be empty")]
    public Guid CustomerId { get; set; }

    [Required(ErrorMessage = "PackageId cannot be empty")]
    public Guid PackageId { get; set; }

    [Required(ErrorMessage = "CheckInDate cannot be empty")]
    public DateTime CheckInDate { get; set; }

    [Required(ErrorMessage = "CheckOutDate cannot be empty")]
    public DateTime CheckOutDate { get; set; }
}