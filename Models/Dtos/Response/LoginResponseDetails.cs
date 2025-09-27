namespace Travel_Service.Models.Dtos.Response;

public class LoginResponseDetails
{
    public string Message { get; set; }
    public LoginResponseDto LoginResponse { get; set; }
    public bool IsSuccess { get; set; }
    public string Token { get; set; }

}