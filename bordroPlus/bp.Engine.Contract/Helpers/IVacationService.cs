using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface IVacationService
    {
        Task<Vacation> newVacation(Vacation vacation);
        Task<List<Vacation>> getVacations();
        Task<Vacation> getVacation(long id);
        Task deleteVacation(long id);
    }
}
