﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceHistoryRecord.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DeviceHistoryRecordEntities : DbContext
    {
        public DeviceHistoryRecordEntities()
            : base("name=DeviceHistoryRecordEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ProductConfig> ProductConfigs { get; set; }
        public virtual DbSet<ProductStage> ProductStages { get; set; }
        public virtual DbSet<StageStep> StageSteps { get; set; }
        public virtual DbSet<StepType> StepTypes { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }
        public virtual DbSet<WorkItemComponent> WorkItemComponents { get; set; }
    }
}
