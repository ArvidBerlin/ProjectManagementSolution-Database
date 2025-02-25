using Data.Entities;

namespace Data.Tests.SeedData;

public static class TestData
{
    public static readonly CustomerAddressEntity[] CustomerAddresses =
    [
        new CustomerAddressEntity { Id = 1, CustomerId = 1, PostalCodeId = 1, Street = "Valhallavägen 146" },
        new CustomerAddressEntity { Id = 2, CustomerId = 2, PostalCodeId = 2, Street = "Odengatan 31" },
        new CustomerAddressEntity { Id = 3, CustomerId = 3, PostalCodeId = 3, Street = "Tegnérgatan 17" }
    ];

    public static readonly CustomerContactEntity[] CustomerContacts =
    [
        new CustomerContactEntity { Id = 1, CustomerId = 1, FirstName = "Arvid", LastName = "Berlin", Email = "arvid@domain.com", Phone = "0701234567" },
        new CustomerContactEntity { Id = 1, CustomerId = 1, FirstName = "Jesper", LastName = "Örnborn", Email = "jesper@domain.com", Phone = "0707654321" },
        new CustomerContactEntity { Id = 1, CustomerId = 1, FirstName = "Erik", LastName = "Essén", Email = "erik@domain.com", Phone = "0731231234" }
    ];

    public static readonly CustomerEntity[] CustomerEntities =
    [
        new CustomerEntity { Id = 1, CustomerName = "Netflix" },
        new CustomerEntity { Id = 2, CustomerName = "Amazon Prime" },
        new CustomerEntity { Id = 3, CustomerName = "Disney+" }
    ];

    public static readonly EmployeeEntity[] EmployeeEntities =
    [
        new EmployeeEntity { Id = 1, FirstName = "Arvid", LastName = "Berlin" },
        new EmployeeEntity { Id = 2, FirstName = "Jesper", LastName = "Örnborn" },
        new EmployeeEntity { Id = 3, FirstName = "Erik", LastName = "Essén" }
    ];

    public static readonly InvoiceEntity[] InvoiceEntities =
    [
        new InvoiceEntity {
            Id = 1,
            ProjectId = 1,
            CustomerId = 1,
            Amount = 10000,
            InvoiceDate = new DateTime(2025, 03, 10),
            DueDate = new DateTime(2025, 03, 20),
            IsPaid = true
        },

        new InvoiceEntity {
            Id = 2,
            ProjectId = 2,
            CustomerId = 2,
            Amount = 5000,
            InvoiceDate = new DateTime(2025, 03, 12),
            DueDate = new DateTime(2025, 03, 22),
            IsPaid = false
        },

        new InvoiceEntity {
            Id = 3,
            ProjectId = 3,
            CustomerId = 3,
            Amount = 12000,
            InvoiceDate = new DateTime(2025, 03, 21),
            DueDate = new DateTime(2025, 04, 02),
            IsPaid = false
        }
    ];

    public static readonly PostalCodeEntity[] PostalCodeEntities =
    [
        new PostalCodeEntity { Id = 1, PostalCode = "113 51", City = "Stockholm" },
        new PostalCodeEntity { Id = 2, PostalCode = "177 44", City = "Järfälla" },
        new PostalCodeEntity { Id = 1, PostalCode = "113 55", City = "Stockholm" }
    ];

    public static readonly ProjectEntity[] ProjectEntities =
    [
        new ProjectEntity {
            Id = 1,
            ProjectName = "Squid Game",
            Description = "Koreanskt thrillerdrama",
            StartDate = new DateTime(2025, 06, 27),
            EndDate = new DateTime(2025, 08, 25),
            StatusId = 1,
            CustomerId = 1,
            ProjectManagerId = 1,
            ProjectTypeId = 1
        },

        new ProjectEntity {
            Id = 1,
            ProjectName = "Silo",
            Description = "Dystopisk thriller",
            StartDate = new DateTime(2024, 11, 15),
            EndDate = new DateTime(2025, 01, 17),
            StatusId = 3,
            CustomerId = 2,
            ProjectManagerId = 2,
            ProjectTypeId = 3
        },

        new ProjectEntity {
            Id = 1,
            ProjectName = "Shogun",
            Description = "Historisk episk drama",
            StartDate = new DateTime(2024, 02, 27),
            EndDate = new DateTime(2024, 04, 23),
            StatusId = 3,
            CustomerId = 3,
            ProjectManagerId = 3,
            ProjectTypeId = 3
        }
    ];

