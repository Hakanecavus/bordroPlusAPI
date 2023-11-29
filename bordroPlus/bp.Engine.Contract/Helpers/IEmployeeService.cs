using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface IEmployeeService
    {
        Task<Employee> newEmployee(Employee employee);
        Task<List<Employee>> getEmployees();
        Task<Employee> getEmployee(long id);
        Task deleteEmployee(long id);
    }
}
