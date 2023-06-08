using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Application;

public sealed class UsersSearcher
{
    private readonly IUsersRepository _usersRepository;

    public UsersSearcher(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public List<User> SearchAll()
    {
        return _usersRepository.SearchAll();
    }
}
