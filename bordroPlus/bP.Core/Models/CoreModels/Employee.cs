using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Employee: Auditable<Employee>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public string legalId { get; set; }
        public DateTime onBoardingDate { get; set; }
        public DateTime dismissalDate { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string branch { get; set; }
        public string duty { get; set; }
        public string unit { get; set; }

        public List<Payroll> payrolls { get; set; }
        public List<UploadFile> uploadFileSet { get; set; }
        public List<JobDefinition> jobDefinition { get; set; }
    }
}
