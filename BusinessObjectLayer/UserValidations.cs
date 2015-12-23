using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
    }
    public class UserMetadata
    {
        [Required]
        [Display(Name = "Username")]
     //   [Remote("IsUserExists", "Home", ErrorMessage = "User Name already in use")]
        public string UsersName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public string Password { get; set; }

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
