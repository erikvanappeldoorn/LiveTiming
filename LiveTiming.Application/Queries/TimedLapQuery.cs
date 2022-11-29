using LiveTiming.Domain;

namespace LiveTiming.Application.Queries;

public record TimedLapQuery(string Driver) : IQuery<TimedLap>;
