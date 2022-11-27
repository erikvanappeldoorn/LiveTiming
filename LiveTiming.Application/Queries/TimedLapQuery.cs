using LiveTiming.Domain;
using MediatR;

namespace LiveTiming.Application.Queries;

public class TimedLapQuery : IQuery<TimedLap>
{
    public required string Driver { get; init; }
    public int Lap { get; init; }
}