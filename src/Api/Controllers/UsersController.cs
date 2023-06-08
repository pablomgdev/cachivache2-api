using ApiSdk;
using ApiSdk.Requests;

using Microsoft.AspNetCore.Mvc;

using Users.Application;
using Users.Domain.Models;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class UsersController : ControllerBase
{
    private readonly UsersSearcher _usersSearcher;
    private readonly UserCreator _userCreator;

    public UsersController(
        UsersSearcher usersSearcher,
        UserCreator userCreator)
    {
        _usersSearcher = usersSearcher;
        _userCreator = userCreator;
    }

    /// <summary>
    /// Creates an user.
    /// </summary>
    /// <returns>User created.</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponse<User>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse<User>), StatusCodes.Status500InternalServerError)]
    public ApiResponse<User> CreateUser([FromBody] CreateUserRequest request)
    {
        User user = _userCreator.Create(request.UserName, request.Email);
        // TODO: return the values of the users properties, no the User objects directly.
        return ApiResponse<User>.Created(user);
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
