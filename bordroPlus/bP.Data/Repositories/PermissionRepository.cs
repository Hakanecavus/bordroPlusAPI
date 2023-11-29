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
        public Task<Permission> Add(Permission model)
        {
            return Task.Run(async () =>
            {
                _context.Permissions.Add(model);
                _context.SaveChangesAsync();
                return await _context.Permissions.FindAsync(model);
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
                var permission = await _context.Permissions.FindAsync(key);
                _context.Permissions.Remove(permission);
                return await _context.Permissions.ToListAsync();
            });
        }

        public Task<Permission> Get(string Key)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<Permission> Get(Permission model)
        {
            return Task.Run(async () =>
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
            });
        }

        public Task<List<Permission>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Permissions.ToListAsync();
            });
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
