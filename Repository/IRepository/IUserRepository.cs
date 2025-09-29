using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IUserRepository
{
    User GetUserById(int id);
    IEnumerable<User> GetAllUsers();
    User GetUserByEmail(string email);
    bool AddUser(User user);
    bool UpdateUser(User user);
    bool DeleteUser(int id);
    bool SaveChanges();
    

}