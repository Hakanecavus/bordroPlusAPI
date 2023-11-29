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
    public class VacationRepository : IVacationRepository
    {
        public readonly AppDBContext _context;
        public VacationRepository(AppDBContext context)
        {
            _context = context;
        }
        public Task<Vacation> Add(Vacation model)
        {
            return Task.Run(async () =>
            {
                _context.Vacations.Add(model);
                _context.SaveChangesAsync();
                return await _context.Vacations.FindAsync(model);
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
                var vacation = await _context.Vacations.FindAsync(key);
                _context.Vacations.Remove(vacation);
                return await _context.Vacations.ToListAsync();
            });
        }

        public Task<Vacation> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var vacation = await _context.Vacations.FindAsync(Key);
                if (vacation == null)
                {
                    return null;
                }
                else
                {
                    return vacation;
                }
            });
        }

        public Task<Vacation> Get(Vacation model)
        {
            return Task.Run(async () =>
            {
                var vacation = await _context.Vacations.FindAsync(model);
                if (vacation == null)
                {
                    return null;
                }
                else
                {
                    return vacation;
                }
            });
        }

        public Task<List<Vacation>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.Vacations.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(Vacation model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<Vacation> UpdatePut(Vacation model)
        {
            throw new NotImplementedException();
        }
    }
}
