namespace Data.Entities;

public class ServiceEntity
{
    public int Id { get; set; }
    public string ServiceName { get; set; } = null!;
    public decimal PricePerHour { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
