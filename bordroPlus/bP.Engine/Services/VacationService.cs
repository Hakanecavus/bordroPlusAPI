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
    public class VacationService : IVacationService
    {
        private readonly IVacationRepository _vacationRepository;
        private readonly IConfiguration _configuration;

        public VacationService(IVacationRepository vacationRepository, IConfiguration configuration)
        {
            _vacationRepository = vacationRepository;
            _configuration = configuration;
        }
        public Task deleteVacation(long id)
        {
            return _vacationRepository.Delete(id.ToString());
        }

        public Task<Vacation> getVacation(long id)
        {
            return _vacationRepository.Get(id.ToString());
        }

        public Task<List<Vacation>> getVacations()
        {
            return _vacationRepository.Get();
        }

        public Task<Vacation> newVacation(Vacation vacation)
        {
            return _vacationRepository.Add(vacation);
        }
    }
}
