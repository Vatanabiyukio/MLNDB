using Rest.Models;
using Rest.Repositories.Impl;

namespace Rest.Services;

public class UserService
{
    private readonly UserDAO _userDao;

    public User CreateAccount(string username, string password)
    {
        return _userDao.AddUser(new User()
        {
            Username = username,
            Password = password,
            ReadingList = null
        });
    }

    public User Login(string username, string password)
    {
        var user = _userDao.GetUserByUsername(username);

        if (user != null)
        {
            if (user.Password == password)
                return user;
        }

        throw new Exception();
    }

    public User AddUser(User user)
    {
        return _userDao.AddUser(user);
    }

    public User UpdateUser(string username, User user)
    {
        return _userDao.UpdateUser(username, user);
    }

    public User GetUserByUsername(string username)
    {
        return _userDao.GetUserByUsername(username);
    }

    public bool DeleteUser(string username)
    {
        return _userDao.DeleteUser(username);
    }
}