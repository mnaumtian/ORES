using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES
{
    public class UserViewModel
    {
        public SelectList RolesList { get; set; }
        public int? SelectedRole { get; set; }
        public User user { get; set; }
    }
}