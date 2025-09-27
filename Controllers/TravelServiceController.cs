using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_Service.Helper;
using Travel_Service.Models.Dtos;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class TravelServiceController :ControllerBase
{
    public readonly ITravelService _tservice;

    public TravelServiceController(ITravelService tservice)
    {
        _tservice = tservice;
    }

    [HttpGet("GetAllPackages")]
    public IActionResult GetAllPackages()
    {
        return null;
    }
    
    [HttpGet("GetPackagesByCustomerId")]
    public IActionResult GetPackagesByCustomerId()
    {
        return null;
    }
}