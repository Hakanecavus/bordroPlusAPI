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
    public class CompanyBranchService : ICompanyBranchService
    {
        private readonly ICompanyBrachRepository _companyBrachRepository ;
        private readonly IConfiguration _configuration;
        public CompanyBranchService(ICompanyBrachRepository companyBrachRepository, IConfiguration configuration)
        {
            _companyBrachRepository = companyBrachRepository;
            _configuration = configuration;
        }
        public Task deleteBranch(long id)
        {
            return _companyBrachRepository.Delete(id.ToString());
        }

        public Task<CompanyBranch> getBranch(long id)
        {
            return _companyBrachRepository.Get(id.ToString());
        }

        public Task<List<CompanyBranch>> getBranches()
        {
            return _companyBrachRepository.Get();
        }

        public Task<CompanyBranch> newBranch(CompanyBranch branch)
        {
            return _companyBrachRepository.Add(branch);
        }
    }
}
