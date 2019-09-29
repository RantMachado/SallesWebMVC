using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesWebMVC.Models
{
    public class SallesWebMVCContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

        public SallesWebMVCContext (DbContextOptions<SallesWebMVCContext> options) : base(options)
        {
        }
    }
}
