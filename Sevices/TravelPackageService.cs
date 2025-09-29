using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Dtos.Response;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;
using Travel_Service.Sevices.IServices;

namespace Travel_Service.Sevices;

public class TravelPackageService: ITravelPackageService
{
    private readonly ITravelPackageRepository _packageRepository;

    public TravelPackageService(ITravelPackageRepository packageRepository)
    {
        _packageRepository = packageRepository;
    }

    public Task<IEnumerable<TravelPackage>> GetAllPackagesAsync()
    {
        return _packageRepository.GetAllPackagesAsync();
    }

    public async Task<TravelPackage> GetPackageByIdAsync(int packageId)
    {
        // Fetch package including flights
        var package = await _packageRepository.GetPackageByIdAsync(packageId);
        return package;
    }
    public Task AddPackageAsync(TravelPackage travelPackage)
    {
        throw new NotImplementedException();
    }
}