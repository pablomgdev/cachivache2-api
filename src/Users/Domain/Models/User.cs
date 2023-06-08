using Shared.Domain.Users.ValueObjects;

namespace Users.Domain.Models;

public sealed class User
{
    public UserId Id { get; set; }
    public UserUsername UserName { get; set; }
    public UserEmail Email { get; set; }

    public User(UserId id, UserUsername username, UserEmail email)
    {
        Id = id;
        UserName = username;
        Email = email;
    }
}
