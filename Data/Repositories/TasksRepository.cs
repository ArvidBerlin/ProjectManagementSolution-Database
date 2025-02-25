using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class TasksRepository(DataContext context) : BaseRepository<TaskEntity>(context), ITasksRepository
{
}
