using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    [MetadataType(typeof(AnswerTypeMetadata))]
    public partial class AnswerType
    {

    }
    public class AnswerTypeMetadata
    {
        [Required]
        [Display(Name = "Answer Type")]
        public string AnswerType1 { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created On")]
        public Nullable<System.DateTime> CreatedOn { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Modified By")]
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
