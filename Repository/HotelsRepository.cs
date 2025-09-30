using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class HotelsRepository: IHotelsRepository
{
    private readonly ApplicationDbContext _context;

    public HotelsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    // {
    //     return await _context.Hotels.Include(h => h.Rooms).ToListAsync();
    // }
    
    

    public async Task<Hotel> GetHotelByIdAsync(int hotelId)
    {
        return await _context.Hotels.Include(h => h.Rooms)
            .FirstOrDefaultAsync(h => h.HotelId == hotelId);
    }
    
    public async Task<IEnumerable<Hotel>> GetAllHotelsAsync()
    {
        return await _context.Hotels
            .Include(h => h.Rooms)
            .ToListAsync();
    }

    public async Task AddHotelAsync(Hotel hotel)
    {
        await _context.Hotels.AddAsync(hotel);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateHotelAsync(Hotel hotel)
    {
        _context.Hotels.Update(hotel);
        await _context.SaveChangesAsync();
    }
    
    public async Task DeleteHotelAsync(int hotelId)
    {
        var hotel = await _context.Hotels.FindAsync(hotelId);
        if (hotel != null)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }
    }
}