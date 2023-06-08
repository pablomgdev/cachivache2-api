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
    [ProducesResponseType(typeof(ApiResponse<List<User>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse<List<User>>), StatusCodes.Status500InternalServerError)]
    public ApiResponse<List<User>> GetAllUsers()
    {
        List<User> users = _usersSearcher.SearchAll();
        // TODO: return the values of the users properties, no the User objects directly.
        return ApiResponse<List<User>>.Ok(users);
    }
}
