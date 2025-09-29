using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface ITravelPackageRepository
{
    Task<IEnumerable<TravelPackage>> GetAllPackagesAsync();
    Task<TravelPackage> GetPackageByIdAsync(int packageId);
    Task AddPackageAsync(TravelPackage travelPackage);
    Task UpdatePackageAsync(TravelPackage travelPackage);
    Task DeletePackageAsync(int packageId);
}