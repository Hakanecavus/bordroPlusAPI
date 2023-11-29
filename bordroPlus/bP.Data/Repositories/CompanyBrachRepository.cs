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
    public class CompanyBrachRepository : ICompanyBrachRepository
    {
        public readonly AppDBContext _context;
        public CompanyBrachRepository(AppDBContext context)
        {
            _context = context;
        }
        public Task<CompanyBranch> Add(CompanyBranch model)
        {
            return Task.Run(async () =>
            {
                _context.CompanyBranches.Add(model);
                _context.SaveChangesAsync();
                return await _context.CompanyBranches.FindAsync(model);
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
                var company = await _context.CompanyBranches.FindAsync(key);
                _context.CompanyBranches.Remove(company);
                return await _context.CompanyBranches.ToListAsync();
            });
        }

        public Task<CompanyBranch> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var company = await _context.CompanyBranches.FindAsync(Key);
                if (company == null)
                {
                    return null;
                }
                else
                {
                    return company;
                }
            });
        }

        public Task<CompanyBranch> Get(CompanyBranch model)
        {
            return Task.Run(async () =>
            {
                var company = await _context.CompanyBranches.FindAsync(model);
                if (company == null)
                {
                    return null;
                }
                else
                {
                    return company;
                }
            });
        }

        public Task<List<CompanyBranch>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.CompanyBranches.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(CompanyBranch model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyBranch> UpdatePut(CompanyBranch model)
        {
            throw new NotImplementedException();
        }
    }
}
