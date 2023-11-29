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
    public class VacationController : ControllerBase
    {
        public readonly IVacationService _vacationService;
        public VacationController(IVacationService vacationService)
        {
            _vacationService = vacationService;
        }

        [HttpPost]
        public Task<Vacation> newVacation(Vacation vacation)
        {
            try
            {
                return _vacationService.newVacation(vacation);
            }
            catch (Exception ex) { throw ex; }

        }

        [HttpGet]
        public Task<Vacation> getVacation(long id)
        {
            try
            {
                return _vacationService.getVacation(id);
            }
            catch (Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<Vacation>> getVacations()
        {
            try
            {
                return _vacationService.getVacations();
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task DeleteVacation(long id)
        {
            try
            {
                return _vacationService.deleteVacation(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
