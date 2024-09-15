using System.Threading.Tasks;
using teamManagment.Models;

namespace teamManagment.Services
{
    public class MyService
    {
        private readonly IRepository<TodoItem> _repository;

        public MyService(IRepository<TodoItem> repository)
        {
            _repository = repository;
        }

        public async Task<TodoItem> GetItemById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
