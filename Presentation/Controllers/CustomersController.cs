using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController(ICustomerService customerService) : ControllerBase
{
    private readonly ICustomerService _customerService = customerService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _customerService.GetCustomersAsync();
        return Ok(result);
    }
}
