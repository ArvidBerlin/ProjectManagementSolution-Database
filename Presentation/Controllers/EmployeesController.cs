using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController(IEmployeeService employeeService) : ControllerBase
{
    private readonly IEmployeeService _employeeService = employeeService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _employeeService.GetEmployeesAsync();
        return Ok(result);
    }
}
