using Data.Entities;

namespace Business.Models;

public class ProjectManager
{
    public int Id { get; set; }

    public Employee? Employee { get; set; } = null!;
}
