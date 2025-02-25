using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class CustomerAddressFactory
{
    public static CustomerAddress? Map(CustomerAddressEntity entity) => entity == null ? null : new CustomerAddress
    {
        Id = entity.Id,
        Customer = CustomerFactory.Map(entity.Customer),
        PostalCode = PostalCodeFactory.Map(entity.PostalCode),
        Street = entity.Street
    };
}
