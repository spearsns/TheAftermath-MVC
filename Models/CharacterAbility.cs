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
    
    public partial class CharacterAbility
    {
        public System.Guid ID { get; set; }
        public System.Guid CharacterID { get; set; }
        public System.Guid AbilityID { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Ability Ability { get; set; }
        public virtual Character Character { get; set; }
    }
}
