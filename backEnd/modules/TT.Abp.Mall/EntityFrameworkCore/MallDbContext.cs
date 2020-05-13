﻿using Microsoft.EntityFrameworkCore;
using TT.Abp.Mall.Domain;
using TT.Abp.Mall.Domain.Addresses;
using TT.Abp.Mall.Domain.Comments;
using TT.Abp.Mall.Domain.News;
using TT.Abp.Mall.Domain.Orders;
using TT.Abp.Mall.Domain.Partners;
using TT.Abp.Mall.Domain.Pays;
using TT.Abp.Mall.Domain.Products;
using TT.Abp.Mall.Domain.Shares;
using TT.Abp.Mall.Domain.Shops;
using TT.Abp.Mall.Domain.Swipers;
using TT.Abp.Mall.Domain.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace TT.Abp.Mall.EntityFrameworkCore
{
    [ConnectionStringName("Mall")]
    public class MallDbContext : AbpDbContext<MallDbContext>, IMallDbContext
    {
        public virtual DbSet<MallUser> MallUsers { get; set; }

        public virtual DbSet<MallShop> MallShops { get; set; }

        public virtual DbSet<ProductSpu> ProductSpu { get; set; }

        public virtual DbSet<ProductSku> ProductSku { get; set; }

        public virtual DbSet<ProductCategory> ProductCategory { get; set; }

        public virtual DbSet<PayOrder> PayOrders { get; set; }

        public virtual DbSet<ProductOrder> ProductOrders { get; set; }

        public virtual DbSet<ProductOrderItem> ProductOrderItems { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<Partner> Partners { get; set; }


        public virtual DbSet<Coupon> Coupons { get; set; }

        public virtual DbSet<UserCoupon> UserCoupons { get; set; }

        public DbSet<TenPayNotify> TenPayNotify { get; set; }

        public DbSet<AppProductCategory> AppProductCategory { get; set; }
        
        public DbSet<AppProductSpu> AppProductSpus { get; set; }

        public DbSet<Swiper> Swipers { get; set; }

        public DbSet<NewsCategory> NewsCategories { get; set; }

        public DbSet<NewsContent> NewsContents { get; set; }
        
        public DbSet<QrDetail> QrDetails { get; set; }

        public MallDbContext(DbContextOptions<MallDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMall();
        }
    }
}