using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class CustomerContactFactory
{
    public static CustomerContact? Map(CustomerContactEntity entity) => entity == null ? null : new CustomerContact
    {
        Id = entity.Id,
        Customer = CustomerFactory.Map(entity.Customer),
        FirstName = entity.FirstName,
        LastName = entity.LastName,
        Email = entity.Email,
        Phone = entity.Phone
    };
}
