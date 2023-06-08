using Users.Domain.Models;

namespace Users.Domain.Repositories;

public interface IUsersRepository
{
    List<User> SearchAll();
}
