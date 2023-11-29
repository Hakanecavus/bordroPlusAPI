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
    public class PayrollService : IPayrollService
    {
        private readonly IPayrollRepository _payrollRepository;
        private readonly IConfiguration _configuration;

        public PayrollService(IPayrollRepository payrollRepository, IConfiguration configuration)
        {
            _configuration = configuration;
            _payrollRepository = payrollRepository;
        }
        public Task deletePayroll(long id)
        {
            return _payrollRepository.Delete(id.ToString());
        }

        public Task<Payroll> getPayroll(long id)
        {
            return _payrollRepository.Get(id.ToString());
        }

        public Task<List<Payroll>> getPayrolls()
        {
            return _payrollRepository.Get();
        }

        public Task<Payroll> newPayroll(Payroll payroll)
        {
            return _payrollRepository.Add(payroll);
        }
    }
}
