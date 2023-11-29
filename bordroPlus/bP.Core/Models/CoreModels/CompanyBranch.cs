using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class CompanyBranch: Auditable<CompanyBranch>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string address { get; set; }
        public string taxOffice { get; set; }
        public string taxNumber { get; set; }
        public string tradeRegisteryNumber { get; set; }
    }
}
