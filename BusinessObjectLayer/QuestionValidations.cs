using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    [MetadataType(typeof(QuesitonMetadata))]
    public partial class Question
    {

    }
    public class QuesitonMetadata
    {
        [Required]
        [Display(Name = "Question")]
        public string Question1 { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created On")]
        public Nullable<System.DateTime> CreatedOn { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Modified On")]
        public Nullable<System.DateTime> ModifiedOn { get; set; }

        [Display(Name = "Is KPI")]
        public bool IsKPI { get; set; }
    }
}
