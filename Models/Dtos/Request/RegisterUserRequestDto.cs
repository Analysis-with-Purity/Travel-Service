using System.ComponentModel.DataAnnotations;

namespace Travel_Service.Models.Dtos.Request;

public class RegisterUserRequestDto
{
    [Required(ErrorMessage = "Customerid cannot be empty")]
    public String Customerid { get; set; }  //= IdGenerator.GenerateUserId();
    
    [Required(ErrorMessage = "Name cannot be empty")]
    public String Name { get; set; }
    
    [Required(ErrorMessage = "Email cannot be empty")]
    public String Email { get; set; }
    
    [Required(ErrorMessage = "Password cannot be empty")]
    public String Password { get; set; }
    
    [Required(ErrorMessage = "Country cannot be empty")]
    public String Country { get; set; }
}