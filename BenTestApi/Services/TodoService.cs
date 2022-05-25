using BenTestApi.DataLayer;
using BenTestApi.Models;

namespace BenTestApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepo;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepo = todoRepository;
        }

        public async Task<IEnumerable<TodoModel>> GetAllTodosServiceLayer()
        {
            try
            {
                return await _todoRepo.GetAllTodosDataLayer();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateTodoServiceLayer(TodoModel todo)
        {
            try
            {
                await _todoRepo.CreateAsyncDataLayer(todo);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
