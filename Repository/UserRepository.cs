using Microsoft.EntityFrameworkCore;
using Travel_Service.Data;
using Travel_Service.Models.Entity;
using Travel_Service.Repository.IRepository;

namespace Travel_Service.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public User GetUserById(int id)
        {
            try
            {
                return _db.Customers.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserById: {ex.Message}");
                return null;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return _db.Customers.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllUsers: {ex.Message}");
                return Enumerable.Empty<User>();
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                return _db.Customers.FirstOrDefault(u => u.Email == email);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserByEmail: {ex.Message}");
                return null;
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                _db.Customers.Add(user);
                return SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddUser: {ex.Message}");
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _db.Customers.Update(user);
                return SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateUser: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                var user = GetUserById(id);
                if (user == null)
                {
                    return false;
                }

                _db.Customers.Remove(user);
                return SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteUser: {ex.Message}");
                return false;
            }
        }

        public bool SaveChanges()
        {
            try
            {
                return _db.SaveChanges() >= 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SaveChanges: {ex.Message}");
                return false;
            }
        }

       
        
}
