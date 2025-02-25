using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController(ITasksService tasksService) : ControllerBase
{
    private readonly ITasksService _tasksService = tasksService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _tasksService.GetTasksAsync();
        return Ok(result);
    }
}
