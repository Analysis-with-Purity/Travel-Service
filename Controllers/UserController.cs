using Microsoft.AspNetCore.Mvc;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserService _user;
        
    public UserController(IUserService user)
    {
        _user = user;
    }
    
    [HttpPost("register")]
    public IActionResult Register([FromBody] User user, string password)
    {
        var result = _user.AddUserAsync(user, password);
        return Ok(result);
    }
  
    [HttpPost("login")]
    public IActionResult Login([FromBody] string email, string password)
    {
        var result = _user.AuthenticateUserAsync(email, password);
        return Ok(result);
    }
}