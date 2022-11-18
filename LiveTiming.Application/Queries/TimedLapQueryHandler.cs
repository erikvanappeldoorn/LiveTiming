using LiveTiming.Domain;
using MediatR;

namespace LiveTiming.Application.Queries;

public class TimedLapQueryHandler : IRequestHandler<TimedLapQuery, TimedLap>
{
    public async Task<TimedLap> Handle(TimedLapQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}