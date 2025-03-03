﻿using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvoicesController(IInvoiceService invoiceService) : ControllerBase
{
    private readonly IInvoiceService _invoiceService = invoiceService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _invoiceService.GetInvoicesAsync();
        return Ok(result);
    }
}
