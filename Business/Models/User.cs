using Data.Entities;

namespace Business.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public Role? Role { get; set; } = null!;
    public Employee? Employee { get; set; } = null!;
}
