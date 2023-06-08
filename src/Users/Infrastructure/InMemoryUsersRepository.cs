using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Infrastructure;

public sealed class InMemoryUsersRepository : IUsersRepository
{
    private static readonly List<User> Users = new();

    public User Save(User user)
    {
        user.Id = new Shared.Domain.Users.ValueObjects.UserId(Users.Count + 1);
        Users.Add(user);
        return user;
    }

    public List<User> SearchAll()
    {
        return Users;
    }
}
