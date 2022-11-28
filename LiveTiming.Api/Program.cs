using LiveTiming.Application;
using LiveTiming.Application.Queries;
using LiveTiming.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", async (string driver, IMediator mediator) =>
{
    var result = await mediator.Send(new TimedLapQuery {Driver = driver});
    return result;
}).WithOpenApi();

app.Run();

public partial class Program { }