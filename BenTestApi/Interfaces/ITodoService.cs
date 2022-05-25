using BenTestApi.Models;

namespace BenTestApi.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoModel>> GetAllTodosServiceLayer();

        Task CreateTodoServiceLayer(TodoModel model);
    }
}