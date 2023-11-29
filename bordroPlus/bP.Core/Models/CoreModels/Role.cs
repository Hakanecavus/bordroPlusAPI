using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Role: Auditable<Role>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string name { get; set; }
        public RoleType role { get; set; }
        public List<Permission> permissions { get; set; }

        public enum RoleType
        {
            USER,
            ADMIN,
            SUPERADMIN,
            MODERATOR
        }
    }
}
