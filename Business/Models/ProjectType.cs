using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Models;

public class ProjectType
{
    public int Id { get; set; }
    public string TypeName { get; set; } = null!;
    public decimal Price { get; set; }
    public string PricingUnit { get; set; } = null!;
}
