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

            SalesRecord r01 = new SalesRecord(01, new DateTime(2018, 04, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r02 = new SalesRecord(02, new DateTime(2018, 05, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r03 = new SalesRecord(03, new DateTime(2018, 05, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r04 = new SalesRecord(04, new DateTime(2018, 05, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r05 = new SalesRecord(05, new DateTime(2018, 06, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r06 = new SalesRecord(06, new DateTime(2018, 07, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r07 = new SalesRecord(07, new DateTime(2018, 08, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r08 = new SalesRecord(08, new DateTime(2018, 09, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r09 = new SalesRecord(09, new DateTime(2018, 10, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 11, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 11, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 12, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 12, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 12, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 01, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 02, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 03, 22), 1100.0, SaleStatus.Canceled, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 03, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 04, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 05, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 06, 19), 100.0, SaleStatus.Pending, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 06, 30), 1239.0, SaleStatus.Canceled, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 07, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 08, 22), 450.5, SaleStatus.Billed, s1);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 09, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 10, 30), 1239.0, SaleStatus.Billed, s3);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 11, 02), 239.9, SaleStatus.Billed, s4);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 11, 22), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 12, 19), 1350.0, SaleStatus.Pending, s2);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 12, 30), 1239.0, SaleStatus.Pending, s3);
            
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(
                r01, r02, r03, r04, r05, r06, r07, r08, r09, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            _context.SaveChanges();
        }
    }
}
