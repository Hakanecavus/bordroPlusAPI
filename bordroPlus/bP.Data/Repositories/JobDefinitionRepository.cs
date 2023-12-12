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
        public async Task<JobDefinition> Add(JobDefinition model)
        {
            _context.JobDefinitions.Add(model);
            await _context.SaveChangesAsync();
            return await _context.JobDefinitions.FindAsync(model.Id);
            
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
            var jobDefinition = await _context.JobDefinitions.FindAsync(key);

            if (jobDefinition != null)
            {
                _context.JobDefinitions.Remove(jobDefinition);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<JobDefinition> Get(string Key)
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
            
        }

        public async Task<JobDefinition> Get(JobDefinition model)
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
        }

        public async Task<List<JobDefinition>> Get()
        {
            return await _context.JobDefinitions.ToListAsync();
            
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
