using ApiSdk;

using Microsoft.AspNetCore.Mvc;

using Users.Application;
using Users.Domain.Models;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class UsersController : ControllerBase
{
    private readonly UsersSearcher _usersSearcher;

    public UsersController(UsersSearcher usersSearcher)
    {
        _usersSearcher = usersSearcher;
    }

    /// <summary>
    /// Get all the users.
    /// </summary>
    /// <returns>List of users.</returns>
    [HttpGet]
    public ApiResponse<List<User>> GetAllUsers()
    {
        List<User> users = _usersSearcher.SearchAll();
        return ApiResponse<List<User>>.Ok(users);
    }
}
