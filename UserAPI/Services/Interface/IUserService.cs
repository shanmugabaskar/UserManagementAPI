using UserAPI.Models;

namespace UserAPI.Services.Interface
{
    public interface IUserService
    {
        IEnumerable<User> GetUserList();
        User GetUserById(int id);
        User AddUser(User product);
        User UpdateUser(User product);
        bool DeleteUser(int Id);

        User Login(User user);
    }
}
