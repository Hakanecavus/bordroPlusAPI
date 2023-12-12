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
        public async Task<CompanyBranch> Add(CompanyBranch model)
        {
            _context.CompanyBranches.Add(model);
            await _context.SaveChangesAsync();
            return await _context.CompanyBranches.FindAsync(model.Id);
            
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
            var branch = await _context.CompanyBranches.FindAsync(key);

            if (branch != null)
            {
                _context.CompanyBranches.Remove(branch);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<CompanyBranch> Get(string Key)
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
            
        }

        public async Task<CompanyBranch> Get(CompanyBranch model)
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
        }

        public async Task<List<CompanyBranch>> Get()
        {
            return await _context.CompanyBranches.ToListAsync();
            
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
