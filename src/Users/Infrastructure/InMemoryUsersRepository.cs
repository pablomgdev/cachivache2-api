using System.Collections.Generic;
using Shared.Domain.Users.ValueObjects;

using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Infrastructure;

// TODO.
public sealed class InMemoryUsersRepository : IUsersRepository
{
    public User FindById(UserId userId)
    {
        throw new NotImplementedException();
    }

    public List<User> SearchAll()
    {
        throw new NotImplementedException();
    }
}
