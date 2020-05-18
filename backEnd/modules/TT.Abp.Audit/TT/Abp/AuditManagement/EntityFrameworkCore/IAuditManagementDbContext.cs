﻿using Microsoft.EntityFrameworkCore;
using TT.Abp.AuditManagement.Domain;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TT.Abp.AuditManagement.EntityFrameworkCore
{
    [ConnectionStringName("AuditManagement")]
    public interface IAuditManagementDbContext : IEfCoreDbContext
    {
        public DbSet<AuditFlow> AuditFlows { get; set; }
    }

    public class AuditManagementDbContext : AbpDbContext<AuditManagementDbContext>, IAuditManagementDbContext
    {
        public virtual DbSet<AuditFlow> AuditFlows { get; set; }

        public AuditManagementDbContext(
            DbContextOptions<AuditManagementDbContext> options
        )
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ConfigureAuditManagement();
        }
    }
}