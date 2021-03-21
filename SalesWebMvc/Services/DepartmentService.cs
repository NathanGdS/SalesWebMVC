using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            this._context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await this._context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
