using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORES.ViewModels
{
    public class GroupMemberViewModel
    {
        public int GroupId { get; set; }
        public IEnumerable<User> UserList { get; set; }
    }
}