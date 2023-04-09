using Shared.Domain.Users.Exceptions;

namespace Shared.Domain.Users.ValueObjects;

public sealed class UserEmail
{
    public string Value { get; set; }

    public UserEmail(string value)
    {
        if (!IsValid(value)) throw new InvalidUserEmailException();
        Value = value;
    }

    private static bool IsValid(string value)
    {
        // TODO: add email validation.
        return !string.IsNullOrEmpty(value);
    }
}
