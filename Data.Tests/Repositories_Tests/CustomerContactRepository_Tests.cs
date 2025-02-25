﻿using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CustomerContactRepository_Tests
{
    private DataContext GetDataContext()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new DataContext(options);
        context.Database.EnsureCreated();
        return context;
    }

    [Fact]
    public async Task GetCustomerContactsAsync_ShouldReturnAllCustomerContacts()
    {
        // Arrange
        var context = GetDataContext();
        context.CustomerContacts.AddRange(TestData.CustomerContactEntities);
        await context.SaveChangesAsync();

        ICustomerContactRepository repository = new CustomerContactRepository(context);

        // Act
        var result = await repository.GetAllAsync();

        // Assert
        Assert.Equal(TestData.CustomerContactEntities.Length, result.Count());
    }
}
