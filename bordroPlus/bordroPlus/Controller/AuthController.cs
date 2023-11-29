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
    public class AuthController : ControllerBase
    {
        public readonly IAuthService _authService;
        public AuthController(IAuthService authService) {
            _authService = authService;
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<string> Login(string username, string password)
        {
            try
            {
                var user = new RequestDTO();
                user.password = password;
                user.email = username;
                var res = await _authService.Login(user);
                return res;
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
    }
}
