using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectManagersController(IProjectManagerService projectManagerService) : ControllerBase
{
    private readonly IProjectManagerService _projectManagerService = projectManagerService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _projectManagerService.GetProjectManagersAsync();
        return Ok(result);
    }
}
