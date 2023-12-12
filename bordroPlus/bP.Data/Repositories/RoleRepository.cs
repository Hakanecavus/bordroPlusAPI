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
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDBContext _context;
        public RoleRepository(AppDBContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<Role> Add(Role model)
        {
            _context.Roles.Add(model);
            _context.SaveChangesAsync();
            return await _context.Roles.FindAsync(model);
            
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
            var role = await _context.Roles.FindAsync(key);

            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<Role> Get(string Key)
        {
            var role = await _context.Roles.FindAsync(Key);
            if (role == null)
            {
                return null;
            }
            else
            {
                return role;
            }
        }

        public async Task<Role> Get(Role model)
        {
            var role = await _context.Roles.FindAsync(model);
            if (role == null)
            {
                return null;
            }
            else
            {
                return role;
            }
        }

        public async Task<List<Role>> Get()
        {
            return await _context.Roles.ToListAsync();
            
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Role model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdatePut(Role model)
        {
            throw new NotImplementedException();
        }
    }
}
