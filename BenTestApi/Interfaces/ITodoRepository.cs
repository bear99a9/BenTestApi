using BenTestApi.Models;

namespace BenTestApi.DataLayer
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoModel>> GetAllTodosDataLayer();

        Task CreateAsyncDataLayer(TodoModel model);
    }
}