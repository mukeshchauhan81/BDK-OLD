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
    
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Mob { get; set; }
        public Nullable<int> ProfileId { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}
