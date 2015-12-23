using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjectLayer
{
    public class Login
    {
        [Required(ErrorMessage = "Please enter username...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password...")]
        public string Password { get; set; }
    }
}
