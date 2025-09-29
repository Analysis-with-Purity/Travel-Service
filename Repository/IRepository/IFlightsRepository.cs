using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IFlightsRepository
{
    Task<IEnumerable<Flight>> GetAllFlightsAsync();
    Task<Flight> GetFlightByIdAsync(int flightId);
    Task AddFlightAsync(Flight flight);
    Task UpdateFlightAsync(Flight flight);
    Task DeleteFlightAsync(int flightId);
}