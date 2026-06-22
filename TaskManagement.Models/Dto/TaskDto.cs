using TaskManagement.Models.Enums;

namespace TaskManagement.Models.Dto;

public class TaskDto
{
    public required string Title { get; set; }

    public string? Description { get; set; }

    public required TaskManagementStatus Status { get; set; }
}