using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bP.Core.Models.CoreModels
{
    public class UploadFile: Auditable<UploadFile>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public FileTypes fileTypes { get; set; }

        public enum FileTypes
        {
            LEGALID,
            PHOTO,
            HEALTH_REPORT,
            OTHER
        }
    }
}
