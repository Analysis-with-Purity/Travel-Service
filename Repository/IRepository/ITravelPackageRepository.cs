using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface ITravelPackageRepository
{
    Task<IEnumerable<TravelPackages>> GetAllPackagesAsync();
    Task<TravelPackages> GetPackageByIdAsync(int packageId);
    Task AddPackageAsync(TravelPackages travelPackage);
    Task UpdatePackageAsync(TravelPackages travelPackage);
    Task DeletePackageAsync(int packageId);
}