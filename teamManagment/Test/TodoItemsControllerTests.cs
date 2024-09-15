using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using teamManagment.Controllers;
using teamManagment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TodoItemsControllerTests
{
    [Fact]
    public async Task GetTodoItems_ReturnsAllItems()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<TodoContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new TodoContext(options))
        {
            context.TodoItems.AddRange(GetTestTodoItems());
            context.SaveChanges();
        }

        using (var context = new TodoContext(options))
        {
            var controller = new TodoItemsController(context);

            // Act
            var result = await controller.GetTodoItems();

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<TodoItem>>>(result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<TodoItem>>(actionResult.Value);
            Assert.Equal(2, returnValue.Count());
        }
    }

    private List<TodoItem> GetTestTodoItems()
    {
        return new List<TodoItem>
        {
            new TodoItem { Id = 1, Name = "Test Item 1", IsComplete = true },
            new TodoItem { Id = 2, Name = "Test Item 2", IsComplete = false }
        };
    }
}