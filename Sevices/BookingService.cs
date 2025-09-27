using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;

namespace Travel_Service.Sevices.IServices;

public class BookingService:IBookingService
{
    public BookedPackageResponseDetails GetAllBookedPackagesByCustomerId(int customerId)
    {
        throw new NotImplementedException();
    }

    public BookedPackageResponseDetails CreateBooking(BookedPackageRequestDto book)
    {
        throw new NotImplementedException();
    }
}