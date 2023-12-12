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
    public class CompanyRepository : ICompanyRepository
    {
        public readonly AppDBContext _context;
        public CompanyRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Company> Add(Company model)
        {
            _context.Companies.Add(model);
            await _context.SaveChangesAsync();
            return await _context.Companies.FindAsync(model.Id);
            
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
            var company = await _context.Companies.FindAsync(key);

            if (company != null)
            {
                _context.Companies.Remove(company);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<Company> Get(string Key)
        {
            var company = await _context.Companies.FindAsync(Key);

            if (company == null)
            {
                return null;
            }
            else
            {
                return company;
            }
            
        }

        public async Task<Company> Get(Company model)
        {
            var company = await _context.Companies.FindAsync(model);

            if (company == null)
            {
                return null;
            }
            else
            {
                return company;
            }
        }

        public async Task<List<Company>> Get()
        {
            return await _context.Companies.ToListAsync();
            
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Company model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdatePut(Company model)
        {
            throw new NotImplementedException();
        }
    }
}
