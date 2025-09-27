using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface ITravelServiceRepository
{
    ICollection<TravelPackages> GetAllTravelPackages();
    bool BookTravelPackage(Booking bookPackage);
    Hotel GetAllHotels(string location);
    Booking GetCustomerTravelPackage(int customerId);
    bool Save();
}