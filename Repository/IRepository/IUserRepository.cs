using Travel_Service.Models.Entity;

namespace Travel_Service.Repository.IRepository;

public interface IUserRepository
{
    bool RegisterUser(User userDetails);
    User GetUserById(Guid customerId);
    User GetUserByEmail(string email);
    bool UpdateUser(User userDetails);
    bool Save();

}