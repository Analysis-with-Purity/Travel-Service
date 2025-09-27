namespace Travel_Service.Models.Dtos.Response;

public class RegisterUserResponseDetails
{
    public string Message { get; set; }
    public RegisterUserResponseDto RegisterUserResponse { get; set; }
    public bool IsSuccess { get; set; }
}