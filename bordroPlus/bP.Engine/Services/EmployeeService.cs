using bp.Engine.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Engine.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IConfiguration _configuration;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IConfiguration configuration, IEmployeeRepository employeeRepository)
        {
            _configuration = configuration;
            _employeeRepository = employeeRepository;
        }

        public Task<Employee> newEmployee(Employee employee)
        {
            return _employeeRepository.Add(employee);
        }
        public Task<List<Employee>> getEmployees()
        {
            return _employeeRepository.Get();
        }
        public Task<Employee> getEmployee(long id)
        {
            return _employeeRepository.Get(id.ToString());
        }

        public Task deleteEmployee(long id)
        {
            return _employeeRepository.Delete(id.ToString());
        }
    }
}
