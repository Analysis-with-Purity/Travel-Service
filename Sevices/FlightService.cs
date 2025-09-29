using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class FlightService:IFlightService
{
    private readonly IFlightsRepository _flightRepository;

    public FlightService(IFlightsRepository flightRepository)
    {
        _flightRepository = flightRepository;
    }

    public Task<IEnumerable<Flight>> GetAllFlightsAsync()
    {
        return _flightRepository.GetAllFlightsAsync();
    }

    public Task<Flight> GetFlightByIdAsync(int flightId)
    {
        return _flightRepository.GetFlightByIdAsync(flightId);
    }

    public Task AddFlightAsync(Flight flight)
    {
        return _flightRepository.AddFlightAsync(flight);
    }

    public Task UpdateFlightAsync(Flight flight)
    {
        return _flightRepository.UpdateFlightAsync(flight);
    }

    public Task DeleteFlightAsync(int flightId)
    {
        return _flightRepository.DeleteFlightAsync(flightId);
    }
}