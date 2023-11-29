using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Company : Auditable<Company>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string name { get; set; }
        public string mersisNumber { get; set; }
        public string taxOffice { get; set; }
        public string taxNumber { get; set; }
        public string tradeRegisteryNumber { get; set; }
        public string workPlaceNumber { get; set; }
        public string website { get; set; }
        public string address { get; set; }
        public bool hasBranch { get; set; }
        public int numberOfBranches { get; set; }
        public List<CompanyBranch> companyBranchSet { get; set; }
    }
}
