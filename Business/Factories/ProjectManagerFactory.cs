using Business.Models;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Business.Factories;

public static class ProjectManagerFactory
{
    public static ProjectManager? Map(ProjectManagerEntity entity) => entity == null ? null : new ProjectManager
    {
        Id = entity.Id,
        Employee = EmployeeFactory.Map(entity.Employee)
    };
}
