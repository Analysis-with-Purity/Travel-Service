using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface IFlightService
{
    Task<IEnumerable<Flight>> GetAllFlightsAsync();
    Task<Flight> GetFlightByIdAsync(int flightId);
    Task AddFlightAsync(Flight flight);
    Task UpdateFlightAsync(Flight flight);
    Task DeleteFlightAsync(int flightId);
}