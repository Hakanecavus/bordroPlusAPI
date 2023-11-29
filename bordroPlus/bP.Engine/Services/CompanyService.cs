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
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IConfiguration _configuration;

        public CompanyService(ICompanyRepository companyRepository, IConfiguration configuration)
        {
            _companyRepository = companyRepository;
            _configuration = configuration;
        }

        public Task deleteCompany(long id)
        {
            return _companyRepository.Delete(id.ToString());
        }

        public Task<List<Company>> getCompanies()
        {
            return _companyRepository.Get();
        }

        public Task<Company> getCompany(long id)
        {
            return _companyRepository.Get(id.ToString());
        }

        public Task<Company> newCompany(Company company)
        {
            return _companyRepository.Add(company);
        }
    }
}
