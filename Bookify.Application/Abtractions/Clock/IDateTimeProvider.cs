namespace Bookify.Application.Abtractions.Clock;
public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
