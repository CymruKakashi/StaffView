using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.DataTransferModels
{
    public class ImportEmployee
    {
        public int Nodeid { get; set; }
        public string Parent { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmployeeTitle { get; set; }
        public string Location { get; set; }
        public int DeskNumber { get; set; }
        public bool OutOfOffice { get; set; }
    }
}
