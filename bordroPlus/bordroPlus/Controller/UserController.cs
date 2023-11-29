using bp.Engine.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Core.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bordroPlus.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public Task<User> newUser(RequestDTO request)
        {
            try
            {
                var res = _userService.createUser(request);
                return Task.FromResult(res.Result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public Task<List<User>> getUsers()
        {
            try
            {
                return _userService.getUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public Task<User> getUser(long id)
        {
            try
            {
                return _userService.getUser(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public Task deleteUser(long id)
        {
            try
            {
                return _userService.deleteUser(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
