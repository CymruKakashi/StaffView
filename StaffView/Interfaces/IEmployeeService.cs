﻿using StaffView.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }
}
