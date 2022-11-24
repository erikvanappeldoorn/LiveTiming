using LiveTiming.Application.Queries;
using LiveTiming.Domain;
using LiveTiming.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(typeof(TimedLapQuery));
builder.Services.AddScoped<ITimedLapRepository, MemoryTImedLapRepository>();

var app = builder.Build();

app.MapGet("/", async (string driver, int lap, IMediator mediator) =>
{
    var result = await mediator.Send(new TimedLapQuery {Driver = driver, Lap = lap});
    return result;
});

app.Run();