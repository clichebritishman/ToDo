using Microsoft.EntityFrameworkCore;
using TaskManagement.Models.Entities;

namespace TaskManagement.Services;

public class TaskManagementDatabaseContext : DbContext
{
    public DbSet<TaskEntity> Tasks { get; set; }

    public TaskManagementDatabaseContext(DbContextOptions<TaskManagementDatabaseContext> options) 
        : base(options)
    {
    }
}
