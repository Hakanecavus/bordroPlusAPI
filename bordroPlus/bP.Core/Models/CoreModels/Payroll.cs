using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class Payroll: Auditable<Payroll>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string name { get; set; }
        public PayrollCalculationType payrollType { get; set; }
        public PayrollStatus payrollStatus { get; set; }
        public float salary { get; set; }
        public float netSalary { get; set; }
        public float hourlyPayment { get; set; }
        public float dailyPayment { get; set; }
        public string currency { get; set; }
        public float weeklyWorkHours { get; set; } //haftalık çalışma saati
        public float daysAtWork { get; set; }
        public float daysOffWork { get; set; }
        public float overTime { get; set; }
        public float overTimeCoef { get; set; } //fazla mesai katsayısı
        public float advancePayment { get; set; } //avans -
        public float levyPayment{ get; set; } //icra kesintisi -
        public DateTime paymentDate { get; set; }
        public float unitPayment{ get; set; } //proje bazlı çalışan kişiler için iş başına ödeme
        public float numberOfUnit{ get; set; } //proje bazlı çalışan kişilerin bitirdiği iş satısı
        public float totalTaxes{ get; set; } // toplam vergi -
        public float incomeTax{ get; set; } //gelir vergisi -
        public float stampTax{ get; set; } //damga vergisi -
        public float stampTaxWage{ get; set; } //damga vergisi matrahı -
        public float incomeTaxException{ get; set; } //gelir vergisi istisnası-
        public float stampTaxException{ get; set; } //damga vergisi istisnası -
        public float incomeTaxWage{ get; set; } //gelir vergisi matrahı-
        public float unemploymentInsurance{ get; set; } //işsizlik sigortası işçi payı -
        public float agi{ get; set; } //Asgari geçim indirimi +
        public float bonus{ get; set; } //primler +
        public float totalWageCut{ get; set; } //toplam kesinti -
        public float additionalRights{ get; set; } //yan haklar +
        public float incomeTaxBase{ get; set; } //gelir vergisi mahrahı -
        public float insuranceCut{ get; set; } //SGK işçi payı -
        public float BES{ get; set; } //Biraysel Emeklilik payı -
        public float disablityDiscount{ get; set; } //engelli indirimi +


        public enum PayrollStatus
        {
            CREATED,
            ON_GOING,
            PENDING_APPROVAL,
            APPROVED,
            ON_TRANSFER,
            COMPLETED,
            CANCELED
        }

        public enum PayrollCalculationType
        {
            GROSS,
            BASIC
        }
    }
}
