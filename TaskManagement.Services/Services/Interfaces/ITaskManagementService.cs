using TaskManagement.Models.Dto;
using TaskManagement.Models.Entities;
using TaskManagement.Models.Enums;

namespace TaskManagement.Services.Services.Interfaces;

public interface ITaskManagementService
{
    public Task<List<TaskEntity>> GetAll();

    public Task<List<TaskEntity>> GetAllFilteredByStatus(TaskManagementStatus status);

    public Task<TaskEntity> CreateTask(TaskDto task);

    public Task<TaskEntity?> UpdateStauts(int id, TaskManagementStatus status);
}
