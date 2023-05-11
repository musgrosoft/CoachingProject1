using Microsoft.EntityFrameworkCore;

namespace CoachingProject1;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> option)
        : base(option) { }

    public DbSet<Todo> Todos => Set<Todo>();
}