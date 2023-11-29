using bp.Engine.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bordroPlus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        public Task<Employee> newEmployee(Employee employee)
        {
            try
            {
                return _employeeService.newEmployee(employee);
            }
            catch (Exception ex) { throw ex; }
            
        }

        [HttpGet]
        public Task<Employee> getEmployee(long id)
        {
            try
            {
                return _employeeService.getEmployee(id);
            }
            catch(Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<Employee>> getEmployees() {
            try
            {
                return _employeeService.getEmployees();
            }
            catch(Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task DeleteEmployee(long id)
        {
            try
            {
                return _employeeService.deleteEmployee(id);
            }
            catch(Exception ex) { throw ex; }   
        }

    }
}
