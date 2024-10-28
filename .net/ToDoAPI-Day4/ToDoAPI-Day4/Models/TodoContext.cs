using Microsoft.EntityFrameworkCore;
using ToDoAPI_Day4.Models;

namespace ToDoAPI_Day4.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
