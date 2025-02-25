using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class InvoiceFactory
{
    public static Invoice? Map(InvoiceEntity entity) => entity == null ? null : new Invoice
    {
        Id = entity.Id,
        Project = ProjectFactory.Map(entity.Project),
        Customer = CustomerFactory.Map(entity.Customer),
        Amount = entity.Amount,
        InvoiceDate = entity.InvoiceDate,
        DueDate = entity.DueDate,
        IsPaid = entity.IsPaid
    };
}
