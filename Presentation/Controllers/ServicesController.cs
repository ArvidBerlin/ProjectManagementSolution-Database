using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServicesController(IServiceService serviceService) : ControllerBase
{
    private readonly IServiceService _serviceService = serviceService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _serviceService.GetServicesAsync();
        return Ok(result);
    }
}
