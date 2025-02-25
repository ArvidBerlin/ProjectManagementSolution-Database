using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class TasksService(ITasksRepository tasksRepository) : ITasksService
{
    private readonly ITasksRepository _tasksRepository = tasksRepository;

    public async Task<IEnumerable<Tasks?>> GetTasksAsync()
    {
        var entities = await _tasksRepository.GetAllAsync();
        return entities.Select(TasksFactory.Map);
    }
}
