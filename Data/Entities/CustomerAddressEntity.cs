namespace Data.Entities;

public class CustomerAddressEntity
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; } = null!;

    public int PostalCodeId { get; set; }
    public PostalCodeEntity PostalCode { get; set; } = null!;

    public string Street { get; set; } = null!;
}
