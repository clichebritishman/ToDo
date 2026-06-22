using System.ComponentModel.DataAnnotations;
using TaskManagement.Models.Enums;

namespace TaskManagement.Models.Entities;

public class TaskEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Title { get; set; }

    public string? Description { get; set; }

    [Required]
    public TaskManagementStatus Status { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }
}
