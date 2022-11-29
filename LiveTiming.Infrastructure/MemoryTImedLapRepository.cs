using LiveTiming.Domain;

namespace LiveTiming.Infrastructure;

public class MemoryTImedLapRepository : ITimedLapRepository
{
    private readonly string[] drivers = {"ALO"};
    public async Task<TimedLap?> GetTimedLapAsync(string driver)
    {
        if (!drivers.Contains(driver))
            return await Task.FromResult<TimedLap?>(null);
        
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