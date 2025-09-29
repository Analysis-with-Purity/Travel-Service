using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface ITravelPackageService
{
    Task<IEnumerable<TravelPackages>> GetAllPackagesAsync();
    Task<TravelPackages> GetPackageByIdAsync(int packageId);
    Task AddPackageAsync(TravelPackages travelPackage);
    // Task UpdatePackageAsync(TravelPackages travelPackage);
    // Task DeletePackageAsync(int packageId);
}