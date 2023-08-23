﻿using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abtractions.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{
}

public interface IBaseCommand
{
}
