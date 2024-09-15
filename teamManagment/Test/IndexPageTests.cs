using Moq;
using teamManagment.Pages;
using Xunit;

public class IndexPageTests
{
    [Fact]
    public void OnGet_PopulatesMessage()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<IndexModel>>();
        var pageModel = new IndexModel(mockLogger.Object);

        // Act
        pageModel.OnGet();

        // Assert
        Assert.Equal("Your application description page.", pageModel.Message);
    }
}
