//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sub_Accounts
    {
        public Sub_Accounts()
        {
            this.Journals = new HashSet<Journal>();
            this.Journal_Details = new HashSet<Journal_Details>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Main_Accounts_ID { get; set; }
    
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual ICollection<Journal_Details> Journal_Details { get; set; }
        public virtual Main_Accounts Main_Accounts { get; set; }
    }
}