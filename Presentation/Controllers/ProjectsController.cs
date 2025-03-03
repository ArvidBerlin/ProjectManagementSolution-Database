﻿using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController(IProjectService projectService) : ControllerBase
{
    private readonly IProjectService _projectService = projectService;

    [HttpPost]
    public async Task<IActionResult> CreateProject(ProjectRegistrationForm form)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var project = await _projectService.CreateProjectAsync(form);
        return project != null ? Ok(project) : BadRequest();
    }

    [HttpGet]
    public async Task<IActionResult> GetProjects()
    {
        var projects = await _projectService.GetProjectsAsync();
        return Ok(projects);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProject(int id)
    {
        var project = await _projectService.GetProjectAsync(id);
        return project != null ? Ok(project) : NotFound();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProject(int id, ProjectUpdateForm form)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updatedProject = await _projectService.UpdateProjectAsync(form);
        return updatedProject ? Ok() : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveProject(int id)
    {
        var project = await _projectService.GetProjectAsync(id);

        if (project == null)
            return NotFound();

        var deletedProject = await _projectService.RemoveProjectAsync(project);
        return deletedProject ? Ok() : BadRequest();
    }
}
