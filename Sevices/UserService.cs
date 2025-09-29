using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class UserService: IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator; // Assume a JWT helper class

    public UserService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return _userRepository.GetAllUsers().ToList();
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return _userRepository.GetUserById(userId);
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        return _userRepository.GetUserByEmail(email);
    }

    public Task AddUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task AddUserAsync(User user, string password)
    {
        // Hash the password before saving
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        _userRepository.AddUser(user);
    }

    

   
    // Validate credentials
    public async Task<bool> ValidateUserCredentialsAsync(string email, string password)
    {
        var user =  _userRepository.GetUserByEmail(email);
        if (user == null) return false;

        return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
    }

    public Task<string> AuthenticateUserAsync(LoginRequest request, IJwtTokenGenerator tokengenerator)
    {
        throw new NotImplementedException();
    }

    // Authenticate user and generate JWT
    public async Task<string> AuthenticateUserAsync(string email, string password)
    {
        var user =  _userRepository.GetUserByEmail(email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            return null;

        // Generate JWT token using a helper class
        return _jwtTokenGenerator.GenerateToken(user);
    }
}
