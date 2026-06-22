using TaskManagement.Models.Entities;
using TaskManagement.Models.Enums;
using TaskManagement.Services.Repositories.Interfaces;

namespace TaskManagement.Services.Repositories;

public interface ITaskRepository : IEntityRepository<TaskEntity>
{
    public Task<List<TaskEntity>> GetAllFilteredByStatus(TaskManagementStatus status);
    Task<TaskEntity?> UpdateStauts(int id, TaskManagementStatus status);
}
