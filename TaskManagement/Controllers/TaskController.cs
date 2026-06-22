using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models.Dto;
using TaskManagement.Models.Entities;
using TaskManagement.Models.Enums;
using TaskManagement.Services.Services.Interfaces;

namespace TaskManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController(ITaskManagementService taskManagementService) : ControllerBase
{
    [EndpointDescription("List All Tasks")]
    [EndpointSummary("List All tasks with an optional filter for status")]
    [HttpGet("GetAll")]
    public async Task<ActionResult<TaskEntity>> Get([FromQuery] TaskManagementStatus? status)
    {
        try
        {
            List<TaskEntity> createdTask = new List<TaskEntity>();

            if (status != null)
            {
                createdTask = await taskManagementService.GetAllFilteredByStatus(status.Value);
            }
            else
            {
                createdTask = await taskManagementService.GetAll();
            }

            return Ok(createdTask);
        }
        catch (Exception ex)
        {
            return new StatusCodeResult(500);
        }
    }


    [EndpointDescription("Create a new task")]
    [EndpointSummary("Creates a new task with the provided details.")]
    [HttpPost("Create")]
    public async Task<ActionResult<TaskEntity>> Post(TaskDto taskDto)
    {
        if (taskDto == null)
            return new BadRequestResult();

        if (string.IsNullOrWhiteSpace(taskDto.Title))
            return new BadRequestResult();

        try
        {
            TaskEntity createdTask = await taskManagementService.CreateTask(taskDto);

            return Ok(createdTask);
        }
        catch (Exception ex)
        {
            return new StatusCodeResult(500);
        }
    }

    [EndpointDescription("Patch a task's status by id")]
    [EndpointSummary("Patch a task's status by id")]
    [HttpPatch("{id}/{status}")]
    public async Task<ActionResult<TaskEntity>> Status(int id, TaskManagementStatus status)
    {
        try
        {
            TaskEntity? createdTask = await taskManagementService.UpdateStauts(id, status);

            return Ok(createdTask);
        }
        catch (Exception ex)
        {
            return new StatusCodeResult(500);
        }
    }
}
