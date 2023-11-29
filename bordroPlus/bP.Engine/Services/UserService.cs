using bp.Engine.Contract.Helpers;
using bP.Core.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Core.Models.DTOs;
using bP.Data.Contract.Helpers;
using bP.Data.DBContext;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bP.Engine.Services
{
    public class UserService : IUserService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly AuthService _authService;

        public UserService(IConfiguration configuration, IUserRepository userRepository, AuthService authService)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _authService = authService;
        }

        public Task<User> createUser(RequestDTO requestDTO)
        {
            var user = new User();
            user.firstName = requestDTO.firstName; 
            user.lastName = requestDTO.lastName; 
            user.email = requestDTO.email;
            _authService.CreatePasswordHash(requestDTO.password, out byte[] passwordHash, out byte[] passwordSalt);
            user.passwordHash = passwordHash;
            user.passwordSalt = passwordSalt;
            user.role = requestDTO.role;

            return _userRepository.Add(user);
        }

        public Task<List<User>> getUsers()
        {
            return _userRepository.Get();
        }
        public Task<User> getUser(long id)
        {
            return _userRepository.Get(id.ToString());
        }
        public Task deleteUser(long id)
        {
            return _userRepository.Delete(id.ToString());
        }
    }
}
