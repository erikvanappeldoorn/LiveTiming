using LiveTiming.Application;
using LiveTiming.Application.Queries;
using LiveTiming.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
var app = builder.Build();

app.MapGet("/", async (string driver, IMediator mediator) =>
{
    var result = await mediator.Send(new TimedLapQuery {Driver = driver});
    return result;
});

app.Run();