using MediatR;

namespace Bookify.Application.Abtractions.Messaging;
internal interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}
