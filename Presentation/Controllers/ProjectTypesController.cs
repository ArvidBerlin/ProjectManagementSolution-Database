﻿using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectTypesController(IProjectTypeService projectTypeService) : ControllerBase
{ 
    private readonly IProjectTypeService _projectTypeService = projectTypeService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _projectTypeService.GetProjectTypesAsync();
        return Ok(result);
    }
}
