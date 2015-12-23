using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    [MetadataType(typeof(FormValidationMetadata))]
    public partial class Form
    {
    }
    public class FormValidationMetadata
    {
        [Required]
        [Display(Name = "Form Name")]
        public string FormName { get; set; }

        [Required]
        [Display(Name = "Form Path")]
        public string FormPath { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created On")]
        public Nullable<System.DateTime> CreatedOn { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Modified On")]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
