using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Services;

namespace Rest.Controllers;

public class UserController : ControllerBase
{
    private readonly UserService _userService;

    [HttpGet]
    public IActionResult CreateAccount(string username, string password)
    {
        try
        {
            var createAccountResult = _userService.CreateAccount(username, password);
            return Ok(createAccountResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult Login(string username, string password)
    {
        try
        {
            var loginResult = _userService.Login(username, password);
            return Ok(loginResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetUserByUsername(string username)
    {
        try
        {
            var userResult = _userService.GetUserByUsername(username);
            return Ok(userResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPost]
    public IActionResult AddUser(User user)
    {
        try
        {
            var userResult = _userService.AddUser(user);
            return Ok(userResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPut]
    public IActionResult UpdateUser(string username, User user)
    {
        try
        {
            var userResult = _userService.UpdateUser(username, user);
            return Ok(userResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpDelete]
    public IActionResult DeleteUser(string username)
    {
        try
        {
            var userResult = _userService.DeleteUser(username);
            return Ok(userResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }
}