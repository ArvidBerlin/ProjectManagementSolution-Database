namespace Data.Entities;

public class CustomerEntity
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = null!;

    public ICollection<CustomerAddressEntity> CustomerAddresses { get; set; } = [];
    public ICollection<CustomerContactEntity> CustomerContacts { get; set; } = [];
    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
