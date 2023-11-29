using bp.Engine.Contract.Helpers;
using bP.Core.Contract.Helpers;
using bP.Core.Models.CoreModels;
using bP.Core.Models.DTOs;
using bP.Core.Models.Helpers;
using bP.Data.Contract.Helpers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bP.Engine.Services
{
    public class AuthService: IAuthService
    {
        private readonly IUserRepository _userData;
        private readonly IConfigurationHelpers _configurationHelpers;

        public AuthService(IUserRepository userData ,IConfigurationHelpers configurationHelpers)
        {
            _userData = userData;
            _configurationHelpers = configurationHelpers;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes((string)password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        public string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.getEmail)

            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configurationHelpers.AccessToken));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;

        }
        public async Task<string> Login(RequestDTO request)
        {
            var user = await _userData.Get(request.email);
            if (!VerifyPasswordHash(request.password, user.getPasswordHash, user.getPasswordSalt) || user == null)
            {
                throw new CustomException(401, "E-mail or password is incorrect");
            }
            else
            {
                string token = CreateToken(user);
                return token;
            }

        }
    }
}
