//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcDemoRestorent.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAST
    {
        public CAST()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public int CastId { get; set; }
        public string CastName { get; set; }
        public string Sessionname { get; set; }
    
        public virtual Session Session { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
