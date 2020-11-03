using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StaffView.Data.Models;
using StaffView.DataTransferModels;
using StaffView.Interfaces;

namespace StaffView.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : BaseApiController
    {

        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _service;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                IEnumerable<Employee> employees = await _service.GetAllEmployeesAsync();
                return Ok(employees);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error getting Products. Exception: {e}");
                return ServerError(new MessageResponse() { Message = "Unexpected error has occurred" });
            }
        }
    }
}
