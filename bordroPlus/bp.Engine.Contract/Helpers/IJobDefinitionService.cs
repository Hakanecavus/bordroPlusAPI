using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface IJobDefinitionService
    {
        Task<JobDefinition> newJobDefinition(JobDefinition jobDefinition);
        Task<List<JobDefinition>> getJobDefinitions();
        Task<JobDefinition> getJobDefinition(long id);
        Task deleteJobDefinition(long id);
    }
}
