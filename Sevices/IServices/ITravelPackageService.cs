using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;

namespace Travel_Service.Sevices.IServices;

public interface ITravelPackageService
{
    Task<IEnumerable<TravelPackage>> GetAllPackagesAsync();
    Task<TravelPackage> GetPackageByIdAsync(int packageId);
    Task AddPackageAsync(TravelPackage travelPackage);
    // Task UpdatePackageAsync(TravelPackage travelPackage);
    // Task DeletePackageAsync(int packageId);
}