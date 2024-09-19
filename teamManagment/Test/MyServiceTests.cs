using Xunit;
using Moq;
using teamManagment.Services;
using teamManagment.Models;

namespace teamManagment.Test
{
    public class MyServiceTests
    {
        [Fact]
        public async Task GetItemById_ReturnsItem()
        {
            // Arrange
            var mockRepository = new Mock<IRepository<TodoItem>>();
            mockRepository.Setup(repo => repo.GetByIdAsync(1))
                .ReturnsAsync(new TodoItem { Id = 1, Name = "Test Item" });

            var service = new MyService(mockRepository.Object);

            // Act
            var result = await service.GetItemById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Test Item", result.Name);
        }
    }
}