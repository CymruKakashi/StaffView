using StaffView.Data.Models;
using StaffView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _repo.GetAllEmployeesAsync();
        }
    }
}
