﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AftermathV1Entities : DbContext
    {
        public AftermathV1Entities()
            : base("name=AftermathV1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AccountRelationship> AccountRelationships { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountStatus> AccountStatus1 { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<Background> Backgrounds { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CharacterAbility> CharacterAbilities { get; set; }
        public virtual DbSet<CharacterAttribute> CharacterAttributes { get; set; }
        public virtual DbSet<CharacterExp> CharacterExps { get; set; }
        public virtual DbSet<CharacterNote> CharacterNotes { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<IDMark> IDMarks { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
