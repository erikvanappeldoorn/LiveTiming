using LiveTiming.Domain;
using Microsoft.AspNetCore.Mvc.Testing;

namespace LiveTiming.Tests;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public ApiTests(WebApplicationFactory<Program> factory)
    { 
        _factory = factory;
    }
    
    [Fact]
    public async void GetTimedLap()
    {
        const string url = @"/?driver=ALO";
        var client = _factory.CreateClient();
        
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        
        var timedLap = await response.Content.ReadFromJsonAsync<TimedLap>();
        Assert.Equal("ALO", timedLap?.Driver);
    }
}