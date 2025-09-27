using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class LoginRequestDto
{
    [Required(ErrorMessage = "EmailAddress cannot be empty")]
    public String Email { get; set; }
    
    [Required(ErrorMessage = "Enter your password")]
    public String Password { get; set; }

}