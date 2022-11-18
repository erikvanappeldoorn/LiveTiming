namespace LiveTiming.Domain;

public class TimedLapRepository : ITimedLapRepository
{
    public async Task<TimedLap> GetTimedLapAsync(string driver, int lap)
    {
        throw new NotImplementedException();
    }

    public async Task AddSectorTimeAsync(string driver, int lap, TimeSpan sectorTime, byte sector)
    {
        throw new NotImplementedException();
    }
}