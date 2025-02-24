using Data.Entities;

namespace Business.Models;

public class CustomerAddress
{
    public int Id { get; set; }

    public Customer? Customer { get; set; } = null!;
    public PostalCode? PostalCode { get; set; } = null!;

    public string Street { get; set; } = null!;
}
