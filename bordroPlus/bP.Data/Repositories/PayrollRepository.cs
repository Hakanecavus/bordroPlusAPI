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
    public class PayrollRepository : IPayrollRepository
    {
        public readonly AppDBContext _context;
        public PayrollRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Payroll> Add(Payroll model)
        {
            _context.Payrolls.Add(model);
            _context.SaveChangesAsync();
            return await _context.Payrolls.FindAsync(model);
            
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
            var payroll = await _context.Payrolls.FindAsync(key);

            if (payroll != null)
            {
                _context.Payrolls.Remove(payroll);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<Payroll> Get(string Key)
        {
            var payroll = await _context.Payrolls.FindAsync(Key);
            if (payroll == null)
            {
                return null;
            }
            else
            {
                return payroll;
            }
            
        }

        public async Task<Payroll> Get(Payroll model)
        {
            var payroll = await _context.Payrolls.FindAsync(model);
            if (payroll == null)
            {
                return null;
            }
            else
            {
                return payroll;
            }
        }

        public async Task<List<Payroll>> Get()
        {
            return await _context.Payrolls.ToListAsync();
            
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Payroll model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Payroll> UpdatePut(Payroll model)
        {
            throw new NotImplementedException();
        }
    }
}
