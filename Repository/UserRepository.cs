using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class UserRepository : IUserRepository
{
    public readonly ApplicationDbContext _db;
    public UserRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public bool RegisterUser(User userDetails)
    {
        try
        {
            _db.Customers.Add(userDetails);
            return Save();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error in addidng customer: {ex.Message}");
            return false;
        }
    }

    public User GetUserById(Guid customerId)
    {
        try
        {
            return _db.Customers.FirstOrDefault(a => a.CustomerId == customerId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in GetUserById: {ex.Message}");
            return null;
        }
    }

    public User GetUserByEmail(string email)
    {
        try
        {
            return _db.Customers.FirstOrDefault(a => a.Email == email);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in GetUserById: {ex.Message}");
            return null;
        }
    }

    public bool UpdateUser(User userDetails)
    {
        try
        {
            _db.Customers.Update(userDetails);
            return Save();
        }
        catch
        {
            return false;
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