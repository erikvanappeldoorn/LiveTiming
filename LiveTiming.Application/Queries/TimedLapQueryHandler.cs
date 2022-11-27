using LiveTiming.Domain;
using MediatR;

namespace LiveTiming.Application.Queries;

public class TimedLapQueryHandler : IQueryHandler<TimedLapQuery, TimedLap>
{
    private readonly ITimedLapRepository _timedLapRepository;

    public TimedLapQueryHandler(ITimedLapRepository timedLapRepository)
    {
        _timedLapRepository = timedLapRepository;
    }
    public async Task<TimedLap> Handle(TimedLapQuery query, CancellationToken cancellationToken)
    {
        return await _timedLapRepository.GetTimedLapAsync(query.Driver);
    }
}