using Microsoft.AspNetCore.Mvc;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos.Request;
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
    public IActionResult Register([FromBody] RegisterUserRequestDto user)
    {
        var result = _user.RegisterUser(user);
        return Ok(result);
    }
  
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequestDto request, [FromServices] JwtTokenGenerator tokenGenerator)
    {
        var result = _user.Login(request, tokenGenerator);
        return Ok(result);
    }
}