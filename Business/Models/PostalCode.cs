namespace Business.Models;

public class PostalCode
{
    public int Id { get; set; }
    public string PostalCodeValue { get; set; } = null!;
    public string City { get; set; } = null!;
}
