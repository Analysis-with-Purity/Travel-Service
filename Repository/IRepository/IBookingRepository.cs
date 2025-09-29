using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IBookingRepository
{
    Task<IEnumerable<Booking>> GetAllBookingsAsync();
    Task<Booking> GetBookingByIdAsync(int bookingId);
    Task AddBookingAsync(Booking booking);
    Task UpdateBookingAsync(Booking booking);
    Task DeleteBookingAsync(int bookingId);
}