namespace LiveTiming.Domain;

public record SectorTime(string Driver, int Lap, Sector Sector, TimeSpan time);