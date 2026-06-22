using Microsoft.EntityFrameworkCore;
using TaskManagement.Models.Entities;
using TaskManagement.Models.Enums;

namespace TaskManagement.Services.Repositories;

public class TaskRepository(TaskManagementDatabaseContext taskManagementDatabaseContext)
    : EntityRepository<TaskEntity>(taskManagementDatabaseContext), ITaskRepository
{
    public async Task<List<TaskEntity>> GetAllFilteredByStatus(TaskManagementStatus status)
    {
        return await taskManagementDatabaseContext
            .Set<TaskEntity>()
            .Where(entity => entity.Status == status)
            .ToListAsync();
    }

    public async Task<TaskEntity?> UpdateStauts(int id, TaskManagementStatus status)
    {
        TaskEntity? taskEntity = await taskManagementDatabaseContext
            .Set<TaskEntity>()
            .Where(taskEntity => taskEntity.Id == id)
            .FirstOrDefaultAsync();

        if (taskEntity != null)
        {
            taskEntity.Status = status;

            taskManagementDatabaseContext.Set<TaskEntity>().Update(taskEntity);

            await taskManagementDatabaseContext.SaveChangesAsync();

        }

        return taskEntity;
    }
}
