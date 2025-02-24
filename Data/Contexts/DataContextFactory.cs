﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Databasteknik\\Projects\\ProjectDatabase\\ProjectManagement\\Data\\Contexts\\Databases\\local_database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        return new DataContext(optionsBuilder.Options);
    }
}
