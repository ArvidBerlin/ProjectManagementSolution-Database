﻿using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using System.Diagnostics;
using System.Formats.Asn1;

namespace Business.Services;

public class ProjectService(IProjectRepository projectRepository) : IProjectService
{
    private readonly IProjectRepository _projectRepository = projectRepository;

    public async Task<Project?> CreateProjectAsync(ProjectRegistrationForm form)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(form);

            var projectEntity = ProjectFactory.Map(form);

            if (projectEntity == null)
                return null;

            projectEntity = await _projectRepository.AddAsync(projectEntity);

            if (projectEntity == null)
                return null;

            var project = ProjectFactory.Map(projectEntity);
            return project;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<IEnumerable<Project?>> GetProjectsAsync()
    {
        var projectEntities = await _projectRepository.GetAllAsync();
        var projects = projectEntities.Select(ProjectFactory.Map);
        return projects;
    }

    public async Task<Project?> GetProjectAsync(int id)
    {
        var projectEntity = await _projectRepository.GetAsync(p => p.Id == id);
        if (projectEntity == null)
            return null;

        var project = ProjectFactory.Map(projectEntity);
        return project;
    }

    public async Task<bool> UpdateProjectAsync(ProjectUpdateForm form)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(form);

            var existingProject = await _projectRepository.GetAsync(x => x.Id == form.Id);

            if (existingProject == null)
                return false; 

            ProjectFactory.Map(existingProject, form);

            var result = await _projectRepository.UpdateAsync(existingProject);
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public async Task<bool> RemoveProjectAsync(Project project)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(project);

            var projectEntity = ProjectFactory.Map(project);

            if (projectEntity == null)
                return false;

            var result = await _projectRepository.RemoveAsync(projectEntity);
            return result;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}
