using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORES.ViewModels
{
    public class RoleRightViewModel
    {
        public SelectList RoleList { get; set; }
        public int SelectedRole { get; set; }
        public IEnumerable<FormRightMatrix> FormList { get; set; }

    }
}