using Moq;
using MVVMApp.Models;
using MVVMApp.Services;
using MVVMApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MVVMApp.Tests
{
    public class UserViewModelTests
    {
        [Fact]
        public async Task LoadUsers_ShouldPopulateUsersCollection()
        {
            // Arrange
            var mockUserService = new Mock<UserService>();
            mockUserService.Setup(service => service.GetUsersAsync()).ReturnsAsync(new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane Doe", Email = "jane@example.com" }
            });

            var viewModel = new UserViewModel(mockUserService.Object);

            // Act
            await Task.Delay(1000); // Wait for async method to complete

            // Assert
            Assert.NotNull(viewModel.Users);
            Assert.Equal(2, viewModel.Users.Count);
        }
    }
}