namespace Travel_Service.Models.Dtos.Response;

public class LoginResponseDto
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
    public string Email {get; set; }
    public string Country {get; set; }
}