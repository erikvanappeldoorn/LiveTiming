using LiveTiming.Application;
using LiveTiming.Application.Queries;
using LiveTiming.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
var app = builder.Build();

app.MapGet("/", async (string driver, int lap, IMediator mediator) =>
{
    var result = await mediator.Send(new TimedLapQuery {Driver = driver, Lap = lap});
    return result;
});

app.Run();