using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface ICompanyService
    {
        Task<Company> newCompany(Company company);
        Task<List<Company>> getCompanies();
        Task<Company> getCompany(long id);
        Task deleteCompany(long id);
    }
}
