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
        public Task<Company> Add(Company model)
        {
            return Task.Run(async () =>
            {
                _context.Companies.Add(model);
                _context.SaveChangesAsync();
                return await _context.Companies.FindAsync(model);
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
                var company = await _context.Companies.FindAsync(key);
                _context.Companies.Remove(company);
                return await _context.Companies.ToListAsync();
            });
        }

        public Task<Company> Get(string Key)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<Company> Get(Company model)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<List<Company>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Companies.ToListAsync();
            });
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
