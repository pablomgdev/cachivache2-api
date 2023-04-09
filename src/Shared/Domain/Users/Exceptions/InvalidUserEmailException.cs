namespace Shared.Domain.Users.Exceptions;

public sealed class InvalidUserEmailException : Exception
{
    public InvalidUserEmailException() : base(message: "User email is invalid.")
    {
    }

    public InvalidUserEmailException(string? message) : base(message)
    {
    }

    public InvalidUserEmailException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
