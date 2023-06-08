using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Infrastructure;

public sealed class InMemoryUsersRepository : IUsersRepository
{
    private static readonly List<User> Users = new();

    public List<User> SearchAll()
    {
        return Users;
    }
}
