﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalTeste.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PortalEntities2 : DbContext
    {
        public PortalEntities2()
            : base("name=PortalEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tab_Questionario> Tab_Questionario { get; set; }
        public virtual DbSet<Tab_QuestionarioLetras> Tab_QuestionarioLetras { get; set; }
        public virtual DbSet<TAB_Usuario> TAB_Usuario { get; set; }
    }
}
