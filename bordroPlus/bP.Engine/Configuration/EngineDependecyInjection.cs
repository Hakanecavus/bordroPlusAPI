using bp.Engine.Contract.Helpers;
using bP.Engine.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Engine.Configuration
{
    public static class EngineDependecyInjection
    {
        public static IServiceCollection DependecyInjectionEngine(this IServiceCollection services)
        {

            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<ICompanyBranchService, CompanyBranchService>();
            services.AddSingleton<ICompanyService, CompanyService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();
            services.AddSingleton<IJobDefinitionService, JobDefinitionService>();
            services.AddSingleton<IPayrollService, PayrollService>();
            services.AddSingleton<IVacationService, VacationService>();

            return services;
        }
    }
}
