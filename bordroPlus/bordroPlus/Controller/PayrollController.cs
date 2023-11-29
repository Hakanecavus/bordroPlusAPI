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
    public class PayrollController : ControllerBase
    {
        public readonly IPayrollService _payrollService;
        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpPost]
        public Task<Payroll> newPayroll(Payroll payroll)
        {
            try
            {
                return _payrollService.newPayroll(payroll);
            }
            catch (Exception ex) { throw ex; }

        }

        [HttpGet]
        public Task<Payroll> getPayroll(long id)
        {
            try
            {
                return _payrollService.getPayroll(id);
            }
            catch (Exception ex) { throw ex; }
        }
        [HttpGet]
        public Task<List<Payroll>> getPayrolls()
        {
            try
            {
                return _payrollService.getPayrolls();
            }
            catch (Exception ex) { throw ex; }
        }

        [HttpDelete]
        public Task DeletePayroll(long id)
        {
            try
            {
                return _payrollService.deletePayroll(id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
