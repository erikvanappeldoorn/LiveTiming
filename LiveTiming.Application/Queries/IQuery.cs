using MediatR;

namespace LiveTiming.Application.Queries;

public interface IQuery<out TResponse>: IRequest<TResponse>
{
    
}
