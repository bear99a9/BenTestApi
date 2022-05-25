using BenTestApi.Models;
using BenTestApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BenTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("GetAllTodos")]
        public async Task<IActionResult> GetAllTodosControllerLayer()
        {
            IEnumerable<TodoModel> response = await _todoService.GetAllTodosServiceLayer();
            
            if (response == null && response.Any())
            {
                return BadRequest("The model does not exist or there is no data in the database!");
            }

            return Ok(response);

        }

        [HttpPost("CreateTodo")]

        public async Task<IActionResult> CreateTodoControllerLayer(TodoModel request)
        {
            await _todoService.CreateTodoServiceLayer(request);

            return Ok("New todo added!");
        }

        //Add Update function
        //Add Delete function
        // Get todo by ID (search for specific todo)

    }
}
