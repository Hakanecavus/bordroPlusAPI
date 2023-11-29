using bp.Engine.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Engine.Services
{
    public class JobDefinitionService : IJobDefinitionService
    {
        private readonly IJobDefinitionRepository _jobDefinitionRepository;
        private readonly IConfiguration _configuration;
        public JobDefinitionService(IJobDefinitionRepository jobDefinitionRepository, IConfiguration configuration)
        {
            _configuration = configuration;
            _jobDefinitionRepository = jobDefinitionRepository;
        }
        public Task deleteJobDefinition(long id)
        {
            return _jobDefinitionRepository.Delete(id.ToString());
        }

        public Task<JobDefinition> getJobDefinition(long id)
        {
            return _jobDefinitionRepository.Get(id.ToString());
        }

        public Task<List<JobDefinition>> getJobDefinitions()
        {
            return _jobDefinitionRepository.Get();
        }

        public Task<JobDefinition> newJobDefinition(JobDefinition jobDefinition)
        {
            return _jobDefinitionRepository.Add(jobDefinition);
        }
    }
}
