using Microsoft.AspNetCore.Identity.Data;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(int userId);
    Task<User> GetUserByEmailAsync(string email);
    Task AddUserAsync(User user); // password required
    // Authentication
    Task<bool> ValidateUserCredentialsAsync(string email, string password);
    Task<string> AuthenticateUserAsync(LoginRequest request, IJwtTokenGenerator tokengenerator); 
}