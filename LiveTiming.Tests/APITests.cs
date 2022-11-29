using FluentAssertions;
using LiveTiming.Domain;
using Microsoft.AspNetCore.Mvc.Testing;

namespace LiveTiming.Tests;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public ApiTests(WebApplicationFactory<Program> factory) => _factory = factory;
    
    [Fact]
    public async void Get_TimedLap_Of_An_Existing_Driver_Should_Return_Valid_TimedLap()
    {
        const string url = @"/?driver=ALO";
        var client = _factory.CreateClient();
        
        var response = await client.GetAsync(url);
        response
        .EnsureSuccessStatusCode();
        
        TimedLap? timedLap = await response.Content.ReadFromJsonAsync<TimedLap>();
        timedLap.Should().NotBeNull();
        timedLap?.Driver.Should().Be("ALO");
        timedLap?.Lap.Should().BeGreaterThan(0);
    }

    
    [Fact]
    public async void Get_TimedLap_Of_A_NonExisting_Driver_Should_Return_Null()
    {
        const string url = @"/?driver=ABC";
        var client = _factory.CreateClient();
        
        var response = await client.GetAsync(url);
        response
            .EnsureSuccessStatusCode();
        
        TimedLap? timedLap = await response.Content.ReadFromJsonAsync<TimedLap>();
        timedLap.Should().BeNull();
    }
}