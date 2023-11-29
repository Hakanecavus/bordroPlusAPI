using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Auditable<U>
    {
        public int createdByPersonId {  get; set; }
        public int createdByUserId { get; set; }
        public string createdByName { get; set; }

        public int modifiedByPersonId { get; set; }
        public int modifiedByUserId { get; set; }
        public string modifiedByName { get; set; }

        public DateTime created { get; set; }
        public DateTime modified { get; set; }


    }
}
