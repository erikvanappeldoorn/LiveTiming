using LiveTiming.Domain;

namespace LiveTiming.Infrastructure;

public class MemoryTImedLapRepository : ITimedLapRepository
{
    public async Task<TimedLap> GetTimedLapAsync(string driver)
    {
        var timedLap = new TimedLap(driver)
        {
            Lap = 1,
            Sector1 = TimeSpan.FromMilliseconds(23_985), 
            Sector2 = TimeSpan.Zero,
            Sector3 = TimeSpan.Zero
        };

        return await Task.FromResult(timedLap);
    }
}