using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCrud.Models.Context
{
    public class AppDbContext :DbContext
        
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
