using bP.Core.Models.CoreModels;
using bP.Data.Contract.Helpers;
using bP.Engine.Services;
using System.Security.Cryptography.X509Certificates;

namespace bordroPlus
{
    public class AppStart
    {
        static IPermissionRepository _permissionRepository;
        static IUserRepository _userRepository;
        static IRoleRepository _roleRepository;
        static AuthService _authService;
        public AppStart(IPermissionRepository permissionRepository, IUserRepository userRepository, IRoleRepository roleRepository, AuthService authService) { 
        
            _permissionRepository = permissionRepository;
            _userRepository= userRepository;
            _roleRepository= roleRepository;
            _authService= authService;
        }
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var permission = _permissionRepository.Get("10000L");
            
            if (permission == null)
            {
                var permissions = new List<Permission>();
                Permission newPermission = new Permission();
                newPermission.Id = 10000L;
                newPermission.name = "view-dashboard";
                newPermission.description = "Can see application dashboard";
                permissions.Add(newPermission);

                foreach(Permission p in permissions)
                {
                    _permissionRepository.Add(p);
                }
                Role role = new Role();
                role.Id = 20000;
                role.name = "superadmin";
                role.role = Role.RoleType.SUPERADMIN;
                role.permissions = permissions;
                _roleRepository.Add(role);

                User superAdmin = new User();
                _authService.CreatePasswordHash("password", out byte[] passwordHash, out byte[] passwordSalt);
                superAdmin.passwordSalt = passwordSalt;
                superAdmin.passwordHash = passwordHash;
                superAdmin.email = "mail@mail.com";
                superAdmin.firstName = "super";
                superAdmin.lastName = "admin";
                superAdmin.role = new List<Role> { role };
                _userRepository.Add(superAdmin);

            }
            

        }
    }
}
