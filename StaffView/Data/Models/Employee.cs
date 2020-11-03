using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Data.Models
{
    public class Employee
    {
        [Key]
        public int Nodeid { get; set; }
        public int? Parent { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmployeeTitle { get; set; }
        public string Location { get; set; }
        public int DeskNumber { get; set; }
        public bool OutOfOffice { get; set; }
    }
}
