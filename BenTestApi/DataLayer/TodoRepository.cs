using BenTestApi.Models;
using Dapper;
using System.Data.SqlClient;

namespace BenTestApi.DataLayer
{
    public class TodoRepository : ITodoRepository
    {
        public TodoRepository()
        {

        }

        public async Task<IEnumerable<TodoModel>> GetAllTodosDataLayer()
        {
            try
            {
                using var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BensTestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                {
                    var sql = "SELECT * FROM todo";
                    var result = await connection.QueryAsync<TodoModel>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task CreateAsyncDataLayer(TodoModel todo)
        {
            try
            {
                using var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BensTestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                {
                    var sql = "INSERT INTO todo(Title, DueDate, IsCompleted) VALUES(@Title, @DueDate, @IsCompleted)";
                    var result = await connection.ExecuteAsync(sql, todo);
              
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

