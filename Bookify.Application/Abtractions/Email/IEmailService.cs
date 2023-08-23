namespace Bookify.Application.Abtractions.Email;
public interface IEmailService
{
    Task SendAsync(Domain.Users.Email recipient, string subject, string body);
}
