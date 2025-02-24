namespace Business.Models;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
}
