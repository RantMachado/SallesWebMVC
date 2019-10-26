using System.Linq;
using System.Collections.Generic;
using SallesWebMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SallesWebMVCContext _context;

        public DepartmentService(SallesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
