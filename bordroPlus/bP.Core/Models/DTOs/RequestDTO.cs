using bP.Core.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.DTOs
{
    public class RequestDTO
    {
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string identityNumber { get; set; } = string.Empty;

        public List<Role> role { get; set; } = new List<Role>();
    }
}
