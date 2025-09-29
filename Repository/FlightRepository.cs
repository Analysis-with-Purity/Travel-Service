using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class FlightRepository:IFlightsRepository
{
    private readonly ApplicationDbContext _context;

    public FlightRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Flight>> GetAllFlightsAsync()
    {
        return await _context.Flights.ToListAsync();
    }

    public async Task<Flight> GetFlightByIdAsync(int flightId)
    {
        return await _context.Flights.FirstOrDefaultAsync(f => f.FlightId == flightId);
    }

    public async Task AddFlightAsync(Flight flight)
    {
        await _context.Flights.AddAsync(flight);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateFlightAsync(Flight flight)
    {
        _context.Flights.Update(flight);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteFlightAsync(int flightId)
    {
        var flight = await _context.Flights.FindAsync(flightId);
        if (flight != null)
        {
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
        }
    }
}