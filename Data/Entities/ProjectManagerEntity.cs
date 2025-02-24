namespace Data.Entities;

public class ProjectManagerEntity
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public EmployeeEntity Employee { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
