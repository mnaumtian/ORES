using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    [MetadataType(typeof(RoleMetadata))]
    public partial class Role
    {

    }
    public class RoleMetadata
    {
        [Required]
        [Display(Name = "Role")]
        public string Role1 { get; set; }

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
