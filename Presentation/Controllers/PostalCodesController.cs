using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostalCodesController(IPostalCodeService postalCodeService) : ControllerBase
{
    private readonly IPostalCodeService _postalCodeService = postalCodeService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var reuslt = await _postalCodeService.GetPostalCodesAsync();
        return Ok(reuslt);
    }
}
