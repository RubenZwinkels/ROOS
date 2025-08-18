using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using System;

namespace roosapp.data;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

        // Zorg dat dit hetzelfde pad is als in MauiProgram.cs
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dataContext.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");

        return new DataContext(optionsBuilder.Options);
    }
}
