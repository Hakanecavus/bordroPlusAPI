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
        public Task<Payroll> Add(Payroll model)
        {
            return Task.Run(async () =>
            {
                _context.Payrolls.Add(model);
                _context.SaveChangesAsync();
                return await _context.Payrolls.FindAsync(model);
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
                var payroll = await _context.Payrolls.FindAsync(key);
                _context.Payrolls.Remove(payroll);
                return await _context.Payrolls.ToListAsync();
            });
        }

        public Task<Payroll> Get(string Key)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<Payroll> Get(Payroll model)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<List<Payroll>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Payrolls.ToListAsync();
            });
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
