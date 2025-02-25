using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class CustomerAddressService(ICustomerAddessRepository customerAddessRepository) : ICustomerAddressService
{
    private readonly ICustomerAddessRepository _customerAddessRepository = customerAddessRepository;

    public async Task<IEnumerable<CustomerAddress?>> GetCustomerAddressesAsync()
    {
        var entities = await _customerAddessRepository.GetAllAsync();
        return entities.Select(CustomerAddressFactory.Map);
    }
}

