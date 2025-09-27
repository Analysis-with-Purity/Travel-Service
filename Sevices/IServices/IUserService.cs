using Travel_Service.Helper;
using Travel_Service.Models.Dtos;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface IUserService
{
    RegisterUserResponseDetails RegisterUser(RegisterUserRequestDto data);
    LoginResponseDetails Login(LoginRequestDto data, JwtTokenGenerator tokenGenerator);


}