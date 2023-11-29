using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }

        public string phone { get; set; }
        public string identityNumber { get; set; }

        public List<Role> role { get; set; }

        public string getEmail
        {
            get { return email; }
        }

        public byte[] getPasswordHash
        {
            get { return passwordHash; }
        }
        public byte[] getPasswordSalt
        {
            get { return passwordSalt; }
        }
    }
}
