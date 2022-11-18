using LiveTiming.Application.Queries;
using LiveTiming.Domain;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<ITimedLapRepository, ITimedLapRepository>();

var app = builder.Build();

app.MapGet("/", async (string driver, int lap, IMediator mediator) =>
{
    var result = await mediator.Send(new TimedLapQuery {Driver = driver, Lap = lap});
    return result;
});

app.Run();