namespace LiveTiming.Application.Queries;

public class TimedLapQuery
{
    public required string Driver { get; init; }
    public int Lap { get; init; }
}