//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjectLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivityLog
    {
        public int ActivityLogId { get; set; }
        public string ActivityName { get; set; }
        public string FormName { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string IsDelete { get; set; }
    
        public virtual User User { get; set; }
    }
}
