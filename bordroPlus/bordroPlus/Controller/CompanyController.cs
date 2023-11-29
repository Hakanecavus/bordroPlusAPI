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
    public class CompanyController : ControllerBase
    {
        public readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public Task<Company> newCompany(Company company)
        {
            try
            {
                return _companyService.newCompany(company);
            }
            catch (Exception ex) { throw ex; }

        }

        [HttpGet]
        public Task<Company> getCompany(long id)
        {
            try
            {
                return _companyService.getCompany(id);
            }
            catch (Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<Company>> getCompanies()
        {
            try
            {
                return _companyService.getCompanies();
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task DeleteCompany(long id)
        {
            try
            {
                return _companyService.deleteCompany(id);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
