namespace LiveTiming.Domain;

public class TimedLap
{
    public TimedLap(string driver, int lap)
    {
        this.Driver = driver;
        this.Lap = lap;
    }
    
    public string Driver { get; init; }
    public int Lap { get; init; }
    public TimeSpan? Sector1 { get; set; }
    public TimeSpan? Sector2 { get; set; }
    public TimeSpan? Sector3 { get; set; }
}