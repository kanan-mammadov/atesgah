using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Loan> Loan { get; set; }

        public DbSet<Invoices> Invoices { get; set; }
    }
}
