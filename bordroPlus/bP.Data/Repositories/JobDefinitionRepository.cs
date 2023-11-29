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
    public class JobDefinitionRepository : IJobDefinitionRepository
    {
        public readonly AppDBContext _context;
        public JobDefinitionRepository(AppDBContext context)
        {
            _context = context;
        }
        public Task<JobDefinition> Add(JobDefinition model)
        {
            return Task.Run(async () =>
            {
                _context.JobDefinitions.Add(model);
                _context.SaveChangesAsync();
                return await _context.JobDefinitions.FindAsync(model);
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
                var jobDefinition = await _context.JobDefinitions.FindAsync(key);
                _context.JobDefinitions.Remove(jobDefinition);
                return await _context.JobDefinitions.ToListAsync();
            });
        }

        public Task<JobDefinition> Get(string Key)
        {
            return Task.Run(async () =>
            {
                var jobDefinition = await _context.JobDefinitions.FindAsync(Key);
                if (jobDefinition == null)
                {
                    return null;
                }
                else
                {
                    return jobDefinition;
                }
            });
        }

        public Task<JobDefinition> Get(JobDefinition model)
        {
            return Task.Run(async () =>
            {
                var jobDefinition = await _context.JobDefinitions.FindAsync(model);
                if (jobDefinition == null)
                {
                    return null;
                }
                else
                {
                    return jobDefinition;
                }
            });
        }

        public Task<List<JobDefinition>> Get()
        {
            return Task.Run(async () =>
            {
                return await _context.JobDefinitions.ToListAsync();
            });
        }

        public Task Update(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }

        public Task Update(JobDefinition model)
        {
            throw new NotImplementedException();
        }

        public Task Update(string Key, Dictionary<string, string> model)
        {
            throw new NotImplementedException();
        }

        public Task<JobDefinition> UpdatePut(JobDefinition model)
        {
            throw new NotImplementedException();
        }
    }
}
