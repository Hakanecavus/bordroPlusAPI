using bP.Core.Models.CoreModels;
using bP.Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp.Engine.Contract.Helpers
{
    public interface IUserService
    {
        Task<User> createUser(RequestDTO requestDTO);
        Task<List<User>> getUsers();
        Task<User> getUser(long id);
        Task deleteUser(long id);
    }
}
