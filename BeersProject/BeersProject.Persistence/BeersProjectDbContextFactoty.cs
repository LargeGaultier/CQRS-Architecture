using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeersProject.Persistence
{
    public class BeersProjectDbContextFactoty : IDesignTimeDbContextFactory<BeersProjectDbContext>
    {
        public BeersProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BeersProjectDbContext>();
            optionsBuilder.UseSqlite("Data Source=BeersProject.db");

            return new BeersProjectDbContext(optionsBuilder.Options);
        }
    }
}
