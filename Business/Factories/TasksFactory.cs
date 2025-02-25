using Data.Entities;
using Business.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Business.Factories;

public static class TasksFactory
{
    public static Tasks? Map(TaskEntity entity) => entity == null ? null : new Tasks
    {
        Id = entity.Id,
        Title = entity.Title,
        Description = entity.Description
    };
}
