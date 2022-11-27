using MediatR;

namespace LiveTiming.Application.Queries;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
where TQuery : IQuery<TResponse>
{
    
}