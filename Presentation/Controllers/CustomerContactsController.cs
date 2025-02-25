using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerContactsController(ICustomerContactService customerContactService) : ControllerBase
{
    private readonly ICustomerContactService _customerContactService = customerContactService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _customerContactService.GetCustomerContactsAsync();
        return Ok(result);
    }
}
