using Shared.Domain.Users.Exceptions;

namespace Shared.Domain.Users.ValueObjects;

public sealed class UserUsername
{
    public string Value { get; set; }

    public UserUsername(string value)
    {
        if (!IsValid(value)) throw new InvalidUserUsernameException();
        Value = value;
    }

    private static bool IsValid(string value)
    {
        return !string.IsNullOrEmpty(value) && !value.Contains(' ');
    }
}
