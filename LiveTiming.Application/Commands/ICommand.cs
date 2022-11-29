using MediatR;

namespace LiveTiming.Application.Commands;

public interface ICommand : IRequest
{
}
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}