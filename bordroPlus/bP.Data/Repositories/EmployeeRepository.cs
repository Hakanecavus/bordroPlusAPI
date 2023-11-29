using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using bP.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly AppDBContext _context;
        public EmployeeRepository(AppDBContext context)
        {
            _context = context;
        }

        public Task<Employee> Add(Employee model)
        {
            return Task.Run(async () =>
            {
                _context.Employees.Add(model);
                _context.SaveChangesAsync();
                return await _context.Employees.FindAsync(model);
            });
        }

        public Task Cancel(string Key)
        {
            throw new NotImplementedException();
        }

        public Task Close(string key)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string key)
        {
            return Task.Run(async () =>
            {
                var employee = await _context.Employees.FindAsync(key);
                _context.Employees.Remove(employee);
                return await _context.Employees.ToListAsync();
            });
        }

        public Task<Employee> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var employee = await _context.Employees.FindAsync(Key);
                if (employee == null)
                {
                    return null;
                }
                else
                {
                    return employee;
                }
            });
        }

        public Task<Employee> Get(Employee model)
        {
            return Task.Run(async () =>
            {
                var employee = await _context.Employees.FindAsync(model);
                if (employee == null)
                {
                    return null;
                }
                else
                {
                    return employee;
                }
            });
        }

        public Task<List<Employee>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Employees.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Employee model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdatePut(Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
