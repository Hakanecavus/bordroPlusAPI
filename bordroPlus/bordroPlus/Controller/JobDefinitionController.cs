using bp.Engine.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Engine.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bordroPlus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JobDefinitionController : ControllerBase
    {
        public readonly IJobDefinitionService _jobDefinitionService;
        public JobDefinitionController(IJobDefinitionService jobDefinitionService)
        {
            _jobDefinitionService = jobDefinitionService;
        }
        [HttpPost]
        public Task<JobDefinition> newJobDefinition(JobDefinition jobDefinition)
        {
            try
            {
                return _jobDefinitionService.newJobDefinition(jobDefinition);
            }
            catch (Exception ex) { throw ex; }

        }

        [HttpGet]
        public Task<JobDefinition> getJobDefinition(long id)
        {
            try
            {
                return _jobDefinitionService.getJobDefinition(id);
            }
            catch (Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<JobDefinition>> getJobDefinitions()
        {
            try
            {
                return _jobDefinitionService.getJobDefinitions();
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task DeleteJobDefinition(long id)
        {
            try
            {
                return _jobDefinitionService.deleteJobDefinition(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
