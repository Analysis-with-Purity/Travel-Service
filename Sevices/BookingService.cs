using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Sevices.IServices;

public class BookingService:IBookingService
{private readonly IBookingRepository _bookingRepository;

    public BookingService(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public async Task<IEnumerable<Booking>> GetAllBookingsAsync()
    {
        return await _bookingRepository.GetAllBookingsAsync();
    }

    public Task<Booking> GetBookingByIdAsync(int bookingId)
    {
        return _bookingRepository.GetBookingByIdAsync(bookingId);
    }

    public Task AddBookingAsync(Booking booking)
    {
        return _bookingRepository.AddBookingAsync(booking);
    }

    public Task UpdateBookingAsync(Booking booking)
    {
        return _bookingRepository.UpdateBookingAsync(booking);
    }

    public Task DeleteBookingAsync(int bookingId)
    {
        return _bookingRepository.DeleteBookingAsync(bookingId);
    }
}