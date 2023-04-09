using ApiSdk;

using Microsoft.AspNetCore.Mvc;

using Shared.Domain.Users.ValueObjects;

using Users.Domain;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class UsersController : ControllerBase
{
    [HttpGet("{id}")]
    public ApiResponse<User> GetUser(int id)
    {
        // TODO: implement this endpoint.
        User user = new(new UserId(id), new UserUsername("Example"), new UserEmail("Example@example.es"));
        // TODO: the response must contain the value objects values, not the domain User object. Think about it.
        return ApiResponse<User>.Ok(user);
    }
}
