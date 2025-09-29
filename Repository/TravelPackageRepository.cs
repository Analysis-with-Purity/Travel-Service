using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Dtos.Request;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class TravelPackageRepository: ITravelPackageRepository
{
    private readonly ApplicationDbContext _context;

    public TravelPackageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TravelPackages>> GetAllPackagesAsync()
    {
        return await _context.Packages
            .Include(tp => tp.Flights)
            .ToListAsync();
    }

    public async Task<TravelPackages> GetPackageByIdAsync(int packageId)
    {
        return await _context.Packages
            .Include(tp => tp.Flights)
            .FirstOrDefaultAsync(tp => tp.PackageId == packageId);
    }

    public async Task AddPackageAsync(TravelPackages travelPackage)
    {
        await _context.Packages.AddAsync(travelPackage);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePackageAsync(TravelPackages travelPackage)
    {
        _context.Packages.Update(travelPackage);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePackageAsync(int packageId)
    {
        var package = await _context.Packages.FindAsync(packageId);
        if (package != null)
        {
            _context.Packages.Remove(package);
            await _context.SaveChangesAsync();
        }
    }
}