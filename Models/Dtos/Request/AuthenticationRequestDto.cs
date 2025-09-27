namespace Travel_Service.Models.Dtos.Request;

public class AuthenticationRequestDto
{
    public record AuthResultDto(string Token, string Email);
}