    public static readonly ProjectManagerEntity[] ProjectManagerEntities = 
    [
        new ProjectManagerEntity { Id = 1, EmployeeId = 1 },
        new ProjectManagerEntity { Id = 2, EmployeeId = 2 },
        new ProjectManagerEntity { Id = 2, EmployeeId = 2 }
    ];

    public static readonly ProjectTypeEntity[] ProjectTypesEntities =
    [
        new ProjectTypeEntity { Id = 1, TypeName = "Preproduktion", Price = 100, PricingUnit = "Tim" },
        new ProjectTypeEntity { Id = 2, TypeName = "Postproduktion", Price = 100, PricingUnit = "Tim" },
        new ProjectTypeEntity { Id = 3, TypeName = "Övrigt", Price = 100, PricingUnit = "Stk" }
    ];

    public static readonly RoleEntity[] RoleEntities =
    [
        new RoleEntity { Id = 1, RoleName = "Producent" },
        new RoleEntity { Id = 2, RoleName = "Regissör" },
        new RoleEntity { Id = 2, RoleName = "Fotograf" }
    ];

    public static readonly ServiceEntity[] ServiceEntities =
    [
        new ServiceEntity { Id = 1, ServiceName = "Biluthyrning", PricePerHour = 800 },
        new ServiceEntity { Id = 1, ServiceName = "Manusbearbetning", PricePerHour = 1000 },
        new ServiceEntity { Id = 1, ServiceName = "Kamerauthyrning", PricePerHour = 1500 }
    ];

    public static readonly StatusEntity[] StatusEntities =
    [
        new StatusEntity { Id = 1, StatusName = "Ej påbörjad" },
        new StatusEntity { Id = 2, StatusName = "Pågår" },
        new StatusEntity { Id = 3, StatusName = "Avslutad" }
    ];

    public static readonly TaskAssignmentEntity[] TaskAssignments =
    [
        new TaskAssignmentEntity { 
            Id = 1, 
            ProjectId = 1, 
            TaskId = 1, 
            EmployeeId = 1, 
            AssignedDate = new DateTime(2025, 02, 28), 
            CompletedDate = new DateTime(2025, 03, 18) 
        },

        new TaskAssignmentEntity {
            Id = 2,
            ProjectId = 2,
            TaskId = 2,
            EmployeeId = 2,
            AssignedDate = new DateTime(2025, 03, 02),
            CompletedDate = new DateTime(2025, 04, 12)
        },

        new TaskAssignmentEntity {
            Id = 3,
            ProjectId = 3,
            TaskId = 3,
            EmployeeId = 3,
            AssignedDate = new DateTime(2025, 03, 10),
            CompletedDate = new DateTime(2025, 03, 29)
        }
    ];

    public static readonly TaskEntity[] TaskEntities =
    [
        new TaskEntity { Id = 1, Title = "Hyra bilar", Description = "Ringa till biluthyrning och boka bilar för uthyrning" },
        new TaskEntity { Id = 2, Title = "Bearbeta manus", Description = "Bearbeta och skriva om manus tillsammans med manusförfattare" },
        new TaskEntity { Id = 3, Title = "Hyra kamerutrustning", Description = "Kontakta LBM och boka prepp" }
    ];

    public static readonly UserEntity[] UserEntities =
    [
        new UserEntity { 
            Id = 1,
            Username = "arvidb",
            FirstName = "Arvid",
            LastName = "Berlin",
            Email = "arvid@domain.com",
            Password = "BytMig123!",
            Created = new DateTime(2025, 03, 01),
            Modified = new DateTime(2025, 03, 12),
            RoleId = 1,
            EmployeeId = 1
        },

        new UserEntity {
            Id = 2,
            Username = "jespero",
            FirstName = "Jesper",
            LastName = "Örnborn",
            Email = "jesper@domain.com",
            Password = "BytMig321!",
            Created = new DateTime(2025, 04, 08),
            Modified = new DateTime(2025, 04, 25),
            RoleId = 2,
            EmployeeId = 2
        },

        new UserEntity {
            Id = 2,
            Username = "erike",
            FirstName = "Erik",
            LastName = "Essén",
            Email = "erik@domain.com",
            Password = "Daligtlosen123!",
            Created = new DateTime(2025, 03, 18),
            Modified = new DateTime(2025, 04, 05),
            RoleId = 2,
            EmployeeId = 2
        }
    ];
}
