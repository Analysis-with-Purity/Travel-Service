using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class TravelServiceRepository: ITravelServiceRepository
{
    public readonly ApplicationDbContext _db;
    public TravelServiceRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public ICollection<TravelPackages> GetAllTravelPackages()
    {
        try
        {
            return _db.Packages.OrderBy(a => a.PackageId).ToList();
        }
        catch (Exception ex)
        {
            // log error or rethrow
            Console.WriteLine($"Error in GetAllTravelPackages: {ex.Message}");
            return new List<TravelPackages>();
        }
    }

    public bool BookTravelPackage(Booking bookPackage)
    {
        try
        {
            _db.Bookings.Add(bookPackage);
            return Save();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in BookTravelPackage: {ex.Message}");
            return false;
        }
        
    }

    public Hotel GetAllHotels(string location)
    {
        try
        {
            return _db.Hotels.FirstOrDefault(a => a.HotelLocation == location);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in GetAllHotels: {ex.Message}");
            return null;
        }
    }

    public Booking GetCustomerTravelPackage(int customerId)
    {
        try
        {
            return _db.Bookings.FirstOrDefault(a => a.CustomerId == customerId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in GetCustomerTravelPackage: {ex.Message}");
            return null;
        }    
    }

    public bool Save()
    {
        try
        {
            return _db.SaveChanges() >= 0;
        }
        catch (DbUpdateException dbEx)
        {
            Console.WriteLine($"Database update error: {dbEx.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in Save: {ex.Message}");
            return false;
        }
    }
}