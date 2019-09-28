using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SallesWebMVC.Models;
using SallesWebMVC.Models.Enums;

namespace SallesWebMVC.Data
{
    public class SeedingService 
    {
        private SallesWebMVCContext _context;

        public SeedingService(SallesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Randolfo", "rant@unicode.com", new DateTime(1992, 06, 12), 1200.0, d1);
            Seller s2 = new Seller(2, "Emili", "emili@silicio.com", new DateTime(1996, 06, 03), 1250.0, d2);
            Seller s3 = new Seller(3, "Rhael", "rha@fashionic.com", new DateTime(2018, 07, 23), 1220.0, d3);
            Seller s4 = new Seller(4, "Vivi", "vivi@bookholic.com", new DateTime(2015, 10, 27), 1230.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 05, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 05, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 05, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 05, 02), 239.9, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();
        }
    }
}
