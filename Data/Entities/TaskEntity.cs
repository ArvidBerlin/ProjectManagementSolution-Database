namespace Data.Entities;

public class TaskEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }

    public ICollection<TaskAssignmentEntity> TaskAssignments { get; set; } = [];
}
