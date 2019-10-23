using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SallesWebMVC.Models;

namespace SallesWebMVC.Services
{
    public class SellerService 
    {
        private readonly SallesWebMVCContext _context;
        
        public SellerService(SallesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(seller => seller.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
