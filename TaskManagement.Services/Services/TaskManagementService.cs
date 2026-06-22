using TaskManagement.Models.Dto;
using TaskManagement.Models.Entities;
using TaskManagement.Models.Enums;
using TaskManagement.Services.Repositories;
using TaskManagement.Services.Services.Interfaces;

namespace TaskManagement.Services.Services;

public class TaskManagementService(ITaskRepository taskRepository) : ITaskManagementService
{
    public async Task<List<TaskEntity>> GetAllFilteredByStatus(TaskManagementStatus status) 
        => await taskRepository.GetAllFilteredByStatus(status);

    public async Task<TaskEntity> CreateTask(TaskDto task)
        => await taskRepository.Create(new TaskEntity()
        {
            Title = task.Title,
            Description = task.Description,
            Status = task.Status,
            CreatedAt = DateTime.UtcNow
        });

    public async Task<List<TaskEntity>> GetAll()
        => await taskRepository.GetAll();

    public async Task<TaskEntity?> UpdateStauts(int id, TaskManagementStatus status)
        => await taskRepository.UpdateStauts(id, status);
}