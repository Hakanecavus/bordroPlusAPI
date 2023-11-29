using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface IPayrollService
    {
        Task<Payroll> newPayroll(Payroll payroll);
        Task<List<Payroll>> getPayrolls();
        Task<Payroll> getPayroll(long id);
        Task deletePayroll(long id);
    }
}
