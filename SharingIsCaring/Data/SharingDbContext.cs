using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Data
{
    public class SharingDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<AssetBrand> AssetBrands { get; set; }
        public DbSet<AssetAssetType> AssetAssetTypes { get; set; }
        public DbSet<AssetRequest> AssetRequests { get; set; }

        public SharingDbContext(DbContextOptions<SharingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<AssetBrand>()
                .HasKey(ab => new { ab.AssetId, ab.BrandId });

            builder.Entity<AssetAssetType>()
                .HasKey(aat => new { aat.AssetId, aat.AssetTypeId });
            builder.Entity<AssetRequest>()
                .HasKey(ar => new { ar.AssetId, ar.Id });
        }
    }
}
