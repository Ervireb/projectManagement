using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

public class ProductsControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private readonly CustomWebApplicationFactory<Program> _factory;

    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        private readonly Action<IApplicationBuilder> _configureApp;

        public CustomWebApplicationFactory(Action<IApplicationBuilder> configureApp)
        {
            _configureApp = configureApp;
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Настройка сервисов
            });

            builder.Configure(app =>
            {
                // Вызов переданной функции для настройки приложения
                _configureApp(app);

                // Другая конфигурация приложения
            });
        }
    }


    [Fact]
    public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
    {
        // Arrange
        var response = await _client.GetAsync("/api/products");

        // Act
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
    }
}