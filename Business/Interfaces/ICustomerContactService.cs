using Business.Models;

namespace Business.Interfaces;

public interface ICustomerContactService
{
    Task<IEnumerable<CustomerContact?>> GetCustomerContactsAsync();
}