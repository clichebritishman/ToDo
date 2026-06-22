
using Microsoft.EntityFrameworkCore;
using TaskManagement.Services;
using TaskManagement.Services.Repositories;
using TaskManagement.Services.Services;
using TaskManagement.Services.Services.Interfaces;

namespace TaskManagement;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<TaskManagementDatabaseContext>(options =>
            options.UseInMemoryDatabase("TaskManagement"));

        builder.Services.AddTransient<ITaskManagementService, TaskManagementService>();
        builder.Services.AddTransient<ITaskRepository, TaskRepository>();

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
