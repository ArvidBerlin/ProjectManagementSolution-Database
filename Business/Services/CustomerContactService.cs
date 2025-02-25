using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CustomerContactService(ICustomerContactRepository customerContactRepository) : ICustomerContactService
{
    private readonly ICustomerContactRepository _customerContactRepository = customerContactRepository;

    public async Task<IEnumerable<CustomerContact?>> GetCustomerContactsAsync()
    {
        var entities = await _customerContactRepository.GetAllAsync();
        return entities.Select(CustomerContactFactory.Map);
    }
}
