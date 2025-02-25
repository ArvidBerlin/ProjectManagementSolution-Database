using Business.Models;

namespace Business.Interfaces;

public interface IProjectService
{
    Task<Project?> CreateProjectAsync(ProjectRegistrationForm form);
    Task<IEnumerable<Project?>> GetProjectsAsync();
    Task<Project?> GetProjectAsync(int id);
    Task<bool> UpdateProjectAsync(Project project);
    Task<bool> RemoveProjectAsync(Project project);
}