using AutoMapper;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;

namespace Travel_Service.TravelServiceMapper;

public class TravelServiceMappings :Profile
{
    public TravelServiceMappings()
    {
        CreateMap<Flight, FlightRequestDto>().ReverseMap();
        CreateMap<Booking, BookedPackageRequestDto>().ReverseMap();
        CreateMap<User, RegisterUserRequestDto>().ReverseMap();
    }
}