using Users.Domain.Models;
using Users.Domain.Repositories;

namespace Users.Application;

public sealed class UserCreator
{
    private readonly IUsersRepository _usersRepository;

    public UserCreator(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public User Create(string? userName, string? email)
    {
        User user = new(new(0), new(userName!), new(email!));
        return _usersRepository.Save(user);
    }
}
