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
    public class CompanyBranchController : ControllerBase
    {
        public readonly ICompanyBranchService _companyBranchService;
        public CompanyBranchController(ICompanyBranchService companyBranchService)
        {
            _companyBranchService = companyBranchService;            
        }
        [HttpPost]
        public Task<CompanyBranch> newBranch(CompanyBranch company)
        {
            try
            {
                return _companyBranchService.newBranch(company);
            }
            catch (Exception ex) { throw ex; }

        }

        [HttpGet]
        public Task<CompanyBranch> getBranch(long id)
        {
            try
            {
                return _companyBranchService.getBranch(id);
            }
            catch (Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<CompanyBranch>> getBranches()
        {
            try
            {
                return _companyBranchService.getBranches();
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task deleteBranch(long id)
        {
            try
            {
                return _companyBranchService.deleteBranch(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
