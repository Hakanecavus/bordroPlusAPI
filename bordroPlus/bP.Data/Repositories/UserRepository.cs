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
    public class UserRepository : IUserRepository
    {
        public AppDBContext _context;
        public UserRepository(AppDBContext context)
        {
            _context = context;
        }

        public Task<User> Add(User model)
        {

            return Task.Run(async () =>
            {
                _context.Users.Add(model);
                _context.SaveChangesAsync();
                return await _context.Users.FindAsync(model);
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
                var user = await _context.Users.FindAsync(key);
                _context.Users.Remove(user);
                return await _context.Users.ToListAsync();
            });
        }

        public Task<User> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var user = await _context.Users.FindAsync(Key);
                if (user == null)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            });

        }

        public Task<User> Get(User model)
        {
            return Task.Run(async () =>
            {
                var user = await _context.Users.FindAsync(model);
                if (user == null)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            });
        }

        public Task<List<User>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Users.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(User model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdatePut(User model)
        {
            throw new NotImplementedException();
        }
    }
}
