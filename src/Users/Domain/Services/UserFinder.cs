using Shared.Domain.Users.ValueObjects;

using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Domain.Services;

public sealed class UserFinder
{
    private readonly IUsersRepository _usersRepository;

    public UserFinder(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public User FindById(UserId userId)
    {
        return _usersRepository.FindById(userId);
    }
}
