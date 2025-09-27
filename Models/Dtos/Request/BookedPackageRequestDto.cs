using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class BookedPackageRequestDto
{
    
    [Required(ErrorMessage = "PackageId cannot be empty")]
    public Guid PackageId { get; set; }


    public Guid? FlightId { get; set; }
    public Guid? RoomId { get; set; }
}