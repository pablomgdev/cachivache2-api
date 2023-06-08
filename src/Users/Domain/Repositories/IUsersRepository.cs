using Shared.Domain.Users.ValueObjects;

using Users.Domain.Models;

namespace Users.Domain.Repositories;

public interface IUsersRepository
{
    User FindById(UserId userId);
    List<User> SearchAll();
}
