namespace LiveTiming.Domain;

public class TimedLap
{
    public TimedLap(string driver)
    {
        Driver = driver;
    }
    
    public string Driver { get; }
    public int Lap { get; init; }
    public TimeSpan? Sector1 { get; set; }
    public TimeSpan? Sector2 { get; set; }
    public TimeSpan? Sector3 { get; set; }

    public TimeSpan? Total => Sector1 ?? TimeSpan.Zero + 
                              Sector2 ?? TimeSpan.Zero + 
                              Sector3 ?? TimeSpan.Zero;
}