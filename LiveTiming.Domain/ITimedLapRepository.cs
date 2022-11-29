namespace LiveTiming.Domain;

public interface ITimedLapRepository
{
    Task<TimedLap?> GetTimedLapAsync(string driver);
}