using Microsoft.EntityFrameworkCore;
using StaffView.Data.Models;
using StaffView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Data.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private StaffViewContext _context;
        public EmployeeRepository(StaffViewContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employee.ToListAsync();
        }
    }
}
