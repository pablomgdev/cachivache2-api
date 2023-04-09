namespace Shared.Domain.Users.ValueObjects;

public sealed class UserId
{
    public int Value { get; set; }

    public UserId(int value)
    {
        Value = value;
    }
}
