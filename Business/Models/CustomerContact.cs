using Data.Entities;

namespace Business.Models;

public class CustomerContact
{
    public int Id { get; set; }

    public Customer? Customer { get; set; } = null!;

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
}
