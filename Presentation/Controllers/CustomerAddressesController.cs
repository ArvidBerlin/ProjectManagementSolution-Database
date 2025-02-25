using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerAddressesController(ICustomerAddressService customerAddressService) : ControllerBase
{
    private readonly ICustomerAddressService _customerAddressService = customerAddressService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _customerAddressService.GetCustomerAddressesAsync();
        return Ok(result);
    }
}
