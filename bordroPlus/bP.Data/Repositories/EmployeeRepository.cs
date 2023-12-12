using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using bP.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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

        public async Task<Employee> Add(Employee model)
        {
            _context.Employees.Add(model);
            await _context.SaveChangesAsync();
            return await _context.Employees.FindAsync(model.Id);
        }

        public Task Cancel(string Key)
        {
            throw new NotImplementedException();
        }

        public Task Close(string key)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string key)
        {
            var employee = await _context.Employees.FindAsync(key);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<Employee> Get(string Key)
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
        }

        public async Task<Employee> Get(Employee model)
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
        }

        public async Task<List<Employee>> Get()
        {
            return await _context.Employees.ToListAsync();
            
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
