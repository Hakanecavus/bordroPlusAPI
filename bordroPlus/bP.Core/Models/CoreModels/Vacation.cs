using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Vacation: Auditable<Vacation>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public float numberOfHours { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public float numberOfDaysOffWork { get; set; }
        public VacationType vacationType { get; set; }

        public enum VacationType
        {
            PAID,
            UNPAID,
            ANNUAL,
            HOSPITAL_REPORT
        }

        public virtual User user { get; set; }
    }
}
