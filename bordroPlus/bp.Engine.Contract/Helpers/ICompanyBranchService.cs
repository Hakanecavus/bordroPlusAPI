using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface ICompanyBranchService
    {
        Task<CompanyBranch> newBranch(CompanyBranch branch);
        Task<List<CompanyBranch>> getBranches();
        Task<CompanyBranch> getBranch(long id);
        Task deleteBranch(long id);
    }
}
