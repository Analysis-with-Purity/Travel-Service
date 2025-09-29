using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class BookingRepository:IBookingRepository
{
    private readonly ApplicationDbContext _context;

    public BookingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
    {
        return await _context.Bookings
            .Include(b => b.TravelPackage)
            .Include(b => b.User)
            .Include(b => b.Flight)
            .Include(b => b.Room)
            .ToListAsync();
    }

    public async Task<Booking> GetBookingByIdAsync(int bookingId)
    {
        return await _context.Bookings
            .Include(b => b.TravelPackage)
            .Include(b => b.Flight)
            .Include(b => b.Room)
            .FirstOrDefaultAsync(b => b.BookingId == bookingId);
    }

    public async Task AddBookingAsync(Booking booking)
    {
        await _context.Bookings.AddAsync(booking);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateBookingAsync(Booking booking)
    {
        _context.Bookings.Update(booking);
        await _context.SaveChangesAsync();
    }


    public async Task DeleteBookingAsync(int bookingId)
    {
        var booking = await _context.Bookings.FindAsync(bookingId);
        if (booking != null)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }
}