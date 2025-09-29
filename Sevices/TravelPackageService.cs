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

    public Task<IEnumerable<TravelPackages>> GetAllPackagesAsync()
    {
        return _packageRepository.GetAllPackagesAsync();
    }

    public Task<TravelPackages> GetPackageByIdAsync(int packageId)
    {
        throw new NotImplementedException();
    }

    public Task AddPackageAsync(TravelPackages travelPackage)
    {
        throw new NotImplementedException();
    }
}