using MediatR;

namespace Bookify.Application.Abtractions.Messaging;
public interface IQuery<TResponse> : IRequest<TResponse>
{
}
