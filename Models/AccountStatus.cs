//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheAftermath_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountStatus
    {
        public System.Guid ID { get; set; }
        public System.Guid AccountID { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }
        public bool Play { get; set; }
        public Nullable<System.Guid> CampaignID { get; set; }
        public Nullable<System.Guid> CharacterID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool Tell { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Campaign Campaign { get; set; }
        public virtual Character Character { get; set; }
    }
}
