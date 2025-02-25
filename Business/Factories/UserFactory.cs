using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class UserFactory
{
    public static User? Map(UserEntity entity) => entity == null ? null : new User
    {
        Id = entity.Id,
        Username = entity.Username,
        FirstName = entity.FirstName,
        LastName = entity.LastName,
        Email = entity.Email,
        Password = entity.Password,
        Created = entity.Created,
        Modified = entity.Modified,
        Role = RoleFactory.Map(entity.Role),
        Employee = EmployeeFactory.Map(entity.Employee)
    };
}