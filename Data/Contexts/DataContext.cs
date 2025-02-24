using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected DataContext()
    {
    }

    public DbSet<CustomerAddressEntity> CustomerAddresses { get; set; }
    public DbSet<CustomerContactEntity> CustomerContacts { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<InvoiceEntity> Invoices { get; set; }
    public DbSet<PostalCodeEntity> PostalCodes { get; set; }
    public DbSet<ProjectEntity> Projects { get; set; }
    public DbSet<ProjectManagerEntity> ProjectManagers { get; set; }
    public DbSet<ProjectTypeEntity> ProjectTypes { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<ServiceEntity> Services { get; set; }
    public DbSet<StatusEntity> Statuses { get; set; }
    public DbSet<TaskAssignmentEntity> TaskAssignments { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Hjälp från ChatGTP, främst med OnDelete-behavior

        modelBuilder.Entity<TaskAssignmentEntity>()
            .HasKey(ta => ta.Id);

        modelBuilder.Entity<TaskAssignmentEntity>()
            .HasOne(ta => ta.Employee)
            .WithMany()
            .HasForeignKey(ta => ta.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<TaskAssignmentEntity>()
            .HasOne(ta => ta.Task)
            .WithMany(ta => ta.TaskAssignments)
            .HasForeignKey(ta => ta.TaskId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CustomerAddressEntity>()
            .HasOne(ca => ca.Customer)
            .WithMany()
            .HasForeignKey(ca => ca.CustomerId);

        modelBuilder.Entity<InvoiceEntity>()
        .HasOne(i => i.Project)
        .WithMany() 
        .HasForeignKey(i => i.ProjectId)
        .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<InvoiceEntity>()
            .HasOne(i => i.Customer)
            .WithMany()
            .HasForeignKey(i => i.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<UserEntity>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<UserEntity>()
        .HasOne(u => u.Role)
        .WithMany()
        .HasForeignKey(u => u.RoleId)
        .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<UserEntity>()
            .HasOne(u => u.Employee)
            .WithMany()
            .HasForeignKey(u => u.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
