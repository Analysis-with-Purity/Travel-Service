using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;

namespace Travel_Service.Sevices.IServices;

public interface IBookingService
{
    BookedPackageResponseDetails GetAllBookedPackagesByCustomerId(int customerId);
    BookedPackageResponseDetails CreateBooking(BookedPackageRequestDto book);

}