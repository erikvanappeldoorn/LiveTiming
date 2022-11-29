using LiveTiming.Domain;

namespace LiveTiming.Application.Commands;

public record AddSectorTimeCommand(string Driver, int Lap, Sector Sector, TimeSpan sectorTime) : ICommand;
