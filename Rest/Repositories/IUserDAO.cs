using Rest.Models;

namespace Rest.Repositories;

public interface IUserDAO
{
    public User AddUser(User userData);
    public User UpdateUser(string username, User userData);
    public bool DeleteUser(string username);
    public List<User> GetAllUsers();
    public User GetUserByUsername(string username);
}