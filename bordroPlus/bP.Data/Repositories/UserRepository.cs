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

        public async Task<User> Add(User model)
        {
            _context.Users.Add(model);
            _context.SaveChangesAsync();
            return await _context.Users.FindAsync(model);
            
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
            var user = await _context.Users.FindAsync(key);

            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<User> Get(string Key)
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

        }

        public async Task<User> Get(User model)
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
            
        }

        public async Task<List<User>> Get()
        {
            return await _context.Users.ToListAsync();

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
