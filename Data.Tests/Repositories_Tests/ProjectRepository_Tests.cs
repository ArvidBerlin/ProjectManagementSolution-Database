using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ProjectRepository_Tests
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
    public async Task AddAsync_Should_AddAndReturnProject()
    {
        // Arrange
        var context = GetDataContext();

        context.Statuses.AddRange(TestData.StatusEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManagers.AddRange(TestData.ProjectManagerEntities);
        context.Services.AddRange(TestData.ServiceEntities);
        context.ProjectTypes.AddRange(TestData.ProjectTypeEntities);
        

        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);

        var projectEntity = TestData.ProjectEntities[0];

        // Act
        var result = await repository.AddAsync(projectEntity);

        // Assert
        Assert.NotEqual(0, result!.Id);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAllProjects()
    {
        // Arrange
        var context = GetDataContext();

        context.Statuses.AddRange(TestData.StatusEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManagers.AddRange(TestData.ProjectManagerEntities);
        context.Services.AddRange(TestData.ServiceEntities);
        context.ProjectTypes.AddRange(TestData.ProjectTypeEntities);
        context.Projects.AddRange(TestData.ProjectEntities);

        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);

        // Act
        var result = await repository.GetAllAsync();

        // Assert
        Assert.Equal(TestData.ProjectEntities.Length, result.Count());
    }

    [Fact]
    public async Task GetAsync_ShouldReturnProject()
    {
        // Arrange
        var context = GetDataContext();

        context.Statuses.AddRange(TestData.StatusEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManagers.AddRange(TestData.ProjectManagerEntities);
        context.Services.AddRange(TestData.ServiceEntities);
        context.ProjectTypes.AddRange(TestData.ProjectTypeEntities);
        context.Projects.AddRange(TestData.ProjectEntities);

        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);

        // Act
        var result = await repository.GetAsync(x => x.Id == 1);

        // Assert
        Assert.Equal(1, result!.Id);
    }

    [Fact]
    public async Task UpdateAsync_ShouldUpdateProject()
    {
        // Arrange
        var context = GetDataContext();

        context.Statuses.AddRange(TestData.StatusEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManagers.AddRange(TestData.ProjectManagerEntities);
        context.Services.AddRange(TestData.ServiceEntities);
        context.ProjectTypes.AddRange(TestData.ProjectTypeEntities);
        context.Projects.AddRange(TestData.ProjectEntities);

        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);

        var existingProject = TestData.ProjectEntities.First();
        var updatedProject = existingProject;
        updatedProject.ProjectName = "Updated Project Name";

        // Act
        await repository.UpdateAsync(updatedProject);
        var result = await repository.GetAsync(x => x.Id == existingProject.Id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Updated Project Name", result.ProjectName);
    }

    [Fact]
    public async Task RemoveAsync_ShouldRemoveProject()
    {
        // Arrange
        var context = GetDataContext();

        context.Statuses.AddRange(TestData.StatusEntities);
        context.Customers.AddRange(TestData.CustomerEntities);
        context.ProjectManagers.AddRange(TestData.ProjectManagerEntities);
        context.Services.AddRange(TestData.ServiceEntities);
        context.ProjectTypes.AddRange(TestData.ProjectTypeEntities);
        context.Projects.AddRange(TestData.ProjectEntities);

        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);

        var projectToRemove = await context.Projects.FindAsync(1);
        Assert.NotNull(projectToRemove); 

        // Act
        await repository.RemoveAsync(projectToRemove);

        // Assert 
        var deletedProject = await context.Projects.FindAsync(1);
        Assert.Null(deletedProject);
    }
}

/*

        var projectToRemove = TestData.ProjectEntities.First();

        // Act
        await repository.RemoveAsync(projectToRemove);
        var result = await repository.GetAsync(x => x.Id == projectToRemove.Id);

        // Assert
        Assert.Null(result);

*/