using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StaffView.Data.Models;
using StaffView.DataTransferModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Data
{
    public class DbInit
    {
        public static void Initialize(StaffViewContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employee.Any())
            {
                return;
            }
            List<ImportEmployee> employees;
            using (StreamReader reader = new StreamReader("Data\\data.json"))
            {
                string json = reader.ReadToEnd();
                employees = JsonConvert.DeserializeObject<List<ImportEmployee>>(json);
            }
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Employee ON;");
                    foreach (ImportEmployee employee in employees)
                    {
                        //Increment the Nodeid and the Parent fields as 0 in an identity column causes an error
                        employee.Nodeid++;
                        bool conversion = Int32.TryParse(employee.Parent, out int result);
                        //would use automapper instead of manual mapping
                        var dbEmployee = new Employee
                        {
                            Nodeid = employee.Nodeid,
                            Parent = null,
                            Firstname = employee.Firstname,
                            Lastname = employee.Lastname,
                            EmployeeTitle = employee.EmployeeTitle,
                            Location = employee.Location,
                            DeskNumber = employee.DeskNumber,
                            OutOfOffice = employee.OutOfOffice
                        };
                        if (conversion) {
                            dbEmployee.Parent = (result+1);
                        }
                        context.Employee.Add(dbEmployee);
                    }
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally {
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Employee OFF;");
                }
            }
  
        }
    }
}
