namespace LiveTiming.Domain;

public interface ITimedLapRepository
{
    Task<TimedLap?> GetTimedLapAsync(string driver, int lap);
    Task AddSectorTimeAsync(string driver, int lap, TimeSpan sectorTime, byte sector);
}