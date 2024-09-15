using Xunit;
using teamManagment.Models;

public class TodoItemTests
{
    [Fact]
    public void CanChangeName()
    {
        // Arrange
        var item = new TodoItem { Name = "Old Name" };

        // Act
        item.Name = "New Name";

        // Assert
        Assert.Equal("New Name", item.Name);
    }
}