using Microsoft.EntityFrameworkCore;
using Greeting_App.Models;

namespace Greeting_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Mapping model to a database table named 'TodoTasks'
        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}