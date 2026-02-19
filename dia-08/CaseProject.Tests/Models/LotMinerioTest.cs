using System.Net;
using Xunit;

public class WeatherForecastTests
{
    private readonly HttpClient _client;

    [Fact]
    public async Task Get_WeatherForecast_DeveRetornar200()
    {
        var response = await _client.GetAsync("/lot-minerio/");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
