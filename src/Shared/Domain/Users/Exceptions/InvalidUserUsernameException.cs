namespace Shared.Domain.Users.Exceptions;

public sealed class InvalidUserUsernameException : Exception
{
    public InvalidUserUsernameException() : base(message: "User username is invalid.")
    {
    }

    public InvalidUserUsernameException(string? message) : base(message)
    {
    }

    public InvalidUserUsernameException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
