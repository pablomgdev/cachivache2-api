using Shared.Domain.Users.ValueObjects;

using Users.Domain.Models;
using Users.Domain.Repositories;
using Users.Domain.Services;

namespace Users.Application;

public sealed class UsersSearcher
{
    private readonly IUsersRepository _usersRepository;
    private readonly UserFinder _userFinder;

    public UsersSearcher(
        IUsersRepository usersRepository,
        UserFinder userFinder)
    {
        _usersRepository = usersRepository;
        // TODO: check if it is better to inject this dependency or user new directly.
        _userFinder = new(_usersRepository);
    }

    public List<User> SearchAll()
    {
        return _usersRepository.SearchAll();
    }

    public User FindById(UserId userId)
    {
        return _userFinder.FindById(userId);
    }
}
