using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class TravelService: ITravelService
{
    public ICollection<BookedPackageResponseDetails> GetAllPackages()
    {
        throw new NotImplementedException();
    }

    public BookedPackageResponseDetails BookTravelPackage(BookedPackageRequestDto package)
    {
        throw new NotImplementedException();
    }
}