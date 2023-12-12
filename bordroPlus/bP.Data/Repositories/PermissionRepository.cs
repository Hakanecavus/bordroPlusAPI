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
    public class PermissionRepository : IPermissionRepository
    {
        public readonly AppDBContext _context;
        public PermissionRepository(AppDBContext context) {
            _context = context;
        }
        public async Task<Permission> Add(Permission model)
        {
            _context.Permissions.Add(model);
            _context.SaveChangesAsync();
            return await _context.Permissions.FindAsync(model);
            
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
            var permission = await _context.Permissions.FindAsync(key);

            if (permission != null)
            {
                _context.Permissions.Remove(permission);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Permission> Get(string Key)
        {
            var permission = await _context.Permissions.FindAsync(Key);
            if (permission == null)
            {
                return null;
            }
            else
            {
                return permission;
            }
        }

        public async Task<Permission> Get(Permission model)
        {
            var permission = await _context.Permissions.FindAsync(model);
            if (permission == null)
            {
                return null;
            }
            else
            {
                return permission;
            }
        }

        public async Task<List<Permission>> Get()
        {
            return await _context.Permissions.ToListAsync();
        }
        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Permission model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Permission> UpdatePut(Permission model)
        {
            throw new NotImplementedException();
        }
    }
}
