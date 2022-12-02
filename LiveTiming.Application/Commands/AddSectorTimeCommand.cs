using LiveTiming.Domain;

namespace LiveTiming.Application.Commands;

public record AddSectorTimeCommand(SectorTime sectorTime) : ICommand;
